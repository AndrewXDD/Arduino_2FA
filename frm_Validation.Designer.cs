
namespace Arduino_2FA
{
    partial class frm_Validation
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
            this.lbl_UserCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_ShowInfo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_HeadTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CheckQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserCode
            // 
            this.lbl_UserCode.AutoSize = true;
            this.lbl_UserCode.Location = new System.Drawing.Point(145, 159);
            this.lbl_UserCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserCode.Name = "lbl_UserCode";
            this.lbl_UserCode.Size = new System.Drawing.Size(75, 17);
            this.lbl_UserCode.TabIndex = 0;
            this.lbl_UserCode.Text = "User Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 155);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 155);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btn_ShowInfo
            // 
            this.btn_ShowInfo.Location = new System.Drawing.Point(493, 145);
            this.btn_ShowInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ShowInfo.Name = "btn_ShowInfo";
            this.btn_ShowInfo.Size = new System.Drawing.Size(137, 42);
            this.btn_ShowInfo.TabIndex = 3;
            this.btn_ShowInfo.Text = "Show Info";
            this.btn_ShowInfo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(112, 235);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 329);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(699, 235);
            this.listView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(180, 329);
            this.listView3.TabIndex = 6;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(336, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 329);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code Viewer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "QR Viewer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Algo Viewer";
            // 
            // lbl_HeadTitle
            // 
            this.lbl_HeadTitle.AutoSize = true;
            this.lbl_HeadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadTitle.Location = new System.Drawing.Point(241, 60);
            this.lbl_HeadTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeadTitle.Name = "lbl_HeadTitle";
            this.lbl_HeadTitle.Size = new System.Drawing.Size(439, 42);
            this.lbl_HeadTitle.TabIndex = 11;
            this.lbl_HeadTitle.Text = "Sistema de validació 2FA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(168, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 55);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_CheckQR
            // 
            this.btn_CheckQR.Location = new System.Drawing.Point(633, 585);
            this.btn_CheckQR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CheckQR.Name = "btn_CheckQR";
            this.btn_CheckQR.Size = new System.Drawing.Size(247, 62);
            this.btn_CheckQR.TabIndex = 13;
            this.btn_CheckQR.Text = "Check Code Chain";
            this.btn_CheckQR.UseVisualStyleBackColor = true;
            // 
            // frm_Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_HeadTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_ShowInfo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_UserCode);
            this.Controls.Add(this.btn_CheckQR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Validation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_ShowInfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_HeadTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CheckQR;
    }
}

