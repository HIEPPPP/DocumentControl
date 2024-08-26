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
using System.IO;
using System.Data.SqlClient;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_UPDATE_DOCUMENT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_UPDATE_DOCUMENT(string DocumentNo)
        {
            this.DocumentNo = DocumentNo;
            InitializeComponent();
        }
        string DocumentNo;
        string DocumentTopLv = string.Empty;
        string ListSectionID = string.Empty;
        string ListSection = string.Empty;
        private void tbnSave_Click(object sender, EventArgs e)
        {
            try
            {
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
                    string queryUpdateMST = "UPDATE TBL_DOCUMENT_MST SET DOCUMENT_LEVEL = @DOCUMENT_LEVEL, DOCUMENT_TOP_LEVEL = @DOCUMENT_TOP_LEVEL, DOCUMENT_HIGHT_LEVEL = @DOCUMENT_HIGHT_LEVEL, DOCUMENT_LEVEL_B = @DOCUMENT_LEVEL_B, FILE_DOCUMENT = @FILE_DOCUMENT, DOCUMENT_NAME = @DOCUMENT_NAME, FORM = @FORM, DEPLOYMENT_SECTION = @DEPLOYMENT_SECTION, " +
                        "DEPLOYMENT_SECTION_ID = @DEPLOYMENT_SECTION_ID, DEPLOYMENTED_SECTION = @DEPLOYMENTED_SECTION, DEPLOYMENTED_SECTION_ID = @DEPLOYMENTED_SECTION_ID, DUE_DATE_DEPLOYMENT = @DUE_DATE_DEPLOYMENT, CONTENT_REVISE = @CONTENT_REVISE, UPDATE_AT = @UPDATE_AT, UPDATE_BY = @UPDATE_BY WHERE DOCUMENT_NO = @DOCUMENT_NO";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(queryUpdateMST, conn))
                        {
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
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            cmd.Parameters.AddWithValue("@CONTENT_REVISE", txtContentResive.Text);
                            cmd.Parameters.AddWithValue("@UPDATE_AT", DateTime.Now);
                            cmd.Parameters.AddWithValue("@UPDATE_BY", Constaint._userID);
                            int resultRegEquiment = cmd.ExecuteNonQuery();

                        }
                    }
                    //Update bảng lịch sử sửa đổi
                    string queryUpdateHistory = "UPDATE TBL_DOCUMENT_REV_HISTORY SET DOCUMENT_LEVEL = @DOCUMENT_LEVEL, DOCUMENT_TOP_LEVEL = @DOCUMENT_TOP_LEVEL, DOCUMENT_HIGHT_LEVEL = @DOCUMENT_HIGHT_LEVEL, DOCUMENT_LEVEL_B = @DOCUMENT_LEVEL_B, FILE_DOCUMENT = @FILE_DOCUMENT, DOCUMENT_NAME = @DOCUMENT_NAME, FORM = @FORM, DEPLOYMENT_SECTION = @DEPLOYMENT_SECTION, " +
                        "DEPLOYMENT_SECTION_ID = @DEPLOYMENT_SECTION_ID, DEPLOYMENTED_SECTION = @DEPLOYMENTED_SECTION, DEPLOYMENTED_SECTION_ID = @DEPLOYMENTED_SECTION_ID, DUE_DATE_DEPLOYMENT = @DUE_DATE_DEPLOYMENT, CONTENT_REVISE = @CONTENT_REVISE, UPDATE_AT = @UPDATE_AT, UPDATE_BY = @UPDATE_BY WHERE DOCUMENT_NO = @DOCUMENT_NO AND REV = @REV";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(queryUpdateHistory, conn))
                        {
                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                            cmd.Parameters.AddWithValue("@REV", txtRev.Text);
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
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                            }
                            cmd.Parameters.AddWithValue("@CONTENT_REVISE", txtContentResive.Text);
                            cmd.Parameters.AddWithValue("@UPDATE_AT", DateTime.Now);
                            cmd.Parameters.AddWithValue("@UPDATE_BY", Constaint._userID);
                            int resultRegEquiment = cmd.ExecuteNonQuery();
                        }
                    }
                    if (!string.IsNullOrEmpty(ListSection))
                    {
                        string queryDelete = "DELETE TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '"+txtRev.Text+"'";
                        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                            {
                                int N = cmd.ExecuteNonQuery();
                            }
                        }
                        string queryDataTemporary = "SELECT * FROM TBL_TEMPORARY_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "'";
                        DataTable DataTemporary = DBUtils._getData(queryDataTemporary);
                        string Section;
                        string SectionID;
                        if (DataTemporary.Rows.Count > 0)
                        {
                            for (int i = 0; i < DataTemporary.Rows.Count; i++)
                            {
                                Section = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION"]);
                                SectionID = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION_ID"]);
                                string querySaveDeployment = "INSERT INTO TBL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID, ISSUED, ORGANIZATION_REQUEST, REQUIRED_CONTENT, DEPLOYMENT_DEADLINE, ID_STATUS) VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @DEPLOYMENT_SECTION_ID, @ISSUED, @ORGANIZATION_REQUEST, @REQUIRED_CONTENT, @DEPLOYMENT_DEADLINE, @ID_STATUS)";
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
                                            cmd.Parameters.AddWithValue("@ID_STATUS", "04");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("@ID_STATUS", "01");
                                        }
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FRM_UPDATE_DOCUMENT_Load(object sender, EventArgs e)
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
                string queryData = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_NO = '" + DocumentNo + "'";
                DataTable Data = DBUtils._getData(queryData);
                if (Data.Rows.Count > 0)
                {
                    txtDocumentNo.Text = Data.Rows[0]["DOCUMENT_NO"].ToString();
                    txtDocumentLevel.Text = Data.Rows[0]["DOCUMENT_LEVEL"].ToString();
                    txtDocumentHightLv.Text = Data.Rows[0]["DOCUMENT_HIGHT_LEVEL"].ToString();
                    txtDocumentType.Text = Data.Rows[0]["DOCUMENT_TYPE"].ToString();
                    txtAttachFile.Text = Data.Rows[0]["FILE_DOCUMENT"].ToString();
                    txtRev.Text = Data.Rows[0]["REV"].ToString();
                    txtDocumentName.Text = Data.Rows[0]["DOCUMENT_NAME"].ToString();
                    txtForm.Text = Data.Rows[0]["FORM"].ToString();
                    txtDeploymentSection.Text = Data.Rows[0]["DEPLOYMENT_SECTION"].ToString();
                    txtDueDate.Text = Data.Rows[0]["DUE_DATE_DEPLOYMENT"].ToString();
                    txtContentResive.Text = Data.Rows[0]["CONTENT_REVISE"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                    string fileUpLoad = Path.Combine(Constaint._folderFileUpload, txtAttachFile.Text.Trim());
                    File.Copy(pathPdfFile, fileUpLoad, true);
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
            string selectedSection = txtDeploymentSection.Text.Trim();
            FRM_SELECT_SECTION f = new FRM_SELECT_SECTION(txtDocumentNo.Text, txtDocumentName.Text, txtRev.Text, txtDueDate.Text, selectedSection, "", "");
            if (f.ShowDialog() == DialogResult.OK)
            {
                ListSection = f.DataSectionSend;
                string ListSectionIDSend = f.DataSectionIDSend;
                if (ListSection != null)
                {
                    txtDeploymentSection.Text = ListSection;
                    ListSectionID = ListSectionIDSend;
                    txtDocumentNo.ReadOnly = true;
                    txtRev.ReadOnly = true;
                }
            }
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
    }
}