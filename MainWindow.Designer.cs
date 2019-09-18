﻿namespace BalloonTracker
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
            this.courseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.altitudeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timestampBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.positionGroup = new System.Windows.Forms.GroupBox();
            this.velocityGroup = new System.Windows.Forms.GroupBox();
            this.batteryVoltBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxAltBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pressureGauge = new LiveCharts.WinForms.SolidGauge();
            this.humidityGauge = new LiveCharts.WinForms.SolidGauge();
            this.intTempGauge = new LiveCharts.WinForms.SolidGauge();
            this.extTempGauge = new LiveCharts.WinForms.SolidGauge();
            this.positionGroup.SuspendLayout();
            this.velocityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TNCListener
            // 
            this.TNCListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TNCListener_DoWork);
            this.TNCListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TNCListener_RunWorkerCompleted);
            // 
            // preferencesBtn
            // 
            this.preferencesBtn.Location = new System.Drawing.Point(745, 23);
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
            this.longitudeLbl.Location = new System.Drawing.Point(18, 87);
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
            this.longitudeBox.Location = new System.Drawing.Point(145, 84);
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
            // courseBox
            // 
            this.courseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBox.Location = new System.Drawing.Point(145, 36);
            this.courseBox.Name = "courseBox";
            this.courseBox.ReadOnly = true;
            this.courseBox.Size = new System.Drawing.Size(214, 30);
            this.courseBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course";
            // 
            // speedBox
            // 
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Location = new System.Drawing.Point(145, 89);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(214, 30);
            this.speedBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speed";
            // 
            // altitudeBox
            // 
            this.altitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeBox.Location = new System.Drawing.Point(145, 132);
            this.altitudeBox.Name = "altitudeBox";
            this.altitudeBox.ReadOnly = true;
            this.altitudeBox.Size = new System.Drawing.Size(214, 30);
            this.altitudeBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 135);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pressure (atm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Humidity (%)";
            // 
            // positionGroup
            // 
            this.positionGroup.Controls.Add(this.latitudeBox);
            this.positionGroup.Controls.Add(this.latitudeLbl);
            this.positionGroup.Controls.Add(this.longitudeLbl);
            this.positionGroup.Controls.Add(this.longitudeBox);
            this.positionGroup.Controls.Add(this.maxAltBox);
            this.positionGroup.Controls.Add(this.label10);
            this.positionGroup.Controls.Add(this.altitudeBox);
            this.positionGroup.Controls.Add(this.label3);
            this.positionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionGroup.Location = new System.Drawing.Point(550, 83);
            this.positionGroup.Name = "positionGroup";
            this.positionGroup.Size = new System.Drawing.Size(401, 238);
            this.positionGroup.TabIndex = 17;
            this.positionGroup.TabStop = false;
            this.positionGroup.Text = "Position";
            // 
            // velocityGroup
            // 
            this.velocityGroup.Controls.Add(this.speedBox);
            this.velocityGroup.Controls.Add(this.label1);
            this.velocityGroup.Controls.Add(this.courseBox);
            this.velocityGroup.Controls.Add(this.label2);
            this.velocityGroup.Location = new System.Drawing.Point(550, 345);
            this.velocityGroup.Name = "velocityGroup";
            this.velocityGroup.Size = new System.Drawing.Size(401, 202);
            this.velocityGroup.TabIndex = 18;
            this.velocityGroup.TabStop = false;
            this.velocityGroup.Text = "Velocity";
            // 
            // batteryVoltBox
            // 
            this.batteryVoltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryVoltBox.Location = new System.Drawing.Point(166, 519);
            this.batteryVoltBox.Name = "batteryVoltBox";
            this.batteryVoltBox.ReadOnly = true;
            this.batteryVoltBox.Size = new System.Drawing.Size(214, 30);
            this.batteryVoltBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Battery Volt.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Int. Temp. (C)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ext. Temp. (C)";
            // 
            // maxAltBox
            // 
            this.maxAltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAltBox.Location = new System.Drawing.Point(145, 180);
            this.maxAltBox.Name = "maxAltBox";
            this.maxAltBox.ReadOnly = true;
            this.maxAltBox.Size = new System.Drawing.Size(214, 30);
            this.maxAltBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Alt. MAX";
            // 
            // pressureGauge
            // 
            this.pressureGauge.Location = new System.Drawing.Point(44, 111);
            this.pressureGauge.Name = "pressureGauge";
            this.pressureGauge.Size = new System.Drawing.Size(215, 140);
            this.pressureGauge.TabIndex = 28;
            // 
            // humidityGauge
            // 
            this.humidityGauge.Location = new System.Drawing.Point(287, 112);
            this.humidityGauge.Name = "humidityGauge";
            this.humidityGauge.Size = new System.Drawing.Size(215, 140);
            this.humidityGauge.TabIndex = 29;
            this.humidityGauge.Text = "solidGauge1";
            // 
            // intTempGauge
            // 
            this.intTempGauge.Location = new System.Drawing.Point(44, 309);
            this.intTempGauge.Name = "intTempGauge";
            this.intTempGauge.Size = new System.Drawing.Size(215, 140);
            this.intTempGauge.TabIndex = 30;
            // 
            // extTempGauge
            // 
            this.extTempGauge.Location = new System.Drawing.Point(286, 309);
            this.extTempGauge.Name = "extTempGauge";
            this.extTempGauge.Size = new System.Drawing.Size(215, 140);
            this.extTempGauge.TabIndex = 31;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 597);
            this.Controls.Add(this.extTempGauge);
            this.Controls.Add(this.intTempGauge);
            this.Controls.Add(this.humidityGauge);
            this.Controls.Add(this.pressureGauge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.batteryVoltBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.velocityGroup);
            this.Controls.Add(this.positionGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timestampBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preferencesBtn);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.positionGroup.ResumeLayout(false);
            this.positionGroup.PerformLayout();
            this.velocityGroup.ResumeLayout(false);
            this.velocityGroup.PerformLayout();
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
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox altitudeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timestampBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox positionGroup;
        private System.Windows.Forms.GroupBox velocityGroup;
        private System.Windows.Forms.TextBox batteryVoltBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox maxAltBox;
        private System.Windows.Forms.Label label10;
        private LiveCharts.WinForms.SolidGauge pressureGauge;
        private LiveCharts.WinForms.SolidGauge humidityGauge;
        private LiveCharts.WinForms.SolidGauge intTempGauge;
        private LiveCharts.WinForms.SolidGauge extTempGauge;
    }
}

