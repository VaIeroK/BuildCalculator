namespace BuildCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuToolStrip = new System.Windows.Forms.MenuStrip();
            this.UserCabinetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowSmetaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CalculateGroupBox = new System.Windows.Forms.GroupBox();
            this.LeftGroupBox = new System.Windows.Forms.GroupBox();
            this.MaterialsListPanel = new System.Windows.Forms.Panel();
            this.MaterialSelectedCheckBox = new System.Windows.Forms.CheckBox();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.RightGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultRubLabel = new System.Windows.Forms.Label();
            this.ResultCostLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.InfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BuildSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildLengthMeterLabel = new System.Windows.Forms.Label();
            this.BuildWidthMeterLabel = new System.Windows.Forms.Label();
            this.BuildSizeResultGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildingAreaResultLabel = new System.Windows.Forms.Label();
            this.FoundationLengthResultLabel = new System.Windows.Forms.Label();
            this.BuildPerimeterResultLabel = new System.Windows.Forms.Label();
            this.BuildingAreaLabel = new System.Windows.Forms.Label();
            this.FoundationLengthLabel = new System.Windows.Forms.Label();
            this.BuildPerimeterLabel = new System.Windows.Forms.Label();
            this.FloorComboBox = new System.Windows.Forms.ComboBox();
            this.FloorLabel = new System.Windows.Forms.Label();
            this.BuildSchemeComboBox = new System.Windows.Forms.ComboBox();
            this.BuildSchemeLabel = new System.Windows.Forms.Label();
            this.BuildLengthLabel = new System.Windows.Forms.Label();
            this.BuildLengthTextBox = new System.Windows.Forms.TextBox();
            this.BuildWidthLabel = new System.Windows.Forms.Label();
            this.BuildWidthTextBox = new System.Windows.Forms.TextBox();
            this.BuildSizeLabel = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.MaterialsListGroupBox = new System.Windows.Forms.GroupBox();
            this.MaterialsPanel = new System.Windows.Forms.Panel();
            this.MaterialGroupBox = new System.Windows.Forms.GroupBox();
            this.InputSecondComboBox = new System.Windows.Forms.ComboBox();
            this.InputSecondLabel = new System.Windows.Forms.Label();
            this.InputFirstComboBox = new System.Windows.Forms.ComboBox();
            this.InputFirstLabel = new System.Windows.Forms.Label();
            this.MaterialSelectButton = new System.Windows.Forms.Button();
            this.CalculateResultButton = new System.Windows.Forms.Button();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.MaterialPictureBox = new System.Windows.Forms.PictureBox();
            this.MainMenuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.CalculateGroupBox.SuspendLayout();
            this.LeftGroupBox.SuspendLayout();
            this.MaterialsListPanel.SuspendLayout();
            this.RightGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).BeginInit();
            this.InfoSplitContainer.Panel1.SuspendLayout();
            this.InfoSplitContainer.Panel2.SuspendLayout();
            this.InfoSplitContainer.SuspendLayout();
            this.BuildSizeGroupBox.SuspendLayout();
            this.BuildSizeResultGroupBox.SuspendLayout();
            this.UserGroupBox.SuspendLayout();
            this.MaterialsListGroupBox.SuspendLayout();
            this.MaterialsPanel.SuspendLayout();
            this.MaterialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuToolStrip
            // 
            this.MainMenuToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserCabinetMenuItem,
            this.HelpMenuItem,
            this.AboutProgramMenuItem});
            this.MainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuToolStrip.Name = "MainMenuToolStrip";
            this.MainMenuToolStrip.Size = new System.Drawing.Size(1338, 25);
            this.MainMenuToolStrip.TabIndex = 0;
            this.MainMenuToolStrip.Text = "MainMenuStrip";
            // 
            // UserCabinetMenuItem
            // 
            this.UserCabinetMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowSmetaMenuItem});
            this.UserCabinetMenuItem.Enabled = false;
            this.UserCabinetMenuItem.Name = "UserCabinetMenuItem";
            this.UserCabinetMenuItem.Size = new System.Drawing.Size(117, 21);
            this.UserCabinetMenuItem.Text = "Личный кабинет";
            // 
            // ShowSmetaMenuItem
            // 
            this.ShowSmetaMenuItem.Name = "ShowSmetaMenuItem";
            this.ShowSmetaMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ShowSmetaMenuItem.Text = "История смет";
            this.ShowSmetaMenuItem.Click += new System.EventHandler(this.ShowSmetaMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(70, 21);
            this.HelpMenuItem.Text = "Справка";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // AboutProgramMenuItem
            // 
            this.AboutProgramMenuItem.Name = "AboutProgramMenuItem";
            this.AboutProgramMenuItem.Size = new System.Drawing.Size(102, 21);
            this.AboutProgramMenuItem.Text = "О программе";
            this.AboutProgramMenuItem.Click += new System.EventHandler(this.AboutProgramMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 689);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1338, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.CalculateGroupBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.LeftGroupBox);
            this.MainSplitContainer.Panel1MinSize = 330;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.RightGroupBox);
            this.MainSplitContainer.Panel2MinSize = 1000;
            this.MainSplitContainer.Size = new System.Drawing.Size(1338, 664);
            this.MainSplitContainer.SplitterDistance = 330;
            this.MainSplitContainer.SplitterWidth = 6;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // CalculateGroupBox
            // 
            this.CalculateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateGroupBox.Controls.Add(this.CalculateResultButton);
            this.CalculateGroupBox.Location = new System.Drawing.Point(3, 611);
            this.CalculateGroupBox.Name = "CalculateGroupBox";
            this.CalculateGroupBox.Size = new System.Drawing.Size(327, 53);
            this.CalculateGroupBox.TabIndex = 1;
            this.CalculateGroupBox.TabStop = false;
            // 
            // LeftGroupBox
            // 
            this.LeftGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftGroupBox.Controls.Add(this.MaterialsListPanel);
            this.LeftGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftGroupBox.Location = new System.Drawing.Point(3, 0);
            this.LeftGroupBox.Name = "LeftGroupBox";
            this.LeftGroupBox.Size = new System.Drawing.Size(327, 611);
            this.LeftGroupBox.TabIndex = 0;
            this.LeftGroupBox.TabStop = false;
            this.LeftGroupBox.Text = "Материалы";
            // 
            // MaterialsListPanel
            // 
            this.MaterialsListPanel.AutoScroll = true;
            this.MaterialsListPanel.Controls.Add(this.MaterialSelectedCheckBox);
            this.MaterialsListPanel.Controls.Add(this.MaterialButton);
            this.MaterialsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsListPanel.Location = new System.Drawing.Point(3, 18);
            this.MaterialsListPanel.Name = "MaterialsListPanel";
            this.MaterialsListPanel.Size = new System.Drawing.Size(321, 590);
            this.MaterialsListPanel.TabIndex = 0;
            // 
            // MaterialSelectedCheckBox
            // 
            this.MaterialSelectedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialSelectedCheckBox.AutoSize = true;
            this.MaterialSelectedCheckBox.Enabled = false;
            this.MaterialSelectedCheckBox.Location = new System.Drawing.Point(290, 19);
            this.MaterialSelectedCheckBox.Name = "MaterialSelectedCheckBox";
            this.MaterialSelectedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MaterialSelectedCheckBox.TabIndex = 1;
            this.MaterialSelectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaterialButton
            // 
            this.MaterialButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaterialButton.Location = new System.Drawing.Point(8, 9);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(305, 33);
            this.MaterialButton.TabIndex = 0;
            this.MaterialButton.Tag = "0";
            this.MaterialButton.Text = "1. Test";
            this.MaterialButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaterialButton.UseVisualStyleBackColor = true;
            this.MaterialButton.Visible = false;
            this.MaterialButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // RightGroupBox
            // 
            this.RightGroupBox.Controls.Add(this.ResultGroupBox);
            this.RightGroupBox.Controls.Add(this.InfoSplitContainer);
            this.RightGroupBox.Controls.Add(this.MaterialsListGroupBox);
            this.RightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RightGroupBox.Name = "RightGroupBox";
            this.RightGroupBox.Size = new System.Drawing.Size(1002, 664);
            this.RightGroupBox.TabIndex = 0;
            this.RightGroupBox.TabStop = false;
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultRubLabel);
            this.ResultGroupBox.Controls.Add(this.ResultCostLabel);
            this.ResultGroupBox.Controls.Add(this.ResultLabel);
            this.ResultGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultGroupBox.Location = new System.Drawing.Point(3, 611);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(996, 50);
            this.ResultGroupBox.TabIndex = 1;
            this.ResultGroupBox.TabStop = false;
            // 
            // ResultRubLabel
            // 
            this.ResultRubLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultRubLabel.AutoSize = true;
            this.ResultRubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultRubLabel.Location = new System.Drawing.Point(971, 17);
            this.ResultRubLabel.Name = "ResultRubLabel";
            this.ResultRubLabel.Size = new System.Drawing.Size(21, 24);
            this.ResultRubLabel.TabIndex = 2;
            this.ResultRubLabel.Text = "₽";
            // 
            // ResultCostLabel
            // 
            this.ResultCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultCostLabel.AutoSize = true;
            this.ResultCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultCostLabel.Location = new System.Drawing.Point(950, 16);
            this.ResultCostLabel.Name = "ResultCostLabel";
            this.ResultCostLabel.Size = new System.Drawing.Size(24, 25);
            this.ResultCostLabel.TabIndex = 1;
            this.ResultCostLabel.Text = "0";
            this.ResultCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(6, 7);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(225, 40);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Итоговая стоимость\r\nна текущем этапе расчётов:";
            // 
            // InfoSplitContainer
            // 
            this.InfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.InfoSplitContainer.Name = "InfoSplitContainer";
            // 
            // InfoSplitContainer.Panel1
            // 
            this.InfoSplitContainer.Panel1.Controls.Add(this.BuildSizeGroupBox);
            this.InfoSplitContainer.Panel1MinSize = 730;
            // 
            // InfoSplitContainer.Panel2
            // 
            this.InfoSplitContainer.Panel2.Controls.Add(this.UserGroupBox);
            this.InfoSplitContainer.Panel2MinSize = 261;
            this.InfoSplitContainer.Size = new System.Drawing.Size(996, 110);
            this.InfoSplitContainer.SplitterDistance = 731;
            this.InfoSplitContainer.TabIndex = 1;
            // 
            // BuildSizeGroupBox
            // 
            this.BuildSizeGroupBox.Controls.Add(this.BuildLengthMeterLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildWidthMeterLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSizeResultGroupBox);
            this.BuildSizeGroupBox.Controls.Add(this.FloorComboBox);
            this.BuildSizeGroupBox.Controls.Add(this.FloorLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSchemeComboBox);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSchemeLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildLengthLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildLengthTextBox);
            this.BuildSizeGroupBox.Controls.Add(this.BuildWidthLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildWidthTextBox);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSizeLabel);
            this.BuildSizeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildSizeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.BuildSizeGroupBox.Name = "BuildSizeGroupBox";
            this.BuildSizeGroupBox.Size = new System.Drawing.Size(731, 110);
            this.BuildSizeGroupBox.TabIndex = 1;
            this.BuildSizeGroupBox.TabStop = false;
            this.BuildSizeGroupBox.Text = "Строение";
            // 
            // BuildLengthMeterLabel
            // 
            this.BuildLengthMeterLabel.AutoSize = true;
            this.BuildLengthMeterLabel.Location = new System.Drawing.Point(137, 52);
            this.BuildLengthMeterLabel.Name = "BuildLengthMeterLabel";
            this.BuildLengthMeterLabel.Size = new System.Drawing.Size(16, 16);
            this.BuildLengthMeterLabel.TabIndex = 11;
            this.BuildLengthMeterLabel.Text = "м";
            // 
            // BuildWidthMeterLabel
            // 
            this.BuildWidthMeterLabel.AutoSize = true;
            this.BuildWidthMeterLabel.Location = new System.Drawing.Point(137, 80);
            this.BuildWidthMeterLabel.Name = "BuildWidthMeterLabel";
            this.BuildWidthMeterLabel.Size = new System.Drawing.Size(16, 16);
            this.BuildWidthMeterLabel.TabIndex = 10;
            this.BuildWidthMeterLabel.Text = "м";
            // 
            // BuildSizeResultGroupBox
            // 
            this.BuildSizeResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildSizeResultGroupBox.Controls.Add(this.BuildingAreaResultLabel);
            this.BuildSizeResultGroupBox.Controls.Add(this.FoundationLengthResultLabel);
            this.BuildSizeResultGroupBox.Controls.Add(this.BuildPerimeterResultLabel);
            this.BuildSizeResultGroupBox.Controls.Add(this.BuildingAreaLabel);
            this.BuildSizeResultGroupBox.Controls.Add(this.FoundationLengthLabel);
            this.BuildSizeResultGroupBox.Controls.Add(this.BuildPerimeterLabel);
            this.BuildSizeResultGroupBox.Location = new System.Drawing.Point(454, 13);
            this.BuildSizeResultGroupBox.Name = "BuildSizeResultGroupBox";
            this.BuildSizeResultGroupBox.Size = new System.Drawing.Size(271, 90);
            this.BuildSizeResultGroupBox.TabIndex = 9;
            this.BuildSizeResultGroupBox.TabStop = false;
            this.BuildSizeResultGroupBox.Text = "Результат";
            // 
            // BuildingAreaResultLabel
            // 
            this.BuildingAreaResultLabel.AutoSize = true;
            this.BuildingAreaResultLabel.Location = new System.Drawing.Point(146, 64);
            this.BuildingAreaResultLabel.Name = "BuildingAreaResultLabel";
            this.BuildingAreaResultLabel.Size = new System.Drawing.Size(30, 16);
            this.BuildingAreaResultLabel.TabIndex = 5;
            this.BuildingAreaResultLabel.Text = "0 м²";
            // 
            // FoundationLengthResultLabel
            // 
            this.FoundationLengthResultLabel.AutoSize = true;
            this.FoundationLengthResultLabel.Location = new System.Drawing.Point(144, 43);
            this.FoundationLengthResultLabel.Name = "FoundationLengthResultLabel";
            this.FoundationLengthResultLabel.Size = new System.Drawing.Size(26, 16);
            this.FoundationLengthResultLabel.TabIndex = 4;
            this.FoundationLengthResultLabel.Text = "0 м";
            // 
            // BuildPerimeterResultLabel
            // 
            this.BuildPerimeterResultLabel.AutoSize = true;
            this.BuildPerimeterResultLabel.Location = new System.Drawing.Point(120, 22);
            this.BuildPerimeterResultLabel.Name = "BuildPerimeterResultLabel";
            this.BuildPerimeterResultLabel.Size = new System.Drawing.Size(26, 16);
            this.BuildPerimeterResultLabel.TabIndex = 3;
            this.BuildPerimeterResultLabel.Text = "0 м";
            // 
            // BuildingAreaLabel
            // 
            this.BuildingAreaLabel.AutoSize = true;
            this.BuildingAreaLabel.Location = new System.Drawing.Point(7, 64);
            this.BuildingAreaLabel.Name = "BuildingAreaLabel";
            this.BuildingAreaLabel.Size = new System.Drawing.Size(140, 16);
            this.BuildingAreaLabel.TabIndex = 2;
            this.BuildingAreaLabel.Text = "Площадь застройки:";
            // 
            // FoundationLengthLabel
            // 
            this.FoundationLengthLabel.AutoSize = true;
            this.FoundationLengthLabel.Location = new System.Drawing.Point(7, 43);
            this.FoundationLengthLabel.Name = "FoundationLengthLabel";
            this.FoundationLengthLabel.Size = new System.Drawing.Size(137, 16);
            this.FoundationLengthLabel.TabIndex = 1;
            this.FoundationLengthLabel.Text = "Длина фундамента:";
            // 
            // BuildPerimeterLabel
            // 
            this.BuildPerimeterLabel.AutoSize = true;
            this.BuildPerimeterLabel.Location = new System.Drawing.Point(7, 22);
            this.BuildPerimeterLabel.Name = "BuildPerimeterLabel";
            this.BuildPerimeterLabel.Size = new System.Drawing.Size(112, 16);
            this.BuildPerimeterLabel.TabIndex = 0;
            this.BuildPerimeterLabel.Text = "Периметр дома:";
            // 
            // FloorComboBox
            // 
            this.FloorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FloorComboBox.FormattingEnabled = true;
            this.FloorComboBox.Location = new System.Drawing.Point(328, 48);
            this.FloorComboBox.Name = "FloorComboBox";
            this.FloorComboBox.Size = new System.Drawing.Size(121, 24);
            this.FloorComboBox.TabIndex = 8;
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.Location = new System.Drawing.Point(325, 30);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(81, 16);
            this.FloorLabel.TabIndex = 7;
            this.FloorLabel.Text = "Этажность:";
            // 
            // BuildSchemeComboBox
            // 
            this.BuildSchemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildSchemeComboBox.FormattingEnabled = true;
            this.BuildSchemeComboBox.Location = new System.Drawing.Point(171, 48);
            this.BuildSchemeComboBox.Name = "BuildSchemeComboBox";
            this.BuildSchemeComboBox.Size = new System.Drawing.Size(121, 24);
            this.BuildSchemeComboBox.TabIndex = 6;
            this.BuildSchemeComboBox.SelectedIndexChanged += new System.EventHandler(this.BuildSchemeComboBox_SelectedIndexChanged);
            // 
            // BuildSchemeLabel
            // 
            this.BuildSchemeLabel.AutoSize = true;
            this.BuildSchemeLabel.Location = new System.Drawing.Point(168, 28);
            this.BuildSchemeLabel.Name = "BuildSchemeLabel";
            this.BuildSchemeLabel.Size = new System.Drawing.Size(86, 16);
            this.BuildSchemeLabel.TabIndex = 5;
            this.BuildSchemeLabel.Text = "Схема дома:";
            // 
            // BuildLengthLabel
            // 
            this.BuildLengthLabel.AutoSize = true;
            this.BuildLengthLabel.Location = new System.Drawing.Point(10, 52);
            this.BuildLengthLabel.Name = "BuildLengthLabel";
            this.BuildLengthLabel.Size = new System.Drawing.Size(51, 16);
            this.BuildLengthLabel.TabIndex = 4;
            this.BuildLengthLabel.Text = "Длина:";
            // 
            // BuildLengthTextBox
            // 
            this.BuildLengthTextBox.Location = new System.Drawing.Point(77, 49);
            this.BuildLengthTextBox.Name = "BuildLengthTextBox";
            this.BuildLengthTextBox.Size = new System.Drawing.Size(58, 22);
            this.BuildLengthTextBox.TabIndex = 3;
            this.BuildLengthTextBox.Text = "0";
            this.BuildLengthTextBox.TextChanged += new System.EventHandler(this.FloatTextBox_TextChanged);
            this.BuildLengthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FloatTextBox_KeyDown);
            this.BuildLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FloatTextBox_KeyPress);
            // 
            // BuildWidthLabel
            // 
            this.BuildWidthLabel.AutoSize = true;
            this.BuildWidthLabel.Location = new System.Drawing.Point(10, 80);
            this.BuildWidthLabel.Name = "BuildWidthLabel";
            this.BuildWidthLabel.Size = new System.Drawing.Size(61, 16);
            this.BuildWidthLabel.TabIndex = 2;
            this.BuildWidthLabel.Text = "Ширина:";
            // 
            // BuildWidthTextBox
            // 
            this.BuildWidthTextBox.Location = new System.Drawing.Point(77, 77);
            this.BuildWidthTextBox.Name = "BuildWidthTextBox";
            this.BuildWidthTextBox.Size = new System.Drawing.Size(58, 22);
            this.BuildWidthTextBox.TabIndex = 1;
            this.BuildWidthTextBox.Text = "0";
            this.BuildWidthTextBox.TextChanged += new System.EventHandler(this.FloatTextBox_TextChanged);
            this.BuildWidthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FloatTextBox_KeyDown);
            this.BuildWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FloatTextBox_KeyPress);
            // 
            // BuildSizeLabel
            // 
            this.BuildSizeLabel.AutoSize = true;
            this.BuildSizeLabel.Location = new System.Drawing.Point(10, 28);
            this.BuildSizeLabel.Name = "BuildSizeLabel";
            this.BuildSizeLabel.Size = new System.Drawing.Size(133, 16);
            this.BuildSizeLabel.TabIndex = 0;
            this.BuildSizeLabel.Text = "Размеры строения:";
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.UserNameLabel);
            this.UserGroupBox.Controls.Add(this.AuthorizeButton);
            this.UserGroupBox.Controls.Add(this.UserPictureBox);
            this.UserGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserGroupBox.Location = new System.Drawing.Point(0, 0);
            this.UserGroupBox.MinimumSize = new System.Drawing.Size(261, 110);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(261, 110);
            this.UserGroupBox.TabIndex = 2;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Пользователь";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(45, 22);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(115, 16);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Не авторизован";
            // 
            // MaterialsListGroupBox
            // 
            this.MaterialsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialsListGroupBox.Controls.Add(this.MaterialsPanel);
            this.MaterialsListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialsListGroupBox.Location = new System.Drawing.Point(2, 132);
            this.MaterialsListGroupBox.Name = "MaterialsListGroupBox";
            this.MaterialsListGroupBox.Size = new System.Drawing.Size(997, 479);
            this.MaterialsListGroupBox.TabIndex = 0;
            this.MaterialsListGroupBox.TabStop = false;
            // 
            // MaterialsPanel
            // 
            this.MaterialsPanel.AutoScroll = true;
            this.MaterialsPanel.Controls.Add(this.MaterialGroupBox);
            this.MaterialsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsPanel.Location = new System.Drawing.Point(3, 18);
            this.MaterialsPanel.Name = "MaterialsPanel";
            this.MaterialsPanel.Size = new System.Drawing.Size(991, 458);
            this.MaterialsPanel.TabIndex = 0;
            this.MaterialsPanel.SizeChanged += new System.EventHandler(this.MaterialsPanel_SizeChanged);
            // 
            // MaterialGroupBox
            // 
            this.MaterialGroupBox.Controls.Add(this.InputSecondComboBox);
            this.MaterialGroupBox.Controls.Add(this.InputSecondLabel);
            this.MaterialGroupBox.Controls.Add(this.InputFirstComboBox);
            this.MaterialGroupBox.Controls.Add(this.InputFirstLabel);
            this.MaterialGroupBox.Controls.Add(this.MaterialSelectButton);
            this.MaterialGroupBox.Controls.Add(this.MaterialPictureBox);
            this.MaterialGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialGroupBox.Location = new System.Drawing.Point(11, 11);
            this.MaterialGroupBox.Name = "MaterialGroupBox";
            this.MaterialGroupBox.Size = new System.Drawing.Size(228, 283);
            this.MaterialGroupBox.TabIndex = 0;
            this.MaterialGroupBox.TabStop = false;
            this.MaterialGroupBox.Text = "Улиточная слизь";
            this.MaterialGroupBox.Visible = false;
            // 
            // InputSecondComboBox
            // 
            this.InputSecondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputSecondComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSecondComboBox.FormattingEnabled = true;
            this.InputSecondComboBox.Location = new System.Drawing.Point(6, 214);
            this.InputSecondComboBox.Name = "InputSecondComboBox";
            this.InputSecondComboBox.Size = new System.Drawing.Size(216, 24);
            this.InputSecondComboBox.TabIndex = 5;
            // 
            // InputSecondLabel
            // 
            this.InputSecondLabel.AutoSize = true;
            this.InputSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSecondLabel.Location = new System.Drawing.Point(4, 195);
            this.InputSecondLabel.Name = "InputSecondLabel";
            this.InputSecondLabel.Size = new System.Drawing.Size(48, 16);
            this.InputSecondLabel.TabIndex = 4;
            this.InputSecondLabel.Text = "Input 2:";
            // 
            // InputFirstComboBox
            // 
            this.InputFirstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputFirstComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstComboBox.FormattingEnabled = true;
            this.InputFirstComboBox.Location = new System.Drawing.Point(6, 165);
            this.InputFirstComboBox.Name = "InputFirstComboBox";
            this.InputFirstComboBox.Size = new System.Drawing.Size(216, 24);
            this.InputFirstComboBox.TabIndex = 3;
            // 
            // InputFirstLabel
            // 
            this.InputFirstLabel.AutoSize = true;
            this.InputFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstLabel.Location = new System.Drawing.Point(4, 146);
            this.InputFirstLabel.Name = "InputFirstLabel";
            this.InputFirstLabel.Size = new System.Drawing.Size(48, 16);
            this.InputFirstLabel.TabIndex = 2;
            this.InputFirstLabel.Text = "Input 1:";
            // 
            // MaterialSelectButton
            // 
            this.MaterialSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialSelectButton.Location = new System.Drawing.Point(7, 244);
            this.MaterialSelectButton.Name = "MaterialSelectButton";
            this.MaterialSelectButton.Size = new System.Drawing.Size(215, 33);
            this.MaterialSelectButton.TabIndex = 1;
            this.MaterialSelectButton.Text = "Выбрать";
            this.MaterialSelectButton.UseVisualStyleBackColor = true;
            // 
            // CalculateResultButton
            // 
            this.CalculateResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateResultButton.Image = global::BuildCalculator.Properties.Resources.Smeta;
            this.CalculateResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculateResultButton.Location = new System.Drawing.Point(3, 16);
            this.CalculateResultButton.Name = "CalculateResultButton";
            this.CalculateResultButton.Size = new System.Drawing.Size(321, 34);
            this.CalculateResultButton.TabIndex = 2;
            this.CalculateResultButton.Text = "Рассчитать полную смету";
            this.CalculateResultButton.UseVisualStyleBackColor = true;
            this.CalculateResultButton.Click += new System.EventHandler(this.CalculateResultButton_Click);
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorizeButton.Image = global::BuildCalculator.Properties.Resources.Enter;
            this.AuthorizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuthorizeButton.Location = new System.Drawing.Point(6, 68);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(249, 35);
            this.AuthorizeButton.TabIndex = 1;
            this.AuthorizeButton.Text = "Вход / Регистрация";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = global::BuildCalculator.Properties.Resources.icon_user;
            this.UserPictureBox.Location = new System.Drawing.Point(6, 21);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(32, 32);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // MaterialPictureBox
            // 
            this.MaterialPictureBox.Location = new System.Drawing.Point(7, 49);
            this.MaterialPictureBox.Name = "MaterialPictureBox";
            this.MaterialPictureBox.Size = new System.Drawing.Size(215, 90);
            this.MaterialPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaterialPictureBox.TabIndex = 0;
            this.MaterialPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 711);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuToolStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1354, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор сметы «Дом ремонта»";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.MainMenuToolStrip.ResumeLayout(false);
            this.MainMenuToolStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.CalculateGroupBox.ResumeLayout(false);
            this.LeftGroupBox.ResumeLayout(false);
            this.MaterialsListPanel.ResumeLayout(false);
            this.MaterialsListPanel.PerformLayout();
            this.RightGroupBox.ResumeLayout(false);
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.InfoSplitContainer.Panel1.ResumeLayout(false);
            this.InfoSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).EndInit();
            this.InfoSplitContainer.ResumeLayout(false);
            this.BuildSizeGroupBox.ResumeLayout(false);
            this.BuildSizeGroupBox.PerformLayout();
            this.BuildSizeResultGroupBox.ResumeLayout(false);
            this.BuildSizeResultGroupBox.PerformLayout();
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.MaterialsListGroupBox.ResumeLayout(false);
            this.MaterialsPanel.ResumeLayout(false);
            this.MaterialGroupBox.ResumeLayout(false);
            this.MaterialGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuToolStrip;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramMenuItem;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.GroupBox LeftGroupBox;
        private System.Windows.Forms.GroupBox RightGroupBox;
        private System.Windows.Forms.GroupBox MaterialsListGroupBox;
        private System.Windows.Forms.Button MaterialButton;
        private System.Windows.Forms.GroupBox BuildSizeGroupBox;
        private System.Windows.Forms.TextBox BuildWidthTextBox;
        private System.Windows.Forms.Label BuildSizeLabel;
        private System.Windows.Forms.Label BuildLengthLabel;
        private System.Windows.Forms.TextBox BuildLengthTextBox;
        private System.Windows.Forms.Label BuildWidthLabel;
        private System.Windows.Forms.Label BuildSchemeLabel;
        private System.Windows.Forms.ComboBox BuildSchemeComboBox;
        private System.Windows.Forms.ComboBox FloorComboBox;
        private System.Windows.Forms.Label FloorLabel;
        private System.Windows.Forms.GroupBox BuildSizeResultGroupBox;
        private System.Windows.Forms.Label BuildingAreaLabel;
        private System.Windows.Forms.Label FoundationLengthLabel;
        private System.Windows.Forms.Label BuildPerimeterLabel;
        private System.Windows.Forms.Label BuildingAreaResultLabel;
        private System.Windows.Forms.Label FoundationLengthResultLabel;
        private System.Windows.Forms.Label BuildPerimeterResultLabel;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.Label BuildLengthMeterLabel;
        private System.Windows.Forms.Label BuildWidthMeterLabel;
        private System.Windows.Forms.SplitContainer InfoSplitContainer;
        private System.Windows.Forms.Panel MaterialsPanel;
        private System.Windows.Forms.GroupBox MaterialGroupBox;
        private System.Windows.Forms.PictureBox MaterialPictureBox;
        private System.Windows.Forms.Button MaterialSelectButton;
        private System.Windows.Forms.Label InputFirstLabel;
        private System.Windows.Forms.ComboBox InputFirstComboBox;
        private System.Windows.Forms.ComboBox InputSecondComboBox;
        private System.Windows.Forms.Label InputSecondLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.CheckBox MaterialSelectedCheckBox;
        private System.Windows.Forms.Button CalculateResultButton;
        private System.Windows.Forms.GroupBox CalculateGroupBox;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultCostLabel;
        private System.Windows.Forms.Label ResultRubLabel;
        private System.Windows.Forms.ToolStripMenuItem UserCabinetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowSmetaMenuItem;
        private System.Windows.Forms.Panel MaterialsListPanel;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
    }
}

