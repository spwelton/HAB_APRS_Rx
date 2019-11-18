namespace BalloonTracker
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.balloonSSIDBox = new System.Windows.Forms.NumericUpDown();
            this.balloonSSIDLbl = new System.Windows.Forms.Label();
            this.balloonCallsignBox = new System.Windows.Forms.TextBox();
            this.balloonCallsignLbl = new System.Windows.Forms.Label();
            this.balloonTrackerDataGrpBox = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.balloonSSIDBox)).BeginInit();
            this.balloonTrackerDataGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // balloonSSIDBox
            // 
            this.balloonSSIDBox.Location = new System.Drawing.Point(144, 60);
            this.balloonSSIDBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.balloonSSIDBox.Name = "balloonSSIDBox";
            this.balloonSSIDBox.Size = new System.Drawing.Size(69, 22);
            this.balloonSSIDBox.TabIndex = 7;
            // 
            // balloonSSIDLbl
            // 
            this.balloonSSIDLbl.AutoSize = true;
            this.balloonSSIDLbl.Location = new System.Drawing.Point(19, 62);
            this.balloonSSIDLbl.Name = "balloonSSIDLbl";
            this.balloonSSIDLbl.Size = new System.Drawing.Size(94, 17);
            this.balloonSSIDLbl.TabIndex = 6;
            this.balloonSSIDLbl.Text = "Balloon SSID:";
            // 
            // balloonCallsignBox
            // 
            this.balloonCallsignBox.Location = new System.Drawing.Point(144, 27);
            this.balloonCallsignBox.Name = "balloonCallsignBox";
            this.balloonCallsignBox.Size = new System.Drawing.Size(100, 22);
            this.balloonCallsignBox.TabIndex = 5;
            // 
            // balloonCallsignLbl
            // 
            this.balloonCallsignLbl.AutoSize = true;
            this.balloonCallsignLbl.Location = new System.Drawing.Point(19, 30);
            this.balloonCallsignLbl.Name = "balloonCallsignLbl";
            this.balloonCallsignLbl.Size = new System.Drawing.Size(119, 17);
            this.balloonCallsignLbl.TabIndex = 4;
            this.balloonCallsignLbl.Text = "Balloon Call-Sign:";
            // 
            // balloonTrackerDataGrpBox
            // 
            this.balloonTrackerDataGrpBox.Controls.Add(this.balloonCallsignLbl);
            this.balloonTrackerDataGrpBox.Controls.Add(this.balloonSSIDBox);
            this.balloonTrackerDataGrpBox.Controls.Add(this.balloonCallsignBox);
            this.balloonTrackerDataGrpBox.Controls.Add(this.balloonSSIDLbl);
            this.balloonTrackerDataGrpBox.Location = new System.Drawing.Point(12, 12);
            this.balloonTrackerDataGrpBox.Name = "balloonTrackerDataGrpBox";
            this.balloonTrackerDataGrpBox.Size = new System.Drawing.Size(269, 104);
            this.balloonTrackerDataGrpBox.TabIndex = 8;
            this.balloonTrackerDataGrpBox.TabStop = false;
            this.balloonTrackerDataGrpBox.Text = "Balloon Tracker Data";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(13, 123);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 46);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(190, 123);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(91, 46);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 198);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.balloonTrackerDataGrpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferencesForm";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balloonSSIDBox)).EndInit();
            this.balloonTrackerDataGrpBox.ResumeLayout(false);
            this.balloonTrackerDataGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown balloonSSIDBox;
        private System.Windows.Forms.Label balloonSSIDLbl;
        private System.Windows.Forms.TextBox balloonCallsignBox;
        private System.Windows.Forms.Label balloonCallsignLbl;
        private System.Windows.Forms.GroupBox balloonTrackerDataGrpBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}