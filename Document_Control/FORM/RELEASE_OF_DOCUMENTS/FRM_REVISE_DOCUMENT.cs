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
    public partial class FRM_REVISE_DOCUMENT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_REVISE_DOCUMENT(string Document_No)
        {
            this.Document_No = Document_No;
            InitializeComponent();
        }
        string Document_No;
        private void FRM_REVISE_DOCUMENT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryData = "SELECT * FROM TBL_DOCUMENT_MST WHERE DOCUMENT_NO = '" + Document_No + "'";
                DataTable Data = DBUtils._getData(queryData);
                if (Data.Rows.Count > 0)
                {
                    txtDocumentNo.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_NO"]);
                    txtDocumentType.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_TYPE"]);
                    txtDocumentLevel.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_LEVEL"]);
                    txtDocumentHightLv.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_HIGHT_LEVEL"]);
                    txtDocumentName.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_NAME"]);
                    int Rev = Convert.ToInt32(Data.Rows[0]["REV"]);
                    if (Rev < 9)
                    {
                        txtRev.Text = "0" + (Rev + 1).ToString();
                    }
                    if (Rev >= 9)
                    {
                        txtRev.Text = (Rev + 1).ToString();
                    }
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAttachForm_Click(object sender, EventArgs e)
        {
            FRM_DOCUMENT_FORM f = new FRM_DOCUMENT_FORM(txtDocumentNo.Text.Trim(), txtRev.Text.Trim());
            if (f.ShowDialog() == DialogResult.OK)
            {
                string CountForm = f.DataFromForm1;
                if (CountForm != null)
                {
                    txtForm.Text = "Đã chọn " + CountForm + " Form";
                }
            }
        }

        private void txtDeploymentSection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentNo.Text))
            {
                MessageBox.Show("Nhập số quản lí", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string selectedSection = txtDeploymentSection.Text.Trim();
            FRM_SELECT_SECTION f = new FRM_SELECT_SECTION(txtDocumentNo.Text, txtDocumentName.Text, txtRev.Text, txtDueDate.Text , selectedSection, "", "");
            if (f.ShowDialog() == DialogResult.OK)
            {
                string Section = f.DataSectionSend;
                if (Section != null)
                {
                    txtDeploymentSection.Text = Section;
                }
            }
        }

        private void tbnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string queryUpdate = "UPDATE TBL_DOCUMENT_MST SET FILE_DOCUMENT = @FILE_DOCUMENT, REV = @REV , FORM = @FORM, DEPLOYMENT_SECTION = @DEPLOYMENT_SECTION, DUE_DATE_DEPLOYMENT = @DUE_DATE_DEPLOYMENT, CONTENT_REVISE = @CONTENT_REVISE WHERE DOCUMENT_NO = @DOCUMENT_NO";
                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                        cmd.Parameters.AddWithValue("@FILE_DOCUMENT", txtAttachFile.Text);
                        cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                        cmd.Parameters.AddWithValue("@FORM", txtForm.Text);
                        cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", txtDeploymentSection.Text);
                        if (string.IsNullOrEmpty(txtDueDate.Text))
                        {
                            cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DUE_DATE_DEPLOYMENT", Convert.ToDateTime(txtDueDate.Text));
                        }
                        cmd.Parameters.AddWithValue("@CONTENT_REVISE", txtContentResive.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                //Lưu vào bảng lịch sử sửa đổi
                string querySaveHistoryRev = "INSERT INTO TBL_DOCUMENT_REV_HISTORY (DOCUMENT_TYPE, DOCUMENT_NO, DOCUMENT_LEVEL, DOCUMENT_HIGHT_LEVEL, FILE_DOCUMENT, REV, DOCUMENT_NAME, FORM, DEPLOYMENT_SECTION, DUE_DATE_DEPLOYMENT, CONTENT_REVISE, CREATE_AT, CREATE_BY) " +
                   "VALUES(@DOCUMENT_TYPE, @DOCUMENT_NO, @DOCUMENT_LEVEL, @DOCUMENT_HIGHT_LEVEL, @FILE_DOCUMENT, @REV, @DOCUMENT_NAME, @FORM, @DEPLOYMENT_SECTION, @DUE_DATE_DEPLOYMENT, @CONTENT_REVISE, @CREATE_AT, @CREATE_BY)";
                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(querySaveHistoryRev, conn))
                    {
                        cmd.Parameters.AddWithValue("@DOCUMENT_TYPE", txtDocumentType.Text);
                        cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                        cmd.Parameters.AddWithValue("@DOCUMENT_LEVEL", txtDocumentLevel.Text);
                        cmd.Parameters.AddWithValue("@DOCUMENT_HIGHT_LEVEL", txtDocumentHightLv.Text);
                        cmd.Parameters.AddWithValue("@FILE_DOCUMENT", txtAttachFile.Text);
                        cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                        cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                        cmd.Parameters.AddWithValue("@FORM", txtForm.Text);
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
                string queryDataTemporary = "SELECT * FROM TBL_TEMPORARY_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + txtDocumentNo.Text + "' AND REV = '"+txtRev.Text+"'";
                DataTable DataTemporary = DBUtils._getData(queryDataTemporary);
                string Section;
                if (DataTemporary.Rows.Count > 0)
                {
                    for (int i = 0; i < DataTemporary.Rows.Count; i++)
                    {
                        Section = Convert.ToString(DataTemporary.Rows[i]["DEPLOYMENT_SECTION"]);
                        string querySaveDeployment = "INSERT INTO TBL_DEPLOYMENT_DOCUMENT (DOCUMENT_NO, REV, DOCUMENT_NAME, DEPLOYMENT_SECTION, ISSUED, ORGANIZATION_REQUEST, REQUIRED_CONTENT, DEPLOYMENT_DEADLINE, ID_STATUS) VALUES (@DOCUMENT_NO, @REV, @DOCUMENT_NAME, @DEPLOYMENT_SECTION, @ISSUED, @ORGANIZATION_REQUEST, @REQUIRED_CONTENT, @DEPLOYMENT_DEADLINE, @ID_STATUS)";
                        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(querySaveDeployment, conn))
                            {
                                cmd.Parameters.AddWithValue("@DOCUMENT_NO", txtDocumentNo.Text);
                                cmd.Parameters.AddWithValue("@REV", txtRev.Text);
                                cmd.Parameters.AddWithValue("@DOCUMENT_NAME", txtDocumentName.Text);
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
                                cmd.Parameters.AddWithValue("@ISSUED", "QA");
                                cmd.Parameters.AddWithValue("@ORGANIZATION_REQUEST", "QA");
                                cmd.Parameters.AddWithValue("@REQUIRED_CONTENT", txtContentResive.Text);
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_DEADLINE", Convert.ToDateTime(txtDueDate.Text));
                                cmd.Parameters.AddWithValue("@ID_STATUS", "01");
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}