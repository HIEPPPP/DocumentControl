namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    partial class FRM_SELECT_SECTION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SELECT_SECTION));
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.SECTION_SHORT_NAME = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gcData.Location = new System.Drawing.Point(12, 12);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(565, 454);
            this.gcData.TabIndex = 69;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            this.gcData.Click += new System.EventHandler(this.gcData_Click);
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvData.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.SECTION_SHORT_NAME,
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsNavigation.AutoFocusNewRow = true;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvData.OptionsSelection.MultiSelect = true;
            this.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.RowAutoHeight = true;
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.SECTION_SHORT_NAME);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 193;
            // 
            // SECTION_SHORT_NAME
            // 
            this.SECTION_SHORT_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.SECTION_SHORT_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SECTION_SHORT_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.SECTION_SHORT_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SECTION_SHORT_NAME.Caption = "Bộ phận";
            this.SECTION_SHORT_NAME.FieldName = "SECTION_SHORT_NAME";
            this.SECTION_SHORT_NAME.Name = "SECTION_SHORT_NAME";
            this.SECTION_SHORT_NAME.Visible = true;
            this.SECTION_SHORT_NAME.Width = 193;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Mảng sản xuất";
            this.gridBand2.Columns.Add(this.bandedGridColumn1);
            this.gridBand2.Columns.Add(this.bandedGridColumn2);
            this.gridBand2.Columns.Add(this.bandedGridColumn3);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 282;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn1.Caption = "Connector F1";
            this.bandedGridColumn1.FieldName = "CONNECTOR_F1";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 94;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn2.Caption = "Connector F2";
            this.bandedGridColumn2.FieldName = "CONNECTOR_F2";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.Width = 94;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn3.Caption = "Terminal";
            this.bandedGridColumn3.FieldName = "TERMINAL";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.Width = 94;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(12, 475);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 27);
            this.btnOK.TabIndex = 70;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(95, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 27);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_SELECT_SECTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 522);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gcData);
            this.MinimumSize = new System.Drawing.Size(430, 554);
            this.Name = "FRM_SELECT_SECTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn bộ phận cần triển khai";
            this.Load += new System.EventHandler(this.FRM_SELECT_SECTION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvData;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SECTION_SHORT_NAME;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
    }
}