namespace SaladBalanceCheck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccessToken = new System.Windows.Forms.TextBox();
            this.RefreshToken = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.DecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.StartOrStop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DecimalPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your balance is: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "N/A - Not logged in";
            // 
            // AccessToken
            // 
            this.AccessToken.Location = new System.Drawing.Point(12, 56);
            this.AccessToken.Name = "AccessToken";
            this.AccessToken.PasswordChar = '*';
            this.AccessToken.PlaceholderText = "sAccessToken";
            this.AccessToken.Size = new System.Drawing.Size(100, 23);
            this.AccessToken.TabIndex = 2;
            // 
            // RefreshToken
            // 
            this.RefreshToken.Location = new System.Drawing.Point(118, 56);
            this.RefreshToken.Name = "RefreshToken";
            this.RefreshToken.PasswordChar = '*';
            this.RefreshToken.PlaceholderText = "sIdRefreshToken";
            this.RefreshToken.Size = new System.Drawing.Size(100, 23);
            this.RefreshToken.TabIndex = 3;
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(224, 56);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(64, 23);
            this.LogIn.TabIndex = 4;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // DecimalPlaces
            // 
            this.DecimalPlaces.Enabled = false;
            this.DecimalPlaces.Location = new System.Drawing.Point(106, 85);
            this.DecimalPlaces.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.DecimalPlaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DecimalPlaces.Name = "DecimalPlaces";
            this.DecimalPlaces.Size = new System.Drawing.Size(34, 23);
            this.DecimalPlaces.TabIndex = 6;
            this.DecimalPlaces.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.DecimalPlaces.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Decimal places:";
            // 
            // LogOut
            // 
            this.LogOut.Enabled = false;
            this.LogOut.Location = new System.Drawing.Point(292, 56);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(64, 23);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // StartOrStop
            // 
            this.StartOrStop.Enabled = false;
            this.StartOrStop.Location = new System.Drawing.Point(224, 83);
            this.StartOrStop.Name = "StartOrStop";
            this.StartOrStop.Size = new System.Drawing.Size(132, 23);
            this.StartOrStop.TabIndex = 9;
            this.StartOrStop.Text = "Start";
            this.StartOrStop.UseVisualStyleBackColor = true;
            this.StartOrStop.Click += new System.EventHandler(this.StartOrStop_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 116);
            this.Controls.Add(this.StartOrStop);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecimalPlaces);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.RefreshToken);
            this.Controls.Add(this.AccessToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Salad Balance Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DecimalPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccessToken;
        private System.Windows.Forms.TextBox RefreshToken;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button StartOrStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.NumericUpDown DecimalPlaces;
        public System.Windows.Forms.Label label2;
    }
}

