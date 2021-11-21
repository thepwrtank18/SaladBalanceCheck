using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace SaladBalanceCheck
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void InternetError()
        {
            if (MessageBox.Show("Cannot connect to the Salad API. Please check your internet connection.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                var ping = new System.Net.NetworkInformation.Ping();

                var result = ping.Send("app-api.salad.io"); // Pings the API to check if the servers are up

                if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
                {
                    InternetError();
                }
            }
            catch (Exception)
            {
                InternetError();
            }

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            AccessToken.ReadOnly = true;
            AccessToken.Enabled = false;
            RefreshToken.ReadOnly = true;
            RefreshToken.Enabled = false;
            LogIn.Enabled = false;
            LogOut.Enabled = false;

            if (AccessToken.Text.Equals("") || RefreshToken.Text.Equals(""))
            {
                MessageBox.Show("Info cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AccessToken.ReadOnly = false;
                AccessToken.Enabled = true;
                RefreshToken.ReadOnly = false;
                RefreshToken.Enabled = true;
                LogIn.Enabled = true;
                LogOut.Enabled = false;
                label4.ForeColor = Color.DimGray;
            }
            else
            {
                try
                {
                    SaladAPI.SaladAPI SaladAPI = new SaladAPI.SaladAPI();
                    SaladAPI.GetReferralCode(AccessToken.Text,
                        RefreshToken.Text); // Serves no purpose other than to check login info
                    AccessToken.ReadOnly = true;
                    AccessToken.Enabled = false;
                    RefreshToken.ReadOnly = true;
                    RefreshToken.Enabled = false;
                    LogIn.Enabled = false;
                    LogOut.Enabled = true;
                    StartOrStop.Enabled = true;
                    DecimalPlaces.Enabled = true;
                    label4.ForeColor = Color.Black;
                    label2.Text = "N/A - Not started";
                }
                catch (Exception exception)
                {

                    if (MessageBox.Show("Info may be incorrect, or servers are down.\nFull Error: " + exception.Message,
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        AccessToken.ReadOnly = false;
                        AccessToken.Enabled = true;
                        RefreshToken.ReadOnly = false;
                        RefreshToken.Enabled = true;
                        LogIn.Enabled = true;
                        LogOut.Enabled = false;
                        label4.ForeColor = Color.DimGray;
                    }

                }
            }

        }

        private void StartOrStop_Click(object sender, EventArgs e)
        {

            switch (StartOrStop.Text)
            {
                case "Start":

                    StartOrStop.Text = "Stop";
                    LogIn.Enabled = false;
                    LogOut.Enabled = false;
                    AccessToken.ReadOnly = true;
                    AccessToken.Enabled = false;
                    RefreshToken.ReadOnly = true;
                    RefreshToken.Enabled = false;
                    DecimalPlaces.Enabled = false;
                    label4.ForeColor = Color.DimGray;
                    backgroundWorker1.RunWorkerAsync();
                    break;

                case "Stop":
                    StartOrStop.Enabled = false;
                    backgroundWorker1.CancelAsync();
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            AccessToken.Text = "";
            RefreshToken.Text = "";
            LogOut.Enabled = false;
            StartOrStop.Enabled = false;
            AccessToken.ReadOnly = false;
            AccessToken.Enabled = true;
            RefreshToken.ReadOnly = false;
            RefreshToken.Enabled = true;
            DecimalPlaces.Enabled = false;
            label2.Text = "N/A - Not logged in";
            DecimalPlaces.Value = 2;
            LogIn.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) // d
        {
            while (!backgroundWorker1.CancellationPending)
            {
                SaladAPI.SaladAPI SaladAPI = new SaladAPI.SaladAPI();
                CheckForIllegalCrossThreadCalls = false; // Who cares about memory leaks?
                label2.Text = "$" + decimal.Round(Convert.ToDecimal(SaladAPI.GetBalance(AccessToken.Text, RefreshToken.Text, false)), Convert.ToInt32(DecimalPlaces.Value));
                Thread.Sleep(5000); // Updates every 5 seconds
                //GC.Collect(); // Initiates garbage collection every 5 seconds. This is the worst way to do this.
            }
            LogIn.Enabled = false;
            LogOut.Enabled = true;
            AccessToken.ReadOnly = true;
            AccessToken.Enabled = false;
            RefreshToken.ReadOnly = true;
            RefreshToken.Enabled = false;
            DecimalPlaces.Enabled = true;
            label4.ForeColor = Color.Black;
            label2.Text = "N/A - Not started";
            StartOrStop.Text = "Start";
            StartOrStop.Enabled = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LogIn.Enabled = false;
            LogOut.Enabled = true;
            AccessToken.ReadOnly = true;
            AccessToken.Enabled = false;
            RefreshToken.ReadOnly = true;
            RefreshToken.Enabled = false;
            DecimalPlaces.Enabled = true;
            label4.ForeColor = Color.Black;
            label2.Text = "N/A - Not started";
            StartOrStop.Text = "Start";
            StartOrStop.Enabled = true;
        }
    }
}