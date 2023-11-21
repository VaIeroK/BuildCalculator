using BuildCalculator.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildCalculator.Forms
{
    public partial class HelpForm : Form
    {
        private class HelpTab
        {
            public Image Image { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        private Thread LoaderThread;
        private Dictionary<int, HelpTab> HelpList;
        private int CurrentButtonIdx;

        public HelpForm()
        {
            InitializeComponent();

            CurrentButtonIdx = -1;
            HelpList = new Dictionary<int, HelpTab>();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            var gb = LoadAnimation.StartAnimation(5, 1.0f, 1, this);
            Controls.Add(gb);
            Controls.SetChildIndex(gb, 0);

            LoaderThread = new Thread(LoadServerInfo);
            LoaderThread.Start();
        }

        private void LoadServerInfo()
        {
            LoadButtons();
            LoadAnimation.StopAnimation();
        }

        private void LoadButtons()
        {
            LoadAnimation.IncrementBar();
            Invoke((MethodInvoker)delegate ()
            {
                ButtonsPanel.Controls.Clear();
            });

            JObject JsonObject = Net.GetRequest("api/help", out _);
            if (JsonObject != null && JsonObject["help_list"] != null)
            {
                JArray buttons = JsonObject["help_list"] as JArray;

                bool hasInvalidData = buttons.Any(button => button["id"] == null || button["name"] == null || button["icon"] == null || button["text"] == null);

                if (!hasInvalidData)
                {
                    buttons = new JArray(
                        from button in buttons
                        orderby (int)button["id"] descending
                        select button
                    );

                    foreach (JToken button in buttons)
                    {
                        HelpTab helpTab = new HelpTab();
                        helpTab.Name = button["name"].ToString();
                        helpTab.Description = button["text"].ToString();

                        Button view_button = new Button();
                        view_button.Name = "MaterialButton_" + button["id"].ToString();
                        view_button.Size = HelpButton.Size;
                        view_button.Location = new Point(HelpButton.Location.X, HelpButton.Location.Y + (HelpButton.Size.Height + 6) * (int)button["id"]);
                        view_button.Dock = DockStyle.Top;
                        view_button.Font = HelpButton.Font;
                        view_button.Text = $"{(int)button["id"] + 1}. {button["name"]}";
                        view_button.TextAlign = HelpButton.TextAlign;
                        view_button.Tag = button["id"].ToString();
                        view_button.Click += HelpButton_Click;

                        try
                        {
                            WebClient client = new WebClient();
                            byte[] imageData = client.DownloadData(button["icon"].ToString());

                            using (var stream = new System.IO.MemoryStream(imageData))
                            {
                                Bitmap bitmap = new Bitmap(stream);
                                helpTab.Image = bitmap;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        }

                        Invoke((MethodInvoker)delegate ()
                        {
                            ButtonsPanel.Controls.Add(view_button);
                        });

                        HelpList.Add((int)button["id"], helpTab);
                    }
                }
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in ButtonsPanel.Controls)
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

            if (CurrentButtonIdx != -1)
            {
                InfoPictureBox.Image = HelpList[CurrentButtonIdx].Image;
                DescriptionRichTextBox.Text = HelpList[CurrentButtonIdx].Description;
            }
            else
            {
                InfoPictureBox.Image = null;
                DescriptionRichTextBox.Text = "";
            }
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoaderThread.Abort();
        }
    }
}
