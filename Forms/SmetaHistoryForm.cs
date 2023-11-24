using BuildCalculator.Classes;
using Newtonsoft.Json;
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
using static BuildCalculator.Forms.SmetaHistoryForm;

namespace BuildCalculator.Forms
{
    public partial class SmetaHistoryForm : Form
    {
        private Thread LoaderThread;
        private int CurrentButtonIdx;
        List<OrderGroup> GroupedOrders;
        Dictionary<int, string> ButtonsLocalization;

        class ButtonLocalizedItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Order
        {
            public int order_id { get; set; }
            public string price { get; set; }
            public int material_id { get; set; }
            public string material_name { get; set; }
            public int material_type_id { get; set; }
            public string material_type_name { get; set; }
            public string material_img { get; set; }
            public int price_item { get; set; }
            public DateTime adjusted_order_date { get; set; }
        }

        public class RootObject
        {
            public List<Order> orderHistory { get; set; }
        }

        public class OrderGroup
        {
            public int order_id { get; set; }
            public List<Order> orders { get; set; }
        }

        public SmetaHistoryForm()
        {
            InitializeComponent();

            CurrentButtonIdx = -1;
            GroupedOrders = new List<OrderGroup>();
            ButtonsLocalization = new Dictionary<int, string>();

            ClearInfo();
            MaterialsListPanel.Controls.Clear();
        }

        private void ClearInfo()
        {
            MaterialPictureBox.Image = null;
            MaterialNameLabel.Text = "";
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
            ParseHistoryList();
            LoadAnimation.StopAnimation();
        }

        private void LoadButtons()
        {
            CurrentButtonIdx = -1;
            MaterialsListPanel.Controls.Clear();

            if (HistoryListBox.SelectedIndex == -1) return;

            var orderGroup = GroupedOrders[HistoryListBox.SelectedIndex];
            {
                if (orderGroup.orders.Count > 0)
                {
                    foreach (var order in orderGroup.orders)
                    {
                        Button view_button = new Button();
                        view_button.Name = "MaterialButton_" + order.material_type_id;
                        view_button.Size = MaterialButton.Size;
                        view_button.Dock = DockStyle.Top;
                        view_button.Font = MaterialButton.Font;
                        if (ButtonsLocalization.ContainsKey(order.material_type_id))
                            view_button.Text = $"{ButtonsLocalization[order.material_type_id]}: {order.price_item} ₽";
                        else
                            view_button.Text = $"ID: {order.material_type_id} - Перевод не найден";
                        view_button.TextAlign = MaterialButton.TextAlign;
                        view_button.Tag = order.material_type_id.ToString();
                        view_button.Click += ButtonsList_Click;

                        MaterialsListPanel.Controls.Add(view_button);
                    }
                }
            }
        }

        private void ParseHistoryList()
        {
            var user = new
            {
                userID = MainForm.UserId
            };
            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            var Response = Net.GetRequestString("api/orderhistory", out _, JObject.Parse(json));

            if (Response != null)
            {
                RootObject jsonObject = null;
                try
                {
                    jsonObject = JsonConvert.DeserializeObject<RootObject>(Response);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке истории: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                GroupedOrders = jsonObject.orderHistory
                .GroupBy(o => o.order_id)
                .Select(g => new OrderGroup
                {
                    order_id = g.Key,
                    orders = g.OrderByDescending(o => o.material_type_id).ToList()
                }).ToList();

                HistoryListBox.Controls.Clear();

                foreach (var orderGroup in GroupedOrders)
                {
                    if (orderGroup.orders.Count > 0)
                        HistoryListBox.Items.Add($"{orderGroup.orders[0].adjusted_order_date.ToShortDateString().Replace('/', '.')} - {orderGroup.orders[0].adjusted_order_date.ToString("HH:mm:ss")}");
                }

                var LocalizeResponse = Net.GetRequestString("api/buttonsData", out _);

                if (LocalizeResponse != null)
                {
                    List<ButtonLocalizedItem> items = null;

                    try
                    {
                        items = JsonConvert.DeserializeObject<List<ButtonLocalizedItem>>(LocalizeResponse);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке локализации кнопок: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ButtonsLocalization.Clear();

                    foreach (var item in items)
                        ButtonsLocalization.Add(item.Id, item.Name);
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
                CurrentButtonIdx = -1;
            else
                cur_button.BackColor = Color.FromArgb(80, 0, 120, 215);

            if (CurrentButtonIdx != -1)
                LoadMaterial();
        }

        private void LoadMaterial()
        {
            if (HistoryListBox.SelectedIndex == -1) return;
            var orderGroup = GroupedOrders[HistoryListBox.SelectedIndex];
            var order = orderGroup.orders.FirstOrDefault(x => x.material_type_id == CurrentButtonIdx);
            if (order == null) return;

            MaterialNameLabel.Text = order.material_name;

            try
            {
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(order.material_img);

                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    Bitmap bitmap = new Bitmap(stream);
                    MaterialPictureBox.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaterialPictureBox.Image = null;
            }
        }

        private void SmetaHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoaderThread.Abort();
        }

        private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInfo();
            LoadButtons();

            if (HistoryListBox.SelectedIndex == -1)
            {
                ResultLabel.Text = "0 ₽";
                return;
            }

            var orderGroup = GroupedOrders[HistoryListBox.SelectedIndex];
            if (orderGroup.orders.Count > 0)
            {
                if (MathHelper.IsFloat(orderGroup.orders[0].price))
                    ResultLabel.Text = $"{Convert.ToSingle(orderGroup.orders[0].price).ToString("0.00")} ₽";
                else
                    ResultLabel.Text = "0 ₽";
            }
            else
                ResultLabel.Text = "0 ₽";
        }
    }
}
