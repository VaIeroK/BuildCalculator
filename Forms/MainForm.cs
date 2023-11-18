#define OPTIMIZE_RESIZE

using BuildCalculator.Classes;
using BuildCalculator.Forms;
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
using System.Text;
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
        public static string UserToken = null;
        public static Settings pSettings = null;

        public MainForm()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            InitializeComponent();
            CurrentButtonIdx = -1;

            pSettings = new Settings("Settings.ini");
            pSettings.SaveVersion();

            FloatTextBox_TextChanged(BuildWidthTextBox, null);
            FloatTextBox_TextChanged(BuildLengthTextBox, null);
            BuildSchemeComboBox.SelectedIndex = 0;
            FloorComboBox.SelectedIndex = 0;

            RefreshUser();

            ClearMaterials();

            LoadMaterialButtons();
        }

        private void LoadMaterialButtons()
        {
            LeftGroupBox.Controls.Clear();

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

                        LeftGroupBox.Controls.Add(view_button);
                    }
                }
            }
        }

        private void ClearMaterials()
        {
            MaterialsPanel.Controls.Clear();
        }

        private void AddMaterial(int idx, JToken body)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "MaterialGroupBox_" + idx;
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
            pictureBox.Name = "MaterialPictureBox_" + idx;
            pictureBox.Size = MaterialPictureBox.Size;
            pictureBox.Location = MaterialPictureBox.Location;
            pictureBox.Anchor = MaterialPictureBox.Anchor;
            pictureBox.SizeMode = MaterialPictureBox.SizeMode;

            byte[] imageBytes = Convert.FromBase64String(body["img"].ToString());
            Bitmap bitmap;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                bitmap = new Bitmap(ms);
            }
            pictureBox.Image = bitmap;

            groupBox.Controls.Add(pictureBox);

            Button button = new Button();
            button.Name = "MaterialSelectButton_" + idx;
            button.Size = MaterialSelectButton.Size;
            button.Location = MaterialSelectButton.Location;
            button.Anchor = MaterialSelectButton.Anchor;
            button.Text = MaterialSelectButton.Text;
            button.Font = MaterialSelectButton.Font;
            groupBox.Controls.Add(button);

            string input1_name = body["input1_name"].ToString();
            JArray input1_values = body["input1_value"] as JArray;
            string input2_name = body["input2_name"].ToString();
            JArray input2_values = body["input2_value"] as JArray;

            if (input1_name != "" && input1_values != null)
            {
                Label label1 = new Label();
                label1.Name = "MaterialInputFirstLabel_" + idx;
                label1.Size = new Size(groupBox.Size.Width - 8, InputFirstLabel.Size.Height);
                label1.Location = InputFirstLabel.Location;
                label1.Anchor = InputFirstLabel.Anchor;
                label1.Text = input1_name;
                label1.Font = InputFirstLabel.Font;
                groupBox.Controls.Add(label1);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "MaterialInputFirstComboBox_" + idx;
                comboBox.Size = InputFirstComboBox.Size;
                comboBox.Location = InputFirstComboBox.Location;
                comboBox.Anchor = InputFirstComboBox.Anchor;
                comboBox.Font = InputFirstComboBox.Font;
                comboBox.DropDownStyle = InputFirstComboBox.DropDownStyle;

                foreach (JToken val in input1_values)
                    comboBox.Items.Add(val.ToString());

                comboBox.SelectedIndex = 0;

                groupBox.Controls.Add(comboBox);
            }

            if (input2_name != "" && input2_values != null)
            {
                Label label1 = new Label();
                label1.Name = "MaterialInputSecondLabel_" + idx;
                label1.Size = new Size(groupBox.Size.Width - 8, InputSecondLabel.Size.Height);
                label1.Location = InputSecondLabel.Location;
                label1.Anchor = InputSecondLabel.Anchor;
                label1.Text = input2_name;
                label1.Font = InputSecondLabel.Font;
                groupBox.Controls.Add(label1);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "MaterialInputSecondComboBox_" + idx;
                comboBox.Size = InputSecondComboBox.Size;
                comboBox.Location = InputSecondComboBox.Location;
                comboBox.Anchor = InputSecondComboBox.Anchor;
                comboBox.Font = InputSecondComboBox.Font;
                comboBox.DropDownStyle = InputSecondComboBox.DropDownStyle;

                foreach (JToken val in input2_values)
                    comboBox.Items.Add(val.ToString());

                comboBox.SelectedIndex = 0;

                groupBox.Controls.Add(comboBox);
            }

            MaterialsPanel.Controls.Add(groupBox);

            CurrentColumn++;
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
            foreach (Control control in LeftGroupBox.Controls)
            {
                if (control is Button)
                    control.BackColor = Color.White;
            }
            Button cur_button = sender as Button;
            int OldButtonIdx = CurrentButtonIdx;
            CurrentButtonIdx = Convert.ToByte(cur_button.Tag.ToString());
            if (OldButtonIdx == CurrentButtonIdx)
                CurrentButtonIdx = -1;
            else
                cur_button.BackColor = Color.FromArgb(80, 0, 120, 215);

            ClearMaterials();
            if (CurrentButtonIdx != -1)
            {
                LoadMaterials();
                RepositionGroupBoxes();
            }    
        }

        private void LoadMaterials()
        {
            JObject jsonObject = new JObject(
                new JProperty("id", CurrentButtonIdx)
            );

            JObject Response = Net.GetRequest("api/material", out _, jsonObject);

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
                    float Perimeter = 0.0f, Foundation, BuildingArea = 0.0f;

                    Foundation = 2 * (Length + Width);
                    BuildingArea = Width * Length;

                    switch (BuildSchemeComboBox.SelectedIndex)
                    {
                        case 0: // Пятистенок
                            Perimeter = 5 * Length;
                            break;
                        case 1: // Шестистенок
                            Perimeter = 6 * Length;
                            break;
                    }

                    BuildPerimeterResultLabel.Text = Perimeter.ToString("0.0") + " м";
                    FoundationLengthResultLabel.Text = Foundation.ToString("0.0") + " м";
                    BuildingAreaResultLabel.Text = BuildingArea.ToString("0.0") + " м²";
                    return;
                }
            }

            BuildPerimeterResultLabel.Text = "0 м";
            FoundationLengthResultLabel.Text = "0 м";
            BuildingAreaResultLabel.Text = "0 м²";
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
                UserNameLabel.Text = "Не авторизован";
                UserToken = "";
                pSettings.Save("token", UserToken);
                pSettings.Save("username", "");
                pSettings.Save("password", "");
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
                    AuthorizeButton.Text = "Выход";
                }
                form.DestroyIcon();
            }
        }

        private void RefreshUser()
        {
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
                                AuthorizeButton.Text = "Выход";

                                if (Response["user"] != null)
                                {
                                    JObject UserData = Response["user"] as JObject;
                                    if (UserData["name"] != null && UserData["lastname"] != null)
                                    {
                                        UserNameLabel.Text = $"{UserData["name"]}\n{UserData["lastname"]}";
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
                        AuthorizeButton.Text = "Выход";
                        JObject UserData = Response["userInfo"] as JObject;
                        if (UserData["name"] != null && UserData["lastname"] != null)
                            UserNameLabel.Text = $"{UserData["name"]}\n{UserData["lastname"]}";
                        else
                            MessageBox.Show($"Ошибка сервера. Невозможно получить имя пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show($"Ошибка сервера. Невозможно получить пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
