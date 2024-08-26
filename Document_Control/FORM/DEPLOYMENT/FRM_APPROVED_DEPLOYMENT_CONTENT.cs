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

namespace Document_Control.FORM.DEPLOYMENT
{
    public partial class FRM_APPROVED_DEPLOYMENT_CONTENT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_APPROVED_DEPLOYMENT_CONTENT(string DeploymentSection, string Document_No, string Rev, bool Check)
        {
            this.Check = Check;
            this.Rev = Rev;
            this.DeploymentSection = DeploymentSection;
            this.Document_No = Document_No;
            InitializeComponent();
        }
        string DeploymentSection;
        string Document_No;
        string Rev;
        bool Check;
        DateTime DueDate;
        private void FRM_APPROVED_DEPLOYMENT_CONTENT_Load(object sender, EventArgs e)
        {
            try
            {
                string queryProductionSegment = "SELECT * FROM TBL_PRODUCTION_SEGMENT";
                DataTable DataSecment = DBUtils._getData(queryProductionSegment);
                rptProductionSecment.DataSource = DataSecment;
                rptProductionSecment.DisplayMember = "PRODUCTION_SEGMENT";
                rptProductionSecment.ValueMember = "ID_PRODUCTION_SEGMENT";
                string queryDataDetail = queryDataDetail = "SELECT * FROM TBL_DETAIL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "' AND REV = '" + Rev + "'";
                DataTable DataDetail = DBUtils._getData(queryDataDetail);
                gcData.DataSource = DataDetail;

                string queryData = "SELECT * FROM TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "' AND REV = '" + Rev + "'";
                DataTable Data = DBUtils._getData(queryData);
                if (Data.Rows.Count > 0)
                {
                    txtRev.Text = Convert.ToString(Data.Rows[0]["REV"]);
                    txtIssued.Text = "QA";
                    txtDocumentName.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_NAME"]);
                    lbSection.Text = Convert.ToString(Data.Rows[0]["DEPLOYMENT_SECTION"]);
                    if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["APPROVED_BY"])))
                    {
                        txtApprovedBy.Text = Convert.ToString(Data.Rows[0]["APPROVED_BY"]);
                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["DEPLOYMENT_DEADLINE"])))
                    {
                        DueDate = Convert.ToDateTime(Data.Rows[0]["DEPLOYMENT_DEADLINE"]);
                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["DATE_APPROVED"])))
                    {
                        txtDateApproved.Text = Convert.ToDateTime(Data.Rows[0]["DATE_APPROVED"]).ToString("dd/MM/yyyy");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMGRApproved_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDateApproved.Text.Trim()))
            {
                return;
            }
            if (Check == false)
            {
                string Section = Convert.ToString(gvData.GetFocusedRowCellValue("SECTION"));
                string querySectionMG = "SELECT * FROM TBL_SECTION_MANAGER WHERE SECTION_SHORT_NAME = '" + Section + "' AND ID_MANAGER = '" + Constaint._userID + "'";
                DataTable dataSectionMG = DBUtils._getData(querySectionMG);
                //string SectionName = Convert.ToString(dataSectionMG.Rows[0]["SECTION_SHORT_NAME"]);
                if (Constaint._access != "01")
                {
                    if (dataSectionMG.Rows.Count <= 0)
                    {
                        MessageBox.Show("Không thể phê duyệt thông tin của bộ phận khác!", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    DialogResult Result = MessageBox.Show("Xác nhận phê duyệt thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Result == DialogResult.OK)
                    {
                        string STTConF1 = string.Empty;
                        string STTConF2 = string.Empty;
                        string STTTer = string.Empty;
                        string queryCheckStatus = "SELECT * FROM TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND  DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                        DataTable DataCheck = DBUtils._getData(queryCheckStatus);
                        if (DataCheck.Rows.Count > 0)
                        {
                             STTConF1 = Convert.ToString(DataCheck.Rows[0]["ID_STATUS_CON_F1"]);
                             STTConF2 = Convert.ToString(DataCheck.Rows[0]["ID_STATUS_CON_F2"]);
                             STTTer = Convert.ToString(DataCheck.Rows[0]["ID_STATUS_TER"]);
                        }
                        if (STTConF1 == "01" || STTConF2 == "01" || STTTer == "01")
                        {
                            MessageBox.Show("Nội dung chưa được xác nhận, Không thể phê duyệt", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        txtApprovedBy.Text = Constaint._nameUser;
                        txtDateApproved.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                        string queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET APPROVED_BY = @APPROVED_BY, DATE_APPROVED = @DATE_APPROVED, ID_STATUS_CON_F1 = @ID_STATUS_CON_F1, ID_STATUS_CON_F2 = @ID_STATUS_CON_F2, ID_STATUS_TER = @ID_STATUS_TER WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND  DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(queryUpdateApproved, conn))
                            {
                                cmd.Parameters.AddWithValue("@APPROVED_BY", txtApprovedBy.Text);
                                cmd.Parameters.AddWithValue("@DATE_APPROVED", Convert.ToDateTime(txtDateApproved.Text));
                                if (STTConF1 == "02")
                                {
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "03");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "00");
                                }
                                if (STTConF2 == "02")
                                {
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "03");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "00");
                                }
                                if (STTTer == "02")
                                {
                                    cmd.Parameters.AddWithValue("@ID_STATUS_TER", "03");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@ID_STATUS_TER", "00");
                                }
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Phê duyệt thành công thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnQApproved_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check == false)
                {
                    if (Constaint._sectionName == "QA" || Constaint._access == "01")
                    {
                        DialogResult Result = MessageBox.Show("Xác nhận thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Result == DialogResult.OK)
                        {
                            string STTConF1 = string.Empty;
                            string STTConF2 = string.Empty;
                            string STTTer = string.Empty;
                            string queryCheckStatus = "SELECT * FROM TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "' AND  DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                            DataTable DataCheckStatus = DBUtils._getData(queryCheckStatus);
                            if (DataCheckStatus.Rows.Count > 0)
                            {
                                STTConF1 = Convert.ToString(DataCheckStatus.Rows[0]["ID_STATUS_CON_F1"]);
                                STTConF2 = Convert.ToString(DataCheckStatus.Rows[0]["ID_STATUS_CON_F2"]);
                                STTTer = Convert.ToString(DataCheckStatus.Rows[0]["ID_STATUS_TER"]);
                            }
                            if (STTConF1 == "01" || STTConF1 == "02" || STTConF2 == "01" || STTConF2 == "02" || STTTer == "01" || STTTer == "02")
                            {
                                MessageBox.Show("Nội dung chưa được trưởng bộ phận phê duyệt, Không thể phê duyệt", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            string queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET QA_APPROVED_BY = @QA_APPROVED_BY, DATE_QA_APPROVED = @DATE_QA_APPROVED, ID_STATUS_CON_F1 = @ID_STATUS_CON_F1, ID_STATUS_CON_F2 = @ID_STATUS_CON_F2, ID_STATUS_TER = @ID_STATUS_TER WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(queryUpdateApproved, conn))
                                {
                                    cmd.Parameters.AddWithValue("@QA_APPROVED_BY", Constaint._nameUser);
                                    cmd.Parameters.AddWithValue("@DATE_QA_APPROVED", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "04");
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "04");
                                    cmd.Parameters.AddWithValue("@ID_STATUS_TER", "04");
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            //Update tên danh sách bộ phận chưa hoàn thành
                            string querySection = "SELECT t.DOCUMENT_NO, string_agg(t.DEPLOYMENT_SECTION, ', ') AS DEPLOYMENT_SECTION FROM (SELECT DOCUMENT_NO, DEPLOYMENT_SECTION from TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND (ID_STATUS_CON_F1 = '01' OR ID_STATUS_CON_F2 = '01' OR ID_STATUS_TER = '01')) AS t GROUP BY DOCUMENT_NO";
                            DataTable dataSection = DBUtils._getData(querySection);
                            string querySectionID = "SELECT t.DOCUMENT_NO, string_agg(t.DEPLOYMENT_SECTION_ID, ', ') AS DEPLOYMENT_SECTION_ID FROM (SELECT DOCUMENT_NO, DEPLOYMENT_SECTION_ID from TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND (ID_STATUS_CON_F1 = '01' OR ID_STATUS_CON_F2 = '01' OR ID_STATUS_TER = '01')) AS t GROUP BY DOCUMENT_NO";
                            DataTable dataSectionID = DBUtils._getData(querySectionID);
                            string Section = string.Empty;
                            string SectionID = string.Empty;
                            if (dataSection.Rows.Count > 0)
                            {
                                Section = Convert.ToString(dataSection.Rows[0]["DEPLOYMENT_SECTION"]);
                            }
                            if (dataSectionID.Rows.Count > 0)
                            {
                                SectionID = Convert.ToString(dataSectionID.Rows[0]["DEPLOYMENT_SECTION_ID"]);
                            }
                            string queryUpdateSection = "UPDATE TBL_DOCUMENT_MST SET DEPLOYMENT_SECTION = @DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID = @DEPLOYMENT_SECTION_ID WHERE DOCUMENT_NO = '" + Document_No + "'";
                            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(queryUpdateSection, conn))
                                {
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                                    cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", SectionID);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            string queryCheckFinish = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_NO = '" + Document_No + "'";
                            DataTable DataCheck = DBUtils._getData(queryCheckFinish);
                            if (string.IsNullOrEmpty(Convert.ToString(DataCheck.Rows[0]["DEPLOYMENT_SECTION"])))
                            {
                                string queryUpdateFinish = "UPDATE TBL_DOCUMENT_MST SET DUE_DATE_DEPLOYMENT = @DUE_DATE_DEPLOYMENT WHERE DOCUMENT_NO = '" + Document_No + "'";
                                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                                {
                                    conn.Open();
                                    using (SqlCommand cmd = new SqlCommand(queryUpdateFinish, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", DBNull.Value);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            MessageBox.Show("Xác nhận thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có quyền phê duyệt", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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