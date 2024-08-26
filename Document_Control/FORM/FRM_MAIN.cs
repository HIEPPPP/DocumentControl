using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Document_Control.FORM.RELEASE_OF_DOCUMENTS;
using Document_Control.DB;
using Document_Control.FORM.ADMIN;

namespace Document_Control.FORM
{
    public partial class FRM_MAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }
        private Form CheckForm(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnAdDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            FRM_ADD_DOCUMENT f = new FRM_ADD_DOCUMENT();
            f.Show();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            mnUser.Text = Constaint._nameUser;
            Form frm = CheckForm(typeof(FRM_DOCUMENT_MST));
            if (frm == null)
            {
                FRM_DOCUMENT_MST f = new FRM_DOCUMENT_MST();
                f.MdiParent = this;
                f.Show();
                if (Constaint._access != "01")
                {
                    btnAdmin.Enabled = false;
                }
            }
            else
            {
                frm.Activate();
            }
        }

        private void FRM_MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN f = new FRM_LOGIN();
            f.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER_CHANGE_PASSWORD f = new FRM_USER_CHANGE_PASSWORD();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(FRM_DOCUMENT_MST));
            if (frm == null)
            {
                FRM_DOCUMENT_MST f = new FRM_DOCUMENT_MST();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            FRM_ACCOUNT_LIST f = new FRM_ACCOUNT_LIST();
            f.ShowDialog();
        }

        private void btnFilterDeployment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(FRM_LIST_DOCUMENT_NEED_DEPLOYMENT));
            if (frm == null)
            {
                FRM_LIST_DOCUMENT_NEED_DEPLOYMENT f = new FRM_LIST_DOCUMENT_NEED_DEPLOYMENT();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}