namespace BuildCalculator.Forms
{
    partial class AboutProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramForm));
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DevsLabel = new System.Windows.Forms.Label();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::BuildCalculator.Properties.Resources.MainIcon_256;
            this.IconPictureBox.Location = new System.Drawing.Point(13, 13);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(93, 94);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(112, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(373, 50);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "О программе\r\nКалькулятор сметы «Дом ремонта»";
            // 
            // DevsLabel
            // 
            this.DevsLabel.AutoSize = true;
            this.DevsLabel.Location = new System.Drawing.Point(116, 76);
            this.DevsLabel.Name = "DevsLabel";
            this.DevsLabel.Size = new System.Drawing.Size(256, 13);
            this.DevsLabel.TabIndex = 2;
            this.DevsLabel.Text = "Copyright Шыша 2023-2023. Все права защищены";
            this.DevsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.Location = new System.Drawing.Point(13, 114);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.ReadOnly = true;
            this.InfoRichTextBox.Size = new System.Drawing.Size(464, 153);
            this.InfoRichTextBox.TabIndex = 3;
            this.InfoRichTextBox.Text = "Code:\nРазработка приложения - ValeroK\nРазработка серверной части - culcat\nГде жаж" +
    "да деятельности? - Вадик\n\nLibraries:\nNewtonsoft.Json - JamesNK";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(115, 94);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(50, 13);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Версия: ";
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 281);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.InfoRichTextBox);
            this.Controls.Add(this.DevsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DevsLabel;
        private System.Windows.Forms.RichTextBox InfoRichTextBox;
        private System.Windows.Forms.Label VersionLabel;
    }
}