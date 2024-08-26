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
    public partial class FRM_SELECT_SECTION : DevExpress.XtraEditors.XtraForm
    {
        string Document_No;
        string Document_name;
        string Rev;
        string DueDate;
        string selectedSection = string.Empty;
        string Content;
        string IDContent;
        private DataTable DataSection;
        public string DataSectionSend { get; set; }
        public string DataSectionIDSend { get; set; }
        public FRM_SELECT_SECTION(string Document_No, string Document_name, string Rev, string DueDate, string selectedSection, string IDContent, string Content)
        {
            InitializeComponent();

            this.Document_No = Document_No;
            this.Document_name = Document_name;
            this.Rev = Rev;
            this.DueDate = DueDate;
            this.selectedSection = selectedSection;
            this.Content = Content;
            this.IDContent = IDContent;

        }
        private void FRM_SELECT_SECTION_Load(object sender, EventArgs e)
        {
            LoadDataSection();
            SelectedRow();
        }
        private void SelectedRow()
        {
            if (!string.IsNullOrEmpty(selectedSection))
            {
                var arrSection = selectedSection.Split(',');

                for (int i = 0; i <= gvData.RowCount - 1; i++)
                {
                    DataRow row = gvData.GetDataRow(i);
                    string section = row["SECTION_SHORT_NAME"].ToString().Trim();
                    foreach (string item in arrSection)
                    {
                        string sectionSelect = item.Trim();
                        if (section == sectionSelect)
                        {
                            gvData.SelectRow(i);
                        }
                    }
                }
            }
        }
        private void LoadDataSection()
        {
            try
            {
                string queryDataSection = "SELECT * FROM TBL_SECTION_MST";
                DataTable DataSection = DBUtils._getData(queryDataSection);
                string queryDataSectionAll = "SELECT * FROM TBL_CONTENT_ALL_SECTION WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND ID_CONTENT = '" + IDContent + "'";
                DataTable DataSectionAll = DBUtils._getData(queryDataSectionAll);
                if (DataSectionAll.Rows.Count > 0)
                {
                    gcData.DataSource = DataSectionAll;
                }
                else
                {
                    gcData.DataSource = DataSection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string SectionRemain = string.Empty;
                DataSection = new DataTable();
                DataSection.Columns.Add("SECTION", typeof(string));
                if (gvData.GetSelectedRows().Count() > 0)
                {
                    foreach (int index in gvData.GetSelectedRows())
                    {
                        DataRow rowSelect = DataSection.NewRow();
                        rowSelect = gvData.GetDataRow(index);
                        DataRow rowSection = DataSection.NewRow();
                        rowSection["SECTION"] = rowSelect["SECTION_SHORT_NAME"];
                        DataSection.Rows.Add(rowSection);
                    }
                }
                // INSERT VÀO BẢNG TẤT CẢ CÁC BỘ PHẬN
                string querySectionAll = "DELETE TBL_CONTENT_ALL_SECTION WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND ID_CONTENT = '" + IDContent + "'";
                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(querySectionAll, conn))
                    {
                        int N = cmd.ExecuteNonQuery();
                    }
                }
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    string querySave = "INSERT INTO TBL_CONTENT_ALL_SECTION (DOCUMENT_NO, SECTION_SHORT_NAME, SECTION_ID, ID_CONTENT, REQUIRED_CONTENT, CONNECTOR_F1, CONNECTOR_F2, TERMINAL, REV) VALUES (@DOCUMENT_NO, @SECTION_SHORT_NAME, @SECTION_ID, @ID_CONTENT , @REQUIRED_CONTENT, @CONNECTOR_F1, @CONNECTOR_F2, @TERMINAL, @REV)";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(querySave, conn))
                        {
                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", Document_No);
                            cmd.Parameters.AddWithValue("@ID_CONTENT", IDContent);
                            cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                            cmd.Parameters.AddWithValue("@SECTION_SHORT_NAME", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_SHORT_NAME")));
                            cmd.Parameters.AddWithValue("@SECTION_ID", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_ID")));
                            cmd.Parameters.AddWithValue("@CONNECTOR_F1", Convert.ToString(gvData.GetRowCellValue(i, "CONNECTOR_F1")));
                            cmd.Parameters.AddWithValue("@CONNECTOR_F2", Convert.ToString(gvData.GetRowCellValue(i, "CONNECTOR_F2")));
                            cmd.Parameters.AddWithValue("@TERMINAL", Convert.ToString(gvData.GetRowCellValue(i, "TERMINAL")));
                            cmd.Parameters.AddWithValue("@REV", Rev);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                // INSERT VÀO BẢNG CÁC BỘ PHẬN CẦN TRIỂN KHAI
                string querySection = "DELETE TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND ID_CONTENT = '" + IDContent + "'";
                string queryDeleteDetail = "DELETE TBL_DETAIL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND ID_CONTENT = '" + IDContent + "'";
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
                string queryDetail = "INSERT TBL_DETAIL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, REQUIRED_CONTENT, DEPLOYMENT_SECTION, ORGANIZATION_REQUEST, ID_CONTENT, ID_PRODUCTION_SEGMENT, FACTORY) " +
                            "VALUES (@DOCUMENT_NO, @REV, @REQUIRED_CONTENT, @DEPLOYMENT_SECTION, @ORGANIZATION_REQUEST, @ID_CONTENT, @ID_PRODUCTION_SEGMENT, @FACTORY)";
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    DataRow row = gvData.GetDataRow(i);
                    if (gvData.IsRowSelected(i))
                    {
                        string querySave = "INSERT INTO TBL_SECTION_DEPLOYMENT_CONTENT (DOCUMENT_NO, DEPLOYMENT_SECTION, SECTION_ID, ID_CONTENT, REQUIRED_CONTENT, CONNECTOR_F1, CONNECTOR_F2, TERMINAL, REV) VALUES (@DOCUMENT_NO, @DEPLOYMENT_SECTION, @SECTION_ID, @ID_CONTENT , @REQUIRED_CONTENT, @CONNECTOR_F1, @CONNECTOR_F2, @TERMINAL, @REV)";
                        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(querySave, conn))
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_NO", Document_No);
                                cmd.Parameters.AddWithValue("@ID_CONTENT", IDContent);
                                cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_SHORT_NAME")));
                                cmd.Parameters.AddWithValue("@SECTION_ID", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_ID")));
                                cmd.Parameters.AddWithValue("@CONNECTOR_F1", Convert.ToString(gvData.GetRowCellValue(i, "CONNECTOR_F1")));
                                cmd.Parameters.AddWithValue("@CONNECTOR_F2", Convert.ToString(gvData.GetRowCellValue(i, "CONNECTOR_F2")));
                                cmd.Parameters.AddWithValue("@TERMINAL", Convert.ToString(gvData.GetRowCellValue(i, "TERMINAL")));
                                cmd.Parameters.AddWithValue("@REV", Rev);
                                cmd.ExecuteNonQuery();
                                if (Convert.ToBoolean(row["CONNECTOR_F1"]) == true)
                                {
                                    using (SqlCommand cmdF1 = new SqlCommand(queryDetail, conn))
                                    {
                                        cmdF1.Parameters.AddWithValue("@DOCUMENT_NO", Document_No);
                                        cmdF1.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                                        cmdF1.Parameters.AddWithValue("@REV", Rev);
                                        cmdF1.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_SHORT_NAME")));
                                        cmdF1.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                        cmdF1.Parameters.AddWithValue("@ID_CONTENT", IDContent);
                                        cmdF1.Parameters.AddWithValue("@ID_PRODUCTION_SEGMENT", "01".Trim());
                                        cmdF1.Parameters.AddWithValue("@FACTORY", "F1");
                                        cmdF1.ExecuteNonQuery();
                                    }
                                }
                                if (Convert.ToBoolean(row["CONNECTOR_F2"]) == true)
                                {
                                    using (SqlCommand cmdF2 = new SqlCommand(queryDetail, conn))
                                    {
                                        cmdF2.Parameters.AddWithValue("@DOCUMENT_NO", Document_No);
                                        cmdF2.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                                        cmdF2.Parameters.AddWithValue("@REV", Rev);
                                        cmdF2.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_SHORT_NAME")));
                                        cmdF2.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                        cmdF2.Parameters.AddWithValue("@ID_CONTENT", IDContent);
                                        cmdF2.Parameters.AddWithValue("@ID_PRODUCTION_SEGMENT", "02".Trim());
                                        cmdF2.Parameters.AddWithValue("@FACTORY", "F2");
                                        cmdF2.ExecuteNonQuery();
                                    }
                                }
                                if (Convert.ToBoolean(row["TERMINAL"]) == true)
                                {
                                    using (SqlCommand cmdF2TER = new SqlCommand(queryDetail, conn))
                                    {
                                        cmdF2TER.Parameters.AddWithValue("@DOCUMENT_NO", Document_No);
                                        cmdF2TER.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                                        cmdF2TER.Parameters.AddWithValue("@REV", Rev);
                                        cmdF2TER.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Convert.ToString(gvData.GetRowCellValue(i, "SECTION_SHORT_NAME")));
                                        cmdF2TER.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                        cmdF2TER.Parameters.AddWithValue("@ID_CONTENT", IDContent);
                                        cmdF2TER.Parameters.AddWithValue("@ID_PRODUCTION_SEGMENT", "03".Trim());
                                        cmdF2TER.Parameters.AddWithValue("@FACTORY", "F2");
                                        cmdF2TER.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
                var sectionRemainList = (from r in DataSection.AsEnumerable()
                                         select r["SECTION"]).Distinct().ToList();
                if (sectionRemainList.Count > 0)
                {
                    foreach (var section in sectionRemainList)
                    {
                        SectionRemain = SectionRemain + ", " + section;
                    }
                }
                string ListSectionIDSend = string.Empty;
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    if (gvData.IsRowSelected(i))
                    {
                        ListSectionIDSend = ListSectionIDSend + ", " + Convert.ToString(gvData.GetRowCellValue(i, "SECTION_ID"));
                    }
                }
                if (!string.IsNullOrEmpty(SectionRemain))
                {
                    DataSectionSend = SectionRemain.Substring(2);
                }
                else
                {
                    DataSectionSend = "";
                }
                if (!string.IsNullOrEmpty(ListSectionIDSend))
                {
                    DataSectionIDSend = ListSectionIDSend.Substring(2);
                }
                else
                {
                    DataSectionIDSend = "";
                }
                DialogResult = DialogResult.OK;
                this.Close();
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

        

        private void gcData_Click(object sender, EventArgs e)
        {

        }
    }
}