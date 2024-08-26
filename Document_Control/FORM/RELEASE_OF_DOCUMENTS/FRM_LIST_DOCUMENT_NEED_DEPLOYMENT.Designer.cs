namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    partial class FRM_LIST_DOCUMENT_NEED_DEPLOYMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LIST_DOCUMENT_NEED_DEPLOYMENT));
            this.txtDocumentType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.btnRev = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONTENT_REVISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DUE_DATE_DEPLOYMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPLOYMENT_SECTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FILE_DOCUMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_HIGHT_LEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_LEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumentType
            // 
            this.txtDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDocumentType.FormattingEnabled = true;
            this.txtDocumentType.Items.AddRange(new object[] {
            "SEWSCV",
            "SWS"});
            this.txtDocumentType.Location = new System.Drawing.Point(125, 7);
            this.txtDocumentType.Name = "txtDocumentType";
            this.txtDocumentType.Size = new System.Drawing.Size(134, 21);
            this.txtDocumentType.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1205, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Mode";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(1266, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(101, 21);
            this.textBox2.TabIndex = 73;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "View";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1205, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Record";
            // 
            // txtRecord
            // 
            this.txtRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRecord.Location = new System.Drawing.Point(1266, 15);
            this.txtRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ReadOnly = true;
            this.txtRecord.Size = new System.Drawing.Size(101, 21);
            this.txtRecord.TabIndex = 71;
            this.txtRecord.TabStop = false;
            this.txtRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRev
            // 
            this.btnRev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRev.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.Appearance.Options.UseFont = true;
            this.btnRev.Enabled = false;
            this.btnRev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRev.ImageOptions.Image")));
            this.btnRev.Location = new System.Drawing.Point(96, 53);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(77, 28);
            this.btnRev.TabIndex = 69;
            this.btnRev.Text = "Rev";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecord);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnRev);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1373, 100);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(96, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 28);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Sửa";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(179, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 28);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Thoát";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(13, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Thêm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(179, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 28);
            this.btnRefresh.TabIndex = 69;
            this.btnRefresh.Text = "Refresh";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Enabled = false;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(13, 53);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 28);
            this.btnDel.TabIndex = 69;
            this.btnDel.Text = "Xóa";
            // 
            // NOTE
            // 
            this.NOTE.AppearanceCell.Options.UseTextOptions = true;
            this.NOTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NOTE.AppearanceHeader.Options.UseTextOptions = true;
            this.NOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NOTE.Caption = "Ghi chú";
            this.NOTE.FieldName = "NOTE";
            this.NOTE.Name = "NOTE";
            this.NOTE.OptionsColumn.AllowEdit = false;
            this.NOTE.Visible = true;
            this.NOTE.VisibleIndex = 11;
            this.NOTE.Width = 104;
            // 
            // CONTENT_REVISE
            // 
            this.CONTENT_REVISE.AppearanceCell.Options.UseTextOptions = true;
            this.CONTENT_REVISE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CONTENT_REVISE.AppearanceHeader.Options.UseTextOptions = true;
            this.CONTENT_REVISE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CONTENT_REVISE.Caption = "Nội dung Revise";
            this.CONTENT_REVISE.FieldName = "CONTENT_REVISE";
            this.CONTENT_REVISE.Name = "CONTENT_REVISE";
            this.CONTENT_REVISE.OptionsColumn.AllowEdit = false;
            this.CONTENT_REVISE.Visible = true;
            this.CONTENT_REVISE.VisibleIndex = 10;
            this.CONTENT_REVISE.Width = 217;
            // 
            // DUE_DATE_DEPLOYMENT
            // 
            this.DUE_DATE_DEPLOYMENT.AppearanceCell.Options.UseTextOptions = true;
            this.DUE_DATE_DEPLOYMENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DUE_DATE_DEPLOYMENT.AppearanceHeader.Options.UseTextOptions = true;
            this.DUE_DATE_DEPLOYMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DUE_DATE_DEPLOYMENT.Caption = "Thời hạn triển khai";
            this.DUE_DATE_DEPLOYMENT.FieldName = "DUE_DATE_DEPLOYMENT";
            this.DUE_DATE_DEPLOYMENT.Name = "DUE_DATE_DEPLOYMENT";
            this.DUE_DATE_DEPLOYMENT.OptionsColumn.AllowEdit = false;
            this.DUE_DATE_DEPLOYMENT.Visible = true;
            this.DUE_DATE_DEPLOYMENT.VisibleIndex = 9;
            this.DUE_DATE_DEPLOYMENT.Width = 161;
            // 
            // DEPLOYMENT_SECTION
            // 
            this.DEPLOYMENT_SECTION.AppearanceCell.Options.UseTextOptions = true;
            this.DEPLOYMENT_SECTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEPLOYMENT_SECTION.AppearanceHeader.Options.UseTextOptions = true;
            this.DEPLOYMENT_SECTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEPLOYMENT_SECTION.Caption = "Bộ phận chưa hoàn thành triển khai";
            this.DEPLOYMENT_SECTION.FieldName = "DEPLOYMENT_SECTION";
            this.DEPLOYMENT_SECTION.Name = "DEPLOYMENT_SECTION";
            this.DEPLOYMENT_SECTION.OptionsColumn.AllowEdit = false;
            this.DEPLOYMENT_SECTION.Visible = true;
            this.DEPLOYMENT_SECTION.VisibleIndex = 8;
            this.DEPLOYMENT_SECTION.Width = 207;
            // 
            // FORM
            // 
            this.FORM.AppearanceCell.Options.UseTextOptions = true;
            this.FORM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FORM.AppearanceHeader.Options.UseTextOptions = true;
            this.FORM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FORM.Caption = "Form";
            this.FORM.FieldName = "FORM";
            this.FORM.Name = "FORM";
            this.FORM.OptionsColumn.AllowEdit = false;
            this.FORM.Visible = true;
            this.FORM.VisibleIndex = 7;
            this.FORM.Width = 137;
            // 
            // DOCUMENT_NAME
            // 
            this.DOCUMENT_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.DOCUMENT_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.DOCUMENT_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_NAME.Caption = "Tên tài liệu";
            this.DOCUMENT_NAME.FieldName = "DOCUMENT_NAME";
            this.DOCUMENT_NAME.Name = "DOCUMENT_NAME";
            this.DOCUMENT_NAME.OptionsColumn.AllowEdit = false;
            this.DOCUMENT_NAME.Visible = true;
            this.DOCUMENT_NAME.VisibleIndex = 3;
            this.DOCUMENT_NAME.Width = 174;
            // 
            // REV
            // 
            this.REV.AppearanceCell.Options.UseTextOptions = true;
            this.REV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.REV.AppearanceHeader.Options.UseTextOptions = true;
            this.REV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.REV.Caption = "Rev";
            this.REV.FieldName = "REV";
            this.REV.Name = "REV";
            this.REV.OptionsColumn.AllowEdit = false;
            this.REV.Visible = true;
            this.REV.VisibleIndex = 4;
            this.REV.Width = 73;
            // 
            // FILE_DOCUMENT
            // 
            this.FILE_DOCUMENT.AppearanceCell.Options.UseTextOptions = true;
            this.FILE_DOCUMENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FILE_DOCUMENT.AppearanceHeader.Options.UseTextOptions = true;
            this.FILE_DOCUMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FILE_DOCUMENT.Caption = "File tài liệu";
            this.FILE_DOCUMENT.FieldName = "FILE_DOCUMENT";
            this.FILE_DOCUMENT.Name = "FILE_DOCUMENT";
            this.FILE_DOCUMENT.OptionsColumn.AllowEdit = false;
            this.FILE_DOCUMENT.Visible = true;
            this.FILE_DOCUMENT.VisibleIndex = 5;
            this.FILE_DOCUMENT.Width = 220;
            // 
            // DOCUMENT_HIGHT_LEVEL
            // 
            this.DOCUMENT_HIGHT_LEVEL.AppearanceCell.Options.UseTextOptions = true;
            this.DOCUMENT_HIGHT_LEVEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_HIGHT_LEVEL.AppearanceHeader.Options.UseTextOptions = true;
            this.DOCUMENT_HIGHT_LEVEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_HIGHT_LEVEL.Caption = "Tài liệu cấp trên";
            this.DOCUMENT_HIGHT_LEVEL.FieldName = "DOCUMENT_HIGHT_LEVEL";
            this.DOCUMENT_HIGHT_LEVEL.Name = "DOCUMENT_HIGHT_LEVEL";
            this.DOCUMENT_HIGHT_LEVEL.Visible = true;
            this.DOCUMENT_HIGHT_LEVEL.VisibleIndex = 6;
            this.DOCUMENT_HIGHT_LEVEL.Width = 119;
            // 
            // DOCUMENT_NO
            // 
            this.DOCUMENT_NO.AppearanceCell.Options.UseTextOptions = true;
            this.DOCUMENT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.DOCUMENT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_NO.Caption = "Control No";
            this.DOCUMENT_NO.FieldName = "DOCUMENT_NO";
            this.DOCUMENT_NO.Name = "DOCUMENT_NO";
            this.DOCUMENT_NO.OptionsColumn.AllowEdit = false;
            this.DOCUMENT_NO.Visible = true;
            this.DOCUMENT_NO.VisibleIndex = 2;
            this.DOCUMENT_NO.Width = 134;
            // 
            // DOCUMENT_LEVEL
            // 
            this.DOCUMENT_LEVEL.AppearanceCell.Options.UseTextOptions = true;
            this.DOCUMENT_LEVEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_LEVEL.AppearanceHeader.Options.UseTextOptions = true;
            this.DOCUMENT_LEVEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_LEVEL.Caption = "Cấp độ tài liệu";
            this.DOCUMENT_LEVEL.FieldName = "DOCUMENT_LEVEL";
            this.DOCUMENT_LEVEL.Name = "DOCUMENT_LEVEL";
            this.DOCUMENT_LEVEL.Visible = true;
            this.DOCUMENT_LEVEL.VisibleIndex = 1;
            this.DOCUMENT_LEVEL.Width = 103;
            // 
            // DOCUMENT_TYPE
            // 
            this.DOCUMENT_TYPE.AppearanceCell.Options.UseTextOptions = true;
            this.DOCUMENT_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.DOCUMENT_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DOCUMENT_TYPE.Caption = "Loại tài liệu";
            this.DOCUMENT_TYPE.FieldName = "DOCUMENT_TYPE";
            this.DOCUMENT_TYPE.Name = "DOCUMENT_TYPE";
            this.DOCUMENT_TYPE.Visible = true;
            this.DOCUMENT_TYPE.VisibleIndex = 0;
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DOCUMENT_TYPE,
            this.DOCUMENT_LEVEL,
            this.DOCUMENT_NO,
            this.DOCUMENT_HIGHT_LEVEL,
            this.FILE_DOCUMENT,
            this.REV,
            this.DOCUMENT_NAME,
            this.FORM,
            this.DEPLOYMENT_SECTION,
            this.DUE_DATE_DEPLOYMENT,
            this.CONTENT_REVISE,
            this.NOTE});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsNavigation.AutoFocusNewRow = true;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.RowAutoHeight = true;
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gcData.Location = new System.Drawing.Point(12, 33);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1373, 520);
            this.gcData.TabIndex = 74;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Loại tài liệu:";
            // 
            // FRM_LIST_DOCUMENT_NEED_DEPLOYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 666);
            this.Controls.Add(this.txtDocumentType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcData);
            this.Name = "FRM_LIST_DOCUMENT_NEED_DEPLOYMENT";
            this.Text = "Danh sách tài liệu đang cần triển khai";
            this.Load += new System.EventHandler(this.FRM_LIST_DOCUMENT_NEED_DEPLOYMENT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtDocumentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecord;
        private DevExpress.XtraEditors.SimpleButton btnRev;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn NOTE;
        private DevExpress.XtraGrid.Columns.GridColumn CONTENT_REVISE;
        private DevExpress.XtraGrid.Columns.GridColumn DUE_DATE_DEPLOYMENT;
        private DevExpress.XtraGrid.Columns.GridColumn DEPLOYMENT_SECTION;
        private DevExpress.XtraGrid.Columns.GridColumn FORM;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn REV;
        private DevExpress.XtraGrid.Columns.GridColumn FILE_DOCUMENT;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_HIGHT_LEVEL;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_LEVEL;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_TYPE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.GridControl gcData;
        private System.Windows.Forms.Label label1;
    }
}