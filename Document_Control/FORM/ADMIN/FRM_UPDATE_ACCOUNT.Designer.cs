namespace Document_Control.FORM.ADMIN
{
    partial class FRM_UPDATE_ACCOUNT
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
            this.txtNhaMay = new System.Windows.Forms.ComboBox();
            this.txtBoPhan = new System.Windows.Forms.ComboBox();
            this.txtQuyen = new System.Windows.Forms.ComboBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNhaMay
            // 
            this.txtNhaMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNhaMay.FormattingEnabled = true;
            this.txtNhaMay.Items.AddRange(new object[] {
            "F1",
            "F2"});
            this.txtNhaMay.Location = new System.Drawing.Point(185, 115);
            this.txtNhaMay.Name = "txtNhaMay";
            this.txtNhaMay.Size = new System.Drawing.Size(148, 21);
            this.txtNhaMay.TabIndex = 80;
            // 
            // txtBoPhan
            // 
            this.txtBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoPhan.FormattingEnabled = true;
            this.txtBoPhan.Location = new System.Drawing.Point(185, 88);
            this.txtBoPhan.Name = "txtBoPhan";
            this.txtBoPhan.Size = new System.Drawing.Size(148, 21);
            this.txtBoPhan.TabIndex = 79;
            // 
            // txtQuyen
            // 
            this.txtQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQuyen.FormattingEnabled = true;
            this.txtQuyen.Location = new System.Drawing.Point(185, 142);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(148, 21);
            this.txtQuyen.TabIndex = 76;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 21);
            this.btnClose.TabIndex = 78;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 21);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Nhà máy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Bộ phận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tên nv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Mã NV:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(185, 61);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(148, 21);
            this.txtTen.TabIndex = 74;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(185, 34);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(148, 21);
            this.txtMaNV.TabIndex = 69;
            // 
            // FRM_UPDATE_ACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 267);
            this.Controls.Add(this.txtNhaMay);
            this.Controls.Add(this.txtBoPhan);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaNV);
            this.Name = "FRM_UPDATE_ACCOUNT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_UPDATE_ACCOUNT";
            this.Load += new System.EventHandler(this.FRM_UPDATE_ACCOUNT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtNhaMay;
        private System.Windows.Forms.ComboBox txtBoPhan;
        private System.Windows.Forms.ComboBox txtQuyen;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaNV;
    }
}