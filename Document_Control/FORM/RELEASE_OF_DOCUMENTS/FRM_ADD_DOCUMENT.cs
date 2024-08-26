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
using System.IO;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_ADD_DOCUMENT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_ADD_DOCUMENT()
        {
            InitializeComponent();
        }
        string DocumentTopLv = string.Empty;
        string ListSectionID = string.Empty;
        private void FRM_ADD_DOCUMENT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryLevel = "SELECT * FROM TBL_DOCUMENT_LEVEL";
                DataTable DataLevel = DBUtils._getData(queryLevel);
                txtDocumentLevel.DataSource = DataLevel;
                txtDocumentLevel.DisplayMember = "Level";
                txtDocumentLevel.ValueMember = "Level";

                txtDocumentLevel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string queryCheck = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_NO = '" + txtDocumentNo.Text.Trim() + "'";
                DataTable DataCheck = DBUtils._getData(queryCheck);
                if (DataCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Số quản lí của tài liệu đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (string.IsNullOrEmpty(txtDocumentType.Text))
                //{
                //    MessageBox.Show("Chọn loại tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (string.IsNullOrEmpty(txtDocumentLevel.Text))
                {
                    MessageBox.Show("Chọn cấp tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtDocumentNo.Text))
                {
                    MessageBox.Show("Nhập số quản lí", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtDocumentLevel.Text != "A")
                {
                    if (string.IsNullOrEmpty(txtDocumentHightLv.Text))
                    {
                        MessageBox.Show("Chọn tài liệu cấp trên", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(txtAttachFile.Text))
                {
                    MessageBox.Show("Chọn file tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtRev.Text))
                {
                    MessageBox.Show("Rev không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtDocumentName.Text))
                {
                    MessageBox.Show("Tên tài liệu không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtForm.Text))
                {
                    MessageBox.Show("Chọn form tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtContentResive.Text))
                {
                    MessageBox.Show("Nhập nội dung Revise", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult Result = MessageBox.Show("Xác nhận lưu thông tin", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    string querySave = "INSERT INTO TBL_DOCUMENT_MST (DOCUMENT_TYPE, DOCUMENT_NO, DOCUMENT_LEVEL, DOCUMENT_TOP_LEVEL, DOCUMENT_HIGHT_LEVEL, DOCUMENT_LEVEL_B, FILE_DOCUMENT, REV, DOCUMENT_NAME, FORM, DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID, DEPLOYMENTED_SECTION, DEPLOYMENTED_SECTION_ID, DUE_DATE_DEPLOYMENT, CONTENT_REVISE, CREATE_AT, CREATE_BY) " +
                        "VALUES(@DOCUMENT_TYPE, @DOCUMENT_NO, @DOCUMENT_LEVEL, @DOCUMENT_TOP_LEVEL, @DOCUMENT_HIGHT_LEVEL, @DOCUMENT_LEVEL_B, @FILE_DOCUMENT, @REV, @DOCUMENT_NAME, @FORM, @DEPLOYMENT_SECTION, @DEPLOYMENT_SECTION_ID, @DEPLOYMENTED_SECTION, @DEPLOYMENTED_SECTION_ID, @DUE_DATE_DEPLOYMENT, @CONTENT_REVISE, @CREATE_AT, @CREATE_BY)";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(querySave, conn))
                        {
                            cmd.Parameters.AddWithValue("@DOCUMENT_TYPE", Constaint._DocumentType);
                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                            cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL", txtDocumentLevel.Text);
                            if (string.IsNullOrEmpty(DocumentTopLv))
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_TOP_LEVEL", txtDocumentNo.Text);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_TOP_LEVEL", DocumentTopLv);
                            }
                            cmd.Parameters.AddWithValue("@DOCUMENT_HIGHT_LEVEL", txtDocumentHightLv.Text);
                            if (txtDocumentLevel.Text == "A")
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL_B", DBNull.Value);
                            }
                            if (txtDocumentLevel.Text == "B")
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL_B", txtDocumentNo.Text);
                            }
                            if (txtDocumentLevel.Text == "C")
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL_B", txtDocumentHightLv.Text);
                            }
                            cmd.Parameters.AddWithValue("@FILE_DOCUMENT", txtAttachFile.Text);
                            cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                            cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                            cmd.Parameters.AddWithValue("@FORM", "Danh sách Form");
                            if (cbDeployment.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", "");
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", "");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", txtDeploymentSection.Text);
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", ListSectionID);
                            }
                            cmd.Parameters.AddWithValue("@DEPLOYMENTED_SECTION", txtDeploymentSection.Text);
                            cmd.Parameters.AddWithValue("@DEPLOYMENTED_SECTION_ID", ListSectionID);
                            if (string.IsNullOrEmpty(txtDueDate.Text))
                            {
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            cmd.Parameters.AddWithValue("@CONTENT_REVISE", txtContentResive.Text);
                            cmd.Parameters.AddWithValue("@CREATE_AT", DateTime.Now);
                            cmd.Parameters.AddWithValue("@CREATE_BY", Constaint._userID);
                            int resultRegEquiment = cmd.ExecuteNonQuery();
                            string fileUpLoad = Path.Combine(Constaint._folderFileUpload, txtAttachFile.Text.Trim());
                            if (resultRegEquiment > 0)
                            {
                                File.Copy(pathPdfFile, fileUpLoad, true);
                            }
                        }
                    }
                    //Lưu vào bảng lịch sử sửa đổi
                    string querySaveHistoryRev = "INSERT INTO TBL_DOCUMENT_REV_HISTORY (DOCUMENT_TYPE, DOCUMENT_NO, DOCUMENT_LEVEL, DOCUMENT_TOP_LEVEL, DOCUMENT_HIGHT_LEVEL, DOCUMENT_LEVEL_B, FILE_DOCUMENT, REV, DOCUMENT_NAME, FORM, DEPLOYMENT_SECTION, DUE_DATE_DEPLOYMENT, CONTENT_REVISE, CREATE_AT, CREATE_BY) " +
                       "VALUES(@DOCUMENT_TYPE, @DOCUMENT_NO, @DOCUMENT_LEVEL, @DOCUMENT_TOP_LEVEL, @DOCUMENT_HIGHT_LEVEL, @DOCUMENT_LEVEL_B, @FILE_DOCUMENT, @REV, @DOCUMENT_NAME, @FORM, @DEPLOYMENT_SECTION, @DUE_DATE_DEPLOYMENT, @CONTENT_REVISE, @CREATE_AT, @CREATE_BY)";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(querySaveHistoryRev, conn))
                        {
                            cmd.Parameters.AddWithValue("@DOCUMENT_TYPE", Constaint._DocumentType);
                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                            cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL", txtDocumentLevel.Text);
                            if (string.IsNullOrEmpty(DocumentTopLv))
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_TOP_LEVEL", txtDocumentNo.Text);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_TOP_LEVEL", DocumentTopLv);
                            }
                            cmd.Parameters.AddWithValue("@DOCUMENT_HIGHT_LEVEL", txtDocumentHightLv.Text);
                            if (txtDocumentLevel.Text == "A")
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL_B", DBNull.Value);
                            }
                            if (txtDocumentLevel.Text == "B")
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL_B", txtDocumentNo.Text);
                            }
                            if (txtDocumentLevel.Text == "C")
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL_B", txtDocumentHightLv.Text);
                            }
                            cmd.Parameters.AddWithValue("@FILE_DOCUMENT", txtAttachFile.Text);
                            cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                            cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                            cmd.Parameters.AddWithValue("@FORM", "Danh sách Form");
                            cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", txtDeploymentSection.Text);
                            if (string.IsNullOrEmpty(txtDueDate.Text))
                            {
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            cmd.Parameters.AddWithValue("@CONTENT_REVISE", txtContentResive.Text);
                            cmd.Parameters.AddWithValue("@CREATE_AT", DateTime.Now);
                            cmd.Parameters.AddWithValue("@CREATE_BY", Constaint._userID);
                            int resultRegEquiment = cmd.ExecuteNonQuery();
                        }
                    }
                    //lưu thông tin triển khai
                    string queryDataTemporary = "SELECT * FROM TBL_TEMPORARY_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "'";
                    DataTable DataTemporary = DBUtils._getData(queryDataTemporary);
                    string queryDataContent = "SELECT * FROM TBL_TF_DETAIL_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "'";
                    DataTable DataContent = DBUtils._getData(queryDataContent);
                    for (int i = 0; i < DataTemporary.Rows.Count; i++)
                    {
                        string Section = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION"]);
                        for (int j = 0; j < DataContent.Rows.Count; j++)
                        {
                            string Content = Convert.ToString(DataContent.Rows[j]["REQUIRED_CONTENT"]);
                            string IDProductionSecment = Convert.ToString(DataContent.Rows[j]["ID_PRODUCTION_SEGMENT"]);
                            string Factory = Convert.ToString(DataContent.Rows[j]["FACTORY"]);
                            string querySaveContent = "INSERT INTO TBL_DETAIL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, REQUIRED_CONTENT, ORGANIZATION_REQUEST, DEPLOYMENT_DEADLINE, ID_PRODUCTION_SEGMENT, FACTORY) " +
                                            "VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @REQUIRED_CONTENT, @ORGANIZATION_REQUEST, @DEPLOYMENT_DEADLINE, @ID_PRODUCTION_SEGMENT, @FACTORY)";
                            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(querySaveContent, conn))
                                {
                                    cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                                    cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                                    cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                                    cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                                    cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                                    cmd.Parameters.AddWithValue("@ID_PRODUCTION_SEGMENT", IDProductionSecment);
                                    cmd.Parameters.AddWithValue("@FACTORY", Factory);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    if (DataTemporary.Rows.Count > 0)
                    {
                        string queryCheckApplyConF1 = "SELECT * FROM TBL_TF_DETAIL_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' AND ID_PRODUCTION_SEGMENT = '01'";
                        DataTable DataCheckConF1 = DBUtils._getData(queryCheckApplyConF1);
                        string queryCheckApplyConF2 = "SELECT * FROM TBL_TF_DETAIL_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' AND ID_PRODUCTION_SEGMENT = '02'";
                        DataTable DataCheckConF2 = DBUtils._getData(queryCheckApplyConF2);
                        string queryCheckApplyTer = "SELECT * FROM TBL_TF_DETAIL_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' AND ID_PRODUCTION_SEGMENT = '03'";
                        DataTable DataCheckTer = DBUtils._getData(queryCheckApplyTer);
                        for (int i = 0; i < DataTemporary.Rows.Count; i++)
                        {
                            string Section = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION"]);
                            string SectionID = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION_ID"]);
                            string querySaveDeployment = "INSERT INTO TBL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID, ISSUED, ORGANIZATION_REQUEST, REQUIRED_CONTENT, DEPLOYMENT_DEADLINE, ID_STATUS_CON_F1, ID_STATUS_CON_F2, ID_STATUS_TER) " +
                                "VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @DEPLOYMENT_SECTION_ID, @ISSUED, @ORGANIZATION_REQUEST, @REQUIRED_CONTENT, @DEPLOYMENT_DEADLINE, @ID_STATUS_CON_F1, @ID_STATUS_CON_F2, @ID_STATUS_TER)";
                            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(querySaveDeployment, conn))
                                {
                                    cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                                    cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                                    cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", SectionID);
                                    cmd.Parameters.AddWithValue("@ISSUED", "QA");
                                    cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                    cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", txtContentResive.Text);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                                    if (cbDeployment.Checked == true)
                                    {
                                        cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "04");
                                        cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "04");
                                        cmd.Parameters.AddWithValue("@ID_STATUS_TER", "04");
                                    }
                                    else
                                    {
                                        if (DataCheckConF1.Rows.Count > 0)
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "01");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "00");
                                        }
                                        if (DataCheckConF2.Rows.Count > 0)
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "01");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "00");
                                        }
                                        if (DataCheckTer.Rows.Count > 0)
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_TER", "01");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_TER", "00");
                                        }
                                    }
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    //Lưu vào bảng tình trạng triển khai
                    string queryListSection = "SELECT DOCUMENT_NO, SECTION_ID, DEPLOYMENT_SECTION from TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' GROUP BY DOCUMENT_NO, SECTION_ID, DEPLOYMENT_SECTION";
                    DataTable DataListSection = DBUtils._getData(queryListSection);
                    if (DataListSection.Rows.Count > 0)
                    {
                        for (int i = 0; i < DataListSection.Rows.Count; i++)
                        {
                            string Section = Convert.ToString(DataListSection.Rows[i]["DEPLOYMENT_SECTION"]);
                            string SectionID = Convert.ToString(DataListSection.Rows[i]["SECTION_ID"]);
                            string querySaveDeployment = "INSERT INTO TBL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID, ISSUED, ORGANIZATION_REQUEST, REQUIRED_CONTENT, DEPLOYMENT_DEADLINE, ID_STATUS_CON_F1, ID_STATUS_CON_F2, ID_STATUS_TER) " +
                                "VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @DEPLOYMENT_SECTION_ID, @ISSUED, @ORGANIZATION_REQUEST, @REQUIRED_CONTENT, @DEPLOYMENT_DEADLINE, @ID_STATUS_CON_F1, @ID_STATUS_CON_F2, @ID_STATUS_TER)";
                            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(querySaveDeployment, conn))
                                {
                                    cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                                    cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                                    cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", SectionID);
                                    cmd.Parameters.AddWithValue("@ISSUED", "QA");
                                    cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                    cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", txtContentResive.Text);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                                    if (cbDeployment.Checked == true)
                                    {
                                        cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "04");
                                        cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "04");
                                        cmd.Parameters.AddWithValue("@ID_STATUS_TER", "04");
                                    }
                                    else
                                    {
                                        string queryCheckSection1 = "SELECT * FROM TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' AND DEPLOYMENT_SECTION =  '" + Section + "' AND CONNECTOR_F1 = '1'";
                                        DataTable dataCheckSection1 = DBUtils._getData(queryCheckSection1);
                                        if (dataCheckSection1.Rows.Count > 0)
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "01");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "00");
                                        }
                                        string queryCheckSection2 = "SELECT * FROM TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' AND DEPLOYMENT_SECTION =  '" + Section + "' AND CONNECTOR_F2 = '1'";
                                        DataTable dataCheckSection2 = DBUtils._getData(queryCheckSection2);
                                        if (dataCheckSection2.Rows.Count > 0)
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "01");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "00");
                                        }
                                        string queryCheckSection3 = "SELECT * FROM TBL_SECTION_DEPLOYMENT_CONTENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '" + txtRev.Text + "' AND DEPLOYMENT_SECTION =  '" + Section + "' AND TERMINAL = '1'";
                                        DataTable dataCheckSection3 = DBUtils._getData(queryCheckSection3);
                                        if (dataCheckSection3.Rows.Count > 0)
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_TER", "01");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS_TER", "00");
                                        }
                                    }
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    //Update thời hạn triển khai
                    string queryUpdateDueDate = "UPDATE TBL_DETAIL_DEPLOYMENT_DOCUMENT SET DEPLOYMENT_DEADLINE = @DEPLOYMENT_DEADLINE WHERE DOCUMENT_NO = @DOCUMENT_NO AND REV = @REV";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(queryUpdateDueDate, conn))
                        {
                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                            cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                            if (string.IsNullOrEmpty(txtDueDate.Text))
                            {
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                            }
                            cmd.ExecuteNonQuery();
                        }
                    }
                    //string querySecment = "SELECT * FROM TBL_PRODUCTION_SEGMENT";
                    //DataTable DataSecment = DBUtils._getData(querySecment);
                    //string Section = string.Empty;
                    //string SectionID;
                    //for (int i = 0; i < DataContent.Rows.Count; i++)
                    //{
                    //    string Content = Convert.ToString(DataContent.Rows[i]["REQUIRED_CONTENT"]);
                    //    string ApplyConF1 = Convert.ToString(DataContent.Rows[i]["CONNECTOR_F1"]);
                    //    string ApplyConF2 = Convert.ToString(DataContent.Rows[i]["CONNECTOR_F2"]);
                    //    string ApplyTer = Convert.ToString(DataContent.Rows[i]["TERMINAL"]);
                    //    if (ApplyConF1 == "1")
                    //    {
                    //        for (int k = 0; k < DataTemporary.Rows.Count; k++)
                    //        {

                    //        }
                    //        for (int k = 0; k < DataSecment.Rows.Count; k++)
                    //        {
                    //            string ProductionSecment = Convert.ToString(DataSecment.Rows[k]["ID_PRODUCTION_SEGMENT"]);
                    //            string Factory = Convert.ToString(DataSecment.Rows[k]["FACTORY"]);
                    //            string querySaveContent = "INSERT INTO TBL_DETAIL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, REQUIRED_CONTENT, ORGANIZATION_REQUEST, DEPLOYMENT_DEADLINE, ID_PRODUCTION_SEGMENT, FACTORY) " +
                    //                "VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @REQUIRED_CONTENT, @ORGANIZATION_REQUEST, @DEPLOYMENT_DEADLINE, @ID_PRODUCTION_SEGMENT, @FACTORY)";
                    //            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    //            {
                    //                conn.Open();
                    //                using (SqlCommand cmd = new SqlCommand(querySaveContent, conn))
                    //                {
                    //                    cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                    //                    cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                    //                    cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                    //                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                    //                    cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                    //                    cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                    //                    cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                    //                    cmd.Parameters.AddWithValue("@ID_PRODUCTION_SEGMENT", ProductionSecment);
                    //                    cmd.Parameters.AddWithValue("@FACTORY", Factory);
                    //                    cmd.ExecuteNonQuery();
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    //if (DataTemporary.Rows.Count > 0)
                    //{
                    //    for (int i = 0; i < DataTemporary.Rows.Count; i++)
                    //    {
                    //        Section = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION"]);
                    //        SectionID = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION_ID"]);
                    //        string querySaveDeployment = "INSERT INTO TBL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID, ISSUED, ORGANIZATION_REQUEST, REQUIRED_CONTENT, DEPLOYMENT_DEADLINE, ID_STATUS_CON_F1, ID_STATUS_CON_F2, ID_STATUS_TER) " +
                    //            "VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @DEPLOYMENT_SECTION_ID, @ISSUED, @ORGANIZATION_REQUEST, @REQUIRED_CONTENT, @DEPLOYMENT_DEADLINE, @ID_STATUS_CON_F1, @ID_STATUS_CON_F2, @ID_STATUS_TER)";
                    //        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    //        {
                    //            conn.Open();
                    //            using (SqlCommand cmd = new SqlCommand(querySaveDeployment, conn))
                    //            {
                    //                cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                    //                cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                    //                cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                    //                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                    //                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", SectionID);
                    //                cmd.Parameters.AddWithValue("@ISSUED", "QA");
                    //                cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                    //                cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", txtContentResive.Text);
                    //                cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                    //                if (cbDeployment.Checked == true)
                    //                {
                    //                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "04");
                    //                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "04");
                    //                    cmd.Parameters.AddWithValue("@ID_STATUS_TER", "04");
                    //                }
                    //                else
                    //                {
                    //                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "01");
                    //                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "01");
                    //                    cmd.Parameters.AddWithValue("@ID_STATUS_TER", "01");
                    //                }
                    //                cmd.ExecuteNonQuery();
                    //            }
                    //        }
                    //        if (DataContent.Rows.Count > 0)
                    //        {
                    //            for (int j = 0; j < DataContent.Rows.Count; j++)
                    //            {
                    //                string Content = Convert.ToString(DataContent.Rows[j]["REQUIRED_CONTENT"]);
                    //                string ApplyConF1 = Convert.ToString(DataContent.Rows[j]["CONNECTOR_F1"]);
                    //                string ApplyConF2 = Convert.ToString(DataContent.Rows[j]["CONNECTOR_F2"]);
                    //                string ApplyTer = Convert.ToString(DataContent.Rows[j]["TERMINAL"]);
                    //                if (ApplyConF1 == "1")
                    //                for (int k = 0; k < DataSecment.Rows.Count; k++)
                    //                {
                    //                    string ProductionSecment = Convert.ToString(DataSecment.Rows[k]["ID_PRODUCTION_SEGMENT"]);
                    //                    string Factory = Convert.ToString(DataSecment.Rows[k]["FACTORY"]);
                    //                    string querySaveContent = "INSERT INTO TBL_DETAIL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, REQUIRED_CONTENT, ORGANIZATION_REQUEST, DEPLOYMENT_DEADLINE, ID_PRODUCTION_SEGMENT, FACTORY) " +
                    //                        "VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @REQUIRED_CONTENT, @ORGANIZATION_REQUEST, @DEPLOYMENT_DEADLINE, @ID_PRODUCTION_SEGMENT, @FACTORY)";
                    //                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    //                    {
                    //                        conn.Open();
                    //                        using (SqlCommand cmd = new SqlCommand(querySaveContent, conn))
                    //                        {
                    //                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                    //                            cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                    //                            cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                    //                            cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                    //                            cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", Content);
                    //                            cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                    //                            cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                    //                            cmd.Parameters.AddWithValue("@ID_PRODUCTION_SEGMENT", ProductionSecment);
                    //                            cmd.Parameters.AddWithValue("@FACTORY", Factory);
                    //                            cmd.ExecuteNonQuery();
                    //                        }
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    //lưu chi tiết nội dung triển khai

                    MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDeploymentSection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentNo.Text))
            {
                MessageBox.Show("Nhập số quản lí của tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtRev.Text))
            {
                MessageBox.Show("Rev không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRM_DEPLOYMENT_CONTENT_SECTION f = new FRM_DEPLOYMENT_CONTENT_SECTION(txtDocumentNo.Text, txtRev.Text);
            f.ShowDialog();
            string Section = f.DataSectionSend;
            string ListSectionIDSend = f.DataSectionIDSend;
            txtDeploymentSection.Text = Section;
            ListSectionID = ListSectionIDSend;
            //string selectedSection = txtDeploymentSection.Text.Trim();
            //FRM_SELECT_SECTION f = new FRM_SELECT_SECTION(txtDocumentNo.Text, txtDocumentName.Text, txtRev.Text, txtDueDate.Text, selectedSection);
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    string Section = f.DataSectionSend;
            //    string ListSectionIDSend = f.DataSectionIDSend;
            //    if (Section != null)
            //    {
            //        txtDeploymentSection.Text = Section;
            //        ListSectionID = ListSectionIDSend;
            //        txtDocumentNo.ReadOnly = true;
            //        txtRev.ReadOnly = true;
            //    }
            //}
        }
        string _fileCopy = string.Empty;
        string pathPdfFile = string.Empty;
        string fileExtension;
        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult result = openFileDialog.ShowDialog();
                openFileDialog.CheckFileExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (result == DialogResult.OK)
                {
                    pathPdfFile = openFileDialog.FileName;
                    _fileCopy = pathPdfFile.Substring(pathPdfFile.LastIndexOf("\\"));
                    fileExtension = Path.GetExtension(pathPdfFile);
                    txtAttachFile.Text = _fileCopy.Substring(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAttachForm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentNo.Text))
            {
                MessageBox.Show("Nhập số quản lí của tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtRev.Text))
            {
                MessageBox.Show("Rev không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRM_DOCUMENT_FORM f = new FRM_DOCUMENT_FORM(txtDocumentNo.Text.Trim(), txtRev.Text.Trim());
            if (f.ShowDialog() == DialogResult.OK)
            {
                string CountForm = f.DataFromForm1;
                if (CountForm != null)
                {
                    txtForm.Text = "Đã chọn " + CountForm + " Form";
                    txtDocumentNo.ReadOnly = true;
                    txtRev.ReadOnly = true;
                }
            }
        }

        private void txtDeploymentSection_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentHightLv_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumentLevel.Text == "A")
                {
                    DocumentTopLv = txtDocumentNo.Text.Trim();
                }
                if (txtDocumentLevel.Text == "B")
                {
                    DocumentTopLv = txtDocumentHightLv.Text.Trim();
                }
                if (txtDocumentLevel.Text == "C")
                {
                    string queryLevel = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_NO = '" + txtDocumentHightLv.Text + "'";
                    DataTable dataLevel = DBUtils._getData(queryLevel);
                    if (dataLevel.Rows.Count > 0)
                    {
                        DocumentTopLv = Convert.ToString(dataLevel.Rows[0]["DOCUMENT_TOP_LEVEL"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDocumentLevel_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDocumentLevel.Text == "A")
            {
                DocumentTopLv = txtDocumentNo.Text.Trim();
            }
            if (txtDocumentLevel.Text == "A")
            {
                txtDocumentHightLv.Text = "";
                txtDocumentHightLv.ReadOnly = true;
            }
            else
            {
                string queryDocument = string.Empty;
                if (txtDocumentLevel.Text == "B")
                {
                    queryDocument = "SELECT DOCUMENT_NO FROM TBL_DOCUMENT_MST WHERE DOCUMENT_LEVEL = 'A'";
                }
                if (txtDocumentLevel.Text == "C")
                {
                    queryDocument = "SELECT DOCUMENT_NO FROM TBL_DOCUMENT_MST WHERE DOCUMENT_LEVEL = 'B'";
                }
                DataTable DataDocument = DBUtils._getData(queryDocument);
                txtDocumentHightLv.Properties.DataSource = DataDocument;
                txtDocumentHightLv.Properties.DisplayMember = "DOCUMENT_NO";
                txtDocumentHightLv.Properties.ValueMember = "DOCUMENT_NO";
                txtDocumentHightLv.ReadOnly = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDocumentNo_Leave(object sender, EventArgs e)
        {
            string queryCheck = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_NO = '" + txtDocumentNo.Text.Trim() + "'";
            DataTable DataCheck = DBUtils._getData(queryCheck);
            if (DataCheck.Rows.Count > 0)
            {
                MessageBox.Show("Số quản lí của tài liệu đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumentNo.Focus();
                txtDocumentNo.Text = "";
                return;
            }
        }

        private void txtContentDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentNo.Text))
            {
                MessageBox.Show("Nhập số quản lí của tài liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtRev.Text))
            {
                MessageBox.Show("Rev không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRM_DEPLOYMENT_CONTENT f = new FRM_DEPLOYMENT_CONTENT(txtDocumentNo.Text.Trim(), txtRev.Text.Trim());
            if (f.ShowDialog() == DialogResult.OK)
            {
                string CountForm = f.DataFromForm1;
                if (CountForm != null)
                {
                    txtContentDetail.Text = "Đã nhập " + CountForm + " nội dung";
                    txtDocumentNo.ReadOnly = true;
                    txtRev.ReadOnly = true;
                }
            }
        }
    }
}