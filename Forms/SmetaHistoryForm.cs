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
    public partial class SmetaHistoryForm : Form
    {
        private Thread LoaderThread;
        private Dictionary<string, Bitmap> CachedImages;
        private Dictionary<int, JObject> CachedMaterials;
        private int CurrentButtonIdx;

        public SmetaHistoryForm()
        {
            InitializeComponent();

            CurrentButtonIdx = -1;
            CachedImages = new Dictionary<string, Bitmap>();
            CachedMaterials = new Dictionary<int, JObject>();
        }

        private void SmetaHistory_Load(object sender, EventArgs e)
        {
            var gb = LoadAnimation.StartAnimation(5, 1.0f, 1, this);
            Controls.Add(gb);
            Controls.SetChildIndex(gb, 0);

            LoaderThread = new Thread(LoadServerInfo);
            LoaderThread.Start();
        }

        private void LoadServerInfo()
        {
            LoadMaterialButtons();
            LoadAnimation.StopAnimation();
        }

        private void LoadMaterialButtons()
        {
            LoadAnimation.IncrementBar();
            Invoke((MethodInvoker)delegate ()
            {
                MaterialsListPanel.Controls.Clear();
            });

            JObject JsonObject = Net.GetRequest("api/buttons", out _);
            if (JsonObject != null && JsonObject["buttons"] != null)
            {
                JArray buttons = JsonObject["buttons"] as JArray;

                bool hasInvalidData = buttons.Any(button => button["id"] == null || button["name"] == null || button["icon"] == null);

                if (!hasInvalidData)
                {
                    buttons = new JArray(
                        from button in buttons
                        orderby (int)button["id"] descending
                        select button
                    );

                    foreach (JToken button in buttons)
                    {
                        Button view_button = new Button();
                        view_button.Name = "MaterialButton_" + button["id"].ToString();
                        view_button.Size = MaterialButton.Size;
                        view_button.Location = new Point(MaterialButton.Location.X, MaterialButton.Location.Y + (MaterialButton.Size.Height + 6) * (int)button["id"]);
                        view_button.Dock = DockStyle.Top;
                        view_button.Font = MaterialButton.Font;
                        view_button.Text = $"         {(int)button["id"] + 1}. {button["name"]}";
                        view_button.TextAlign = MaterialButton.TextAlign;
                        view_button.Tag = button["id"].ToString();
                        view_button.Click += ButtonsList_Click;

                        try
                        {
                            byte[] imageBytes = Convert.FromBase64String(button["icon"].ToString());
                            Bitmap bitmap;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                bitmap = new Bitmap(ms);
                            }
                            view_button.Image = bitmap;
                            view_button.ImageAlign = MaterialButton.ImageAlign;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Invoke((MethodInvoker)delegate ()
                        {
                            MaterialsListPanel.Controls.Add(view_button);
                        });

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

            //ClearMaterials();
            //if (CurrentButtonIdx != -1)
            //{
            //    LoadMaterials();
            //    RepositionGroupBoxes();
            //}
        }

        private void SmetaHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoaderThread.Abort();
        }
    }
}
