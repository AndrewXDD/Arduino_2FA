
namespace Arduino_2FA
{
    partial class frm_Central
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitol = new System.Windows.Forms.Label();
            this.txtCoordinate = new System.Windows.Forms.TextBox();
            this.txtCoordinateCode = new System.Windows.Forms.TextBox();
            this.lblCentralAuthentication = new System.Windows.Forms.Label();
            this.lblBaseAuthentication = new System.Windows.Forms.Label();
            this.pictureBoxImage1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCoordinate = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblCoordinateCode = new System.Windows.Forms.Label();
            this.txtOTPCode1 = new System.Windows.Forms.TextBox();
            this.txtOTPCode2 = new System.Windows.Forms.TextBox();
            this.lblOtpCode = new System.Windows.Forms.Label();
            this.pictureBoxImage2 = new System.Windows.Forms.PictureBox();
            this.lblMissatge = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPorts = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 109);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitol
            // 
            this.lblTitol.AutoSize = true;
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lblTitol.Location = new System.Drawing.Point(23, 22);
            this.lblTitol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(138, 42);
            this.lblTitol.TabIndex = 1;
            this.lblTitol.Text = "Central";
            // 
            // txtCoordinate
            // 
            this.txtCoordinate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoordinate.Location = new System.Drawing.Point(365, 124);
            this.txtCoordinate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinate.Name = "txtCoordinate";
            this.txtCoordinate.Size = new System.Drawing.Size(111, 22);
            this.txtCoordinate.TabIndex = 2;
            // 
            // txtCoordinateCode
            // 
            this.txtCoordinateCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoordinateCode.Location = new System.Drawing.Point(365, 154);
            this.txtCoordinateCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinateCode.Name = "txtCoordinateCode";
            this.txtCoordinateCode.Size = new System.Drawing.Size(111, 22);
            this.txtCoordinateCode.TabIndex = 3;
            // 
            // lblCentralAuthentication
            // 
            this.lblCentralAuthentication.AutoSize = true;
            this.lblCentralAuthentication.Location = new System.Drawing.Point(208, 99);
            this.lblCentralAuthentication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCentralAuthentication.Name = "lblCentralAuthentication";
            this.lblCentralAuthentication.Size = new System.Drawing.Size(196, 17);
            this.lblCentralAuthentication.TabIndex = 4;
            this.lblCentralAuthentication.Text = "CENTRAL AUTHENTICATION";
            // 
            // lblBaseAuthentication
            // 
            this.lblBaseAuthentication.AutoSize = true;
            this.lblBaseAuthentication.Location = new System.Drawing.Point(208, 202);
            this.lblBaseAuthentication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseAuthentication.Name = "lblBaseAuthentication";
            this.lblBaseAuthentication.Size = new System.Drawing.Size(168, 17);
            this.lblBaseAuthentication.TabIndex = 5;
            this.lblBaseAuthentication.Text = "BASE AUTHENTICATION";
            // 
            // pictureBoxImage1
            // 
            this.pictureBoxImage1.Location = new System.Drawing.Point(593, 127);
            this.pictureBoxImage1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImage1.Name = "pictureBoxImage1";
            this.pictureBoxImage1.Size = new System.Drawing.Size(51, 49);
            this.pictureBoxImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage1.TabIndex = 7;
            this.pictureBoxImage1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // lblCoordinate
            // 
            this.lblCoordinate.AutoSize = true;
            this.lblCoordinate.Location = new System.Drawing.Point(280, 127);
            this.lblCoordinate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinate.Name = "lblCoordinate";
            this.lblCoordinate.Size = new System.Drawing.Size(77, 17);
            this.lblCoordinate.TabIndex = 11;
            this.lblCoordinate.Text = "Coordinate";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(484, 144);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(81, 32);
            this.btnVerify.TabIndex = 12;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // lblCoordinateCode
            // 
            this.lblCoordinateCode.AutoSize = true;
            this.lblCoordinateCode.Location = new System.Drawing.Point(245, 154);
            this.lblCoordinateCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateCode.Name = "lblCoordinateCode";
            this.lblCoordinateCode.Size = new System.Drawing.Size(112, 17);
            this.lblCoordinateCode.TabIndex = 13;
            this.lblCoordinateCode.Text = "Coordinate code";
            // 
            // txtOTPCode1
            // 
            this.txtOTPCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTPCode1.Enabled = false;
            this.txtOTPCode1.Location = new System.Drawing.Point(365, 225);
            this.txtOTPCode1.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTPCode1.Name = "txtOTPCode1";
            this.txtOTPCode1.Size = new System.Drawing.Size(111, 22);
            this.txtOTPCode1.TabIndex = 14;
            // 
            // txtOTPCode2
            // 
            this.txtOTPCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTPCode2.Enabled = false;
            this.txtOTPCode2.Location = new System.Drawing.Point(365, 255);
            this.txtOTPCode2.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTPCode2.Name = "txtOTPCode2";
            this.txtOTPCode2.Size = new System.Drawing.Size(111, 22);
            this.txtOTPCode2.TabIndex = 15;
            // 
            // lblOtpCode
            // 
            this.lblOtpCode.AutoSize = true;
            this.lblOtpCode.Location = new System.Drawing.Point(285, 257);
            this.lblOtpCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtpCode.Name = "lblOtpCode";
            this.lblOtpCode.Size = new System.Drawing.Size(72, 17);
            this.lblOtpCode.TabIndex = 16;
            this.lblOtpCode.Text = "OTP code";
            // 
            // pictureBoxImage2
            // 
            this.pictureBoxImage2.Location = new System.Drawing.Point(593, 230);
            this.pictureBoxImage2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImage2.Name = "pictureBoxImage2";
            this.pictureBoxImage2.Size = new System.Drawing.Size(51, 49);
            this.pictureBoxImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage2.TabIndex = 17;
            this.pictureBoxImage2.TabStop = false;
            // 
            // lblMissatge
            // 
            this.lblMissatge.AutoSize = true;
            this.lblMissatge.Location = new System.Drawing.Point(27, 315);
            this.lblMissatge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissatge.Name = "lblMissatge";
            this.lblMissatge.Size = new System.Drawing.Size(78, 17);
            this.lblMissatge.TabIndex = 18;
            this.lblMissatge.Text = "MISSATGE";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(31, 151);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(93, 46);
            this.lblTimer.TabIndex = 19;
            this.lblTimer.Text = "TIMER";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(400, 18);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(116, 17);
            this.lblPorts.TabIndex = 22;
            this.lblPorts.Text = "Ports disponibles";
            // 
            // cmbPorts
            // 
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(403, 39);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(185, 24);
            this.cmbPorts.TabIndex = 21;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(603, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(76, 24);
            this.btnConnect.TabIndex = 20;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frm_Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 356);
            this.Controls.Add(this.lblPorts);
            this.Controls.Add(this.cmbPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMissatge);
            this.Controls.Add(this.pictureBoxImage2);
            this.Controls.Add(this.lblOtpCode);
            this.Controls.Add(this.txtOTPCode2);
            this.Controls.Add(this.txtOTPCode1);
            this.Controls.Add(this.lblCoordinateCode);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblCoordinate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxImage1);
            this.Controls.Add(this.lblBaseAuthentication);
            this.Controls.Add(this.lblCentralAuthentication);
            this.Controls.Add(this.txtCoordinateCode);
            this.Controls.Add(this.txtCoordinate);
            this.Controls.Add(this.lblTitol);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Central";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Central_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.TextBox txtCoordinate;
        private System.Windows.Forms.TextBox txtCoordinateCode;
        private System.Windows.Forms.Label lblCentralAuthentication;
        private System.Windows.Forms.Label lblBaseAuthentication;
        private System.Windows.Forms.PictureBox pictureBoxImage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCoordinate;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblCoordinateCode;
        private System.Windows.Forms.TextBox txtOTPCode1;
        private System.Windows.Forms.TextBox txtOTPCode2;
        private System.Windows.Forms.Label lblOtpCode;
        private System.Windows.Forms.PictureBox pictureBoxImage2;
        private System.Windows.Forms.Label lblMissatge;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnect;
    }
}