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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.SqlClient;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_DOCUMENT_REV_HISTORY : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DOCUMENT_REV_HISTORY(string Document_No)
        {
            this.Document_No = Document_No;
            InitializeComponent();
        }
        string Document_No;
        private void FRM_DOCUMENT_REV_HISTORY_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryDataDocMST = "SELECT * FROM TBL_DOCUMENT_REV_HISTORY WHERE DOCUMENT_NO = '"+Document_No+"' ORDER BY REV ASC";
                DataTable DataDocMST = DBUtils._getData(queryDataDocMST);
                gcData.DataSource = DataDocMST;
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
                    if (colCaption == "Bộ phận cần triển khai")
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa thông tin?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE TBL_DOCUMENT_REV_HISTORY WHERE ID_IDENTITY = '" + Convert.ToString(gvData.GetFocusedRowCellValue("ID_IDENTITY")) + "'";
                    using (SqlConnection _conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        _conn.Open();
                        using (SqlCommand cmd = new SqlCommand(queryDelete, _conn))
                        {
                            int n = cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}