namespace BuildCalculator.Forms
{
    partial class SmetaHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmetaHistory));
            this.HistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.MaterialsListGroupBox = new System.Windows.Forms.GroupBox();
            this.MaterialsListPanel = new System.Windows.Forms.Panel();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.InputSecondTextBox = new System.Windows.Forms.TextBox();
            this.InputFirstTextBox = new System.Windows.Forms.TextBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.InputSecondLabel = new System.Windows.Forms.Label();
            this.InputFirstLabel = new System.Windows.Forms.Label();
            this.MaterialPictureBox = new System.Windows.Forms.PictureBox();
            this.HistoryGroupBox.SuspendLayout();
            this.MaterialsListGroupBox.SuspendLayout();
            this.MaterialsListPanel.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryGroupBox
            // 
            this.HistoryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryGroupBox.Controls.Add(this.HistoryListBox);
            this.HistoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryGroupBox.Location = new System.Drawing.Point(13, 13);
            this.HistoryGroupBox.Name = "HistoryGroupBox";
            this.HistoryGroupBox.Size = new System.Drawing.Size(201, 360);
            this.HistoryGroupBox.TabIndex = 0;
            this.HistoryGroupBox.TabStop = false;
            this.HistoryGroupBox.Text = "Список смет";
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 16;
            this.HistoryListBox.Location = new System.Drawing.Point(3, 18);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(195, 339);
            this.HistoryListBox.TabIndex = 0;
            // 
            // MaterialsListGroupBox
            // 
            this.MaterialsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialsListGroupBox.Controls.Add(this.MaterialsListPanel);
            this.MaterialsListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialsListGroupBox.Location = new System.Drawing.Point(220, 13);
            this.MaterialsListGroupBox.Name = "MaterialsListGroupBox";
            this.MaterialsListGroupBox.Size = new System.Drawing.Size(240, 360);
            this.MaterialsListGroupBox.TabIndex = 1;
            this.MaterialsListGroupBox.TabStop = false;
            this.MaterialsListGroupBox.Text = "Список материалов";
            // 
            // MaterialsListPanel
            // 
            this.MaterialsListPanel.AutoScroll = true;
            this.MaterialsListPanel.Controls.Add(this.MaterialButton);
            this.MaterialsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsListPanel.Location = new System.Drawing.Point(3, 18);
            this.MaterialsListPanel.Name = "MaterialsListPanel";
            this.MaterialsListPanel.Size = new System.Drawing.Size(234, 339);
            this.MaterialsListPanel.TabIndex = 0;
            // 
            // MaterialButton
            // 
            this.MaterialButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaterialButton.Location = new System.Drawing.Point(3, 3);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(228, 32);
            this.MaterialButton.TabIndex = 0;
            this.MaterialButton.Text = "1. Test";
            this.MaterialButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaterialButton.UseVisualStyleBackColor = true;
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationGroupBox.Controls.Add(this.InputSecondTextBox);
            this.InformationGroupBox.Controls.Add(this.InputFirstTextBox);
            this.InformationGroupBox.Controls.Add(this.ResultGroupBox);
            this.InformationGroupBox.Controls.Add(this.InputSecondLabel);
            this.InformationGroupBox.Controls.Add(this.InputFirstLabel);
            this.InformationGroupBox.Controls.Add(this.MaterialPictureBox);
            this.InformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationGroupBox.Location = new System.Drawing.Point(466, 13);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(341, 360);
            this.InformationGroupBox.TabIndex = 2;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Информация";
            // 
            // InputSecondTextBox
            // 
            this.InputSecondTextBox.Location = new System.Drawing.Point(7, 237);
            this.InputSecondTextBox.Name = "InputSecondTextBox";
            this.InputSecondTextBox.ReadOnly = true;
            this.InputSecondTextBox.Size = new System.Drawing.Size(328, 22);
            this.InputSecondTextBox.TabIndex = 12;
            // 
            // InputFirstTextBox
            // 
            this.InputFirstTextBox.Location = new System.Drawing.Point(7, 187);
            this.InputFirstTextBox.Name = "InputFirstTextBox";
            this.InputFirstTextBox.ReadOnly = true;
            this.InputFirstTextBox.Size = new System.Drawing.Size(328, 22);
            this.InputFirstTextBox.TabIndex = 11;
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultGroupBox.Controls.Add(this.ResultLabel);
            this.ResultGroupBox.Location = new System.Drawing.Point(7, 265);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(328, 89);
            this.ResultGroupBox.TabIndex = 10;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Итоговая стоимость";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(19, 33);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(80, 31);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "0 руб";
            // 
            // InputSecondLabel
            // 
            this.InputSecondLabel.AutoSize = true;
            this.InputSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSecondLabel.Location = new System.Drawing.Point(4, 216);
            this.InputSecondLabel.Name = "InputSecondLabel";
            this.InputSecondLabel.Size = new System.Drawing.Size(48, 16);
            this.InputSecondLabel.TabIndex = 8;
            this.InputSecondLabel.Text = "Input 2:";
            // 
            // InputFirstLabel
            // 
            this.InputFirstLabel.AutoSize = true;
            this.InputFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstLabel.Location = new System.Drawing.Point(4, 167);
            this.InputFirstLabel.Name = "InputFirstLabel";
            this.InputFirstLabel.Size = new System.Drawing.Size(48, 16);
            this.InputFirstLabel.TabIndex = 6;
            this.InputFirstLabel.Text = "Input 1:";
            // 
            // MaterialPictureBox
            // 
            this.MaterialPictureBox.Location = new System.Drawing.Point(6, 21);
            this.MaterialPictureBox.Name = "MaterialPictureBox";
            this.MaterialPictureBox.Size = new System.Drawing.Size(329, 140);
            this.MaterialPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaterialPictureBox.TabIndex = 1;
            this.MaterialPictureBox.TabStop = false;
            // 
            // SmetaHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 385);
            this.Controls.Add(this.InformationGroupBox);
            this.Controls.Add(this.MaterialsListGroupBox);
            this.Controls.Add(this.HistoryGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmetaHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmetaHistory_FormClosing);
            this.Load += new System.EventHandler(this.SmetaHistory_Load);
            this.HistoryGroupBox.ResumeLayout(false);
            this.MaterialsListGroupBox.ResumeLayout(false);
            this.MaterialsListPanel.ResumeLayout(false);
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HistoryGroupBox;
        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.GroupBox MaterialsListGroupBox;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.Panel MaterialsListPanel;
        private System.Windows.Forms.Button MaterialButton;
        private System.Windows.Forms.PictureBox MaterialPictureBox;
        private System.Windows.Forms.Label InputSecondLabel;
        private System.Windows.Forms.Label InputFirstLabel;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox InputFirstTextBox;
        private System.Windows.Forms.TextBox InputSecondTextBox;
    }
}