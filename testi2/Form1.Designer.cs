namespace testi2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCurrentTime = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMainView = new System.Windows.Forms.TableLayoutPanel();
            this.labelSunset = new System.Windows.Forms.Label();
            this.labelDayLength = new System.Windows.Forms.Label();
            this.tableLayoutPanelClock = new System.Windows.Forms.TableLayoutPanel();
            this.labelClock = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLatestHumidity = new System.Windows.Forms.Label();
            this.pictureBoxHumidityChange = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxTemperatureChange = new System.Windows.Forms.PictureBox();
            this.labelLatestTemperature = new System.Windows.Forms.Label();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEmpty = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearDatabase = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button8HoursAgo = new System.Windows.Forms.Button();
            this.buttonLastHour = new System.Windows.Forms.Button();
            this.button2HoursAgo = new System.Windows.Forms.Button();
            this.button3HoursAgo = new System.Windows.Forms.Button();
            this.button4HoursAgo = new System.Windows.Forms.Button();
            this.button5HoursAgo = new System.Windows.Forms.Button();
            this.button6HoursAgo = new System.Windows.Forms.Button();
            this.button7HoursAgo = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateMainview = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateBackground = new System.Windows.Forms.Timer(this.components);
            this.timerColorAnimationForSunset = new System.Windows.Forms.Timer(this.components);
            this.timerColorAnimationForSunrise = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tableLayoutPanelMainView.SuspendLayout();
            this.tableLayoutPanelClock.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidityChange)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperatureChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.tabPageAdmin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.17046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.82953F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCurrentTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.01124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.988764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonCurrentTime
            // 
            this.buttonCurrentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrentTime.Location = new System.Drawing.Point(529, 350);
            this.buttonCurrentTime.Name = "buttonCurrentTime";
            this.buttonCurrentTime.Size = new System.Drawing.Size(101, 29);
            this.buttonCurrentTime.TabIndex = 8;
            this.buttonCurrentTime.Text = "Now";
            this.buttonCurrentTime.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.tabPageAdmin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 341);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageMain.Controls.Add(this.tableLayoutPanelMainView);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(512, 315);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMainView
            // 
            this.tableLayoutPanelMainView.ColumnCount = 3;
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelMainView.Controls.Add(this.labelSunset, 0, 3);
            this.tableLayoutPanelMainView.Controls.Add(this.labelDayLength, 0, 3);
            this.tableLayoutPanelMainView.Controls.Add(this.tableLayoutPanelClock, 1, 1);
            this.tableLayoutPanelMainView.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanelMainView.Controls.Add(this.tableLayoutPanel5, 2, 2);
            this.tableLayoutPanelMainView.Controls.Add(this.pictureBoxWeather, 2, 1);
            this.tableLayoutPanelMainView.Controls.Add(this.pictureBoxMoon, 0, 1);
            this.tableLayoutPanelMainView.Controls.Add(this.labelSunrise, 0, 3);
            this.tableLayoutPanelMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainView.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMainView.Name = "tableLayoutPanelMainView";
            this.tableLayoutPanelMainView.RowCount = 4;
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanelMainView.Size = new System.Drawing.Size(506, 309);
            this.tableLayoutPanelMainView.TabIndex = 1;
            this.tableLayoutPanelMainView.DoubleClick += new System.EventHandler(this.tableLayoutPanelMainView_DoubleClick);
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSunset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSunset.Location = new System.Drawing.Point(339, 292);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(164, 17);
            this.labelSunset.TabIndex = 10;
            this.labelSunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDayLength
            // 
            this.labelDayLength.AutoSize = true;
            this.labelDayLength.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDayLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayLength.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDayLength.Location = new System.Drawing.Point(171, 292);
            this.labelDayLength.Name = "labelDayLength";
            this.labelDayLength.Size = new System.Drawing.Size(162, 17);
            this.labelDayLength.TabIndex = 9;
            this.labelDayLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelClock
            // 
            this.tableLayoutPanelClock.ColumnCount = 3;
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.Controls.Add(this.labelClock, 1, 1);
            this.tableLayoutPanelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelClock.Location = new System.Drawing.Point(171, 105);
            this.tableLayoutPanelClock.Name = "tableLayoutPanelClock";
            this.tableLayoutPanelClock.RowCount = 3;
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.Size = new System.Drawing.Size(162, 96);
            this.tableLayoutPanelClock.TabIndex = 3;
            // 
            // labelClock
            // 
            this.labelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClock.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.SystemColors.Info;
            this.labelClock.Location = new System.Drawing.Point(19, 9);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(123, 76);
            this.labelClock.TabIndex = 2;
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.labelLatestHumidity, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxHumidityChange, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(162, 25);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // labelLatestHumidity
            // 
            this.labelLatestHumidity.AutoSize = true;
            this.labelLatestHumidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLatestHumidity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestHumidity.ForeColor = System.Drawing.SystemColors.Info;
            this.labelLatestHumidity.Location = new System.Drawing.Point(3, 0);
            this.labelLatestHumidity.Name = "labelLatestHumidity";
            this.labelLatestHumidity.Size = new System.Drawing.Size(91, 25);
            this.labelLatestHumidity.TabIndex = 5;
            this.labelLatestHumidity.Text = "Humidity";
            this.labelLatestHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelLatestHumidity, "Humidity");
            // 
            // pictureBoxHumidityChange
            // 
            this.pictureBoxHumidityChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHumidityChange.Location = new System.Drawing.Point(100, 3);
            this.pictureBoxHumidityChange.Name = "pictureBoxHumidityChange";
            this.pictureBoxHumidityChange.Size = new System.Drawing.Size(25, 19);
            this.pictureBoxHumidityChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHumidityChange.TabIndex = 6;
            this.pictureBoxHumidityChange.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxTemperatureChange, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelLatestTemperature, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(339, 207);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(164, 25);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // pictureBoxTemperatureChange
            // 
            this.pictureBoxTemperatureChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxTemperatureChange.Location = new System.Drawing.Point(37, 3);
            this.pictureBoxTemperatureChange.Name = "pictureBoxTemperatureChange";
            this.pictureBoxTemperatureChange.Size = new System.Drawing.Size(25, 19);
            this.pictureBoxTemperatureChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTemperatureChange.TabIndex = 7;
            this.pictureBoxTemperatureChange.TabStop = false;
            // 
            // labelLatestTemperature
            // 
            this.labelLatestTemperature.AutoSize = true;
            this.labelLatestTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLatestTemperature.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestTemperature.ForeColor = System.Drawing.SystemColors.Info;
            this.labelLatestTemperature.Location = new System.Drawing.Point(68, 0);
            this.labelLatestTemperature.Name = "labelLatestTemperature";
            this.labelLatestTemperature.Size = new System.Drawing.Size(93, 25);
            this.labelLatestTemperature.TabIndex = 4;
            this.labelLatestTemperature.Text = "Temperature";
            this.labelLatestTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labelLatestTemperature, "Temperature");
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(339, 105);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(164, 96);
            this.pictureBoxWeather.TabIndex = 0;
            this.pictureBoxWeather.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxWeather, "Current weather");
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMoon.Location = new System.Drawing.Point(3, 105);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(162, 96);
            this.pictureBoxMoon.TabIndex = 1;
            this.pictureBoxMoon.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxMoon, "Current moon phase");
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSunrise.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSunrise.Location = new System.Drawing.Point(3, 292);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(162, 17);
            this.labelSunrise.TabIndex = 8;
            this.labelSunrise.Text = "asdfghjkl";
            this.labelSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.dataGridViewInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(512, 315);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInfo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(978, 391);
            this.dataGridViewInfo.TabIndex = 2;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Size = new System.Drawing.Size(512, 315);
            this.tabPageAdmin.TabIndex = 2;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.ButtonEmpty, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.SelectedButton, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.CleanButton, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.monthCalendar1, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(984, 397);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // ButtonEmpty
            // 
            this.ButtonEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEmpty.ForeColor = System.Drawing.Color.Red;
            this.ButtonEmpty.Location = new System.Drawing.Point(591, 300);
            this.ButtonEmpty.Name = "ButtonEmpty";
            this.ButtonEmpty.Size = new System.Drawing.Size(190, 94);
            this.ButtonEmpty.TabIndex = 1;
            this.ButtonEmpty.Text = "Empty database";
            this.ButtonEmpty.UseVisualStyleBackColor = true;
            // 
            // SelectedButton
            // 
            this.SelectedButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedButton.Location = new System.Drawing.Point(199, 301);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(190, 93);
            this.SelectedButton.TabIndex = 4;
            this.SelectedButton.Text = "Delete selected";
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanButton.Location = new System.Drawing.Point(395, 301);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(190, 93);
            this.CleanButton.TabIndex = 2;
            this.CleanButton.Text = "Clean wrong values";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 226);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel2.Controls.Add(this.buttonSearch);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 350);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(520, 25);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(135, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearch.Location = new System.Drawing.Point(144, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(68, 20);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button8HoursAgo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonLastHour, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.button2HoursAgo, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.button3HoursAgo, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.button4HoursAgo, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button5HoursAgo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button6HoursAgo, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button7HoursAgo, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(529, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(101, 341);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // button8HoursAgo
            // 
            this.button8HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8HoursAgo.Location = new System.Drawing.Point(3, 3);
            this.button8HoursAgo.Name = "button8HoursAgo";
            this.button8HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button8HoursAgo.TabIndex = 9;
            this.button8HoursAgo.Text = "8 hours ago";
            this.button8HoursAgo.UseVisualStyleBackColor = true;
            // 
            // buttonLastHour
            // 
            this.buttonLastHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLastHour.Location = new System.Drawing.Point(3, 297);
            this.buttonLastHour.Name = "buttonLastHour";
            this.buttonLastHour.Size = new System.Drawing.Size(95, 41);
            this.buttonLastHour.TabIndex = 8;
            this.buttonLastHour.Text = "Last hour";
            this.buttonLastHour.UseVisualStyleBackColor = true;
            // 
            // button2HoursAgo
            // 
            this.button2HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2HoursAgo.Location = new System.Drawing.Point(3, 255);
            this.button2HoursAgo.Name = "button2HoursAgo";
            this.button2HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button2HoursAgo.TabIndex = 8;
            this.button2HoursAgo.Text = "2 hours ago";
            this.button2HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button3HoursAgo
            // 
            this.button3HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3HoursAgo.Location = new System.Drawing.Point(3, 213);
            this.button3HoursAgo.Name = "button3HoursAgo";
            this.button3HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button3HoursAgo.TabIndex = 8;
            this.button3HoursAgo.Text = "3 hours ago";
            this.button3HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button4HoursAgo
            // 
            this.button4HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4HoursAgo.Location = new System.Drawing.Point(3, 171);
            this.button4HoursAgo.Name = "button4HoursAgo";
            this.button4HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button4HoursAgo.TabIndex = 8;
            this.button4HoursAgo.Text = "4 hours ago";
            this.button4HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button5HoursAgo
            // 
            this.button5HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5HoursAgo.Location = new System.Drawing.Point(3, 129);
            this.button5HoursAgo.Name = "button5HoursAgo";
            this.button5HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button5HoursAgo.TabIndex = 8;
            this.button5HoursAgo.Text = "5 hours ago";
            this.button5HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button6HoursAgo
            // 
            this.button6HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6HoursAgo.Location = new System.Drawing.Point(3, 87);
            this.button6HoursAgo.Name = "button6HoursAgo";
            this.button6HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button6HoursAgo.TabIndex = 8;
            this.button6HoursAgo.Text = "6 hours ago";
            this.button6HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button7HoursAgo
            // 
            this.button7HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7HoursAgo.Location = new System.Drawing.Point(3, 45);
            this.button7HoursAgo.Name = "button7HoursAgo";
            this.button7HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button7HoursAgo.TabIndex = 8;
            this.button7HoursAgo.Text = "7 hours ago";
            this.button7HoursAgo.UseVisualStyleBackColor = true;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerUpdateMainview
            // 
            this.timerUpdateMainview.Enabled = true;
            this.timerUpdateMainview.Interval = 10000;
            this.timerUpdateMainview.Tick += new System.EventHandler(this.timerUpdateMainview_Tick);
            // 
            // timerUpdateBackground
            // 
            this.timerUpdateBackground.Enabled = true;
            this.timerUpdateBackground.Interval = 60000;
            this.timerUpdateBackground.Tick += new System.EventHandler(this.timerUpdateBackground_Tick);
            // 
            // timerColorAnimationForSunset
            // 
            this.timerColorAnimationForSunset.Enabled = true;
            this.timerColorAnimationForSunset.Interval = 30000;
            this.timerColorAnimationForSunset.Tick += new System.EventHandler(this.timerColorAnimationForSunset_Tick);
            // 
            // timerColorAnimationForSunrise
            // 
            this.timerColorAnimationForSunrise.Enabled = true;
            this.timerColorAnimationForSunrise.Interval = 30000;
            this.timerColorAnimationForSunrise.Tick += new System.EventHandler(this.timerColorAnimationForSunrise_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tableLayoutPanelMainView.ResumeLayout(false);
            this.tableLayoutPanelMainView.PerformLayout();
            this.tableLayoutPanelClock.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidityChange)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperatureChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.tabPageAdmin.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonCurrentTime;
        private System.Windows.Forms.Button buttonLastHour;
        private System.Windows.Forms.Button button2HoursAgo;
        private System.Windows.Forms.Button button3HoursAgo;
        private System.Windows.Forms.Button button4HoursAgo;
        private System.Windows.Forms.Button button5HoursAgo;
        private System.Windows.Forms.Button button6HoursAgo;
        private System.Windows.Forms.Button button7HoursAgo;
        private System.Windows.Forms.Button button8HoursAgo;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainView;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClock;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelLatestTemperature;
        private System.Windows.Forms.Timer timerUpdateMainview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonClearDatabase;
        private System.Windows.Forms.Label labelLatestHumidity;
        private System.Windows.Forms.Timer timerUpdateBackground;
        private System.Windows.Forms.Timer timerColorAnimationForSunset;
        private System.Windows.Forms.Timer timerColorAnimationForSunrise;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBoxHumidityChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBoxTemperatureChange;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label labelDayLength;
        private System.Windows.Forms.Label labelSunrise;
    }
}

