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
            this.MainMenuToolStrip = new System.Windows.Forms.MenuStrip();
            this.AboutProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.LeftGroupBox = new System.Windows.Forms.GroupBox();
            this.WindowAndDoorsButton = new System.Windows.Forms.Button();
            this.FacadeButton = new System.Windows.Forms.Button();
            this.StairButton = new System.Windows.Forms.Button();
            this.ChimneyButton = new System.Windows.Forms.Button();
            this.RoofButton = new System.Windows.Forms.Button();
            this.CeilingButton = new System.Windows.Forms.Button();
            this.WallsButton = new System.Windows.Forms.Button();
            this.FoundationButton = new System.Windows.Forms.Button();
            this.RightGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BuildSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildHeightMeterLabel = new System.Windows.Forms.Label();
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
            this.BuildHeightLabel = new System.Windows.Forms.Label();
            this.BuildHeightTextBox = new System.Windows.Forms.TextBox();
            this.BuildWidthLabel = new System.Windows.Forms.Label();
            this.BuildWidthTextBox = new System.Windows.Forms.TextBox();
            this.BuildSizeLabel = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaterialsListGroupBox = new System.Windows.Forms.GroupBox();
            this.MaterialsPanel = new System.Windows.Forms.Panel();
            this.MaterialGroupBox = new System.Windows.Forms.GroupBox();
            this.InputSecondComboBox = new System.Windows.Forms.ComboBox();
            this.InputSecondLabel = new System.Windows.Forms.Label();
            this.InputFirstComboBox = new System.Windows.Forms.ComboBox();
            this.InputFirstLabel = new System.Windows.Forms.Label();
            this.MaterialSelectButton = new System.Windows.Forms.Button();
            this.MaterialPictureBox = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.MainMenuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.LeftGroupBox.SuspendLayout();
            this.RightGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).BeginInit();
            this.InfoSplitContainer.Panel1.SuspendLayout();
            this.InfoSplitContainer.Panel2.SuspendLayout();
            this.InfoSplitContainer.SuspendLayout();
            this.BuildSizeGroupBox.SuspendLayout();
            this.BuildSizeResultGroupBox.SuspendLayout();
            this.UserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MaterialsListGroupBox.SuspendLayout();
            this.MaterialsPanel.SuspendLayout();
            this.MaterialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuToolStrip
            // 
            this.MainMenuToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramMenuItem});
            this.MainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuToolStrip.Name = "MainMenuToolStrip";
            this.MainMenuToolStrip.Size = new System.Drawing.Size(1338, 25);
            this.MainMenuToolStrip.TabIndex = 0;
            this.MainMenuToolStrip.Text = "menuStrip1";
            // 
            // AboutProgramMenuItem
            // 
            this.AboutProgramMenuItem.Name = "AboutProgramMenuItem";
            this.AboutProgramMenuItem.Size = new System.Drawing.Size(102, 21);
            this.AboutProgramMenuItem.Text = "О программе";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 689);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1338, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.LeftGroupBox);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.RightGroupBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(1338, 664);
            this.MainSplitContainer.SplitterDistance = 253;
            this.MainSplitContainer.SplitterWidth = 6;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // LeftGroupBox
            // 
            this.LeftGroupBox.Controls.Add(this.WindowAndDoorsButton);
            this.LeftGroupBox.Controls.Add(this.FacadeButton);
            this.LeftGroupBox.Controls.Add(this.StairButton);
            this.LeftGroupBox.Controls.Add(this.ChimneyButton);
            this.LeftGroupBox.Controls.Add(this.RoofButton);
            this.LeftGroupBox.Controls.Add(this.CeilingButton);
            this.LeftGroupBox.Controls.Add(this.WallsButton);
            this.LeftGroupBox.Controls.Add(this.FoundationButton);
            this.LeftGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LeftGroupBox.Name = "LeftGroupBox";
            this.LeftGroupBox.Size = new System.Drawing.Size(253, 664);
            this.LeftGroupBox.TabIndex = 0;
            this.LeftGroupBox.TabStop = false;
            this.LeftGroupBox.Text = "Материалы";
            // 
            // WindowAndDoorsButton
            // 
            this.WindowAndDoorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowAndDoorsButton.Image = global::BuildCalculator.Properties.Resources.icon_door_and_window;
            this.WindowAndDoorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WindowAndDoorsButton.Location = new System.Drawing.Point(6, 306);
            this.WindowAndDoorsButton.Name = "WindowAndDoorsButton";
            this.WindowAndDoorsButton.Size = new System.Drawing.Size(241, 33);
            this.WindowAndDoorsButton.TabIndex = 7;
            this.WindowAndDoorsButton.Tag = "7";
            this.WindowAndDoorsButton.Text = "            8. Окна, двери";
            this.WindowAndDoorsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WindowAndDoorsButton.UseVisualStyleBackColor = true;
            this.WindowAndDoorsButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // FacadeButton
            // 
            this.FacadeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacadeButton.Image = global::BuildCalculator.Properties.Resources.icon_house;
            this.FacadeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FacadeButton.Location = new System.Drawing.Point(6, 267);
            this.FacadeButton.Name = "FacadeButton";
            this.FacadeButton.Size = new System.Drawing.Size(241, 33);
            this.FacadeButton.TabIndex = 6;
            this.FacadeButton.Tag = "6";
            this.FacadeButton.Text = "            7. Фасад";
            this.FacadeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FacadeButton.UseVisualStyleBackColor = true;
            this.FacadeButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // StairButton
            // 
            this.StairButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StairButton.Image = global::BuildCalculator.Properties.Resources.icon_stair;
            this.StairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StairButton.Location = new System.Drawing.Point(6, 228);
            this.StairButton.Name = "StairButton";
            this.StairButton.Size = new System.Drawing.Size(241, 33);
            this.StairButton.TabIndex = 5;
            this.StairButton.Tag = "5";
            this.StairButton.Text = "            6. Лестница";
            this.StairButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StairButton.UseVisualStyleBackColor = true;
            this.StairButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // ChimneyButton
            // 
            this.ChimneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChimneyButton.Image = global::BuildCalculator.Properties.Resources.icon_chimney_top;
            this.ChimneyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChimneyButton.Location = new System.Drawing.Point(6, 189);
            this.ChimneyButton.Name = "ChimneyButton";
            this.ChimneyButton.Size = new System.Drawing.Size(241, 33);
            this.ChimneyButton.TabIndex = 4;
            this.ChimneyButton.Tag = "4";
            this.ChimneyButton.Text = "            5. Труба";
            this.ChimneyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChimneyButton.UseVisualStyleBackColor = true;
            this.ChimneyButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // RoofButton
            // 
            this.RoofButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoofButton.Image = global::BuildCalculator.Properties.Resources.icon_roof;
            this.RoofButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoofButton.Location = new System.Drawing.Point(6, 150);
            this.RoofButton.Name = "RoofButton";
            this.RoofButton.Size = new System.Drawing.Size(241, 33);
            this.RoofButton.TabIndex = 3;
            this.RoofButton.Tag = "3";
            this.RoofButton.Text = "            4. Кровля";
            this.RoofButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoofButton.UseVisualStyleBackColor = true;
            this.RoofButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // CeilingButton
            // 
            this.CeilingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CeilingButton.Image = global::BuildCalculator.Properties.Resources.icon_wall_raw;
            this.CeilingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CeilingButton.Location = new System.Drawing.Point(6, 111);
            this.CeilingButton.Name = "CeilingButton";
            this.CeilingButton.Size = new System.Drawing.Size(241, 33);
            this.CeilingButton.TabIndex = 2;
            this.CeilingButton.Tag = "2";
            this.CeilingButton.Text = "            3. Перекрытия";
            this.CeilingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CeilingButton.UseVisualStyleBackColor = true;
            this.CeilingButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // WallsButton
            // 
            this.WallsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WallsButton.Image = global::BuildCalculator.Properties.Resources.icon_wall;
            this.WallsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WallsButton.Location = new System.Drawing.Point(6, 72);
            this.WallsButton.Name = "WallsButton";
            this.WallsButton.Size = new System.Drawing.Size(241, 33);
            this.WallsButton.TabIndex = 1;
            this.WallsButton.Tag = "1";
            this.WallsButton.Text = "            2. Стены";
            this.WallsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WallsButton.UseVisualStyleBackColor = true;
            this.WallsButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // FoundationButton
            // 
            this.FoundationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoundationButton.Image = global::BuildCalculator.Properties.Resources.icon_foundation;
            this.FoundationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoundationButton.Location = new System.Drawing.Point(6, 33);
            this.FoundationButton.Name = "FoundationButton";
            this.FoundationButton.Size = new System.Drawing.Size(241, 33);
            this.FoundationButton.TabIndex = 0;
            this.FoundationButton.Tag = "0";
            this.FoundationButton.Text = "            1. Фундамент";
            this.FoundationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoundationButton.UseVisualStyleBackColor = true;
            this.FoundationButton.Click += new System.EventHandler(this.ButtonsList_Click);
            // 
            // RightGroupBox
            // 
            this.RightGroupBox.Controls.Add(this.InfoSplitContainer);
            this.RightGroupBox.Controls.Add(this.MaterialsListGroupBox);
            this.RightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RightGroupBox.Name = "RightGroupBox";
            this.RightGroupBox.Size = new System.Drawing.Size(1079, 664);
            this.RightGroupBox.TabIndex = 0;
            this.RightGroupBox.TabStop = false;
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
            this.InfoSplitContainer.Size = new System.Drawing.Size(1073, 110);
            this.InfoSplitContainer.SplitterDistance = 792;
            this.InfoSplitContainer.SplitterWidth = 6;
            this.InfoSplitContainer.TabIndex = 1;
            // 
            // BuildSizeGroupBox
            // 
            this.BuildSizeGroupBox.Controls.Add(this.BuildHeightMeterLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildWidthMeterLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSizeResultGroupBox);
            this.BuildSizeGroupBox.Controls.Add(this.FloorComboBox);
            this.BuildSizeGroupBox.Controls.Add(this.FloorLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSchemeComboBox);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSchemeLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildHeightLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildHeightTextBox);
            this.BuildSizeGroupBox.Controls.Add(this.BuildWidthLabel);
            this.BuildSizeGroupBox.Controls.Add(this.BuildWidthTextBox);
            this.BuildSizeGroupBox.Controls.Add(this.BuildSizeLabel);
            this.BuildSizeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildSizeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.BuildSizeGroupBox.Name = "BuildSizeGroupBox";
            this.BuildSizeGroupBox.Size = new System.Drawing.Size(792, 110);
            this.BuildSizeGroupBox.TabIndex = 1;
            this.BuildSizeGroupBox.TabStop = false;
            this.BuildSizeGroupBox.Text = "Строение";
            // 
            // BuildHeightMeterLabel
            // 
            this.BuildHeightMeterLabel.AutoSize = true;
            this.BuildHeightMeterLabel.Location = new System.Drawing.Point(137, 80);
            this.BuildHeightMeterLabel.Name = "BuildHeightMeterLabel";
            this.BuildHeightMeterLabel.Size = new System.Drawing.Size(16, 16);
            this.BuildHeightMeterLabel.TabIndex = 11;
            this.BuildHeightMeterLabel.Text = "м";
            // 
            // BuildWidthMeterLabel
            // 
            this.BuildWidthMeterLabel.AutoSize = true;
            this.BuildWidthMeterLabel.Location = new System.Drawing.Point(137, 53);
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
            this.BuildSizeResultGroupBox.Location = new System.Drawing.Point(515, 13);
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
            this.BuildingAreaResultLabel.Size = new System.Drawing.Size(26, 16);
            this.BuildingAreaResultLabel.TabIndex = 5;
            this.BuildingAreaResultLabel.Text = "0 м";
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
            this.BuildSchemeComboBox.FormattingEnabled = true;
            this.BuildSchemeComboBox.Location = new System.Drawing.Point(171, 48);
            this.BuildSchemeComboBox.Name = "BuildSchemeComboBox";
            this.BuildSchemeComboBox.Size = new System.Drawing.Size(121, 24);
            this.BuildSchemeComboBox.TabIndex = 6;
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
            // BuildHeightLabel
            // 
            this.BuildHeightLabel.AutoSize = true;
            this.BuildHeightLabel.Location = new System.Drawing.Point(10, 80);
            this.BuildHeightLabel.Name = "BuildHeightLabel";
            this.BuildHeightLabel.Size = new System.Drawing.Size(58, 16);
            this.BuildHeightLabel.TabIndex = 4;
            this.BuildHeightLabel.Text = "Высота:";
            // 
            // BuildHeightTextBox
            // 
            this.BuildHeightTextBox.Location = new System.Drawing.Point(77, 77);
            this.BuildHeightTextBox.Name = "BuildHeightTextBox";
            this.BuildHeightTextBox.Size = new System.Drawing.Size(58, 22);
            this.BuildHeightTextBox.TabIndex = 3;
            // 
            // BuildWidthLabel
            // 
            this.BuildWidthLabel.AutoSize = true;
            this.BuildWidthLabel.Location = new System.Drawing.Point(10, 53);
            this.BuildWidthLabel.Name = "BuildWidthLabel";
            this.BuildWidthLabel.Size = new System.Drawing.Size(61, 16);
            this.BuildWidthLabel.TabIndex = 2;
            this.BuildWidthLabel.Text = "Ширина:";
            // 
            // BuildWidthTextBox
            // 
            this.BuildWidthTextBox.Location = new System.Drawing.Point(77, 50);
            this.BuildWidthTextBox.Name = "BuildWidthTextBox";
            this.BuildWidthTextBox.Size = new System.Drawing.Size(58, 22);
            this.BuildWidthTextBox.TabIndex = 1;
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
            this.UserGroupBox.Controls.Add(this.pictureBox1);
            this.UserGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserGroupBox.Location = new System.Drawing.Point(0, 0);
            this.UserGroupBox.MinimumSize = new System.Drawing.Size(261, 110);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(275, 110);
            this.UserGroupBox.TabIndex = 2;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Пользователь";
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorizeButton.Location = new System.Drawing.Point(6, 69);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(263, 32);
            this.AuthorizeButton.TabIndex = 1;
            this.AuthorizeButton.Text = "Вход/Регистрация";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuildCalculator.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.MaterialsListGroupBox.Size = new System.Drawing.Size(1074, 529);
            this.MaterialsListGroupBox.TabIndex = 0;
            this.MaterialsListGroupBox.TabStop = false;
            this.MaterialsListGroupBox.Text = "Материалы";
            // 
            // MaterialsPanel
            // 
            this.MaterialsPanel.AutoScroll = true;
            this.MaterialsPanel.Controls.Add(this.MaterialGroupBox);
            this.MaterialsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsPanel.Location = new System.Drawing.Point(3, 18);
            this.MaterialsPanel.Name = "MaterialsPanel";
            this.MaterialsPanel.Size = new System.Drawing.Size(1068, 508);
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
            // MaterialPictureBox
            // 
            this.MaterialPictureBox.Location = new System.Drawing.Point(7, 29);
            this.MaterialPictureBox.Name = "MaterialPictureBox";
            this.MaterialPictureBox.Size = new System.Drawing.Size(215, 110);
            this.MaterialPictureBox.TabIndex = 0;
            this.MaterialPictureBox.TabStop = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 711);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuToolStrip);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1354, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.MainMenuToolStrip.ResumeLayout(false);
            this.MainMenuToolStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.LeftGroupBox.ResumeLayout(false);
            this.RightGroupBox.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MaterialsListGroupBox.ResumeLayout(false);
            this.MaterialsPanel.ResumeLayout(false);
            this.MaterialGroupBox.ResumeLayout(false);
            this.MaterialGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button FoundationButton;
        private System.Windows.Forms.Button WindowAndDoorsButton;
        private System.Windows.Forms.Button FacadeButton;
        private System.Windows.Forms.Button StairButton;
        private System.Windows.Forms.Button ChimneyButton;
        private System.Windows.Forms.Button RoofButton;
        private System.Windows.Forms.Button CeilingButton;
        private System.Windows.Forms.Button WallsButton;
        private System.Windows.Forms.GroupBox BuildSizeGroupBox;
        private System.Windows.Forms.TextBox BuildWidthTextBox;
        private System.Windows.Forms.Label BuildSizeLabel;
        private System.Windows.Forms.Label BuildHeightLabel;
        private System.Windows.Forms.TextBox BuildHeightTextBox;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.Label BuildHeightMeterLabel;
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
    }
}

