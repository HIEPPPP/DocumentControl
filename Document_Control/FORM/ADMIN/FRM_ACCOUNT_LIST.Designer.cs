namespace Document_Control.FORM.ADMIN
{
    partial class FRM_ACCOUNT_LIST
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
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmQuyềnPhêDuyệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Appearance.Options.UseFont = true;
            this.btnChangePassword.Location = new System.Drawing.Point(9, 44);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 56;
            this.btnChangePassword.Text = "Đổi MK";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Location = new System.Drawing.Point(171, 18);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 55;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(756, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mode";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(90, 45);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(817, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(101, 21);
            this.textBox2.TabIndex = 54;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "View";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(90, 18);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(756, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Record";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(9, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRecord
            // 
            this.txtRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRecord.Location = new System.Drawing.Point(817, 21);
            this.txtRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ReadOnly = true;
            this.txtRecord.Size = new System.Drawing.Size(101, 21);
            this.txtRecord.TabIndex = 52;
            this.txtRecord.TabStop = false;
            this.txtRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtRecord);
            this.groupBox1.Location = new System.Drawing.Point(11, 579);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 76);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(867, 50);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 24);
            this.btnRefresh.TabIndex = 63;
            this.btnRefresh.Text = "Refresh";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Quyền";
            this.gridColumn2.FieldName = "ACCESS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 165;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Nhà máy";
            this.gridColumn1.FieldName = "FACTORY";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 119;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Bộ phận";
            this.gridColumn3.FieldName = "SECTION_SHORT_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 140;
            // 
            // NAME
            // 
            this.NAME.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.NAME.AppearanceHeader.Options.UseForeColor = true;
            this.NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAME.Caption = "Tên NV";
            this.NAME.FieldName = "FULLNAME";
            this.NAME.Name = "NAME";
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            this.NAME.Width = 165;
            // 
            // USER_ID
            // 
            this.USER_ID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.USER_ID.AppearanceHeader.Options.UseForeColor = true;
            this.USER_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.USER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.USER_ID.Caption = "Mã NV";
            this.USER_ID.FieldName = "USER_ID";
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.Visible = true;
            this.USER_ID.VisibleIndex = 0;
            this.USER_ID.Width = 113;
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.USER_ID,
            this.NAME,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
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
            this.gcData.Location = new System.Drawing.Point(11, 79);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(925, 490);
            this.gcData.TabIndex = 61;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoTàiKhoảnToolStripMenuItem,
            this.thêmQuyềnPhêDuyệtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Image = global::Document_Control.Properties.Resources.UserGroup_32x32;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Image = global::Document_Control.Properties.Resources.Action_LinkUnlink_Link_32x32;
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo tài khoản";
            this.tạoTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnToolStripMenuItem_Click);
            // 
            // thêmQuyềnPhêDuyệtToolStripMenuItem
            // 
            this.thêmQuyềnPhêDuyệtToolStripMenuItem.Image = global::Document_Control.Properties.Resources.BO_Role_32x32;
            this.thêmQuyềnPhêDuyệtToolStripMenuItem.Name = "thêmQuyềnPhêDuyệtToolStripMenuItem";
            this.thêmQuyềnPhêDuyệtToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.thêmQuyềnPhêDuyệtToolStripMenuItem.Text = "Thêm quyền phê duyệt";
            this.thêmQuyềnPhêDuyệtToolStripMenuItem.Click += new System.EventHandler(this.thêmQuyềnPhêDuyệtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::Document_Control.Properties.Resources.Action_Close;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // FRM_ACCOUNT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_ACCOUNT_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách tài khoản";
            this.Load += new System.EventHandler(this.FRM_ACCOUNT_LIST_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn USER_ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.GridControl gcData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmQuyềnPhêDuyệtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}