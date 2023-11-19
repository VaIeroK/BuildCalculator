using BuildCalculator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildCalculator.Classes
{
    public static class LoadAnimation
    {
        private static Timer AnimationTimer;
        private static Timer TextAnimationTimer;
        private static float RotateAngle;
        private static float RotateStepAngle;
        private static Image SourceImage;
        private static Form ParentForm;
        private static string[] LoadingTexts;
        private static byte LoadingTextsStep;

        public static GroupBox StartAnimation(int tick, float step_angle, int progress_steps, Form parent)
        {
            ParentForm = parent;
            AnimationTimer = new Timer();
            TextAnimationTimer = new Timer();
            AnimationTimer.Interval = tick;
            TextAnimationTimer.Interval = 300;
            AnimationTimer.Tick += AnimationTimer_Tick;
            TextAnimationTimer.Tick += TextAnimationTimer_Tick;
            RotateAngle = 0.0f;
            RotateStepAngle = step_angle;
            SourceImage = Resources.Loading;
            LoadingTexts = new string[] { "Загрузка", "Загрузка.", "Загрузка..", "Загрузка..." };
            LoadingTextsStep = 0;

            GroupBox AnimationGroupBox = new GroupBox();
            AnimationGroupBox.Location = new Point(0, 0);
            AnimationGroupBox.Dock = DockStyle.Fill;
            AnimationGroupBox.Size = parent.Size;
            AnimationGroupBox.Name = "AnimationGroupBox";
            AnimationGroupBox.Resize += ResizeGroupBox;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "PictureBox";
            pictureBox.Image = SourceImage;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(128, 128);
            pictureBox.Location = new Point((AnimationGroupBox.Width - pictureBox.Width) / 2, (AnimationGroupBox.Height - pictureBox.Height) / 2);

            Label label = new Label();
            label.Name = "AnimationLabel";
            label.Text = LoadingTexts[LoadingTextsStep];
            label.Font = new Font("Arial", 14, FontStyle.Regular);
            label.Location = new Point(((AnimationGroupBox.Width - pictureBox.Width) / 2) + 20, ((AnimationGroupBox.Height - pictureBox.Height) / 2) + pictureBox.Height);

            ProgressBar progressBar = new ProgressBar();
            progressBar.Location = new Point(((AnimationGroupBox.Width - pictureBox.Width) / 2), ((AnimationGroupBox.Height - pictureBox.Height) / 2) + pictureBox.Height + label.Height + 5);
            progressBar.Size = new Size(128, 24);
            progressBar.Name = "AnimationProgressBar";
            progressBar.Maximum = progress_steps;

            AnimationGroupBox.Controls.Add(pictureBox);
            AnimationGroupBox.Controls.Add(label);
            AnimationGroupBox.Controls.Add(progressBar);

            AnimationTimer.Start();
            TextAnimationTimer.Start();
            AnimationGroupBox.ResumeLayout(true);
            return AnimationGroupBox;
        }

        public static void StopAnimation()
        {
            AnimationTimer.Stop();
            TextAnimationTimer.Stop();
            ParentForm.Invoke((MethodInvoker)delegate ()
            {
                ParentForm.Controls.Remove(ParentForm.Controls["AnimationGroupBox"]);
                ParentForm.Controls["MainMenuToolStrip"].Visible = true;
            });
        }

        public static void IncrementBar()
        {
            ParentForm.Invoke((MethodInvoker)delegate ()
            {
                GroupBox groupBox = ParentForm.Controls["AnimationGroupBox"] as GroupBox;
                ProgressBar progressBar = groupBox.Controls["AnimationProgressBar"] as ProgressBar;
                progressBar.Value++;
            });
        }

        private static Bitmap RotateImage(Image image, float angle)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, new PointF(image.Width / 2f, image.Height / 2f));

            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.Transform = matrix;
                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }

            return rotatedImage;
        }

        private static void ResizeGroupBox(object sender, EventArgs e)
        {
            GroupBox groupBox = ParentForm.Controls["AnimationGroupBox"] as GroupBox;
            PictureBox pictureBox = groupBox.Controls["PictureBox"] as PictureBox;
            Label label = groupBox.Controls["AnimationLabel"] as Label;
            ProgressBar progressBar = groupBox.Controls["AnimationProgressBar"] as ProgressBar;
            pictureBox.Location = new Point((groupBox.Width - pictureBox.Width) / 2, (groupBox.Height - pictureBox.Height) / 2);
            label.Location = new Point(((groupBox.Width - pictureBox.Width) / 2) + 20, ((groupBox.Height - pictureBox.Height) / 2) + pictureBox.Height);
            progressBar.Location = new Point(((groupBox.Width - pictureBox.Width) / 2), ((groupBox.Height - pictureBox.Height) / 2) + pictureBox.Height + label.Height + 5);
        }

        private static void AnimationTimer_Tick(object sender, EventArgs e)
        {
            RotateAngle += RotateStepAngle;

            (ParentForm.Controls["AnimationGroupBox"].Controls["PictureBox"] as PictureBox).Image = RotateImage(SourceImage, RotateAngle);

            if (RotateAngle >= 360.0f)
                RotateAngle = 0.0f;
        }

        private static void TextAnimationTimer_Tick(object sender, EventArgs e)
        {
            (ParentForm.Controls["AnimationGroupBox"].Controls["AnimationLabel"] as Label).Text = LoadingTexts[LoadingTextsStep];
            LoadingTextsStep++;

            if (LoadingTextsStep >= LoadingTexts.Length)
                LoadingTextsStep = 0;
        }
    }
}
