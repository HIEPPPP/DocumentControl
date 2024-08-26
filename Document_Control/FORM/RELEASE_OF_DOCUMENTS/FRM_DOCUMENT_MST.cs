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
    public partial class FRM_DOCUMENT_MST : DevExpress.XtraEditors.XtraForm
    {

        public FRM_DOCUMENT_MST()
        {
            InitializeComponent();
        }

        private void FRM_DOCUMENT_MST_Load(object sender, EventArgs e)
        {
            LoadData();
            if (Constaint._access == "01" || Constaint._sectionShort == "QA")
            {
                btnAdd.Enabled = true;
                btnRev.Enabled = true;
                btnUpdate.Enabled = true;
                btnDel.Enabled = true;
            }
        }
        public void LoadData()
        {
            try
            {
                string queryDataDocMST = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_TYPE = '" + Constaint._DocumentType + "' ORDER BY DOCUMENT_TOP_LEVEL ASC, DOCUMENT_LEVEL_B ASC, DOCUMENT_LEVEL ASC";
                DataTable DataDocMST = DBUtils._getData(queryDataDocMST);
                gcData.DataSource = DataDocMST;
                cbFilter.Checked = false;
                cbFilter2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_ADD_DOCUMENT f = new FRM_ADD_DOCUMENT();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
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

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            string Document_No = Convert.ToString(gvData.GetFocusedRowCellValue("DOCUMENT_NO"));
            FRM_REVISE_DOCUMENT f = new FRM_REVISE_DOCUMENT(Document_No);
            f.ShowDialog();
            LoadData();
        }

        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFilter.Checked == true)
                {
                    cbFilter2.Checked = false;
                    string queryData = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_TYPE = '" + Constaint._DocumentType + "' AND DEPLOYMENT_SECTION_ID LIKE '%" + Constaint._sectionID + "%'";
                    DataTable Data = DBUtils._getData(queryData);
                    gcData.DataSource = Data;
                }
                else
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbFilter2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFilter2.Checked == true)
                {
                    cbFilter.Checked = false;
                    string queryData = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_TYPE = '" + Constaint._DocumentType + "' AND DEPLOYMENTED_SECTION_ID LIKE '%" + Constaint._sectionID + "%'";
                    DataTable Data = DBUtils._getData(queryData);
                    gcData.DataSource = Data;
                }
                else
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string DocumentNo = gvData.GetFocusedRowCellValue("DOCUMENT_NO").ToString();
            FRM_UPDATE_DOCUMENT f = new FRM_UPDATE_DOCUMENT(DocumentNo);
            f.ShowDialog();
            LoadData();
        }

        private void gvData_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Level = Convert.ToString(gvData.GetRowCellValue(e.RowHandle, gvData.Columns["DOCUMENT_LEVEL"]));
                if (Level == "A")
                {
                    if (e.Column.FieldName == "DOCUMENT_LEVEL")
                    {
                        e.Appearance.BackColor = Color.LightSteelBlue;
                    }
                }
                if (Level == "B")
                {
                    if (e.Column.FieldName == "DOCUMENT_LEVEL")
                    {
                        e.Appearance.BackColor = Color.PeachPuff;
                    }
                }
                if (Level == "C")
                {
                    if (e.Column.FieldName == "DOCUMENT_LEVEL")
                    {
                        e.Appearance.BackColor = Color.PaleGreen;
                    }
                }
                if (!string.IsNullOrEmpty(Convert.ToString(gvData.GetRowCellValue(e.RowHandle, gvData.Columns["DUE_DATE_DEPLOYMENT"]))))
                {
                    DateTime now = DateTime.Now;
                    DateTime DueDate = Convert.ToDateTime(gvData.GetRowCellValue(e.RowHandle, gvData.Columns["DUE_DATE_DEPLOYMENT"]));
                    TimeSpan time = DueDate - now;
                    if (time.Days < 0)
                    {
                        if (e.Column.FieldName == "DUE_DATE_DEPLOYMENT")
                        {
                            e.Appearance.BackColor = Color.OrangeRed;
                        }
                    }
                    if (time.Days > 0 && time.Days < 3)
                    {
                        if (e.Column.FieldName == "DUE_DATE_DEPLOYMENT")
                        {
                            e.Appearance.BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa thông tin?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE TBL_DOCUMENT_MST WHERE ID_IDENTITY = '" + Convert.ToString(gvData.GetFocusedRowCellValue("ID_IDENTITY")) + "'";
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

        private void gvData_RowCountChanged(object sender, EventArgs e)
        {
            txtRecord.Text = gvData.RowCount.ToString();
        }

        private void txtDocumentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Constaint._DocumentType = txtDocumentType.Text;
            LoadData();
        }
    }
}