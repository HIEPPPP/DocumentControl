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

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_DEPLOYMENT_CONTENT_SECTION : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DEPLOYMENT_CONTENT_SECTION(string DocumentNo, string Rev)
        {
            this.DocumentNo = DocumentNo;
            this.Rev = Rev;
            InitializeComponent();
        }
        string DocumentNo;
        string Rev;

        private void FRM_DEPLOYMENT_CONTENT_SECTION_Load(object sender, EventArgs e)
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

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            if (gvData.FocusedColumn.FieldName == "DEPLOYMENT_SECTION_LIST")
            {
                string selectedSection = Convert.ToString(gvData.GetFocusedRowCellValue("DEPLOYMENT_SECTION_LIST"));
                string IDContent = Convert.ToString(gvData.GetFocusedRowCellValue("ID_IDENTITY"));
                string Content = Convert.ToString(gvData.GetFocusedRowCellValue("REQUIRED_CONTENT"));
                FRM_SELECT_SECTION f = new FRM_SELECT_SECTION(DocumentNo, "", Rev, "", selectedSection, IDContent, Content);
                f.ShowDialog();
                string Section = f.DataSectionSend;
                if (!string.IsNullOrEmpty(Section))
                {
                    gvData.SetFocusedRowCellValue("DEPLOYMENT_SECTION_LIST", Section);
                }
            }
        }
        public string DataSectionSend { get; set; }
        public string DataSectionIDSend { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    DataRow row = gvData.GetDataRow(i);
                    string queryUpdate = "UPDATE TBL_DEPLOYMENT_CONTENT SET DEPLOYMENT_SECTION_LIST = @DEPLOYMENT_SECTION_LIST WHERE ID_IDENTITY = @ID_IDENTITY";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(queryUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID_IDENTITY", row["ID_IDENTITY"]);
                            cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_LIST", row["DEPLOYMENT_SECTION_LIST"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                string queryListSection = "  SELECT t.DOCUMENT_NO, string_agg(t.DEPLOYMENT_SECTION, ', ') AS DEPLOYMENT_SECTION FROM (SELECT DOCUMENT_NO, DEPLOYMENT_SECTION from TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + DocumentNo + "' AND REV = '" + Rev + "' GROUP BY DOCUMENT_NO, DEPLOYMENT_SECTION) AS t GROUP BY DOCUMENT_NO";
                DataTable DataListSection = DBUtils._getData(queryListSection);
                if (DataListSection.Rows.Count > 0)
                {
                    DataSectionSend = Convert.ToString(DataListSection.Rows[0]["DEPLOYMENT_SECTION"]);
                }
                string queryListSectionID = "  SELECT t.DOCUMENT_NO, string_agg(t.SECTION_ID, ', ') AS DEPLOYMENT_SECTION FROM (SELECT DOCUMENT_NO, SECTION_ID from TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + DocumentNo + "' AND REV = '" + Rev + "' GROUP BY DOCUMENT_NO, SECTION_ID) AS t GROUP BY DOCUMENT_NO";
                DataTable DataListSectionID = DBUtils._getData(queryListSectionID);
                if (DataListSectionID.Rows.Count > 0)
                {
                    DataSectionIDSend = Convert.ToString(DataListSectionID.Rows[0]["DEPLOYMENT_SECTION"]);
                }
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}