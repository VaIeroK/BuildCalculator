#define OPTIMIZE_RESIZE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            InitializeComponent();
            CurrentButtonIdx = 0;

            MaterialsPanel.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                AddMaterial(i, "");
            }
        }

        private void AddMaterial(int idx, string Name)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "MaterialGroupBox_" + idx;
            groupBox.Text = Name;

            int x = CurrentColumn * (MaterialGroupBox.Width + GroupBoxMargin);
            int y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);

            if (x + MaterialGroupBox.Width > MaterialsPanel.ClientSize.Width)
            {
                CurrentRow++;
                CurrentColumn = 0;
                x = 0;
                y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);
            }

            groupBox.Location = new System.Drawing.Point(x, y);
            groupBox.Size = new System.Drawing.Size(MaterialGroupBox.Width, MaterialGroupBox.Height);

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

                if (x + MaterialGroupBox.Width > MaterialsPanel.ClientSize.Width)
                {
                    CurrentRow++;
                    CurrentColumn = 0;
                    x = 0;
                    y = CurrentRow * (MaterialGroupBox.Height + GroupBoxMargin);
                }

                control.Location = new System.Drawing.Point(x, y);
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
            CurrentButtonIdx = Convert.ToByte(cur_button.Tag.ToString());
            cur_button.BackColor = Color.FromArgb(80, 0, 120, 215);
        }
    }
}
