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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Document_Control.DB;
using System.Data.SqlClient;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_DOCUMENT_FORM : DevExpress.XtraEditors.XtraForm
    {
        public string DataFromForm1 { get; set; }
        public FRM_DOCUMENT_FORM(string Document_No, string Rev)
        {
            this.Rev = Rev;
            this.Document_No = Document_No;
            InitializeComponent();
        }
        string Document_No;
        string Rev;
        private void FRM_DOCUMENT_FORM_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryData = "SELECT * FROM TBL_DOCUMENT_FORM WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "'";
                DataTable DataForm = DBUtils._getData(queryData);
                gcData.DataSource = DataForm;

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
                //gvData.FocusedRowHandle = GridControl.NewItemRowHandle;
                //gvData.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvData.FocusedColumn = gvData.Columns[0];
                gvData.ShowEditor();
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
                    int y = gvData.FocusedRowHandle;
                    gvData.SetRowCellValue(y, gvData.Columns["FORM_NO"], _fileCopy.Substring(1));
                    string fileUpLoad = Path.Combine(Constaint._folderFileUpload, _fileCopy.Substring(1));
                    File.Copy(pathPdfFile, fileUpLoad, true);
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
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    DataRow row = gvData.GetDataRow(i);
                    if (row.RowState == DataRowState.Added)
                    {
                        if (string.IsNullOrEmpty(Convert.ToString(row["FORM_NAME"])))
                        {
                            MessageBox.Show("Nhập tên Form!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (string.IsNullOrEmpty(Convert.ToString(row["FORM_NO"])))
                        {
                            MessageBox.Show("Chọn File Form!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                string queryDelete = "DELETE TBL_DOCUMENT_FORM WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "'";
                using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                    {
                        int resultRegEquiment = cmd.ExecuteNonQuery();
                    }
                }
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    DataRow row = gvData.GetDataRow(i);
                    string Form_No = Convert.ToString(row["FORM_NO"]);
                    string Form_Name = Convert.ToString(row["FORM_NAME"]);
                    string querySave = "INSERT INTO TBL_DOCUMENT_FORM (DOCUMENT_NO, FORM_NO, FORM_NAME, REV) VALUES (@DOCUMENT_NO , @FORM_NO, @FORM_NAME, @REV)";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(querySave, conn))
                        {
                            cmd.Parameters.AddWithValue("@DOCUMENT_NO", Document_No);
                            cmd.Parameters.AddWithValue("@FORM_NO", Form_No);
                            cmd.Parameters.AddWithValue("@FORM_NAME", Form_Name);
                            cmd.Parameters.AddWithValue("@REV", Rev);
                            int resultRegEquiment = cmd.ExecuteNonQuery();
                        }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gvData.DeleteSelectedRows();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                    if (colCaption == "Form No")
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(gvData.GetFocusedRowCellValue("FORM_NO"))))
                        {
                            System.Diagnostics.Process.Start(Constaint._folderFileUpload + gvData.GetFocusedRowCellValue("FORM_NO").ToString());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("File không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}