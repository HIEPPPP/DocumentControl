namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    partial class FRM_LIST_FORM
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LIST_FORM));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FORM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FORM_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AttachFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).BeginInit();
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
            this.gcData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnFile});
            this.gcData.Size = new System.Drawing.Size(874, 492);
            this.gcData.TabIndex = 71;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FORM_NAME,
            this.FORM_NO,
            this.AttachFile});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsNavigation.AutoFocusNewRow = true;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.RowAutoHeight = true;
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // FORM_NAME
            // 
            this.FORM_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.FORM_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FORM_NAME.Caption = "Tên form";
            this.FORM_NAME.FieldName = "FORM_NAME";
            this.FORM_NAME.Name = "FORM_NAME";
            this.FORM_NAME.Visible = true;
            this.FORM_NAME.VisibleIndex = 0;
            this.FORM_NAME.Width = 359;
            // 
            // FORM_NO
            // 
            this.FORM_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.FORM_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FORM_NO.Caption = "Form No";
            this.FORM_NO.FieldName = "FORM_NO";
            this.FORM_NO.Name = "FORM_NO";
            this.FORM_NO.OptionsColumn.AllowEdit = false;
            this.FORM_NO.Visible = true;
            this.FORM_NO.VisibleIndex = 1;
            this.FORM_NO.Width = 418;
            // 
            // AttachFile
            // 
            this.AttachFile.ColumnEdit = this.btnFile;
            this.AttachFile.Name = "AttachFile";
            this.AttachFile.Visible = true;
            this.AttachFile.VisibleIndex = 2;
            this.AttachFile.Width = 38;
            // 
            // btnFile
            // 
            this.btnFile.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnFile.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.ContextImageOptions.Image")));
            this.btnFile.Name = "btnFile";
            this.btnFile.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 26);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_LIST_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gcData);
            this.MaximumSize = new System.Drawing.Size(900, 609);
            this.MinimumSize = new System.Drawing.Size(900, 609);
            this.Name = "FRM_LIST_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Form";
            this.Load += new System.EventHandler(this.FRM_LIST_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn FORM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn FORM_NO;
        private DevExpress.XtraGrid.Columns.GridColumn AttachFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFile;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}