#define OPTIMIZE_RESIZE

using BuildCalculator.Classes;
using BuildCalculator.Forms;
using BuildCalculator.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Шыша corporation © 2023
namespace BuildCalculator
{
    public partial class MainForm : Form
    {
        private const int GroupBoxMargin = 10;
        private int CurrentRow;
        private int CurrentColumn;
        private int CurrentButtonIdx;
        public static string UserToken = "";
        public static ProgramSettings pSettings = null;
        private Dictionary<string, Bitmap> CachedImages;
        private Dictionary<int, JObject> CachedMaterials;
        private Dictionary<int, MaterialObject> SelectedMaterials;
        private Thread LoaderThread;

        public MainForm()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            InitializeComponent();

            CurrentButtonIdx = -1;
            CachedImages = new Dictionary<string, Bitmap>();
            SelectedMaterials = new Dictionary<int, MaterialObject>();
            CachedMaterials = new Dictionary<int, JObject>();

            pSettings = new ProgramSettings("Settings.ini");
            pSettings.SaveVersion();

            FloatTextBox_TextChanged(BuildWidthTextBox, null);
            FloatTextBox_TextChanged(BuildLengthTextBox, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var gb = LoadAnimation.StartAnimation(5, 1.0f, 3, this);
            Controls.Add(gb);
            Controls.SetChildIndex(gb, 0);
            Controls["MainMenuToolStrip"].Visible = false;

            LoaderThread = new Thread(LoadServerInfo);
            LoaderThread.Start();
        }

        private void LoadServerInfo()
        {
            RefreshUser();

            ClearMaterials();

            LoadMaterialButtons();
            LoadBuildInfo();
            LoadAnimation.StopAnimation();
            Invoke((MethodInvoker)delegate ()
            {
                Controls["MainMenuToolStrip"].Visible = true;
            });
        }

        private void LoadBuildInfo()
        {
            LoadAnimation.IncrementBar();

            HttpStatusCode Status;
            var Response = Net.GetRequest("api/schema", out Status);
            
            if (Status == HttpStatusCode.OK)
            {
                if (Response != null && Response["schemaDoma"] != null && Response["floors"] != null)
                {
                    JArray schemes = Response["schemaDoma"] as JArray;
                    JArray floors = Response["floors"] as JArray;

                    Invoke((MethodInvoker)delegate ()
                    {
                        foreach (JToken scheme in schemes)
                            BuildSchemeComboBox.Items.Add(scheme.ToString());

                        foreach (JToken floor in floors)
                            FloorComboBox.Items.Add(floor.ToString());

                        BuildSchemeComboBox.SelectedIndex = 0;
                        FloorComboBox.SelectedIndex = 0;
                    });
                }
            }
        }

        private void LoadMaterialButtons()
        {
            LoadAnimation.IncrementBar();
            Invoke((MethodInvoker)delegate ()
            {
                MaterialsListPanel.Controls.Clear();
            });
            SelectedMaterials.Clear();

            JObject JsonObject = Net.GetRequest("api/buttons", out _);
            if (JsonObject != null && JsonObject["buttons"] != null)
            {
                JArray buttons = JsonObject["buttons"] as JArray;

                bool hasInvalidData = buttons.Any(button => button["id"] == null || button["name"] == null || button["icon"] == null);

                if (!hasInvalidData)
                {
                    buttons = new JArray(
                        from button in buttons
                        orderby (int)button["id"]
                        select button
                    );

                    foreach (JToken button in buttons)
                    {
                        CheckBox view_checkbox = new CheckBox();
                        view_checkbox.Name = "MaterialSelectCheckBox_" + button["id"].ToString();
                        view_checkbox.Size = MaterialSelectedCheckBox.Size;
                        view_checkbox.Location = new Point(MaterialSelectedCheckBox.Location.X, MaterialSelectedCheckBox.Location.Y + (MaterialSelectedCheckBox.Size.Height + 25) * (int)button["id"]);
                        view_checkbox.Anchor = MaterialSelectedCheckBox.Anchor;
                        view_checkbox.Tag = button["id"].ToString();
                        view_checkbox.Enabled = MaterialSelectedCheckBox.Enabled;

                        Button view_button = new Button();
                        view_button.Name = "MaterialButton_" + button["id"].ToString();
                        view_button.Size = MaterialButton.Size;
                        view_button.Location = new Point(MaterialButton.Location.X, MaterialButton.Location.Y + (MaterialButton.Size.Height + 6) * (int)button["id"]);
                        view_button.Anchor = MaterialButton.Anchor;
                        view_button.Font = MaterialButton.Font;
                        view_button.Text = $"         {(int)button["id"] + 1}. {button["name"]}";
                        view_button.TextAlign = MaterialButton.TextAlign;
                        view_button.Tag = button["id"].ToString();
                        view_button.Click += ButtonsList_Click;

                        byte[] imageBytes = Convert.FromBase64String(button["icon"].ToString());
                        Bitmap bitmap;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            bitmap = new Bitmap(ms);
                        }
                        view_button.Image = bitmap;
                        view_button.ImageAlign = MaterialButton.ImageAlign;

                        Invoke((MethodInvoker)delegate ()
                        {
                            MaterialsListPanel.Controls.Add(view_checkbox);
                            MaterialsListPanel.Controls.Add(view_button);
                        });
                        SelectedMaterials.Add((int)button["id"], new MaterialObject());

                        if (!CachedMaterials.ContainsKey((int)button["id"]))
                        {
                            JObject jsonObject = new JObject(
                                new JProperty("id", (int)button["id"])
                            );
                            HttpStatusCode Status;
                            var Response = Net.GetRequest("api/material", out Status, jsonObject);
                            if (Status == HttpStatusCode.OK)
                                CachedMaterials.Add((int)button["id"], Response);
                        }
                    }
                }
            }
        }

        private void ClearMaterials()
        {
            Invoke((MethodInvoker)delegate ()
            {
                MaterialsPanel.Controls.Clear();
            });
        }

        private void AddMaterial(int idx, JToken body)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "MaterialGroupBox_" + body["id"].ToString();
            groupBox.Text = body["name"].ToString();
            groupBox.Font = MaterialGroupBox.Font;
            groupBox.Tag = body["id"].ToString();

            int x = CurrentColumn * (MaterialGroupBox.Width + GroupBoxMargin);
            int y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);

            if (x + MaterialGroupBox.Width > MaterialsPanel.Size.Width)
            {
                CurrentRow++;
                CurrentColumn = 0;
                x = 0;
                y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);
            }

            groupBox.Location = new System.Drawing.Point(x, y);
            groupBox.Size = MaterialGroupBox.Size;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "MaterialPictureBox_" + body["id"].ToString();
            pictureBox.Size = MaterialPictureBox.Size;
            pictureBox.Location = MaterialPictureBox.Location;
            pictureBox.Anchor = MaterialPictureBox.Anchor;
            pictureBox.SizeMode = MaterialPictureBox.SizeMode;

            if (CachedImages.ContainsKey(body["img"].ToString()))
                pictureBox.Image = CachedImages[body["img"].ToString()];
            else if (body["img"].ToString() != "")
            {
                try
                {
                    WebClient client = new WebClient();
                    byte[] imageData = client.DownloadData(body["img"].ToString());

                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        Bitmap bitmap = new Bitmap(stream);
                        pictureBox.Image = bitmap;
                        CachedImages.Add(body["img"].ToString(), bitmap);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                }
            }

            groupBox.Controls.Add(pictureBox);

            Button button = new Button();
            button.Name = "MaterialSelectButton_" + body["id"].ToString();
            button.Size = MaterialSelectButton.Size;
            button.Location = MaterialSelectButton.Location;
            button.Anchor = MaterialSelectButton.Anchor;
            button.Text = MaterialSelectButton.Text;
            button.Font = MaterialSelectButton.Font;
            button.Click += MaterialSelectButton_Click;
            button.Tag = body["id"].ToString();

            if (SelectedMaterials[CurrentButtonIdx].MaterialId == (int)body["id"])
                button.BackColor = Color.FromArgb(80, 0, 120, 215);

            groupBox.Controls.Add(button);

            string input1_name = body["input1_name"].ToString();
            JArray input1_values = body["input1_value"] as JArray;
            string input2_name = body["input2_name"].ToString();
            JArray input2_values = body["input2_value"] as JArray;

            if (input1_name != "" && input1_values != null)
            {
                Label label1 = new Label();
                label1.Name = "MaterialInputFirstLabel_" + body["id"].ToString();
                label1.Size = new Size(groupBox.Size.Width - 8, InputFirstLabel.Size.Height);
                label1.Location = InputFirstLabel.Location;
                label1.Anchor = InputFirstLabel.Anchor;
                label1.Text = input1_name;
                label1.Font = InputFirstLabel.Font;
                groupBox.Controls.Add(label1);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "MaterialInputFirstComboBox_" + body["id"].ToString();
                comboBox.Size = InputFirstComboBox.Size;
                comboBox.Location = InputFirstComboBox.Location;
                comboBox.Anchor = InputFirstComboBox.Anchor;
                comboBox.Font = InputFirstComboBox.Font;
                comboBox.DropDownStyle = InputFirstComboBox.DropDownStyle;
                comboBox.Tag = body["id"].ToString();
                comboBox.SelectedIndexChanged += MaterialFirstInput_IndexChanged;

                foreach (JToken val in input1_values)
                    comboBox.Items.Add(val.ToString());

                comboBox.SelectedIndex = 0;

                groupBox.Controls.Add(comboBox);
            }

            if (input2_name != "" && input2_values != null)
            {
                Label label1 = new Label();
                label1.Name = "MaterialInputSecondLabel_" + body["id"].ToString();
                label1.Size = new Size(groupBox.Size.Width - 8, InputSecondLabel.Size.Height);
                label1.Location = InputSecondLabel.Location;
                label1.Anchor = InputSecondLabel.Anchor;
                label1.Text = input2_name;
                label1.Font = InputSecondLabel.Font;
                groupBox.Controls.Add(label1);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "MaterialInputSecondComboBox_" + body["id"].ToString();
                comboBox.Size = InputSecondComboBox.Size;
                comboBox.Location = InputSecondComboBox.Location;
                comboBox.Anchor = InputSecondComboBox.Anchor;
                comboBox.Font = InputSecondComboBox.Font;
                comboBox.DropDownStyle = InputSecondComboBox.DropDownStyle;
                comboBox.Tag = body["id"].ToString();
                comboBox.SelectedIndexChanged += MaterialSecondInput_IndexChanged;

                foreach (JToken val in input2_values)
                    comboBox.Items.Add(val.ToString());

                comboBox.SelectedIndex = 0;

                groupBox.Controls.Add(comboBox);
            }

            MaterialsPanel.Controls.Add(groupBox);

            CurrentColumn++;
        }

        private void MaterialSelectButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int material_id = Convert.ToInt32(button.Tag);

            foreach (Control control in MaterialsPanel.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control gb_control in control.Controls)
                    {
                        if (gb_control is Button)
                            gb_control.BackColor = Color.White;
                    }
                }
            }

            var CheckBox = MaterialsListPanel.Controls["MaterialSelectCheckBox_" + CurrentButtonIdx] as CheckBox;
            if (SelectedMaterials[CurrentButtonIdx].MaterialId != material_id)
            {
                ComboBox FirstComboBox = MaterialsPanel.Controls["MaterialGroupBox_" + material_id].Controls["MaterialInputFirstComboBox_" + material_id] as ComboBox;
                if (FirstComboBox != null)
                    SelectedMaterials[CurrentButtonIdx].FirstInputValue = Convert.ToSingle(FirstComboBox.Items[FirstComboBox.SelectedIndex].ToString());
                else
                    SelectedMaterials[CurrentButtonIdx].FirstInputValue = -1;

                ComboBox SecondComboBox = MaterialsPanel.Controls["MaterialGroupBox_" + material_id].Controls["MaterialInputSecondComboBox_" + material_id] as ComboBox;
                if (SecondComboBox != null)
                    SelectedMaterials[CurrentButtonIdx].SecondInputValue = Convert.ToSingle(SecondComboBox.Items[FirstComboBox.SelectedIndex].ToString());
                else
                    SelectedMaterials[CurrentButtonIdx].SecondInputValue = -1;

                SelectedMaterials[CurrentButtonIdx].MaterialId = material_id;
                button.BackColor = Color.FromArgb(80, 0, 120, 215);
                CheckBox.Checked = true;
            }
            else
            {
                SelectedMaterials[CurrentButtonIdx].MaterialId = -1;
                SelectedMaterials[CurrentButtonIdx].FirstInputValue = -1.0f;
                SelectedMaterials[CurrentButtonIdx].SecondInputValue = -1.0f;
                CheckBox.Checked = false;
            }

            RecalcCostInfo();
        }

        private void MaterialFirstInput_IndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox = sender as ComboBox;
            int material_id = Convert.ToInt32(ComboBox.Tag);

            if (SelectedMaterials[CurrentButtonIdx].MaterialId == material_id)
            {
                SelectedMaterials[CurrentButtonIdx].FirstInputValue = Convert.ToSingle(ComboBox.Items[ComboBox.SelectedIndex].ToString());
                RecalcCostInfo();
            }
        }

        private void MaterialSecondInput_IndexChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox = sender as ComboBox;
            int material_id = Convert.ToInt32(ComboBox.Tag);

            if (SelectedMaterials[CurrentButtonIdx].MaterialId == material_id)
            {
                SelectedMaterials[CurrentButtonIdx].SecondInputValue = Convert.ToSingle(ComboBox.Items[ComboBox.SelectedIndex].ToString());
                RecalcCostInfo();
            }
        }

        private void MaterialsPanel_SizeChanged(object sender, EventArgs e)
        {
            RepositionGroupBoxes();
        }

        private void RepositionGroupBoxes()
        {
            CurrentRow = 0;
            CurrentColumn = 0;

            foreach (Control control in MaterialsPanel.Controls)
            {
                int x = CurrentColumn * (MaterialGroupBox.Width + GroupBoxMargin);
                int y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);

                if (x + MaterialGroupBox.Width > MaterialsPanel.Size.Width)
                {
                    CurrentRow++;
                    CurrentColumn = 0;
                    x = 0;
                    y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);
                }

                control.Location = new Point(x, y + MaterialsPanel.AutoScrollPosition.Y);
                CurrentColumn++;
            }
            MaterialsPanel.ResumeLayout(true);
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
#if OPTIMIZE_RESIZE
            Control sender_control = sender as Control;
            foreach (Control control in sender_control.Controls)
            {
                MainForm_ResizeBegin(control, null);
                control.SuspendLayout();
            }
#endif
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
#if OPTIMIZE_RESIZE
            Control sender_control = sender as Control;
            foreach (Control control in sender_control.Controls)
            {
                MainForm_ResizeEnd(control, null);
                control.ResumeLayout(true);
            }
#endif
        }

        private void ButtonsList_Click(object sender, EventArgs e)
        {
            foreach (Control control in MaterialsListPanel.Controls)
            {
                if (control is Button)
                    control.BackColor = Color.White;
            }
            Button cur_button = sender as Button;
            int OldButtonIdx = CurrentButtonIdx;
            CurrentButtonIdx = Convert.ToByte(cur_button.Tag.ToString());
            if (OldButtonIdx == CurrentButtonIdx)
            {
                CurrentButtonIdx = -1;
                MaterialsListGroupBox.Text = "";
            }
            else
            {
                cur_button.BackColor = Color.FromArgb(80, 0, 120, 215);
                string gb_text = cur_button.Text.Substring(cur_button.Text.IndexOf('.') + 2).Trim();
                int indexOfColon = gb_text.IndexOf(':');
                if (indexOfColon != -1)
                    gb_text = gb_text.Substring(0, indexOfColon);
                MaterialsListGroupBox.Text = gb_text;
            }

            ClearMaterials();
            if (CurrentButtonIdx != -1)
            {
                LoadMaterials();
                RepositionGroupBoxes();
            }    
        }

        private void LoadMaterials()
        {
            JObject Response = null;

            if (CachedMaterials.ContainsKey(CurrentButtonIdx))
                Response = CachedMaterials[CurrentButtonIdx];
            else
            {
                JObject jsonObject = new JObject(
                    new JProperty("id", CurrentButtonIdx)
                );
                Response = Net.GetRequest("api/material", out _, jsonObject);
            }

            if (Response != null && Response["material"] != null)
            {
                JArray materials = Response["material"] as JArray;

                if (materials != null)
                {
                    bool hasInvalidData = materials.Any(material => material["id"] == null || material["name"] == null || material["img"] == null || material["work_price"] == null || material["material_price"] == null);

                    if (!hasInvalidData)
                    {
                        materials = new JArray(
                            from material in materials
                            orderby (int)material["id"]
                            select material
                        );

                        int idx = 0;
                        foreach (JToken material in materials)
                        {
                            AddMaterial(idx, material);
                            idx++;
                        }
                    }
                }
            }
        }

        private void FloatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.Length == 0)
                e.Handled = true;
        }

        private void FloatTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            float out_val;
            if (float.TryParse(textBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out out_val))
            {
                if (out_val <= 0.0f)
                    textBox.BackColor = Color.FromArgb(255, 255, 128, 128);
                else
                    textBox.BackColor = SystemColors.Window;
            }
            else
                textBox.BackColor = Color.FromArgb(255, 255, 128, 128);
            RecalcBuildSizeInfo();
        }

        private void FloatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();
                if (!float.TryParse(clipboardText, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void RecalcBuildSizeInfo()
        {
            if (MathHelper.IsFloat(BuildWidthTextBox.Text) && MathHelper.IsFloat(BuildLengthTextBox.Text))
            {
                float Width = Convert.ToSingle(BuildWidthTextBox.Text);
                float Length = Convert.ToSingle(BuildLengthTextBox.Text);

                if (Width > 0.0f && Length > 0.0f)
                {
                    JObject jsonObject = new JObject(
                        new JProperty("Width", Width),
                        new JProperty("Length", Length),
                        new JProperty("Schema", BuildSchemeComboBox.SelectedIndex)
                    );

                    HttpStatusCode Status;
                    var Response = Net.GetRequest("api/calc", out Status, jsonObject);

                    if (Status == HttpStatusCode.OK)
                    {
                        if (Response != null && Response["Perimeter"] != null && Response["Foundation"] != null && Response["BuildingArea"] != null)
                        {
                            BuildPerimeterResultLabel.Text = Response["Perimeter"].ToString() + " м";
                            FoundationLengthResultLabel.Text = Response["Foundation"].ToString() + " м";
                            BuildingAreaResultLabel.Text = Response["BuildingArea"].ToString() + " м²";
                            RecalcCostInfo();
                            return;
                        }
                    }
                }
            }

            BuildPerimeterResultLabel.Text = "0 м";
            FoundationLengthResultLabel.Text = "0 м";
            BuildingAreaResultLabel.Text = "0 м²";
            RecalcCostInfo();
        }

        private void RecalcCostInfo()
        {
            var Response = GetResultResponse();
            if (Response != null)
            {
                JArray materials = Response["material"] as JArray;

                if (materials != null)
                {
                    Dictionary<int, float> Results = new Dictionary<int, float>();
                    foreach (JToken material in materials)
                    {
                        if (material["material_type_id"] != null && material["total_price"] != null)
                            Results.Add((int)material["material_type_id"], (float)material["total_price"]);
                    }

                    foreach (Control control in MaterialsListPanel.Controls)
                    {
                        if (control is Button)
                        {
                            int b_id = Convert.ToInt32(control.Tag.ToString());

                            int indexOfColon = control.Text.IndexOf(':');

                            if (indexOfColon != -1)
                                control.Text = control.Text.Substring(0, indexOfColon);

                            if (Results.ContainsKey(b_id))
                                control.Text += $": {Results[b_id]} руб";
                        }
                    }

                    int symbol_step = 10;
                    ResultCostLabel.Text = $"{Results.Values.Sum()}";
                    ResultCostLabel.Location = new Point((916 - (ResultCostLabel.Text.Length - 1) * symbol_step), 16);
                }
            }
            else
            {
                ResultCostLabel.Text = "0";
                ResultCostLabel.Location = new Point(916, 16); // дефолтная позиция
            }
        }

        private void BuildSchemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalcBuildSizeInfo();
        }

        private void AuthorizeButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == "Выход")
            {
                button.Text = "Вход / Регистрация";
                button.Image = Resources.Enter;
                UserNameLabel.Text = "Не авторизован";
                UserToken = "";
                pSettings.Save("token", UserToken);
                pSettings.Save("username", "");
                pSettings.Save("password", "");
                UserCabinetMenuItem.Enabled = false;
            }
            else
            {
                AuthorizeForm form = new AuthorizeForm();
                form.ShowDialog();

                if (form.Valid)
                {
                    UserToken = form.Token;
                    UserNameLabel.Text = $"{form.UserName}\n{form.UserLastName}";
                    pSettings.Save("token", UserToken);
                    pSettings.Save("username", form.UserLogin);
                    pSettings.Save("password", form.UserPassword);
                    button.Text = "Выход";
                    button.Image = Resources.Exit;
                    UserCabinetMenuItem.Enabled = true;
                }
                form.DestroyIcon();
            }
        }

        private void RefreshUser()
        {
            LoadAnimation.IncrementBar();
            UserNameLabel.Text = "Не авторизован";
            string loaded_token = pSettings.Load("token");
            string loaded_username = pSettings.Load("username");
            string loaded_password = pSettings.Load("password");
            if (loaded_token != "")
            {
                HttpStatusCode Status;
                JObject jsonObject = new JObject(
                    new JProperty("token", loaded_token)
                );
                var Response = Net.GetRequest("api/verify", out Status, jsonObject);
                
                if (Status != HttpStatusCode.OK)
                {
                    jsonObject = new JObject(
                        new JProperty("username", loaded_username),
                        new JProperty("password", loaded_password)
                    );

                    Response = Net.GetRequest("api/login", out Status, jsonObject);

                    switch (Status)
                    {
                        case HttpStatusCode.OK:
                            if (Response["token"] != null)
                            {
                                UserToken = Response["token"].ToString();
                                pSettings.Save("token", UserToken);
                                Invoke((MethodInvoker)delegate ()
                                {
                                    AuthorizeButton.Text = "Выход";
                                    AuthorizeButton.Image = Resources.Exit;
                                    UserCabinetMenuItem.Enabled = true;
                                });

                                if (Response["user"] != null)
                                {
                                    JObject UserData = Response["user"] as JObject;
                                    if (UserData["name"] != null && UserData["lastname"] != null)
                                    {
                                        Invoke((MethodInvoker)delegate ()
                                        {
                                            UserNameLabel.Text = $"{UserData["name"]}\n{UserData["lastname"]}";
                                        });
                                    }
                                    else
                                        MessageBox.Show($"Ошибка сервера. Невозможно получить имя пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show($"Ошибка сервера. Невозможно получить пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show($"Невозможно войти в аккаунт! Отсутствует токен пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case HttpStatusCode.Unauthorized:
                            AutoClosingMessageBox.Show("Неверный логин или пароль!", "", 2000, MessageBoxIcon.Error);
                            break;
                        case HttpStatusCode.InternalServerError:
                            MessageBox.Show($"Неудается связаться с сервером.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            MessageBox.Show($"Ошибка {Status}. Невозможно войти в аккаунт!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    if (Response["userInfo"] != null)
                    {
                        UserToken = loaded_token;
                        pSettings.Save("token", UserToken);
                        Invoke((MethodInvoker)delegate ()
                        {
                            AuthorizeButton.Text = "Выход";
                            AuthorizeButton.Image = Resources.Exit;
                            UserCabinetMenuItem.Enabled = true;
                        });
                        JObject UserData = Response["userInfo"] as JObject;
                        if (UserData["name"] != null && UserData["lastname"] != null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                UserNameLabel.Text = $"{UserData["name"]}\n{UserData["lastname"]}";
                            });
                        }
                        else
                            MessageBox.Show($"Ошибка сервера. Невозможно получить имя пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show($"Ошибка сервера. Невозможно получить пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoaderThread.Abort();
        }

        private void CalculateResultButton_Click(object sender, EventArgs e)
        {
            if (!SelectedMaterials.Values.Any(value => value.MaterialId == -1))
            {
                var Response = GetResultResponse();

            }
            else
                MessageBox.Show("Пожалуйста, выберите все материалы", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private JObject GetResultResponse()
        {
            if (MathHelper.IsFloat(BuildWidthTextBox.Text) && MathHelper.IsFloat(BuildLengthTextBox.Text))
            {
                float Width = Convert.ToSingle(BuildWidthTextBox.Text);
                float Length = Convert.ToSingle(BuildLengthTextBox.Text);

                if (Width > 0.0f && Length > 0.0f)
                {
                    var materialsList = new List<object>();

                    for (int i = 0; i < SelectedMaterials.Count; i++)
                    {
                        int materialTypeId = SelectedMaterials.ElementAt(i).Key;
                        int selectedMaterialId = SelectedMaterials.ElementAt(i).Value.MaterialId;

                        if (selectedMaterialId == -1)
                            continue;

                        float firstInputValue = SelectedMaterials.ElementAt(i).Value.FirstInputValue;
                        float secondInputValue = SelectedMaterials.ElementAt(i).Value.SecondInputValue;

                        var materialObject = new
                        {
                            material_type_id = materialTypeId,
                            selected_material_id = selectedMaterialId,
                            first_input_value = firstInputValue,
                            second_input_value = secondInputValue
                        };

                        materialsList.Add(materialObject);
                    }

                    var materials = new
                    {
                        materials = materialsList,
                        house_info = new
                        {
                            width = Width,
                            length = Length,
                            scheme = BuildSchemeComboBox.SelectedIndex,
                            floors = Convert.ToInt32(FloorComboBox.Items[FloorComboBox.SelectedIndex].ToString())
                        }
                    };

                    string json = JsonConvert.SerializeObject(materials, Formatting.Indented);
                    var Response = Net.PostRequest("api/calcmaterial", out _, JObject.Parse(json));
                    return Response;
                }
            }
            return null;
        }

        private void ShowSmetaMenuItem_Click(object sender, EventArgs e)
        {
            if (UserToken != "")
            {
                SmetaHistory smetaHistory = new SmetaHistory();
                smetaHistory.ShowDialog();
            }
            else
                MessageBox.Show("Ошибка. Пользователь не залогинен в аккаунт", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
