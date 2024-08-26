namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    partial class FRM_ADD_DOCUMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_DOCUMENT));
            this.txtDocumentLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.txtContentResive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeploymentSection = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAttachFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFile = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRev = new System.Windows.Forms.TextBox();
            this.btnAttachForm = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDeployment = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtContentDetail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.tbnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDocumentHightLv = new DevExpress.XtraEditors.GridLookUpEdit();
            this.txtDocumentTopLvView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDueDate = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentHightLv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentTopLvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumentLevel
            // 
            this.txtDocumentLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDocumentLevel.FormattingEnabled = true;
            this.txtDocumentLevel.Location = new System.Drawing.Point(158, 39);
            this.txtDocumentLevel.Name = "txtDocumentLevel";
            this.txtDocumentLevel.Size = new System.Drawing.Size(252, 21);
            this.txtDocumentLevel.TabIndex = 0;
            this.txtDocumentLevel.SelectedIndexChanged += new System.EventHandler(this.txtDocumentLevel_SelectedIndexChanged);
            this.txtDocumentLevel.ValueMemberChanged += new System.EventHandler(this.txtDocumentLevel_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cấp tài liệu:";
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.Location = new System.Drawing.Point(158, 140);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(252, 21);
            this.txtDocumentName.TabIndex = 2;
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(158, 75);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(252, 21);
            this.txtDocumentNo.TabIndex = 2;
            this.txtDocumentNo.Leave += new System.EventHandler(this.txtDocumentNo_Leave);
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(591, 70);
            this.txtForm.Name = "txtForm";
            this.txtForm.ReadOnly = true;
            this.txtForm.Size = new System.Drawing.Size(252, 21);
            this.txtForm.TabIndex = 2;
            // 
            // txtContentResive
            // 
            this.txtContentResive.Location = new System.Drawing.Point(591, 103);
            this.txtContentResive.Multiline = true;
            this.txtContentResive.Name = "txtContentResive";
            this.txtContentResive.Size = new System.Drawing.Size(252, 58);
            this.txtContentResive.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài liệu cấp trên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số quản lí tài liệu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên tài liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Form:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nội dung revise:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bộ phận cần triển khai:";
            // 
            // txtDeploymentSection
            // 
            this.txtDeploymentSection.Location = new System.Drawing.Point(591, 208);
            this.txtDeploymentSection.Name = "txtDeploymentSection";
            this.txtDeploymentSection.ReadOnly = true;
            this.txtDeploymentSection.Size = new System.Drawing.Size(252, 21);
            this.txtDeploymentSection.TabIndex = 2;
            this.txtDeploymentSection.Click += new System.EventHandler(this.txtDeploymentSection_Click);
            this.txtDeploymentSection.TextChanged += new System.EventHandler(this.txtDeploymentSection_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "File tài liệu:";
            // 
            // txtAttachFile
            // 
            this.txtAttachFile.Location = new System.Drawing.Point(591, 38);
            this.txtAttachFile.Name = "txtAttachFile";
            this.txtAttachFile.ReadOnly = true;
            this.txtAttachFile.Size = new System.Drawing.Size(252, 21);
            this.txtAttachFile.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thời hạn triển khai:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(849, 38);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(48, 21);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "Chọn";
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số Rev:";
            // 
            // txtRev
            // 
            this.txtRev.Location = new System.Drawing.Point(158, 175);
            this.txtRev.Name = "txtRev";
            this.txtRev.Size = new System.Drawing.Size(252, 21);
            this.txtRev.TabIndex = 2;
            // 
            // btnAttachForm
            // 
            this.btnAttachForm.Location = new System.Drawing.Point(849, 70);
            this.btnAttachForm.Name = "btnAttachForm";
            this.btnAttachForm.Size = new System.Drawing.Size(48, 21);
            this.btnAttachForm.TabIndex = 4;
            this.btnAttachForm.Text = "Chọn";
            this.btnAttachForm.Click += new System.EventHandler(this.btnAttachForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDeployment);
            this.groupBox1.Controls.Add(this.txtDocumentHightLv);
            this.groupBox1.Controls.Add(this.txtDocumentLevel);
            this.groupBox1.Controls.Add(this.btnAttachForm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDueDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAttachFile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDocumentNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDeploymentSection);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContentResive);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRev);
            this.groupBox1.Controls.Add(this.txtContentDetail);
            this.groupBox1.Controls.Add(this.txtForm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDocumentName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 289);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbDeployment
            // 
            this.cbDeployment.AutoSize = true;
            this.cbDeployment.Location = new System.Drawing.Point(591, 247);
            this.cbDeployment.Name = "cbDeployment";
            this.cbDeployment.Size = new System.Drawing.Size(145, 17);
            this.cbDeployment.TabIndex = 6;
            this.cbDeployment.Text = "Đã hoàn thành triển khai";
            this.cbDeployment.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.tbnSave);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtContentDetail
            // 
            this.txtContentDetail.Location = new System.Drawing.Point(591, 175);
            this.txtContentDetail.Name = "txtContentDetail";
            this.txtContentDetail.ReadOnly = true;
            this.txtContentDetail.Size = new System.Drawing.Size(252, 21);
            this.txtContentDetail.TabIndex = 2;
            this.txtContentDetail.Click += new System.EventHandler(this.txtContentDetail_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Các nội dung chi tiết:";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(95, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbnSave
            // 
            this.tbnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSave.Appearance.Options.UseFont = true;
            this.tbnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbnSave.ImageOptions.Image")));
            this.tbnSave.Location = new System.Drawing.Point(6, 20);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(83, 26);
            this.tbnSave.TabIndex = 4;
            this.tbnSave.Text = "Lưu ";
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // txtDocumentHightLv
            // 
            this.txtDocumentHightLv.Location = new System.Drawing.Point(158, 108);
            this.txtDocumentHightLv.Name = "txtDocumentHightLv";
            this.txtDocumentHightLv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDocumentHightLv.Properties.NullText = "";
            this.txtDocumentHightLv.Properties.PopupView = this.txtDocumentTopLvView;
            this.txtDocumentHightLv.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.txtDocumentHightLv.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.txtDocumentHightLv.Size = new System.Drawing.Size(252, 20);
            this.txtDocumentHightLv.TabIndex = 5;
            this.txtDocumentHightLv.EditValueChanged += new System.EventHandler(this.txtDocumentHightLv_EditValueChanged);
            // 
            // txtDocumentTopLvView
            // 
            this.txtDocumentTopLvView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtDocumentTopLvView.Name = "txtDocumentTopLvView";
            this.txtDocumentTopLvView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtDocumentTopLvView.OptionsView.ShowGroupPanel = false;
            // 
            // txtDueDate
            // 
            this.txtDueDate.EditValue = null;
            this.txtDueDate.Location = new System.Drawing.Point(158, 208);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDate.Size = new System.Drawing.Size(252, 20);
            this.txtDueDate.TabIndex = 3;
            // 
            // FRM_ADD_DOCUMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(931, 386);
            this.Name = "FRM_ADD_DOCUMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài liệu";
            this.Load += new System.EventHandler(this.FRM_ADD_DOCUMENT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentHightLv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentTopLvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtDocumentLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentName;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.TextBox txtContentResive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeploymentSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAttachFile;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit txtDueDate;
        private DevExpress.XtraEditors.SimpleButton tbnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.GridLookUpEdit txtDocumentHightLv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView txtDocumentTopLvView;
        private DevExpress.XtraEditors.SimpleButton btnFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRev;
        private DevExpress.XtraEditors.SimpleButton btnAttachForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDeployment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContentDetail;
    }
}