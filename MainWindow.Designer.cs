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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TNCListener = new System.ComponentModel.BackgroundWorker();
            this.latitudeLbl = new System.Windows.Forms.Label();
            this.longitudeLbl = new System.Windows.Forms.Label();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.packetParser = new System.ComponentModel.BackgroundWorker();
            this.positionGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ascentRateChart = new LiveCharts.WinForms.CartesianChart();
            this.altitudeChart = new LiveCharts.WinForms.CartesianChart();
            this.ascentRateBox = new System.Windows.Forms.TextBox();
            this.altitudeBox = new System.Windows.Forms.TextBox();
            this.maxAltBox = new System.Windows.Forms.TextBox();
            this.ascentRateLbl = new System.Windows.Forms.Label();
            this.maxAltLbl = new System.Windows.Forms.Label();
            this.altLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pressureLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.humidityGroup = new System.Windows.Forms.GroupBox();
            this.humidityLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.intTempGroup = new System.Windows.Forms.GroupBox();
            this.intTempLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.extTempGroup = new System.Windows.Forms.GroupBox();
            this.extTempLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.velocityGroup = new System.Windows.Forms.GroupBox();
            this.velocityLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.batteryGroup = new System.Windows.Forms.GroupBox();
            this.batteryVoltageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.batteryVoltageChart = new LiveCharts.WinForms.CartesianChart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastPacketTimestampLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.packetsRxLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.packetsExpectedLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.packetSuccessLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.packetSuccessUnitLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.preferencesButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.positionGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compass)).BeginInit();
            this.pressureGroup.SuspendLayout();
            this.pressureLayoutPanel.SuspendLayout();
            this.humidityGroup.SuspendLayout();
            this.humidityLayoutPanel.SuspendLayout();
            this.intTempGroup.SuspendLayout();
            this.intTempLayoutPanel.SuspendLayout();
            this.extTempGroup.SuspendLayout();
            this.extTempLayoutPanel.SuspendLayout();
            this.velocityGroup.SuspendLayout();
            this.velocityLayoutPanel.SuspendLayout();
            this.batteryGroup.SuspendLayout();
            this.batteryVoltageLayoutPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TNCListener
            // 
            this.TNCListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TNCListener_DoWork);
            this.TNCListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TNCListener_RunWorkerCompleted);
            // 
            // latitudeLbl
            // 
            this.latitudeLbl.AutoSize = true;
            this.latitudeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latitudeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLbl.Location = new System.Drawing.Point(3, 0);
            this.latitudeLbl.Name = "latitudeLbl";
            this.latitudeLbl.Size = new System.Drawing.Size(182, 42);
            this.latitudeLbl.TabIndex = 1;
            this.latitudeLbl.Text = "Latitude";
            this.latitudeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // longitudeLbl
            // 
            this.longitudeLbl.AutoSize = true;
            this.longitudeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLbl.Location = new System.Drawing.Point(3, 42);
            this.longitudeLbl.Name = "longitudeLbl";
            this.longitudeLbl.Size = new System.Drawing.Size(182, 42);
            this.longitudeLbl.TabIndex = 2;
            this.longitudeLbl.Text = "Longitude";
            this.longitudeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // latitudeBox
            // 
            this.latitudeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeBox.Location = new System.Drawing.Point(191, 3);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.ReadOnly = true;
            this.latitudeBox.Size = new System.Drawing.Size(182, 30);
            this.latitudeBox.TabIndex = 3;
            // 
            // longitudeBox
            // 
            this.longitudeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeBox.Location = new System.Drawing.Point(191, 45);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.ReadOnly = true;
            this.longitudeBox.Size = new System.Drawing.Size(182, 30);
            this.longitudeBox.TabIndex = 4;
            // 
            // packetParser
            // 
            this.packetParser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PacketParser_DoWork);
            this.packetParser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PacketParser_RunWorkerCompleted);
            // 
            // positionGroup
            // 
            this.mainLayoutPanel.SetColumnSpan(this.positionGroup, 2);
            this.positionGroup.Controls.Add(this.tableLayoutPanel1);
            this.positionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionGroup.Location = new System.Drawing.Point(5, 764);
            this.positionGroup.Margin = new System.Windows.Forms.Padding(5);
            this.positionGroup.Name = "positionGroup";
            this.positionGroup.Size = new System.Drawing.Size(1892, 243);
            this.positionGroup.TabIndex = 17;
            this.positionGroup.TabStop = false;
            this.positionGroup.Text = "Position";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.Controls.Add(this.ascentRateChart, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.altitudeChart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ascentRateBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.altitudeBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxAltBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.longitudeLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ascentRateLbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.latitudeLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.latitudeBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.longitudeBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.maxAltLbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.altLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1886, 214);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ascentRateChart
            // 
            this.ascentRateChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ascentRateChart.Location = new System.Drawing.Point(1170, 45);
            this.ascentRateChart.Name = "ascentRateChart";
            this.tableLayoutPanel1.SetRowSpan(this.ascentRateChart, 4);
            this.ascentRateChart.Size = new System.Drawing.Size(713, 166);
            this.ascentRateChart.TabIndex = 39;
            this.ascentRateChart.Text = "cartesianChart1";
            // 
            // altitudeChart
            // 
            this.altitudeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altitudeChart.Location = new System.Drawing.Point(454, 45);
            this.altitudeChart.Name = "altitudeChart";
            this.tableLayoutPanel1.SetRowSpan(this.altitudeChart, 4);
            this.altitudeChart.Size = new System.Drawing.Size(710, 166);
            this.altitudeChart.TabIndex = 38;
            this.altitudeChart.Text = "cartesianChart1";
            // 
            // ascentRateBox
            // 
            this.ascentRateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ascentRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascentRateBox.Location = new System.Drawing.Point(191, 171);
            this.ascentRateBox.Name = "ascentRateBox";
            this.ascentRateBox.ReadOnly = true;
            this.ascentRateBox.Size = new System.Drawing.Size(182, 30);
            this.ascentRateBox.TabIndex = 30;
            // 
            // altitudeBox
            // 
            this.altitudeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeBox.Location = new System.Drawing.Point(191, 87);
            this.altitudeBox.Name = "altitudeBox";
            this.altitudeBox.ReadOnly = true;
            this.altitudeBox.Size = new System.Drawing.Size(182, 30);
            this.altitudeBox.TabIndex = 29;
            // 
            // maxAltBox
            // 
            this.maxAltBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxAltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAltBox.Location = new System.Drawing.Point(191, 129);
            this.maxAltBox.Name = "maxAltBox";
            this.maxAltBox.ReadOnly = true;
            this.maxAltBox.Size = new System.Drawing.Size(182, 30);
            this.maxAltBox.TabIndex = 27;
            // 
            // ascentRateLbl
            // 
            this.ascentRateLbl.AutoSize = true;
            this.ascentRateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ascentRateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascentRateLbl.Location = new System.Drawing.Point(3, 168);
            this.ascentRateLbl.Name = "ascentRateLbl";
            this.ascentRateLbl.Size = new System.Drawing.Size(182, 46);
            this.ascentRateLbl.TabIndex = 27;
            this.ascentRateLbl.Text = "Ascent Rate";
            this.ascentRateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxAltLbl
            // 
            this.maxAltLbl.AutoSize = true;
            this.maxAltLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxAltLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAltLbl.Location = new System.Drawing.Point(3, 126);
            this.maxAltLbl.Name = "maxAltLbl";
            this.maxAltLbl.Size = new System.Drawing.Size(182, 42);
            this.maxAltLbl.TabIndex = 25;
            this.maxAltLbl.Text = "Alt. MAX";
            this.maxAltLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // altLbl
            // 
            this.altLbl.AutoSize = true;
            this.altLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altLbl.Location = new System.Drawing.Point(3, 84);
            this.altLbl.Name = "altLbl";
            this.altLbl.Size = new System.Drawing.Size(182, 42);
            this.altLbl.TabIndex = 28;
            this.altLbl.Text = "Altitude";
            this.altLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(454, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "Altitude";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1170, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(713, 42);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ascent Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(379, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 42);
            this.label3.TabIndex = 42;
            this.label3.Text = "feet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(379, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 42);
            this.label4.TabIndex = 43;
            this.label4.Text = "feet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(379, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 46);
            this.label5.TabIndex = 44;
            this.label5.Text = "fps";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureGauge
            // 
            this.pressureGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureGauge.Location = new System.Drawing.Point(10, 10);
            this.pressureGauge.Margin = new System.Windows.Forms.Padding(10);
            this.pressureGauge.Name = "pressureGauge";
            this.pressureGauge.Size = new System.Drawing.Size(213, 194);
            this.pressureGauge.TabIndex = 28;
            // 
            // humidityGauge
            // 
            this.humidityGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humidityGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityGauge.Location = new System.Drawing.Point(10, 10);
            this.humidityGauge.Margin = new System.Windows.Forms.Padding(10);
            this.humidityGauge.Name = "humidityGauge";
            this.humidityGauge.Size = new System.Drawing.Size(213, 194);
            this.humidityGauge.TabIndex = 29;
            this.humidityGauge.Text = "solidGauge1";
            // 
            // intTempGauge
            // 
            this.intTempGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intTempGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intTempGauge.Location = new System.Drawing.Point(10, 10);
            this.intTempGauge.Margin = new System.Windows.Forms.Padding(10);
            this.intTempGauge.Name = "intTempGauge";
            this.intTempGauge.Size = new System.Drawing.Size(213, 194);
            this.intTempGauge.TabIndex = 30;
            // 
            // extTempGauge
            // 
            this.extTempGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extTempGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extTempGauge.Location = new System.Drawing.Point(10, 10);
            this.extTempGauge.Margin = new System.Windows.Forms.Padding(10);
            this.extTempGauge.Name = "extTempGauge";
            this.extTempGauge.Size = new System.Drawing.Size(213, 194);
            this.extTempGauge.TabIndex = 31;
            // 
            // pressureChart
            // 
            this.pressureChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureChart.Location = new System.Drawing.Point(243, 10);
            this.pressureChart.Margin = new System.Windows.Forms.Padding(10);
            this.pressureChart.Name = "pressureChart";
            this.pressureChart.Size = new System.Drawing.Size(682, 194);
            this.pressureChart.TabIndex = 32;
            this.pressureChart.Text = "cartesianChart1";
            // 
            // compass
            // 
            this.compass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("compass.BackgroundImage")));
            this.compass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.compass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compass.Location = new System.Drawing.Point(795, 10);
            this.compass.Margin = new System.Windows.Forms.Padding(10);
            this.compass.Name = "compass";
            this.compass.Size = new System.Drawing.Size(130, 144);
            this.compass.TabIndex = 33;
            this.compass.TabStop = false;
            // 
            // intTempChart
            // 
            this.intTempChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intTempChart.Location = new System.Drawing.Point(243, 10);
            this.intTempChart.Margin = new System.Windows.Forms.Padding(10);
            this.intTempChart.Name = "intTempChart";
            this.intTempChart.Size = new System.Drawing.Size(682, 194);
            this.intTempChart.TabIndex = 34;
            this.intTempChart.Text = "cartesianChart1";
            // 
            // extTempChart
            // 
            this.extTempChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extTempChart.Location = new System.Drawing.Point(243, 10);
            this.extTempChart.Margin = new System.Windows.Forms.Padding(10);
            this.extTempChart.Name = "extTempChart";
            this.extTempChart.Size = new System.Drawing.Size(682, 194);
            this.extTempChart.TabIndex = 36;
            this.extTempChart.Text = "cartesianChart1";
            // 
            // humidityChart
            // 
            this.humidityChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humidityChart.Location = new System.Drawing.Point(243, 10);
            this.humidityChart.Margin = new System.Windows.Forms.Padding(10);
            this.humidityChart.Name = "humidityChart";
            this.humidityChart.Size = new System.Drawing.Size(682, 194);
            this.humidityChart.TabIndex = 35;
            this.humidityChart.Text = "cartesianChart1";
            // 
            // batteryGauge
            // 
            this.batteryGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batteryGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryGauge.Location = new System.Drawing.Point(10, 10);
            this.batteryGauge.Margin = new System.Windows.Forms.Padding(10);
            this.batteryGauge.Name = "batteryGauge";
            this.batteryGauge.Size = new System.Drawing.Size(213, 194);
            this.batteryGauge.TabIndex = 37;
            // 
            // courseBox
            // 
            this.courseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBox.Location = new System.Drawing.Point(795, 174);
            this.courseBox.Margin = new System.Windows.Forms.Padding(10);
            this.courseBox.Name = "courseBox";
            this.courseBox.ReadOnly = true;
            this.courseBox.Size = new System.Drawing.Size(130, 23);
            this.courseBox.TabIndex = 6;
            this.courseBox.Text = "0";
            this.courseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedBox
            // 
            this.speedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Location = new System.Drawing.Point(10, 174);
            this.speedBox.Margin = new System.Windows.Forms.Padding(10);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(130, 23);
            this.speedBox.TabIndex = 8;
            this.speedBox.Text = "0";
            this.speedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedGauge
            // 
            this.speedGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGauge.Location = new System.Drawing.Point(10, 10);
            this.speedGauge.Margin = new System.Windows.Forms.Padding(10);
            this.speedGauge.Name = "speedGauge";
            this.speedGauge.Size = new System.Drawing.Size(130, 144);
            this.speedGauge.TabIndex = 38;
            this.speedGauge.Text = "angularGauge1";
            // 
            // speedChart
            // 
            this.speedChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedChart.Location = new System.Drawing.Point(160, 10);
            this.speedChart.Margin = new System.Windows.Forms.Padding(10);
            this.speedChart.Name = "speedChart";
            this.velocityLayoutPanel.SetRowSpan(this.speedChart, 2);
            this.speedChart.Size = new System.Drawing.Size(615, 194);
            this.speedChart.TabIndex = 39;
            this.speedChart.Text = "cartesianChart1";
            // 
            // pressureGroup
            // 
            this.pressureGroup.Controls.Add(this.pressureLayoutPanel);
            this.pressureGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureGroup.Location = new System.Drawing.Point(5, 5);
            this.pressureGroup.Margin = new System.Windows.Forms.Padding(5);
            this.pressureGroup.Name = "pressureGroup";
            this.pressureGroup.Size = new System.Drawing.Size(941, 243);
            this.pressureGroup.TabIndex = 40;
            this.pressureGroup.TabStop = false;
            this.pressureGroup.Text = "Pressure (atm)";
            // 
            // pressureLayoutPanel
            // 
            this.pressureLayoutPanel.ColumnCount = 2;
            this.pressureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pressureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.pressureLayoutPanel.Controls.Add(this.pressureGauge, 0, 0);
            this.pressureLayoutPanel.Controls.Add(this.pressureChart, 1, 0);
            this.pressureLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.pressureLayoutPanel.Name = "pressureLayoutPanel";
            this.pressureLayoutPanel.RowCount = 1;
            this.pressureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pressureLayoutPanel.Size = new System.Drawing.Size(935, 214);
            this.pressureLayoutPanel.TabIndex = 33;
            // 
            // humidityGroup
            // 
            this.humidityGroup.Controls.Add(this.humidityLayoutPanel);
            this.humidityGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humidityGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityGroup.Location = new System.Drawing.Point(956, 5);
            this.humidityGroup.Margin = new System.Windows.Forms.Padding(5);
            this.humidityGroup.Name = "humidityGroup";
            this.humidityGroup.Size = new System.Drawing.Size(941, 243);
            this.humidityGroup.TabIndex = 41;
            this.humidityGroup.TabStop = false;
            this.humidityGroup.Text = "Humidity (%)";
            // 
            // humidityLayoutPanel
            // 
            this.humidityLayoutPanel.ColumnCount = 2;
            this.humidityLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.humidityLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.humidityLayoutPanel.Controls.Add(this.humidityChart, 1, 0);
            this.humidityLayoutPanel.Controls.Add(this.humidityGauge, 0, 0);
            this.humidityLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humidityLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.humidityLayoutPanel.Name = "humidityLayoutPanel";
            this.humidityLayoutPanel.RowCount = 1;
            this.humidityLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.humidityLayoutPanel.Size = new System.Drawing.Size(935, 214);
            this.humidityLayoutPanel.TabIndex = 36;
            // 
            // intTempGroup
            // 
            this.intTempGroup.Controls.Add(this.intTempLayoutPanel);
            this.intTempGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intTempGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intTempGroup.Location = new System.Drawing.Point(5, 258);
            this.intTempGroup.Margin = new System.Windows.Forms.Padding(5);
            this.intTempGroup.Name = "intTempGroup";
            this.intTempGroup.Size = new System.Drawing.Size(941, 243);
            this.intTempGroup.TabIndex = 42;
            this.intTempGroup.TabStop = false;
            this.intTempGroup.Text = "Internal Temperature (C)";
            // 
            // intTempLayoutPanel
            // 
            this.intTempLayoutPanel.ColumnCount = 2;
            this.intTempLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.intTempLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.intTempLayoutPanel.Controls.Add(this.intTempChart, 1, 0);
            this.intTempLayoutPanel.Controls.Add(this.intTempGauge, 0, 0);
            this.intTempLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intTempLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.intTempLayoutPanel.Name = "intTempLayoutPanel";
            this.intTempLayoutPanel.RowCount = 1;
            this.intTempLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.intTempLayoutPanel.Size = new System.Drawing.Size(935, 214);
            this.intTempLayoutPanel.TabIndex = 35;
            // 
            // extTempGroup
            // 
            this.extTempGroup.Controls.Add(this.extTempLayoutPanel);
            this.extTempGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extTempGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extTempGroup.Location = new System.Drawing.Point(956, 258);
            this.extTempGroup.Margin = new System.Windows.Forms.Padding(5);
            this.extTempGroup.Name = "extTempGroup";
            this.extTempGroup.Size = new System.Drawing.Size(941, 243);
            this.extTempGroup.TabIndex = 43;
            this.extTempGroup.TabStop = false;
            this.extTempGroup.Text = "External Temperature (C)";
            // 
            // extTempLayoutPanel
            // 
            this.extTempLayoutPanel.ColumnCount = 2;
            this.extTempLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.extTempLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.extTempLayoutPanel.Controls.Add(this.extTempChart, 1, 0);
            this.extTempLayoutPanel.Controls.Add(this.extTempGauge, 0, 0);
            this.extTempLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extTempLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.extTempLayoutPanel.Name = "extTempLayoutPanel";
            this.extTempLayoutPanel.RowCount = 1;
            this.extTempLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.extTempLayoutPanel.Size = new System.Drawing.Size(935, 214);
            this.extTempLayoutPanel.TabIndex = 37;
            // 
            // velocityGroup
            // 
            this.velocityGroup.Controls.Add(this.velocityLayoutPanel);
            this.velocityGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocityGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityGroup.Location = new System.Drawing.Point(5, 511);
            this.velocityGroup.Margin = new System.Windows.Forms.Padding(5);
            this.velocityGroup.Name = "velocityGroup";
            this.velocityGroup.Size = new System.Drawing.Size(941, 243);
            this.velocityGroup.TabIndex = 44;
            this.velocityGroup.TabStop = false;
            this.velocityGroup.Text = "Speed (MPH) / Direction";
            // 
            // velocityLayoutPanel
            // 
            this.velocityLayoutPanel.ColumnCount = 3;
            this.velocityLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.velocityLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.velocityLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.velocityLayoutPanel.Controls.Add(this.speedBox, 0, 1);
            this.velocityLayoutPanel.Controls.Add(this.speedGauge, 0, 0);
            this.velocityLayoutPanel.Controls.Add(this.courseBox, 2, 1);
            this.velocityLayoutPanel.Controls.Add(this.speedChart, 1, 0);
            this.velocityLayoutPanel.Controls.Add(this.compass, 2, 0);
            this.velocityLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocityLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.velocityLayoutPanel.Name = "velocityLayoutPanel";
            this.velocityLayoutPanel.RowCount = 2;
            this.velocityLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.velocityLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.velocityLayoutPanel.Size = new System.Drawing.Size(935, 214);
            this.velocityLayoutPanel.TabIndex = 40;
            // 
            // batteryGroup
            // 
            this.batteryGroup.Controls.Add(this.batteryVoltageLayoutPanel);
            this.batteryGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batteryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryGroup.Location = new System.Drawing.Point(956, 511);
            this.batteryGroup.Margin = new System.Windows.Forms.Padding(5);
            this.batteryGroup.Name = "batteryGroup";
            this.batteryGroup.Size = new System.Drawing.Size(941, 243);
            this.batteryGroup.TabIndex = 45;
            this.batteryGroup.TabStop = false;
            this.batteryGroup.Text = "Battery Voltage";
            // 
            // batteryVoltageLayoutPanel
            // 
            this.batteryVoltageLayoutPanel.ColumnCount = 2;
            this.batteryVoltageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.batteryVoltageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.batteryVoltageLayoutPanel.Controls.Add(this.batteryGauge, 0, 0);
            this.batteryVoltageLayoutPanel.Controls.Add(this.batteryVoltageChart, 1, 0);
            this.batteryVoltageLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batteryVoltageLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.batteryVoltageLayoutPanel.Name = "batteryVoltageLayoutPanel";
            this.batteryVoltageLayoutPanel.RowCount = 1;
            this.batteryVoltageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.batteryVoltageLayoutPanel.Size = new System.Drawing.Size(935, 214);
            this.batteryVoltageLayoutPanel.TabIndex = 38;
            // 
            // batteryVoltageChart
            // 
            this.batteryVoltageChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batteryVoltageChart.Location = new System.Drawing.Point(243, 10);
            this.batteryVoltageChart.Margin = new System.Windows.Forms.Padding(10);
            this.batteryVoltageChart.Name = "batteryVoltageChart";
            this.batteryVoltageChart.Size = new System.Drawing.Size(682, 194);
            this.batteryVoltageChart.TabIndex = 38;
            this.batteryVoltageChart.Text = "cartesianChart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lastPacketTimestampLbl,
            this.toolStripStatusLabel3,
            this.packetsRxLbl,
            this.toolStripStatusLabel5,
            this.packetsExpectedLbl,
            this.toolStripStatusLabel4,
            this.packetSuccessLbl,
            this.packetSuccessUnitLbl,
            this.toolStripStatusLabel2,
            this.preferencesButton});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1013);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1902, 42);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 37);
            this.toolStripStatusLabel1.Text = "Last Packet Rx:";
            // 
            // lastPacketTimestampLbl
            // 
            this.lastPacketTimestampLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPacketTimestampLbl.Margin = new System.Windows.Forms.Padding(0, 3, 30, 2);
            this.lastPacketTimestampLbl.Name = "lastPacketTimestampLbl";
            this.lastPacketTimestampLbl.Size = new System.Drawing.Size(86, 37);
            this.lastPacketTimestampLbl.Text = "00:00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(143, 37);
            this.toolStripStatusLabel3.Text = "Packet Success:";
            // 
            // packetsRxLbl
            // 
            this.packetsRxLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetsRxLbl.Name = "packetsRxLbl";
            this.packetsRxLbl.Size = new System.Drawing.Size(23, 37);
            this.packetsRxLbl.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(20, 37);
            this.toolStripStatusLabel5.Text = "/";
            // 
            // packetsExpectedLbl
            // 
            this.packetsExpectedLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetsExpectedLbl.Name = "packetsExpectedLbl";
            this.packetsExpectedLbl.Size = new System.Drawing.Size(23, 37);
            this.packetsExpectedLbl.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 37);
            this.toolStripStatusLabel4.Text = ",";
            // 
            // packetSuccessLbl
            // 
            this.packetSuccessLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetSuccessLbl.Name = "packetSuccessLbl";
            this.packetSuccessLbl.Size = new System.Drawing.Size(23, 37);
            this.packetSuccessLbl.Text = "0";
            // 
            // packetSuccessUnitLbl
            // 
            this.packetSuccessUnitLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetSuccessUnitLbl.Margin = new System.Windows.Forms.Padding(0, 3, 30, 2);
            this.packetSuccessUnitLbl.Name = "packetSuccessUnitLbl";
            this.packetSuccessUnitLbl.Size = new System.Drawing.Size(28, 37);
            this.packetSuccessUnitLbl.Text = "%";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1193, 37);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // preferencesButton
            // 
            this.preferencesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.preferencesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesButton.Image = ((System.Drawing.Image)(resources.GetObject("preferencesButton.Image")));
            this.preferencesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.preferencesButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.preferencesButton.Name = "preferencesButton";
            this.preferencesButton.ShowDropDownArrow = false;
            this.preferencesButton.Size = new System.Drawing.Size(115, 32);
            this.preferencesButton.Text = "Preferences";
            this.preferencesButton.Click += new System.EventHandler(this.ToolStripDropDownButton1_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Controls.Add(this.pressureGroup, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.positionGroup, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.extTempGroup, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.batteryGroup, 1, 2);
            this.mainLayoutPanel.Controls.Add(this.humidityGroup, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.velocityGroup, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.intTempGroup, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 5;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1902, 1055);
            this.mainLayoutPanel.TabIndex = 47;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "HAB Telemetry Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.positionGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compass)).EndInit();
            this.pressureGroup.ResumeLayout(false);
            this.pressureLayoutPanel.ResumeLayout(false);
            this.humidityGroup.ResumeLayout(false);
            this.humidityLayoutPanel.ResumeLayout(false);
            this.intTempGroup.ResumeLayout(false);
            this.intTempLayoutPanel.ResumeLayout(false);
            this.extTempGroup.ResumeLayout(false);
            this.extTempLayoutPanel.ResumeLayout(false);
            this.velocityGroup.ResumeLayout(false);
            this.velocityLayoutPanel.ResumeLayout(false);
            this.velocityLayoutPanel.PerformLayout();
            this.batteryGroup.ResumeLayout(false);
            this.batteryVoltageLayoutPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker TNCListener;
        private System.Windows.Forms.Label latitudeLbl;
        private System.Windows.Forms.Label longitudeLbl;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.ComponentModel.BackgroundWorker packetParser;
        private System.Windows.Forms.GroupBox positionGroup;
        private System.Windows.Forms.Label maxAltLbl;
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
        private System.Windows.Forms.Label ascentRateLbl;
        private System.Windows.Forms.GroupBox intTempGroup;
        private System.Windows.Forms.GroupBox extTempGroup;
        private System.Windows.Forms.GroupBox velocityGroup;
        private System.Windows.Forms.GroupBox batteryGroup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lastPacketTimestampLbl;
        private System.Windows.Forms.ToolStripDropDownButton preferencesButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel pressureLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel extTempLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel humidityLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel intTempLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel velocityLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel batteryVoltageLayoutPanel;
        private LiveCharts.WinForms.CartesianChart batteryVoltageChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart ascentRateChart;
        private LiveCharts.WinForms.CartesianChart altitudeChart;
        private System.Windows.Forms.TextBox ascentRateBox;
        private System.Windows.Forms.TextBox altitudeBox;
        private System.Windows.Forms.TextBox maxAltBox;
        private System.Windows.Forms.Label altLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel packetSuccessLbl;
        private System.Windows.Forms.ToolStripStatusLabel packetSuccessUnitLbl;
        private System.Windows.Forms.ToolStripStatusLabel packetsRxLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel packetsExpectedLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

