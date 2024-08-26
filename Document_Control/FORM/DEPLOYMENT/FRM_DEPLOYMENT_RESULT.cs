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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_DEPLOYMENT_RESULT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DEPLOYMENT_RESULT(string DeploymentSection, string Document_No, string Rev, bool Check, string IDProductionSegment, string Factory, bool Approved)
        {
            this.Approved = Approved;
            this.Check = Check;
            this.Rev = Rev;
            this.DeploymentSection = DeploymentSection;
            this.Document_No = Document_No;
            this.IDProductionSegment = IDProductionSegment;
            this.Factory = Factory;
            InitializeComponent();
        }
        bool Approved;
        bool Check;
        string Document_No;
        string DeploymentSection;
        string Rev;
        string IDProductionSegment;
        string Factory;
        private void FRM_DEPLOYMENT_RESULT_Load(object sender, EventArgs e)
        {
            if (Check == true)
            {
                btnAddRow.Enabled = false;
                btnDel.Enabled = false;
                btnSave.Enabled = false;
            }
            LoadData();
        }
        DateTime DueDate;
        private void LoadData()
        {
            try
            {
                string queryDataDetail = string.Empty;
                if (Approved == true)
                {
                    queryDataDetail = "SELECT * FROM TBL_DETAIL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "' AND REV = '" + Rev + "'";
                }
                else
                {
                    queryDataDetail = "SELECT * FROM TBL_DETAIL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "' AND REV = '" + Rev + "' AND ID_PRODUCTION_SEGMENT = '" + IDProductionSegment + "' AND FACTORY = '" + Factory + "'";
                }
                DataTable DataDetail = DBUtils._getData(queryDataDetail);
                gcData.DataSource = DataDetail;
                string queryProductionSegment = "SELECT * FROM TBL_PRODUCTION_SEGMENT";
                DataTable DataSecment = DBUtils._getData(queryProductionSegment);
                rptProductionSecment.DataSource = DataSecment;
                rptProductionSecment.DisplayMember = "PRODUCTION_SEGMENT";
                rptProductionSecment.ValueMember = "ID_PRODUCTION_SEGMENT";
                string queryData = "SELECT * FROM TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "' AND REV = '" + Rev + "'";
                DataTable Data = DBUtils._getData(queryData);
                if (Data.Rows.Count > 0)
                {
                    txtRev.Text = Convert.ToString(Data.Rows[0]["REV"]);
                    txtIssued.Text = "QA";
                    txtDocumentName.Text = Convert.ToString(Data.Rows[0]["DOCUMENT_NAME"]);
                    lbSection.Text = Convert.ToString(Data.Rows[0]["DEPLOYMENT_SECTION"]);
                    if (IDProductionSegment == "01")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["CONFIRMED_BY_CON_F1"])))
                        {
                            txtConfirmBy.Text = Convert.ToString(Data.Rows[0]["CONFIRMED_BY_CON_F1"]);
                        }
                        if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["DATE_CONFIRM_CON_F1"])))
                        {
                            txtDateConfirmed.Text = Convert.ToDateTime(Data.Rows[0]["DATE_CONFIRM_CON_F1"]).ToString("dd/MM/yyyy");
                        }
                    }
                    if (IDProductionSegment == "02")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["CONFIRMED_BY_CON_F2"])))
                        {
                            txtConfirmBy.Text = Convert.ToString(Data.Rows[0]["CONFIRMED_BY_CON_F2"]);
                        }
                        if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["DATE_CONFIRM_CON_F2"])))
                        {
                            txtDateConfirmed.Text = Convert.ToDateTime(Data.Rows[0]["DATE_CONFIRM_CON_F2"]).ToString("dd/MM/yyyy");
                        }
                    }
                    if (IDProductionSegment == "03")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["CONFIRMED_BY_TER"])))
                        {
                            txtConfirmBy.Text = Convert.ToString(Data.Rows[0]["CONFIRMED_BY_TER"]);
                        }
                        if (!string.IsNullOrEmpty(Convert.ToString(Data.Rows[0]["DATE_CONFIRM_TER"])))
                        {
                            txtDateConfirmed.Text = Convert.ToDateTime(Data.Rows[0]["DATE_CONFIRM_TER"]).ToString("dd/MM/yyyy");
                        }
                    }
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = MessageBox.Show("Xác nhận lưu thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    for (int i = 0; i < gvData.RowCount; i++)
                    {
                        DataRow row = gvData.GetDataRow(i);
                        string querySave = "UPDATE TBL_DETAIL_DEPLOYMENT_DOCUMENT SET DEPLOYMENT_CONTENT = @DEPLOYMENT_CONTENT, RESULT_FILE = @RESULT_FILE, FINISH_DAY = @FINISH_DAY WHERE ID_IDENTITY = @ID_IDENTITY";
                        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(querySave, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_IDENTITY", Convert.ToString(row["ID_IDENTITY"]));
                                cmd.Parameters.AddWithValue("@DEPLOYMENT_CONTENT", Convert.ToString(row["DEPLOYMENT_CONTENT"]));
                                cmd.Parameters.AddWithValue("@RESULT_FILE", Convert.ToString(row["RESULT_FILE"]));
                                if (string.IsNullOrEmpty(Convert.ToString(row["FINISH_DAY"])))
                                {
                                    cmd.Parameters.AddWithValue("@FINISH_DAY", DBNull.Value);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@FINISH_DAY", Convert.ToDateTime(row["FINISH_DAY"]));
                                }
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                gvData.AddNewRow();
                gvData.Focus();
                //gvData.FocusedRowHandle = GridControl.NewItemRowHandle;
                //gvData.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvData.FocusedColumn = gvData.Columns[0];
                gvData.ShowEditor();
                int y = gvData.FocusedRowHandle;
                gvData.SetRowCellValue(y, gvData.Columns["ORGANIZATION_REQUEST"], "QA");
                gvData.SetRowCellValue(y, gvData.Columns["DEPLOYMENT_DEADLINE"], DueDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string _fileCopy = string.Empty;
        string pathPdfFile = string.Empty;
        string fileExtension;
        private void btnFileConF1_Click(object sender, EventArgs e)
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
                    int y = gvData.FocusedRowHandle;
                    gvData.SetRowCellValue(y, gvData.Columns["RESULT_FILE"], _fileCopy.Substring(1));
                    string fileUpLoad = Path.Combine(Constaint._folderFileUpload, _fileCopy.Substring(1));
                    File.Copy(pathPdfFile, fileUpLoad, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFileConF2_Click(object sender, EventArgs e)
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
                    int y = gvData.FocusedRowHandle;
                    gvData.SetRowCellValue(y, gvData.Columns["RESULT_FILE_CON_F2"], _fileCopy.Substring(1));
                    string fileUpLoad = Path.Combine(Constaint._folderFileUpload, _fileCopy.Substring(1));
                    File.Copy(pathPdfFile, fileUpLoad, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFileTer_Click(object sender, EventArgs e)
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
                    int y = gvData.FocusedRowHandle;
                    gvData.SetRowCellValue(y, gvData.Columns["RESULT_FILE_TER"], _fileCopy.Substring(1));
                    string fileUpLoad = Path.Combine(Constaint._folderFileUpload, _fileCopy.Substring(1));
                    File.Copy(pathPdfFile, fileUpLoad, true);
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

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                if (info.InRow || info.InRowCell)
                {
                    string colCaption = info.Column == null ? "N/A" : info.Column.GetTextCaption();
                    if (gvData.FocusedColumn.FieldName == "RESULT_FILE_CON_F1")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(gvData.GetFocusedRowCellValue("RESULT_FILE_CON_F1"))))
                        {
                            System.Diagnostics.Process.Start(Constaint._folderFileUpload + gvData.GetFocusedRowCellValue("RESULT_FILE_CON_F1").ToString());
                        }
                    }
                    if (gvData.FocusedColumn.FieldName == "RESULT_FILE_CON_F2")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(gvData.GetFocusedRowCellValue("RESULT_FILE_CON_F2"))))
                        {
                            System.Diagnostics.Process.Start(Constaint._folderFileUpload + gvData.GetFocusedRowCellValue("RESULT_FILE_CON_F2").ToString());
                        }
                    }
                    if (gvData.FocusedColumn.FieldName == "RESULT_FILE_TER")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(gvData.GetFocusedRowCellValue("RESULT_FILE_TER"))))
                        {
                            System.Diagnostics.Process.Start(Constaint._folderFileUpload + gvData.GetFocusedRowCellValue("RESULT_FILE_TER").ToString());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("File không tồn tại!");
            }
        }

        private void txtConfirmBy_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!string.IsNullOrEmpty(txtDateConfirmed.Text.Trim()))
            //    {
            //        return;
            //    }
            //    if (Check == false)
            //    {
            //        if (Constaint._access != "01")
            //        {
            //            if (lbSection.Text != Constaint._sectionShort)
            //            {
            //                MessageBox.Show("Không thể xác nhận thông tin bộ phận khác", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;
            //            }
            //        }
            //        DialogResult Result = MessageBox.Show("Xác nhận thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //        if (Result == DialogResult.OK)
            //        {
            //            txtConfirmBy.Text = Constaint._nameUser;
            //            txtDateConfirmed.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
            //            string queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET CONFIRMED_BY = @CONFIRMED_BY, DATE_CONFIRM = @DATE_CONFIRM, ID_STATUS = @ID_STATUS WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
            //            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
            //            {
            //                conn.Open();
            //                using (SqlCommand cmd = new SqlCommand(queryUpdateApproved, conn))
            //                {
            //                    cmd.Parameters.AddWithValue("@CONFIRMED_BY", txtConfirmBy.Text);
            //                    cmd.Parameters.AddWithValue("@DATE_CONFIRM", Convert.ToDateTime(txtDateConfirmed.Text));
            //                    cmd.Parameters.AddWithValue("@ID_STATUS", "02");
            //                    cmd.ExecuteNonQuery();
            //                }
            //            }
            //            MessageBox.Show("Xác nhận thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void txtApprovedBy_DoubleClick(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtDateApproved.Text.Trim()))
            //{
            //    return;
            //}
            //if (Check == false)
            //{
            //    string Section = Convert.ToString(gvData.GetFocusedRowCellValue("SECTION"));
            //    string querySectionMG = "SELECT * FROM TBL_SECTION_MANAGER WHERE SECTION_SHORT_NAME = '" + Section + "' AND ID_MANAGER = '" + Constaint._userID + "'";
            //    DataTable dataSectionMG = DBUtils._getData(querySectionMG);
            //    //string SectionName = Convert.ToString(dataSectionMG.Rows[0]["SECTION_SHORT_NAME"]);
            //    if (Constaint._access != "01")
            //    {
            //        if (dataSectionMG.Rows.Count <= 0)
            //        {
            //            MessageBox.Show("Không thể phê duyệt thông tin của bộ phận khác!", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        DialogResult Result = MessageBox.Show("Xác nhận phê duyệt thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //        if (Result == DialogResult.OK)
            //        {
            //            txtApprovedBy.Text = Constaint._nameUser;
            //            txtDateApproved.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
            //            string queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET APPROVED_BY = @APPROVED_BY, DATE_APPROVED = @DATE_APPROVED, ID_STATUS = @ID_STATUS WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
            //            using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
            //            {
            //                conn.Open();
            //                using (SqlCommand cmd = new SqlCommand(queryUpdateApproved, conn))
            //                {
            //                    cmd.Parameters.AddWithValue("@APPROVED_BY", txtApprovedBy.Text);
            //                    cmd.Parameters.AddWithValue("@DATE_APPROVED", Convert.ToDateTime(txtDateApproved.Text));
            //                    cmd.Parameters.AddWithValue("@ID_STATUS", "03");
            //                    cmd.ExecuteNonQuery();
            //                }
            //            }
            //            MessageBox.Show("Phê duyệt thành công thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
        }

        private void txtQAApproved_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!string.IsNullOrEmpty(txtDateQAApproved.Text.Trim()))
            //    {
            //        return;
            //    }
            //    if (Check == false)
            //    {
            //        if (Constaint._sectionName == "QA" || Constaint._access == "01")
            //        {
            //            DialogResult Result = MessageBox.Show("Xác nhận thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //            if (Result == DialogResult.OK)
            //            {
            //                txtQAApproved.Text = Constaint._nameUser;
            //                txtDateQAApproved.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
            //                string queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET QA_APPROVED_BY = @QA_APPROVED_BY, DATE_QA_APPROVED = @DATE_QA_APPROVED, ID_STATUS = @ID_STATUS WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
            //                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
            //                {
            //                    conn.Open();
            //                    using (SqlCommand cmd = new SqlCommand(queryUpdateApproved, conn))
            //                    {
            //                        cmd.Parameters.AddWithValue("@QA_APPROVED_BY", txtQAApproved.Text);
            //                        cmd.Parameters.AddWithValue("@DATE_QA_APPROVED", Convert.ToDateTime(txtDateQAApproved.Text));
            //                        cmd.Parameters.AddWithValue("@ID_STATUS", "04");
            //                        cmd.ExecuteNonQuery();
            //                    }
            //                }
            //                //Update tên danh sách bộ phận chưa hoàn thành
            //                string querySection = "SELECT t.DOCUMENT_NO, string_agg(t.DEPLOYMENT_SECTION, ', ') AS DEPLOYMENT_SECTION FROM (SELECT DOCUMENT_NO, DEPLOYMENT_SECTION from TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND ID_STATUS = '01') AS t GROUP BY DOCUMENT_NO";
            //                DataTable dataSection = DBUtils._getData(querySection);
            //                string querySectionID = "SELECT t.DOCUMENT_NO, string_agg(t.DEPLOYMENT_SECTION_ID, ', ') AS DEPLOYMENT_SECTION_ID FROM (SELECT DOCUMENT_NO, DEPLOYMENT_SECTION_ID from TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND ID_STATUS = '01') AS t GROUP BY DOCUMENT_NO";
            //                DataTable dataSectionID = DBUtils._getData(querySectionID);
            //                string Section = string.Empty;
            //                string SectionID = string.Empty;
            //                if (dataSection.Rows.Count > 0)
            //                {
            //                    Section = Convert.ToString(dataSection.Rows[0]["DEPLOYMENT_SECTION"]);
            //                }
            //                if (dataSectionID.Rows.Count > 0)
            //                {
            //                    SectionID = Convert.ToString(dataSectionID.Rows[0]["DEPLOYMENT_SECTION_ID"]);
            //                }
            //                string queryUpdateSection = "UPDATE TBL_DOCUMENT_MST SET DEPLOYMENT_SECTION = @DEPLOYMENT_SECTION, DEPLOYMENT_SECTION_ID = @DEPLOYMENT_SECTION_ID WHERE DOCUMENT_NO = '" + Document_No + "'";
            //                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
            //                {
            //                    conn.Open();
            //                    using (SqlCommand cmd = new SqlCommand(queryUpdateSection, conn))
            //                    {
            //                        cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION", Section);
            //                        cmd.Parameters.AddWithValue("@DEPLOYMENT_SECTION_ID", SectionID);
            //                        cmd.ExecuteNonQuery();
            //                    }
            //                }
            //                MessageBox.Show("Xác nhận thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Không có quyền phê duyệt", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            gvData.DeleteSelectedRows();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDateConfirmed.Text.Trim()))
                {
                    return;
                }
                if (Check == false)
                {
                    if (Constaint._access != "01")
                    {
                        if (lbSection.Text != Constaint._sectionShort)
                        {
                            MessageBox.Show("Không thể xác nhận thông tin bộ phận khác", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    DialogResult Result = MessageBox.Show("Xác nhận thông tin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Result == DialogResult.OK)
                    {
                        txtConfirmBy.Text = Constaint._nameUser;
                        txtDateConfirmed.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                        string queryUpdateApproved = string.Empty;
                        if (IDProductionSegment == "01")
                        {
                            queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET CONFIRMED_BY_CON_F1 = @CONFIRMED_BY_CON_F1, DATE_CONFIRM_CON_F1 = @DATE_CONFIRM_CON_F1, ID_STATUS_CON_F1 = @ID_STATUS_CON_F1 WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                        }
                        if (IDProductionSegment == "02")
                        {
                            queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET CONFIRMED_BY_CON_F2 = @CONFIRMED_BY_CON_F2, DATE_CONFIRM_CON_F2 = @DATE_CONFIRM_CON_F2, ID_STATUS_CON_F2 = @ID_STATUS_CON_F2 WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                        }
                        if (IDProductionSegment == "03")
                        {
                            queryUpdateApproved = "UPDATE TBL_DEPLOYMENT_DOCUMENT SET CONFIRMED_BY_TER = @CONFIRMED_BY_TER, DATE_CONFIRM_TER = @DATE_CONFIRM_TER, ID_STATUS_TER = @ID_STATUS_TER WHERE DOCUMENT_NO = '" + Document_No + "' AND DEPLOYMENT_SECTION = '" + DeploymentSection + "'";
                        }
                        using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(queryUpdateApproved, conn))
                            {
                                if (IDProductionSegment == "01")
                                {
                                    cmd.Parameters.AddWithValue("@CONFIRMED_BY_CON_F1", txtConfirmBy.Text);
                                    cmd.Parameters.AddWithValue("@DATE_CONFIRM_CON_F1", Convert.ToDateTime(txtDateConfirmed.Text));
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F1", "02");
                                }
                                if (IDProductionSegment == "02")
                                {
                                    cmd.Parameters.AddWithValue("@CONFIRMED_BY_CON_F2", txtConfirmBy.Text);
                                    cmd.Parameters.AddWithValue("@DATE_CONFIRM_CON_F2", Convert.ToDateTime(txtDateConfirmed.Text));
                                    cmd.Parameters.AddWithValue("@ID_STATUS_CON_F2", "02");
                                }
                                if (IDProductionSegment == "03")
                                {
                                    cmd.Parameters.AddWithValue("@CONFIRMED_BY_TER", txtConfirmBy.Text);
                                    cmd.Parameters.AddWithValue("@DATE_CONFIRM_TER", Convert.ToDateTime(txtDateConfirmed.Text));
                                    cmd.Parameters.AddWithValue("@ID_STATUS_TER", "02");
                                }
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Xác nhận thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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