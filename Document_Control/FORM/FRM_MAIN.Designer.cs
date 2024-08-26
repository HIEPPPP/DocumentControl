namespace Document_Control.FORM
{
    partial class FRM_MAIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdDocument = new DevExpress.XtraBars.BarButtonItem();
            this.btnListDocument = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnFilterDeployment = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAdDocument,
            this.btnListDocument,
            this.btnAdmin,
            this.barEditItem1,
            this.btnFilterDeployment,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.QuickToolbarItemLinks.Add(this.btnAdmin);
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            this.ribbon.Size = new System.Drawing.Size(1468, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAdDocument
            // 
            this.btnAdDocument.Caption = "Thêm tài liệu mới";
            this.btnAdDocument.Id = 1;
            this.btnAdDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdDocument.ImageOptions.Image")));
            this.btnAdDocument.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdDocument.ImageOptions.LargeImage")));
            this.btnAdDocument.Name = "btnAdDocument";
            this.btnAdDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdDocument_ItemClick);
            // 
            // btnListDocument
            // 
            this.btnListDocument.Caption = "Danh sách tài liệu";
            this.btnListDocument.Id = 2;
            this.btnListDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListDocument.ImageOptions.Image")));
            this.btnListDocument.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnListDocument.ImageOptions.LargeImage")));
            this.btnListDocument.Name = "btnListDocument";
            this.btnListDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListDocument_ItemClick);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Caption = "barButtonItem1";
            this.btnAdmin.Id = 3;
            this.btnAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.ImageOptions.Image")));
            this.btnAdmin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.ImageOptions.LargeImage")));
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdmin_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemSearchLookUpEdit1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnFilterDeployment
            // 
            this.btnFilterDeployment.Caption = "Danh sách tài liệu cần triển khai";
            this.btnFilterDeployment.Id = 5;
            this.btnFilterDeployment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnFilterDeployment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnFilterDeployment.Name = "btnFilterDeployment";
            this.btnFilterDeployment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFilterDeployment_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh sách tài liệu cần phế duyệt";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdDocument);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnListDocument);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lí tài liệu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFilterDeployment);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 735);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1468, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUser});
            this.menuStrip1.Location = new System.Drawing.Point(1329, 76);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(94, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnUser
            // 
            this.mnUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mnUser.Image = global::Document_Control.Properties.Resources.BO_User_32x32;
            this.mnUser.Name = "mnUser";
            this.mnUser.Size = new System.Drawing.Size(86, 20);
            this.mnUser.Text = "Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::Document_Control.Properties.Resources.AssignTo_32x32;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = global::Document_Control.Properties.Resources.Action_ResetPassword_32x32;
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::Document_Control.Properties.Resources.Action_Close_32x32;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 759);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FRM_MAIN";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FRM_MAIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_MAIN_FormClosed);
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAdDocument;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnUser;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem btnListDocument;
        private DevExpress.XtraBars.BarButtonItem btnAdmin;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem btnFilterDeployment;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}