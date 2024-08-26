namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    partial class FRM_DEPLOYMENT_STATUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DEPLOYMENT_STATUS));
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.DEPLOYMENT_SECTION = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ID_STATUS_CON_F1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rptDataStatus = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_STATUS_CON_F2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ID_STATUS_TER = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDueDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.txtRev = new System.Windows.Forms.TextBox();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.btnMGRApproved = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnQApproved = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDataStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gcData.Location = new System.Drawing.Point(6, 20);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptDataStatus});
            this.gcData.Size = new System.Drawing.Size(883, 417);
            this.gcData.TabIndex = 69;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvData.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ID_STATUS_CON_F1,
            this.DEPLOYMENT_SECTION,
            this.ID_STATUS_CON_F2,
            this.ID_STATUS_TER});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsNavigation.AutoFocusNewRow = true;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.RowAutoHeight = true;
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvData_RowCellStyle);
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.DEPLOYMENT_SECTION);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 210;
            // 
            // DEPLOYMENT_SECTION
            // 
            this.DEPLOYMENT_SECTION.AppearanceCell.Options.UseTextOptions = true;
            this.DEPLOYMENT_SECTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEPLOYMENT_SECTION.AppearanceHeader.Options.UseTextOptions = true;
            this.DEPLOYMENT_SECTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEPLOYMENT_SECTION.Caption = "Bộ phận cần triển khai";
            this.DEPLOYMENT_SECTION.FieldName = "DEPLOYMENT_SECTION";
            this.DEPLOYMENT_SECTION.Name = "DEPLOYMENT_SECTION";
            this.DEPLOYMENT_SECTION.OptionsColumn.AllowEdit = false;
            this.DEPLOYMENT_SECTION.Visible = true;
            this.DEPLOYMENT_SECTION.Width = 210;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Tình trạng triển khai";
            this.gridBand2.Columns.Add(this.ID_STATUS_CON_F1);
            this.gridBand2.Columns.Add(this.ID_STATUS_CON_F2);
            this.gridBand2.Columns.Add(this.ID_STATUS_TER);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 622;
            // 
            // ID_STATUS_CON_F1
            // 
            this.ID_STATUS_CON_F1.AppearanceCell.Options.UseTextOptions = true;
            this.ID_STATUS_CON_F1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_STATUS_CON_F1.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_STATUS_CON_F1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_STATUS_CON_F1.Caption = "Connector ở nhà máy 1";
            this.ID_STATUS_CON_F1.ColumnEdit = this.rptDataStatus;
            this.ID_STATUS_CON_F1.FieldName = "ID_STATUS_CON_F1";
            this.ID_STATUS_CON_F1.Name = "ID_STATUS_CON_F1";
            this.ID_STATUS_CON_F1.OptionsColumn.AllowEdit = false;
            this.ID_STATUS_CON_F1.Visible = true;
            this.ID_STATUS_CON_F1.Width = 217;
            // 
            // rptDataStatus
            // 
            this.rptDataStatus.AutoHeight = false;
            this.rptDataStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptDataStatus.Name = "rptDataStatus";
            this.rptDataStatus.NullText = "";
            this.rptDataStatus.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ID_STATUS_CON_F2
            // 
            this.ID_STATUS_CON_F2.AppearanceCell.Options.UseTextOptions = true;
            this.ID_STATUS_CON_F2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_STATUS_CON_F2.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_STATUS_CON_F2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_STATUS_CON_F2.Caption = "Connector ở nhà máy 2";
            this.ID_STATUS_CON_F2.ColumnEdit = this.rptDataStatus;
            this.ID_STATUS_CON_F2.FieldName = "ID_STATUS_CON_F2";
            this.ID_STATUS_CON_F2.Name = "ID_STATUS_CON_F2";
            this.ID_STATUS_CON_F2.OptionsColumn.AllowEdit = false;
            this.ID_STATUS_CON_F2.Visible = true;
            this.ID_STATUS_CON_F2.Width = 208;
            // 
            // ID_STATUS_TER
            // 
            this.ID_STATUS_TER.AppearanceCell.Options.UseTextOptions = true;
            this.ID_STATUS_TER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_STATUS_TER.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_STATUS_TER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_STATUS_TER.Caption = "Terminal";
            this.ID_STATUS_TER.ColumnEdit = this.rptDataStatus;
            this.ID_STATUS_TER.FieldName = "ID_STATUS_TER";
            this.ID_STATUS_TER.Name = "ID_STATUS_TER";
            this.ID_STATUS_TER.OptionsColumn.AllowEdit = false;
            this.ID_STATUS_TER.Visible = true;
            this.ID_STATUS_TER.Width = 197;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDueDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDocumentName);
            this.groupBox1.Controls.Add(this.txtRev);
            this.groupBox1.Controls.Add(this.txtDocumentNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 106);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài liệu";
            // 
            // txtDueDate
            // 
            this.txtDueDate.EditValue = null;
            this.txtDueDate.Location = new System.Drawing.Point(550, 70);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDate.Properties.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(278, 20);
            this.txtDueDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời hạn triển khai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rev:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Doc. No:";
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.Location = new System.Drawing.Point(550, 30);
            this.txtDocumentName.Multiline = true;
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.ReadOnly = true;
            this.txtDocumentName.Size = new System.Drawing.Size(278, 21);
            this.txtDocumentName.TabIndex = 0;
            // 
            // txtRev
            // 
            this.txtRev.Location = new System.Drawing.Point(107, 66);
            this.txtRev.Name = "txtRev";
            this.txtRev.ReadOnly = true;
            this.txtRev.Size = new System.Drawing.Size(244, 21);
            this.txtRev.TabIndex = 0;
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(107, 30);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.ReadOnly = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(244, 21);
            this.txtDocumentNo.TabIndex = 0;
            // 
            // btnMGRApproved
            // 
            this.btnMGRApproved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMGRApproved.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMGRApproved.Appearance.Options.UseFont = true;
            this.btnMGRApproved.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMGRApproved.ImageOptions.Image")));
            this.btnMGRApproved.Location = new System.Drawing.Point(16, 20);
            this.btnMGRApproved.Name = "btnMGRApproved";
            this.btnMGRApproved.Size = new System.Drawing.Size(125, 55);
            this.btnMGRApproved.TabIndex = 72;
            this.btnMGRApproved.Text = "MGR phê duyệt";
            this.btnMGRApproved.Click += new System.EventHandler(this.btnNMGApproved_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnQApproved);
            this.groupBox2.Controls.Add(this.btnMGRApproved);
            this.groupBox2.Location = new System.Drawing.Point(12, 565);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 88);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(278, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 55);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQApproved
            // 
            this.btnQApproved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQApproved.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQApproved.Appearance.Options.UseFont = true;
            this.btnQApproved.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQApproved.ImageOptions.Image")));
            this.btnQApproved.Location = new System.Drawing.Point(147, 20);
            this.btnQApproved.Name = "btnQApproved";
            this.btnQApproved.Size = new System.Drawing.Size(125, 55);
            this.btnQApproved.TabIndex = 72;
            this.btnQApproved.Text = "QA Phê duyệt";
            this.btnQApproved.Click += new System.EventHandler(this.btnQApproved_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gcData);
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(895, 443);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình trạng triển khai";
            // 
            // FRM_DEPLOYMENT_STATUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 659);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_DEPLOYMENT_STATUS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bộ phận triển khai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_DEPLOYMENT_STATUS_FormClosed);
            this.Load += new System.EventHandler(this.FRM_DEPLOYMENT_STATUS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDataStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDocumentName;
        private System.Windows.Forms.TextBox txtRev;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit txtDueDate;
        private DevExpress.XtraEditors.SimpleButton btnMGRApproved;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnQApproved;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rptDataStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvData;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DEPLOYMENT_SECTION;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ID_STATUS_CON_F1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ID_STATUS_CON_F2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ID_STATUS_TER;
    }
}