namespace BuildCalculator.Forms
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MainGroupBox.SuspendLayout();
            this.ButtonsGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            this.DescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.InfoGroupBox);
            this.MainGroupBox.Controls.Add(this.ButtonsGroupBox);
            this.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(798, 543);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsGroupBox.Controls.Add(this.ButtonsPanel);
            this.ButtonsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonsGroupBox.Location = new System.Drawing.Point(7, 13);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(246, 524);
            this.ButtonsGroupBox.TabIndex = 0;
            this.ButtonsGroupBox.TabStop = false;
            this.ButtonsGroupBox.Text = "Список";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGroupBox.Controls.Add(this.InfoPanel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoGroupBox.Location = new System.Drawing.Point(259, 13);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(533, 524);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Информация";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.HelpButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 18);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(240, 503);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.DescriptionGroupBox);
            this.InfoPanel.Controls.Add(this.InfoPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(3, 18);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(527, 503);
            this.InfoPanel.TabIndex = 0;
            // 
            // HelpButton
            // 
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpButton.Location = new System.Drawing.Point(0, 0);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(240, 31);
            this.HelpButton.TabIndex = 0;
            this.HelpButton.Text = "1. Text";
            this.HelpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(520, 278);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoPictureBox.TabIndex = 0;
            this.InfoPictureBox.TabStop = false;
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Controls.Add(this.DescriptionRichTextBox);
            this.DescriptionGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionGroupBox.Location = new System.Drawing.Point(0, 286);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(527, 217);
            this.DescriptionGroupBox.TabIndex = 2;
            this.DescriptionGroupBox.TabStop = false;
            this.DescriptionGroupBox.Text = "Описание";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(3, 18);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.ReadOnly = true;
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(521, 196);
            this.DescriptionRichTextBox.TabIndex = 0;
            this.DescriptionRichTextBox.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 543);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.MainGroupBox.ResumeLayout(false);
            this.ButtonsGroupBox.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            this.DescriptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private System.Windows.Forms.GroupBox DescriptionGroupBox;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
    }
}