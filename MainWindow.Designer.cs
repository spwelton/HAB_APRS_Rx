namespace BalloonTracker
{
    partial class MainWindow
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
            this.TNCListener = new System.ComponentModel.BackgroundWorker();
            this.preferencesBtn = new System.Windows.Forms.Button();
            this.latitudeLbl = new System.Windows.Forms.Label();
            this.longitudeLbl = new System.Windows.Forms.Label();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.packetParser = new System.ComponentModel.BackgroundWorker();
            this.altitudeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timestampBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionGroup = new System.Windows.Forms.GroupBox();
            this.ascentRateChart = new LiveCharts.WinForms.CartesianChart();
            this.altitudeChart = new LiveCharts.WinForms.CartesianChart();
            this.ascentRateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxAltBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pressureGauge = new LiveCharts.WinForms.SolidGauge();
            this.humidityGauge = new LiveCharts.WinForms.SolidGauge();
            this.intTempGauge = new LiveCharts.WinForms.SolidGauge();
            this.extTempGauge = new LiveCharts.WinForms.SolidGauge();
            this.pressureChart = new LiveCharts.WinForms.CartesianChart();
            this.compass = new System.Windows.Forms.PictureBox();
            this.intTempChart = new LiveCharts.WinForms.CartesianChart();
            this.extTempChart = new LiveCharts.WinForms.CartesianChart();
            this.humidityChart = new LiveCharts.WinForms.CartesianChart();
            this.batteryGauge = new LiveCharts.WinForms.SolidGauge();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.speedGauge = new LiveCharts.WinForms.AngularGauge();
            this.speedChart = new LiveCharts.WinForms.CartesianChart();
            this.pressureGroup = new System.Windows.Forms.GroupBox();
            this.humidityGroup = new System.Windows.Forms.GroupBox();
            this.intTempGroup = new System.Windows.Forms.GroupBox();
            this.extTempGroup = new System.Windows.Forms.GroupBox();
            this.velocityGroup = new System.Windows.Forms.GroupBox();
            this.batteryGroup = new System.Windows.Forms.GroupBox();
            this.positionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compass)).BeginInit();
            this.pressureGroup.SuspendLayout();
            this.humidityGroup.SuspendLayout();
            this.intTempGroup.SuspendLayout();
            this.extTempGroup.SuspendLayout();
            this.velocityGroup.SuspendLayout();
            this.batteryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TNCListener
            // 
            this.TNCListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TNCListener_DoWork);
            this.TNCListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TNCListener_RunWorkerCompleted);
            // 
            // preferencesBtn
            // 
            this.preferencesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesBtn.Location = new System.Drawing.Point(1423, 20);
            this.preferencesBtn.Name = "preferencesBtn";
            this.preferencesBtn.Size = new System.Drawing.Size(206, 48);
            this.preferencesBtn.TabIndex = 0;
            this.preferencesBtn.Text = "Preferences";
            this.preferencesBtn.UseVisualStyleBackColor = true;
            this.preferencesBtn.Click += new System.EventHandler(this.PreferencesBtn_Click);
            // 
            // latitudeLbl
            // 
            this.latitudeLbl.AutoSize = true;
            this.latitudeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLbl.Location = new System.Drawing.Point(18, 39);
            this.latitudeLbl.Name = "latitudeLbl";
            this.latitudeLbl.Size = new System.Drawing.Size(81, 25);
            this.latitudeLbl.TabIndex = 1;
            this.latitudeLbl.Text = "Latitude";
            // 
            // longitudeLbl
            // 
            this.longitudeLbl.AutoSize = true;
            this.longitudeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLbl.Location = new System.Drawing.Point(18, 75);
            this.longitudeLbl.Name = "longitudeLbl";
            this.longitudeLbl.Size = new System.Drawing.Size(98, 25);
            this.longitudeLbl.TabIndex = 2;
            this.longitudeLbl.Text = "Longitude";
            // 
            // latitudeBox
            // 
            this.latitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeBox.Location = new System.Drawing.Point(145, 36);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.ReadOnly = true;
            this.latitudeBox.Size = new System.Drawing.Size(214, 30);
            this.latitudeBox.TabIndex = 3;
            // 
            // longitudeBox
            // 
            this.longitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeBox.Location = new System.Drawing.Point(145, 72);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.ReadOnly = true;
            this.longitudeBox.Size = new System.Drawing.Size(214, 30);
            this.longitudeBox.TabIndex = 4;
            // 
            // packetParser
            // 
            this.packetParser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PacketParser_DoWork);
            this.packetParser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PacketParser_RunWorkerCompleted);
            // 
            // altitudeBox
            // 
            this.altitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeBox.Location = new System.Drawing.Point(145, 108);
            this.altitudeBox.Name = "altitudeBox";
            this.altitudeBox.ReadOnly = true;
            this.altitudeBox.Size = new System.Drawing.Size(214, 30);
            this.altitudeBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Altitude";
            // 
            // timestampBox
            // 
            this.timestampBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timestampBox.Location = new System.Drawing.Point(287, 29);
            this.timestampBox.Name = "timestampBox";
            this.timestampBox.ReadOnly = true;
            this.timestampBox.Size = new System.Drawing.Size(214, 30);
            this.timestampBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Packet Received";
            // 
            // positionGroup
            // 
            this.positionGroup.Controls.Add(this.ascentRateChart);
            this.positionGroup.Controls.Add(this.altitudeChart);
            this.positionGroup.Controls.Add(this.ascentRateBox);
            this.positionGroup.Controls.Add(this.label5);
            this.positionGroup.Controls.Add(this.latitudeBox);
            this.positionGroup.Controls.Add(this.latitudeLbl);
            this.positionGroup.Controls.Add(this.longitudeLbl);
            this.positionGroup.Controls.Add(this.longitudeBox);
            this.positionGroup.Controls.Add(this.maxAltBox);
            this.positionGroup.Controls.Add(this.label10);
            this.positionGroup.Controls.Add(this.altitudeBox);
            this.positionGroup.Controls.Add(this.label3);
            this.positionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionGroup.Location = new System.Drawing.Point(1228, 83);
            this.positionGroup.Name = "positionGroup";
            this.positionGroup.Size = new System.Drawing.Size(401, 632);
            this.positionGroup.TabIndex = 17;
            this.positionGroup.TabStop = false;
            this.positionGroup.Text = "Position";
            // 
            // ascentRateChart
            // 
            this.ascentRateChart.Location = new System.Drawing.Point(23, 422);
            this.ascentRateChart.Name = "ascentRateChart";
            this.ascentRateChart.Size = new System.Drawing.Size(336, 200);
            this.ascentRateChart.TabIndex = 38;
            this.ascentRateChart.Text = "cartesianChart1";
            // 
            // altitudeChart
            // 
            this.altitudeChart.Location = new System.Drawing.Point(23, 144);
            this.altitudeChart.Name = "altitudeChart";
            this.altitudeChart.Size = new System.Drawing.Size(336, 200);
            this.altitudeChart.TabIndex = 37;
            this.altitudeChart.Text = "cartesianChart1";
            // 
            // ascentRateBox
            // 
            this.ascentRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascentRateBox.Location = new System.Drawing.Point(145, 386);
            this.ascentRateBox.Name = "ascentRateBox";
            this.ascentRateBox.ReadOnly = true;
            this.ascentRateBox.Size = new System.Drawing.Size(214, 30);
            this.ascentRateBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ascent Rate";
            // 
            // maxAltBox
            // 
            this.maxAltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAltBox.Location = new System.Drawing.Point(145, 350);
            this.maxAltBox.Name = "maxAltBox";
            this.maxAltBox.ReadOnly = true;
            this.maxAltBox.Size = new System.Drawing.Size(214, 30);
            this.maxAltBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Alt. MAX";
            // 
            // pressureGauge
            // 
            this.pressureGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureGauge.Location = new System.Drawing.Point(16, 34);
            this.pressureGauge.Name = "pressureGauge";
            this.pressureGauge.Size = new System.Drawing.Size(215, 140);
            this.pressureGauge.TabIndex = 28;
            // 
            // humidityGauge
            // 
            this.humidityGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityGauge.Location = new System.Drawing.Point(19, 34);
            this.humidityGauge.Name = "humidityGauge";
            this.humidityGauge.Size = new System.Drawing.Size(215, 140);
            this.humidityGauge.TabIndex = 29;
            this.humidityGauge.Text = "solidGauge1";
            // 
            // intTempGauge
            // 
            this.intTempGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intTempGauge.Location = new System.Drawing.Point(16, 29);
            this.intTempGauge.Name = "intTempGauge";
            this.intTempGauge.Size = new System.Drawing.Size(215, 140);
            this.intTempGauge.TabIndex = 30;
            // 
            // extTempGauge
            // 
            this.extTempGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extTempGauge.Location = new System.Drawing.Point(25, 29);
            this.extTempGauge.Name = "extTempGauge";
            this.extTempGauge.Size = new System.Drawing.Size(215, 140);
            this.extTempGauge.TabIndex = 31;
            // 
            // pressureChart
            // 
            this.pressureChart.Location = new System.Drawing.Point(268, 34);
            this.pressureChart.Name = "pressureChart";
            this.pressureChart.Size = new System.Drawing.Size(281, 140);
            this.pressureChart.TabIndex = 32;
            this.pressureChart.Text = "cartesianChart1";
            // 
            // compass
            // 
            this.compass.BackgroundImage = global::BalloonTracker.Properties.Resources.pointer_arrow;
            this.compass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.compass.Location = new System.Drawing.Point(582, 41);
            this.compass.Name = "compass";
            this.compass.Size = new System.Drawing.Size(128, 128);
            this.compass.TabIndex = 33;
            this.compass.TabStop = false;
            // 
            // intTempChart
            // 
            this.intTempChart.Location = new System.Drawing.Point(268, 29);
            this.intTempChart.Name = "intTempChart";
            this.intTempChart.Size = new System.Drawing.Size(281, 140);
            this.intTempChart.TabIndex = 34;
            this.intTempChart.Text = "cartesianChart1";
            // 
            // extTempChart
            // 
            this.extTempChart.Location = new System.Drawing.Point(268, 29);
            this.extTempChart.Name = "extTempChart";
            this.extTempChart.Size = new System.Drawing.Size(281, 140);
            this.extTempChart.TabIndex = 36;
            this.extTempChart.Text = "cartesianChart1";
            // 
            // humidityChart
            // 
            this.humidityChart.Location = new System.Drawing.Point(262, 34);
            this.humidityChart.Name = "humidityChart";
            this.humidityChart.Size = new System.Drawing.Size(281, 140);
            this.humidityChart.TabIndex = 35;
            this.humidityChart.Text = "cartesianChart1";
            // 
            // batteryGauge
            // 
            this.batteryGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryGauge.Location = new System.Drawing.Point(16, 45);
            this.batteryGauge.Name = "batteryGauge";
            this.batteryGauge.Size = new System.Drawing.Size(215, 140);
            this.batteryGauge.TabIndex = 37;
            // 
            // courseBox
            // 
            this.courseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBox.Location = new System.Drawing.Point(582, 187);
            this.courseBox.Name = "courseBox";
            this.courseBox.ReadOnly = true;
            this.courseBox.Size = new System.Drawing.Size(128, 23);
            this.courseBox.TabIndex = 6;
            this.courseBox.Text = "0";
            this.courseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedBox
            // 
            this.speedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Location = new System.Drawing.Point(24, 191);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(140, 23);
            this.speedBox.TabIndex = 8;
            this.speedBox.Text = "0";
            this.speedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedGauge
            // 
            this.speedGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGauge.Location = new System.Drawing.Point(24, 29);
            this.speedGauge.Name = "speedGauge";
            this.speedGauge.Size = new System.Drawing.Size(140, 140);
            this.speedGauge.TabIndex = 38;
            this.speedGauge.Text = "angularGauge1";
            // 
            // speedChart
            // 
            this.speedChart.Location = new System.Drawing.Point(190, 29);
            this.speedChart.Name = "speedChart";
            this.speedChart.Size = new System.Drawing.Size(359, 181);
            this.speedChart.TabIndex = 39;
            this.speedChart.Text = "cartesianChart1";
            // 
            // pressureGroup
            // 
            this.pressureGroup.Controls.Add(this.pressureChart);
            this.pressureGroup.Controls.Add(this.pressureGauge);
            this.pressureGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureGroup.Location = new System.Drawing.Point(44, 83);
            this.pressureGroup.Name = "pressureGroup";
            this.pressureGroup.Size = new System.Drawing.Size(555, 180);
            this.pressureGroup.TabIndex = 40;
            this.pressureGroup.TabStop = false;
            this.pressureGroup.Text = "Pressure (atm)";
            // 
            // humidityGroup
            // 
            this.humidityGroup.Controls.Add(this.humidityGauge);
            this.humidityGroup.Controls.Add(this.humidityChart);
            this.humidityGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityGroup.Location = new System.Drawing.Point(653, 83);
            this.humidityGroup.Name = "humidityGroup";
            this.humidityGroup.Size = new System.Drawing.Size(555, 180);
            this.humidityGroup.TabIndex = 41;
            this.humidityGroup.TabStop = false;
            this.humidityGroup.Text = "Humidity (%)";
            // 
            // intTempGroup
            // 
            this.intTempGroup.Controls.Add(this.intTempGauge);
            this.intTempGroup.Controls.Add(this.intTempChart);
            this.intTempGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intTempGroup.Location = new System.Drawing.Point(44, 281);
            this.intTempGroup.Name = "intTempGroup";
            this.intTempGroup.Size = new System.Drawing.Size(555, 180);
            this.intTempGroup.TabIndex = 42;
            this.intTempGroup.TabStop = false;
            this.intTempGroup.Text = "Internal Temperature (C)";
            // 
            // extTempGroup
            // 
            this.extTempGroup.Controls.Add(this.extTempGauge);
            this.extTempGroup.Controls.Add(this.extTempChart);
            this.extTempGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extTempGroup.Location = new System.Drawing.Point(647, 281);
            this.extTempGroup.Name = "extTempGroup";
            this.extTempGroup.Size = new System.Drawing.Size(555, 180);
            this.extTempGroup.TabIndex = 43;
            this.extTempGroup.TabStop = false;
            this.extTempGroup.Text = "External Temperature (C)";
            // 
            // velocityGroup
            // 
            this.velocityGroup.Controls.Add(this.compass);
            this.velocityGroup.Controls.Add(this.courseBox);
            this.velocityGroup.Controls.Add(this.speedGauge);
            this.velocityGroup.Controls.Add(this.speedChart);
            this.velocityGroup.Controls.Add(this.speedBox);
            this.velocityGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityGroup.Location = new System.Drawing.Point(44, 482);
            this.velocityGroup.Name = "velocityGroup";
            this.velocityGroup.Size = new System.Drawing.Size(739, 233);
            this.velocityGroup.TabIndex = 44;
            this.velocityGroup.TabStop = false;
            this.velocityGroup.Text = "Speed (MPH)";
            // 
            // batteryGroup
            // 
            this.batteryGroup.Controls.Add(this.batteryGauge);
            this.batteryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryGroup.Location = new System.Drawing.Point(953, 482);
            this.batteryGroup.Name = "batteryGroup";
            this.batteryGroup.Size = new System.Drawing.Size(255, 233);
            this.batteryGroup.TabIndex = 45;
            this.batteryGroup.TabStop = false;
            this.batteryGroup.Text = "Battery Voltage";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1013);
            this.Controls.Add(this.batteryGroup);
            this.Controls.Add(this.velocityGroup);
            this.Controls.Add(this.extTempGroup);
            this.Controls.Add(this.intTempGroup);
            this.Controls.Add(this.humidityGroup);
            this.Controls.Add(this.pressureGroup);
            this.Controls.Add(this.positionGroup);
            this.Controls.Add(this.timestampBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preferencesBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.positionGroup.ResumeLayout(false);
            this.positionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compass)).EndInit();
            this.pressureGroup.ResumeLayout(false);
            this.humidityGroup.ResumeLayout(false);
            this.intTempGroup.ResumeLayout(false);
            this.extTempGroup.ResumeLayout(false);
            this.velocityGroup.ResumeLayout(false);
            this.velocityGroup.PerformLayout();
            this.batteryGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker TNCListener;
        private System.Windows.Forms.Button preferencesBtn;
        private System.Windows.Forms.Label latitudeLbl;
        private System.Windows.Forms.Label longitudeLbl;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.ComponentModel.BackgroundWorker packetParser;
        private System.Windows.Forms.TextBox altitudeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timestampBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox positionGroup;
        private System.Windows.Forms.TextBox maxAltBox;
        private System.Windows.Forms.Label label10;
        private LiveCharts.WinForms.SolidGauge pressureGauge;
        private LiveCharts.WinForms.SolidGauge humidityGauge;
        private LiveCharts.WinForms.SolidGauge intTempGauge;
        private LiveCharts.WinForms.SolidGauge extTempGauge;
        private LiveCharts.WinForms.CartesianChart pressureChart;
        private System.Windows.Forms.PictureBox compass;
        private LiveCharts.WinForms.CartesianChart intTempChart;
        private LiveCharts.WinForms.CartesianChart extTempChart;
        private LiveCharts.WinForms.CartesianChart humidityChart;
        private LiveCharts.WinForms.SolidGauge batteryGauge;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox speedBox;
        private LiveCharts.WinForms.AngularGauge speedGauge;
        private LiveCharts.WinForms.CartesianChart speedChart;
        private System.Windows.Forms.GroupBox pressureGroup;
        private System.Windows.Forms.GroupBox humidityGroup;
        private System.Windows.Forms.TextBox ascentRateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox intTempGroup;
        private System.Windows.Forms.GroupBox extTempGroup;
        private System.Windows.Forms.GroupBox velocityGroup;
        private System.Windows.Forms.GroupBox batteryGroup;
        private LiveCharts.WinForms.CartesianChart ascentRateChart;
        private LiveCharts.WinForms.CartesianChart altitudeChart;
    }
}

