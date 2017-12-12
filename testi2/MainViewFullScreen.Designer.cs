namespace testi2
{
    partial class MainViewFullScreen
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
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateMainview = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateBackground = new System.Windows.Forms.Timer(this.components);
            this.timerColorAnimationForSunset = new System.Windows.Forms.Timer(this.components);
            this.timerColorAnimationForSunrise = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanelMainView.SuspendLayout();
            this.tableLayoutPanelClock.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidityChange)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperatureChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMainView
            // 
            this.tableLayoutPanelMainView.ColumnCount = 3;
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
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
            this.tableLayoutPanelMainView.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMainView.Name = "tableLayoutPanelMainView";
            this.tableLayoutPanelMainView.RowCount = 4;
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.2233F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03882F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92294F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.81494F));
            this.tableLayoutPanelMainView.Size = new System.Drawing.Size(800, 490);
            this.tableLayoutPanelMainView.TabIndex = 2;
            this.tableLayoutPanelMainView.DoubleClick += new System.EventHandler(this.tableLayoutPanelMainView_DoubleClick);
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSunset.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSunset.Location = new System.Drawing.Point(535, 444);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelSunset.Size = new System.Drawing.Size(262, 46);
            this.labelSunset.TabIndex = 10;
            this.labelSunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDayLength
            // 
            this.labelDayLength.AutoSize = true;
            this.labelDayLength.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDayLength.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayLength.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDayLength.Location = new System.Drawing.Point(269, 444);
            this.labelDayLength.Name = "labelDayLength";
            this.labelDayLength.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelDayLength.Size = new System.Drawing.Size(260, 46);
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
            this.tableLayoutPanelClock.Location = new System.Drawing.Point(269, 111);
            this.tableLayoutPanelClock.Name = "tableLayoutPanelClock";
            this.tableLayoutPanelClock.RowCount = 3;
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.Size = new System.Drawing.Size(260, 175);
            this.tableLayoutPanelClock.TabIndex = 3;
            // 
            // labelClock
            // 
            this.labelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClock.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.SystemColors.Info;
            this.labelClock.Location = new System.Drawing.Point(29, 17);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(202, 140);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 292);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(260, 67);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // labelLatestHumidity
            // 
            this.labelLatestHumidity.AutoSize = true;
            this.labelLatestHumidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLatestHumidity.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestHumidity.ForeColor = System.Drawing.SystemColors.Info;
            this.labelLatestHumidity.Location = new System.Drawing.Point(3, 0);
            this.labelLatestHumidity.Name = "labelLatestHumidity";
            this.labelLatestHumidity.Size = new System.Drawing.Size(150, 67);
            this.labelLatestHumidity.TabIndex = 5;
            this.labelLatestHumidity.Text = "Humidity";
            this.labelLatestHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxHumidityChange
            // 
            this.pictureBoxHumidityChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHumidityChange.Location = new System.Drawing.Point(159, 3);
            this.pictureBoxHumidityChange.Name = "pictureBoxHumidityChange";
            this.pictureBoxHumidityChange.Size = new System.Drawing.Size(25, 61);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(535, 292);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(262, 67);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // pictureBoxTemperatureChange
            // 
            this.pictureBoxTemperatureChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxTemperatureChange.Location = new System.Drawing.Point(76, 3);
            this.pictureBoxTemperatureChange.Name = "pictureBoxTemperatureChange";
            this.pictureBoxTemperatureChange.Size = new System.Drawing.Size(25, 61);
            this.pictureBoxTemperatureChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTemperatureChange.TabIndex = 7;
            this.pictureBoxTemperatureChange.TabStop = false;
            // 
            // labelLatestTemperature
            // 
            this.labelLatestTemperature.AutoSize = true;
            this.labelLatestTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLatestTemperature.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestTemperature.ForeColor = System.Drawing.SystemColors.Info;
            this.labelLatestTemperature.Location = new System.Drawing.Point(107, 0);
            this.labelLatestTemperature.Name = "labelLatestTemperature";
            this.labelLatestTemperature.Size = new System.Drawing.Size(152, 67);
            this.labelLatestTemperature.TabIndex = 4;
            this.labelLatestTemperature.Text = "Temperature";
            this.labelLatestTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(535, 111);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(262, 175);
            this.pictureBoxWeather.TabIndex = 0;
            this.pictureBoxWeather.TabStop = false;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMoon.Location = new System.Drawing.Point(3, 111);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(260, 175);
            this.pictureBoxMoon.TabIndex = 1;
            this.pictureBoxMoon.TabStop = false;
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSunrise.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSunrise.Location = new System.Drawing.Point(3, 444);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelSunrise.Size = new System.Drawing.Size(260, 46);
            this.labelSunrise.TabIndex = 8;
            this.labelSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.timerUpdateBackground.Interval = 300000;
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
            // MainViewFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.tableLayoutPanelMainView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainViewFullScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainViewFullScreen";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainView;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label labelDayLength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClock;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelLatestHumidity;
        private System.Windows.Forms.PictureBox pictureBoxHumidityChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBoxTemperatureChange;
        private System.Windows.Forms.Label labelLatestTemperature;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerUpdateMainview;
        private System.Windows.Forms.Timer timerUpdateBackground;
        private System.Windows.Forms.Timer timerColorAnimationForSunset;
        private System.Windows.Forms.Timer timerColorAnimationForSunrise;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}