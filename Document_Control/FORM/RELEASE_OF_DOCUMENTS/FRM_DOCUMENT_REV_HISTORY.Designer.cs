namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    partial class FRM_DOCUMENT_REV_HISTORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DOCUMENT_REV_HISTORY));
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DUE_DATE_DEPLOYMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPLOYMENT_SECTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FILE_DOCUMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_HIGHT_LEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT_LEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CONTENT_REVISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1189, 42);
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
            this.textBox2.Location = new System.Drawing.Point(1250, 40);
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
            this.label3.Location = new System.Drawing.Point(1189, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Record";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecord);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Location = new System.Drawing.Point(12, 647);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 68);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // txtRecord
            // 
            this.txtRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRecord.Location = new System.Drawing.Point(1250, 14);
            this.txtRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ReadOnly = true;
            this.txtRecord.Size = new System.Drawing.Size(101, 21);
            this.txtRecord.TabIndex = 71;
            this.txtRecord.TabStop = false;
            this.txtRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(183, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 28);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(100, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 28);
            this.btnRefresh.TabIndex = 69;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(17, 23);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 28);
            this.btnDel.TabIndex = 69;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.NOTE.VisibleIndex = 10;
            this.NOTE.Width = 104;
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
            this.DUE_DATE_DEPLOYMENT.VisibleIndex = 8;
            this.DUE_DATE_DEPLOYMENT.Width = 161;
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
            this.DEPLOYMENT_SECTION.VisibleIndex = 7;
            this.DEPLOYMENT_SECTION.Width = 167;
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
            this.FORM.VisibleIndex = 6;
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
            this.DOCUMENT_NAME.VisibleIndex = 2;
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
            this.REV.VisibleIndex = 3;
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
            this.FILE_DOCUMENT.VisibleIndex = 4;
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
            this.DOCUMENT_HIGHT_LEVEL.VisibleIndex = 5;
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
            this.DOCUMENT_NO.VisibleIndex = 1;
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
            this.DOCUMENT_LEVEL.VisibleIndex = 0;
            this.DOCUMENT_LEVEL.Width = 103;
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.CONTENT_REVISE.VisibleIndex = 9;
            this.CONTENT_REVISE.Width = 217;
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gcData.Location = new System.Drawing.Point(12, 20);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1360, 621);
            this.gcData.TabIndex = 71;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // FRM_DOCUMENT_REV_HISTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcData);
            this.Name = "FRM_DOCUMENT_REV_HISTORY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử sửa đổi";
            this.Load += new System.EventHandler(this.FRM_DOCUMENT_REV_HISTORY_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecord;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn NOTE;
        private DevExpress.XtraGrid.Columns.GridColumn DUE_DATE_DEPLOYMENT;
        private DevExpress.XtraGrid.Columns.GridColumn DEPLOYMENT_SECTION;
        private DevExpress.XtraGrid.Columns.GridColumn FORM;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn REV;
        private DevExpress.XtraGrid.Columns.GridColumn FILE_DOCUMENT;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_HIGHT_LEVEL;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT_LEVEL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn CONTENT_REVISE;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraEditors.SimpleButton btnDel;
    }
}