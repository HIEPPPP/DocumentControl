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
using System.Data.SqlClient;
using DevExpress.XtraGrid;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_DEPLOYMENT_CONTENT : DevExpress.XtraEditors.XtraForm
    {
        public string DataFromForm1 { get; set; }
        public FRM_DEPLOYMENT_CONTENT(string DocumentNo, string Rev)
        {
            this.DocumentNo = DocumentNo;
            this.Rev = Rev;
            InitializeComponent();
        }
        string DocumentNo;
        string Rev;
        private void FRM_DEPLOYMENT_CONTENT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryData = "SELECT * FROM TBL_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + DocumentNo + "' AND REV = '" + Rev + "'";
                DataTable Data = DBUtils._getData(queryData);
                gcData.DataSource = Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                gvData.AddNewRow();
                gvData.Focus();
                gvData.SetRowCellValue(GridControl.NewItemRowHandle, "CONNECTOR_F1", false);
                gvData.SetRowCellValue(GridControl.NewItemRowHandle, "CONNECTOR_F2", false);
                gvData.SetRowCellValue(GridControl.NewItemRowHandle, "TERMINAL", false);

                gvData.FocusedColumn = gvData.Columns[0];
                gvData.ShowEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gvData.DeleteSelectedRows();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    DataRow row = gvData.GetDataRow(i);
                    if (row.RowState == DataRowState.Added)
                    {
                        if (string.IsNullOrEmpty(Convert.ToString(row["REQUIRED_CONTENT"])))
                        {
                            MessageBox.Show("Nhập nội dung!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                string querySection = "DELETE TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + DocumentNo + "' AND REV = '" + Rev + "'";
                string queryDeleteDetail = "DELETE TBL_DETAIL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + DocumentNo + "' AND REV = '" + Rev + "'";
                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(querySection, conn))
                    {
                        int N = cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(queryDeleteDetail, conn))
                    {
                        int N = cmd.ExecuteNonQuery();
                    }
                }
                string queryDelete = "DELETE TBL_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + DocumentNo + "' AND REV = '" + Rev + "'";
                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                {
                    conn.Open();
                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(queryDelete, conn, sqlTransaction))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        for (int i = 0; i < gvData.RowCount; i++)
                        {
                            DataRow row = gvData.GetDataRow(i);
                            string RequiredContent = Convert.ToString(row["REQUIRED_CONTENT"]);
                            string querySave = "INSERT INTO TBL_DEPLOYMENT_CONTENT (DOCUMENT_NO, REQUIRED_CONTENT, REV) " +
                                "VALUES (@DOCUMENT_NO , @REQUIRED_CONTENT, @REV)";
                            using (SqlCommand cmd = new SqlCommand(querySave, conn, sqlTransaction))
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@DOCUMENT_NO", DocumentNo);
                                cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", RequiredContent);
                                cmd.Parameters.AddWithValue("@REV", Rev);
                                cmd.ExecuteNonQuery();

                            }
                        }
                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        MessageBox.Show(ex.ToString());
                    }
                }

                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataFromForm1 = Convert.ToString(gvData.RowCount);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            //if (gvData.FocusedColumn.FieldName == "DEPLOYMENT_SECTION")
            //{
            //    FRM_SELECT_SECTION f = new FRM_SELECT_SECTION(DocumentNo, "", Rev, "","" );
            //    f.ShowDialog();
            //}
        }
    }
}