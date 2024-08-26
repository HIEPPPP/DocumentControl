using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Document_Control.DB;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_LIST_DOCUMENT_NEED_DEPLOYMENT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_LIST_DOCUMENT_NEED_DEPLOYMENT()
        {
            InitializeComponent();
        }

        private void FRM_LIST_DOCUMENT_NEED_DEPLOYMENT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                string queryData = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_TYPE = '" + Constaint._DocumentType + "' AND DEPLOYMENT_SECTION_ID LIKE '%" + Constaint._sectionID + "%'";
                DataTable Data = DBUtils._getData(queryData);
                gcData.DataSource = Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = gvData.FocusedRowHandle;
                string Document_No = Convert.ToString(gvData.GetFocusedRowCellValue("DOCUMENT_NO"));
                string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                string ProductType = Convert.ToString(gvData.GetFocusedRowCellValue("PRODUCT_TYPE"));
                if (info.InRow || info.InRowCell)
                {
                    string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                    if (colCaption == "Bộ phận chưa hoàn thành triển khai")
                    {
                        FRM_DEPLOYMENT_STATUS f = new FRM_DEPLOYMENT_STATUS(Document_No, Rev);
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                    if (colCaption == "Form")
                    {
                        FRM_LIST_FORM f = new FRM_LIST_FORM(Document_No, Rev);
                        f.ShowDialog();
                    }
                    if (colCaption == "Rev")
                    {
                        FRM_DOCUMENT_REV_HISTORY f = new FRM_DOCUMENT_REV_HISTORY(Document_No);
                        f.ShowDialog();
                    }
                    if (colCaption == "File tài liệu")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(gvData.GetFocusedRowCellValue("FILE_DOCUMENT"))))
                        {
                            System.Diagnostics.Process.Start(Constaint._folderFileUpload + gvData.GetFocusedRowCellValue("FILE_DOCUMENT").ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}