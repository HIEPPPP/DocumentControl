namespace Document_Control.FORM.ADMIN
{
    partial class FRM_ADD_ACCESS_MANGER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_ACCESS_MANGER));
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhaMay = new System.Windows.Forms.TextBox();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_MANAGER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSectionAdd = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoPhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(578, 33);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.ReadOnly = true;
            this.txtQuyen.Size = new System.Drawing.Size(133, 21);
            this.txtQuyen.TabIndex = 91;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(740, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 61);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNhaMay
            // 
            this.txtNhaMay.Location = new System.Drawing.Point(293, 73);
            this.txtNhaMay.Name = "txtNhaMay";
            this.txtNhaMay.ReadOnly = true;
            this.txtNhaMay.Size = new System.Drawing.Size(133, 21);
            this.txtNhaMay.TabIndex = 85;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Bộ phận được phê duyệt";
            this.gridColumn3.FieldName = "SECTION_SHORT_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 400;
            // 
            // FULLNAME
            // 
            this.FULLNAME.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.FULLNAME.AppearanceHeader.Options.UseForeColor = true;
            this.FULLNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.FULLNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FULLNAME.Caption = "Tên NV";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 1;
            this.FULLNAME.Width = 330;
            // 
            // ID_MANAGER
            // 
            this.ID_MANAGER.AppearanceCell.Options.UseTextOptions = true;
            this.ID_MANAGER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_MANAGER.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.ID_MANAGER.AppearanceHeader.Options.UseForeColor = true;
            this.ID_MANAGER.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_MANAGER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_MANAGER.Caption = "Mã NV";
            this.ID_MANAGER.FieldName = "ID_MANAGER";
            this.ID_MANAGER.Name = "ID_MANAGER";
            this.ID_MANAGER.Visible = true;
            this.ID_MANAGER.VisibleIndex = 0;
            this.ID_MANAGER.Width = 140;
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_MANAGER,
            this.FULLNAME,
            this.gridColumn3});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvData.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcData.Location = new System.Drawing.Point(12, 164);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(852, 397);
            this.gcData.TabIndex = 98;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtQuyen);
            this.groupBox1.Controls.Add(this.txtSectionAdd);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtNhaMay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoPhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 113);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // txtSectionAdd
            // 
            this.txtSectionAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSectionAdd.FormattingEnabled = true;
            this.txtSectionAdd.Location = new System.Drawing.Point(578, 73);
            this.txtSectionAdd.Name = "txtSectionAdd";
            this.txtSectionAdd.Size = new System.Drawing.Size(133, 21);
            this.txtSectionAdd.TabIndex = 92;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(69, 40);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(133, 21);
            this.txtMaNV.TabIndex = 82;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Mã NV";
            // 
            // txtBoPhan
            // 
            this.txtBoPhan.Location = new System.Drawing.Point(293, 40);
            this.txtBoPhan.Name = "txtBoPhan";
            this.txtBoPhan.ReadOnly = true;
            this.txtBoPhan.Size = new System.Drawing.Size(133, 21);
            this.txtBoPhan.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Tên ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(69, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(133, 21);
            this.txtTen.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Bộ phận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Nhà máy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "Phê duyệt bộ phận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 33);
            this.label7.TabIndex = 96;
            this.label7.Text = "Thêm quyền phê duyệt";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(12, 573);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 28);
            this.btnDel.TabIndex = 100;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(95, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 28);
            this.btnClose.TabIndex = 101;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_ADD_ACCESS_MANGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 625);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.MaximumSize = new System.Drawing.Size(878, 657);
            this.MinimumSize = new System.Drawing.Size(878, 657);
            this.Name = "FRM_ADD_ACCESS_MANGER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm quyền phê duyệt";
            this.Load += new System.EventHandler(this.FRM_ADD_ACCESS_MANGER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuyen;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtNhaMay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraGrid.Columns.GridColumn ID_MANAGER;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.GridControl gcData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtSectionAdd;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoPhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}