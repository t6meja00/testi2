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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.buttonMax = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonLastHour = new System.Windows.Forms.Button();
            this.button2HoursAgo = new System.Windows.Forms.Button();
            this.button3HoursAgo = new System.Windows.Forms.Button();
            this.button4HoursAgo = new System.Windows.Forms.Button();
            this.button5HoursAgo = new System.Windows.Forms.Button();
            this.button6HoursAgo = new System.Windows.Forms.Button();
            this.button7HoursAgo = new System.Windows.Forms.Button();
            this.buttonClearDatabase = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonCurrentTime
            // 
            this.buttonCurrentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrentTime.Location = new System.Drawing.Point(794, 408);
            this.buttonCurrentTime.Name = "buttonCurrentTime";
            this.buttonCurrentTime.Size = new System.Drawing.Size(155, 34);
            this.buttonCurrentTime.TabIndex = 8;
            this.buttonCurrentTime.Text = "Now";
            this.buttonCurrentTime.UseVisualStyleBackColor = true;
            this.buttonCurrentTime.Click += new System.EventHandler(this.buttonCurrentTime_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(785, 399);
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
            this.tabPageMain.Size = new System.Drawing.Size(777, 373);
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
            this.tableLayoutPanelMainView.Size = new System.Drawing.Size(771, 367);
            this.tableLayoutPanelMainView.TabIndex = 1;
            this.tableLayoutPanelMainView.DoubleClick += new System.EventHandler(this.tableLayoutPanelMainView_DoubleClick);
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSunset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSunset.Location = new System.Drawing.Point(516, 350);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(252, 17);
            this.labelSunset.TabIndex = 10;
            this.labelSunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDayLength
            // 
            this.labelDayLength.AutoSize = true;
            this.labelDayLength.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDayLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayLength.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDayLength.Location = new System.Drawing.Point(259, 350);
            this.labelDayLength.Name = "labelDayLength";
            this.labelDayLength.Size = new System.Drawing.Size(251, 17);
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
            this.tableLayoutPanelClock.Location = new System.Drawing.Point(259, 125);
            this.tableLayoutPanelClock.Name = "tableLayoutPanelClock";
            this.tableLayoutPanelClock.RowCount = 3;
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.Size = new System.Drawing.Size(251, 116);
            this.tableLayoutPanelClock.TabIndex = 3;
            // 
            // labelClock
            // 
            this.labelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClock.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.SystemColors.Info;
            this.labelClock.Location = new System.Drawing.Point(28, 11);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(194, 92);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 247);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 31);
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
            this.labelLatestHumidity.Size = new System.Drawing.Size(144, 31);
            this.labelLatestHumidity.TabIndex = 5;
            this.labelLatestHumidity.Text = "Humidity";
            this.labelLatestHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelLatestHumidity, "Humidity");
            // 
            // pictureBoxHumidityChange
            // 
            this.pictureBoxHumidityChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHumidityChange.Location = new System.Drawing.Point(153, 3);
            this.pictureBoxHumidityChange.Name = "pictureBoxHumidityChange";
            this.pictureBoxHumidityChange.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxHumidityChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHumidityChange.TabIndex = 6;
            this.pictureBoxHumidityChange.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxTemperatureChange, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelLatestTemperature, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(516, 247);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(252, 31);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBoxTemperatureChange
            // 
            this.pictureBoxTemperatureChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxTemperatureChange.Location = new System.Drawing.Point(35, 3);
            this.pictureBoxTemperatureChange.Name = "pictureBoxTemperatureChange";
            this.pictureBoxTemperatureChange.Size = new System.Drawing.Size(25, 25);
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
            this.labelLatestTemperature.Location = new System.Drawing.Point(66, 0);
            this.labelLatestTemperature.Name = "labelLatestTemperature";
            this.labelLatestTemperature.Size = new System.Drawing.Size(88, 31);
            this.labelLatestTemperature.TabIndex = 4;
            this.labelLatestTemperature.Text = "Temperature";
            this.labelLatestTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labelLatestTemperature, "Temperature");
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(516, 125);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(252, 116);
            this.pictureBoxWeather.TabIndex = 0;
            this.pictureBoxWeather.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxWeather, "Current weather");
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMoon.Location = new System.Drawing.Point(3, 125);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(250, 116);
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
            this.labelSunrise.Location = new System.Drawing.Point(3, 350);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(250, 17);
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
            this.tabPageInfo.Size = new System.Drawing.Size(777, 373);
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
            this.dataGridViewInfo.Size = new System.Drawing.Size(771, 367);
            this.dataGridViewInfo.TabIndex = 2;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Size = new System.Drawing.Size(777, 373);
            this.tabPageAdmin.TabIndex = 2;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonClear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEmpty, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.SelectedButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.monthCalendar1, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 373);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.Location = new System.Drawing.Point(583, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(191, 58);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear database";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEmpty.Location = new System.Drawing.Point(583, 67);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(191, 58);
            this.buttonEmpty.TabIndex = 1;
            this.buttonEmpty.Text = "Empty Database";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            // 
            // SelectedButton
            // 
            this.SelectedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedButton.Location = new System.Drawing.Point(583, 131);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(191, 58);
            this.SelectedButton.TabIndex = 2;
            this.SelectedButton.Text = "Delete selected";
            this.SelectedButton.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(590, 202);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel2.Controls.Add(this.buttonSearch);
            this.flowLayoutPanel2.Controls.Add(this.labelEmpty);
            this.flowLayoutPanel2.Controls.Add(this.buttonAverage);
            this.flowLayoutPanel2.Controls.Add(this.labelAverage);
            this.flowLayoutPanel2.Controls.Add(this.buttonMax);
            this.flowLayoutPanel2.Controls.Add(this.labelMax);
            this.flowLayoutPanel2.Controls.Add(this.buttonMin);
            this.flowLayoutPanel2.Controls.Add(this.labelMin);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 408);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(785, 34);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ShortcutsEnabled = false;
            this.textBoxSearch.Size = new System.Drawing.Size(135, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearch.Location = new System.Drawing.Point(144, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(68, 27);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Location = new System.Drawing.Point(218, 0);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(22, 13);
            this.labelEmpty.TabIndex = 12;
            this.labelEmpty.Text = "     ";
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(246, 3);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(118, 27);
            this.buttonAverage.TabIndex = 5;
            this.buttonAverage.Text = "Average temperature";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAverage.Location = new System.Drawing.Point(370, 0);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(29, 33);
            this.labelAverage.TabIndex = 9;
            this.labelAverage.Text = "AVG";
            this.labelAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(405, 3);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(118, 27);
            this.buttonMax.TabIndex = 6;
            this.buttonMax.Text = "Max temperature";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMax.Location = new System.Drawing.Point(529, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(30, 33);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "MAX";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(565, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(118, 27);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.Text = "Min terperature";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMin.Location = new System.Drawing.Point(689, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(27, 33);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "MIN";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonShowAll, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonLastHour, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.button2HoursAgo, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.button3HoursAgo, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.button4HoursAgo, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button5HoursAgo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button6HoursAgo, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button7HoursAgo, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(794, 3);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(155, 399);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowAll.Location = new System.Drawing.Point(3, 3);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(149, 43);
            this.buttonShowAll.TabIndex = 9;
            this.buttonShowAll.Text = "Show all";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonLastHour
            // 
            this.buttonLastHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLastHour.Location = new System.Drawing.Point(3, 346);
            this.buttonLastHour.Name = "buttonLastHour";
            this.buttonLastHour.Size = new System.Drawing.Size(149, 50);
            this.buttonLastHour.TabIndex = 8;
            this.buttonLastHour.Text = "1 hour ago";
            this.buttonLastHour.UseVisualStyleBackColor = true;
            this.buttonLastHour.Click += new System.EventHandler(this.buttonLastHour_Click);
            // 
            // button2HoursAgo
            // 
            this.button2HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2HoursAgo.Location = new System.Drawing.Point(3, 297);
            this.button2HoursAgo.Name = "button2HoursAgo";
            this.button2HoursAgo.Size = new System.Drawing.Size(149, 43);
            this.button2HoursAgo.TabIndex = 8;
            this.button2HoursAgo.Text = "2 hours ago";
            this.button2HoursAgo.UseVisualStyleBackColor = true;
            this.button2HoursAgo.Click += new System.EventHandler(this.button2HoursAgo_Click);
            // 
            // button3HoursAgo
            // 
            this.button3HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3HoursAgo.Location = new System.Drawing.Point(3, 248);
            this.button3HoursAgo.Name = "button3HoursAgo";
            this.button3HoursAgo.Size = new System.Drawing.Size(149, 43);
            this.button3HoursAgo.TabIndex = 8;
            this.button3HoursAgo.Text = "3 hours ago";
            this.button3HoursAgo.UseVisualStyleBackColor = true;
            this.button3HoursAgo.Click += new System.EventHandler(this.button3HoursAgo_Click);
            // 
            // button4HoursAgo
            // 
            this.button4HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4HoursAgo.Location = new System.Drawing.Point(3, 199);
            this.button4HoursAgo.Name = "button4HoursAgo";
            this.button4HoursAgo.Size = new System.Drawing.Size(149, 43);
            this.button4HoursAgo.TabIndex = 8;
            this.button4HoursAgo.Text = "4 hours ago";
            this.button4HoursAgo.UseVisualStyleBackColor = true;
            this.button4HoursAgo.Click += new System.EventHandler(this.button4HoursAgo_Click);
            // 
            // button5HoursAgo
            // 
            this.button5HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5HoursAgo.Location = new System.Drawing.Point(3, 150);
            this.button5HoursAgo.Name = "button5HoursAgo";
            this.button5HoursAgo.Size = new System.Drawing.Size(149, 43);
            this.button5HoursAgo.TabIndex = 8;
            this.button5HoursAgo.Text = "5 hours ago";
            this.button5HoursAgo.UseVisualStyleBackColor = true;
            this.button5HoursAgo.Click += new System.EventHandler(this.button5HoursAgo_Click);
            // 
            // button6HoursAgo
            // 
            this.button6HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6HoursAgo.Location = new System.Drawing.Point(3, 101);
            this.button6HoursAgo.Name = "button6HoursAgo";
            this.button6HoursAgo.Size = new System.Drawing.Size(149, 43);
            this.button6HoursAgo.TabIndex = 8;
            this.button6HoursAgo.Text = "6 hours ago";
            this.button6HoursAgo.UseVisualStyleBackColor = true;
            this.button6HoursAgo.Click += new System.EventHandler(this.button6HoursAgo_Click);
            // 
            // button7HoursAgo
            // 
            this.button7HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7HoursAgo.Location = new System.Drawing.Point(3, 52);
            this.button7HoursAgo.Name = "button7HoursAgo";
            this.button7HoursAgo.Size = new System.Drawing.Size(149, 43);
            this.button7HoursAgo.TabIndex = 8;
            this.button7HoursAgo.Text = "7 hours ago";
            this.button7HoursAgo.UseVisualStyleBackColor = true;
            this.button7HoursAgo.Click += new System.EventHandler(this.button7HoursAgo_Click);
            // 
            // buttonClearDatabase
            // 
            this.buttonClearDatabase.Location = new System.Drawing.Point(0, 0);
            this.buttonClearDatabase.Name = "buttonClearDatabase";
            this.buttonClearDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDatabase.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(953, 444);
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
        private System.Windows.Forms.Button buttonShowAll;
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
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label labelMin;
    }
}

