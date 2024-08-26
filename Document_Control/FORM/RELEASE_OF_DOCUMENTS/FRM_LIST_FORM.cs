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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_LIST_FORM : DevExpress.XtraEditors.XtraForm
    {
        public FRM_LIST_FORM(string Document_No, string Rev)
        {
            this.Rev = Rev;
            this.Document_No = Document_No;
            InitializeComponent();
        }
        string Document_No;
        string Rev;
        private void FRM_LIST_FORM_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryData = "SELECT * FROM TBL_DOCUMENT_FORM WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "'";
                DataTable Data = DBUtils._getData(queryData);
                gcData.DataSource = Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string _fileCopy = string.Empty;
        string pathSaveFile = string.Empty;
        string fileExtension;
        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog = new SaveFileDialog();
                SaveFileDialog.FileName = Convert.ToString(gvData.GetFocusedRowCellValue("FORM_NO"));
                DialogResult result = SaveFileDialog.ShowDialog();
                SaveFileDialog.CheckFileExists = true;
                SaveFileDialog.AddExtension = true;
                SaveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (result == DialogResult.OK)
                {
                    //SaveFileDialog.FileName = Convert.ToString(gvData.GetFocusedRowCellValue("FORM_NO"));
                    //_fileCopy = pathPdfFile.Substring(pathPdfFile.LastIndexOf("\\"));
                    pathSaveFile = SaveFileDialog.FileName;
                    int LastIndex = pathSaveFile.LastIndexOf('\\');
                    int SecondIndex = pathSaveFile.LastIndexOf('\\', LastIndex - 1);
                    string FolderSave = SaveFileDialog.FileName.Substring(0, SecondIndex);
                    fileExtension = Path.GetExtension(pathSaveFile);
                    string fileUpLoad = Path.Combine(Constaint._folderFileUpload, Convert.ToString(gvData.GetFocusedRowCellValue("FORM_NO")));
                    File.Copy(fileUpLoad, pathSaveFile, true);
                    MessageBox.Show("Lưu file thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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