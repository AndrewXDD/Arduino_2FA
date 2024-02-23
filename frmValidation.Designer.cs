
namespace Arduino_2FA
{
    partial class frmValidation
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidation));
            this.lblUserCode = new System.Windows.Forms.Label();
            this.txtCodiUsuari = new System.Windows.Forms.TextBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lblSequenceCode = new System.Windows.Forms.Label();
            this.lblReaderQR = new System.Windows.Forms.Label();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.lblHeadTitle = new System.Windows.Forms.Label();
            this.btnCheckQR = new System.Windows.Forms.Button();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClosed = new System.Windows.Forms.PictureBox();
            this.txtNomComplertUsuari = new System.Windows.Forms.TextBox();
            this.txtSequenceCode = new System.Windows.Forms.TextBox();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Location = new System.Drawing.Point(358, 99);
            this.lblUserCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(83, 17);
            this.lblUserCode.TabIndex = 0;
            this.lblUserCode.Text = "User Name:";
            // 
            // txtCodiUsuari
            // 
            this.txtCodiUsuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodiUsuari.Location = new System.Drawing.Point(449, 96);
            this.txtCodiUsuari.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodiUsuari.Name = "txtCodiUsuari";
            this.txtCodiUsuari.Size = new System.Drawing.Size(64, 22);
            this.txtCodiUsuari.TabIndex = 1;
            // 
            // txtQRCode
            // 
            this.txtQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQRCode.Enabled = false;
            this.txtQRCode.Location = new System.Drawing.Point(651, 190);
            this.txtQRCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(181, 329);
            this.txtQRCode.TabIndex = 2;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(695, 96);
            this.btnShowInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(137, 42);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lblSequenceCode
            // 
            this.lblSequenceCode.AutoSize = true;
            this.lblSequenceCode.Font = new System.Drawing.Font("Lucida Bright", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblSequenceCode.Location = new System.Drawing.Point(17, 170);
            this.lblSequenceCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSequenceCode.Name = "lblSequenceCode";
            this.lblSequenceCode.Size = new System.Drawing.Size(166, 16);
            this.lblSequenceCode.TabIndex = 8;
            this.lblSequenceCode.Text = "Code Chain Sequence";
            // 
            // lblReaderQR
            // 
            this.lblReaderQR.AutoSize = true;
            this.lblReaderQR.Font = new System.Drawing.Font("Lucida Bright", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblReaderQR.Location = new System.Drawing.Point(208, 170);
            this.lblReaderQR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderQR.Name = "lblReaderQR";
            this.lblReaderQR.Size = new System.Drawing.Size(84, 16);
            this.lblReaderQR.TabIndex = 9;
            this.lblReaderQR.Text = "QR Reader";
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Lucida Bright", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblQRCode.Location = new System.Drawing.Point(647, 170);
            this.lblQRCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(134, 16);
            this.lblQRCode.TabIndex = 10;
            this.lblQRCode.Text = "Code Chain in QR";
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.AutoSize = true;
            this.lblHeadTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadTitle.Location = new System.Drawing.Point(18, 35);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadTitle.Name = "lblHeadTitle";
            this.lblHeadTitle.Size = new System.Drawing.Size(571, 34);
            this.lblHeadTitle.TabIndex = 11;
            this.lblHeadTitle.Text = "CODE CHAIN VALIDATION  SYSTEM";
            // 
            // btnCheckQR
            // 
            this.btnCheckQR.Location = new System.Drawing.Point(211, 537);
            this.btnCheckQR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckQR.Name = "btnCheckQR";
            this.btnCheckQR.Size = new System.Drawing.Size(182, 62);
            this.btnCheckQR.TabIndex = 13;
            this.btnCheckQR.Text = "Check Code Chain";
            this.btnCheckQR.UseVisualStyleBackColor = true;
            this.btnCheckQR.Click += new System.EventHandler(this.btn_CheckQR_Click);
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamera.Location = new System.Drawing.Point(211, 190);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(433, 329);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamera.TabIndex = 14;
            this.pictureBoxCamera.TabStop = false;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(21, 99);
            this.lblCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(61, 17);
            this.lblCamera.TabIndex = 15;
            this.lblCamera.Text = "Camera:";
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(89, 96);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(229, 24);
            this.cmbDevice.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClosed
            // 
            this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosed.BackColor = System.Drawing.Color.Transparent;
            this.btnClosed.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.Image")));
            this.btnClosed.Location = new System.Drawing.Point(823, 0);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(30, 34);
            this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosed.TabIndex = 24;
            this.btnClosed.TabStop = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // txtNomComplertUsuari
            // 
            this.txtNomComplertUsuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomComplertUsuari.Enabled = false;
            this.txtNomComplertUsuari.Location = new System.Drawing.Point(521, 96);
            this.txtNomComplertUsuari.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomComplertUsuari.Name = "txtNomComplertUsuari";
            this.txtNomComplertUsuari.Size = new System.Drawing.Size(158, 22);
            this.txtNomComplertUsuari.TabIndex = 25;
            // 
            // txtSequenceCode
            // 
            this.txtSequenceCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSequenceCode.Location = new System.Drawing.Point(20, 190);
            this.txtSequenceCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSequenceCode.Multiline = true;
            this.txtSequenceCode.Name = "txtSequenceCode";
            this.txtSequenceCode.Size = new System.Drawing.Size(181, 329);
            this.txtSequenceCode.TabIndex = 26;
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(401, 537);
            this.btnGenerateQR.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(182, 62);
            this.btnGenerateQR.TabIndex = 27;
            this.btnGenerateQR.Text = "Generate QR";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // frmValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 615);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.txtSequenceCode);
            this.Controls.Add(this.txtNomComplertUsuari);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.pictureBoxCamera);
            this.Controls.Add(this.lblHeadTitle);
            this.Controls.Add(this.lblQRCode);
            this.Controls.Add(this.lblReaderQR);
            this.Controls.Add(this.lblSequenceCode);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.txtCodiUsuari);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.btnCheckQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmValidation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmValidation_FormClosing);
            this.Load += new System.EventHandler(this.frmValidation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.TextBox txtCodiUsuari;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lblSequenceCode;
        private System.Windows.Forms.Label lblReaderQR;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.Label lblHeadTitle;
        private System.Windows.Forms.Button btnCheckQR;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnClosed;
        private System.Windows.Forms.TextBox txtNomComplertUsuari;
        private System.Windows.Forms.TextBox txtSequenceCode;
        private System.Windows.Forms.Button btnGenerateQR;
    }
}

