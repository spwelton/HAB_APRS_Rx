using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalloonTracker
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.balloonCallSign = balloonCallsignBox.Text;
            Properties.Settings.Default.balloonSSID = balloonSSIDBox.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            balloonCallsignBox.Text = Properties.Settings.Default.balloonCallSign;
            balloonSSIDBox.Text = Properties.Settings.Default.balloonSSID;
        }
    }
}
