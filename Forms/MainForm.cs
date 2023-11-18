#define OPTIMIZE_RESIZE

using BuildCalculator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
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

        public MainForm()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            InitializeComponent();
            CurrentButtonIdx = -1;

            FloatTextBox_TextChanged(BuildWidthTextBox, null);
            FloatTextBox_TextChanged(BuildLengthTextBox, null);
            BuildSchemeComboBox.SelectedIndex = 0;
            FloorComboBox.SelectedIndex = 0;

            ClearMaterials();
        }

        private void ClearMaterials()
        {
            MaterialsPanel.Controls.Clear();
        }

        private void AddMaterial(int idx, string Name)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "MaterialGroupBox_" + idx;
            groupBox.Text = Name;
            groupBox.Font = MaterialGroupBox.Font;

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
            groupBox.Controls.Add(pictureBox);

            Button button = new Button();
            button.Name = "MaterialSelectButton_" + idx;
            button.Size = MaterialSelectButton.Size;
            button.Location = MaterialSelectButton.Location;
            button.Anchor = MaterialSelectButton.Anchor;
            button.Text = MaterialSelectButton.Text;
            button.Font = MaterialSelectButton.Font;
            groupBox.Controls.Add(button);

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
                for (int i = 0; i < 10; i++)
                {
                    AddMaterial(i, "Улиточная слизь");
                }
                RepositionGroupBoxes();
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
    }
}
