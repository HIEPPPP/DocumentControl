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
using DevExpress.XtraGrid.Views.Grid;
using Document_Control.FORM.DEPLOYMENT;

namespace Document_Control.FORM.RELEASE_OF_DOCUMENTS
{
    public partial class FRM_DEPLOYMENT_STATUS : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DEPLOYMENT_STATUS(string Document_No, string Rev)
        {
            this.Document_No = Document_No;
            this.Rev = Rev;
            InitializeComponent();
        }
        string Rev;
        string Document_No;
        private void FRM_DEPLOYMENT_STATUS_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string queryDataStatus = "  SELECT * FROM TBL_DEPLOYMENT_DOCUMENT WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "'";
                DataTable Data = DBUtils._getData(queryDataStatus);
                gcData.DataSource = Data;
                string queryStatus = "  SELECT ID_STATUS, STATUS FROM TBL_STATUS_MST";
                DataTable DataStatus = DBUtils._getData(queryStatus);
                rptDataStatus.DataSource = DataStatus;
                rptDataStatus.DisplayMember = "STATUS";
                rptDataStatus.ValueMember = "ID_STATUS";
                string queryDataMST = "SELECT * FROM TBL_DOCUMENT_REV_HISTORY WHERE DOCUMENT_NO = '" + Document_No + "' AND REV = '" + Rev + "'";
                DataTable DataMST = DBUtils._getData(queryDataMST);
                if (DataMST.Rows.Count > 0)
                {
                    txtDocumentNo.Text = Document_No;
                    txtDocumentName.Text = Convert.ToString(DataMST.Rows[0]["DOCUMENT_NAME"]);
                    txtRev.Text = Convert.ToString(DataMST.Rows[0]["REV"]);
                    txtDueDate.Text = Convert.ToString(DataMST.Rows[0]["DUE_DATE_DEPLOYMENT"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNMGApproved_Click(object sender, EventArgs e)
        {
            bool Check = false;
            string DeploymentSection = Convert.ToString(gvData.GetFocusedRowCellValue("DEPLOYMENT_SECTION"));
            string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
            if (Constaint._access == "01")
            {
                FRM_APPROVED_DEPLOYMENT_CONTENT f = new FRM_APPROVED_DEPLOYMENT_CONTENT(DeploymentSection, Document_No, Rev, Check);
                f.ShowDialog();
                FRM_DEPLOYMENT_STATUS_Load(sender, e);
            }
            else
            {
                if (DeploymentSection == Constaint._sectionShort)
                {
                    FRM_APPROVED_DEPLOYMENT_CONTENT f = new FRM_APPROVED_DEPLOYMENT_CONTENT(DeploymentSection, Document_No, Rev, Check);
                    f.ShowDialog();
                    FRM_DEPLOYMENT_STATUS_Load(sender, e);
                }
            }
        }

        private void gvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string StatusConF1 = Convert.ToString(gvData.GetRowCellValue(e.RowHandle, gvData.Columns["ID_STATUS_CON_F1"]));
                    if (e.Column.FieldName == "ID_STATUS_CON_F1")
                    {
                        if (StatusConF1 == "02")
                        {
                            e.Appearance.BackColor = Color.Yellow;
                        }
                        if (StatusConF1 == "03")
                        {
                            e.Appearance.BackColor = Color.GreenYellow;
                        }
                        if (StatusConF1 == "04")
                        {
                            e.Appearance.BackColor = Color.Green;
                        }
                    }
                    string StatusConF2 = Convert.ToString(gvData.GetRowCellValue(e.RowHandle, gvData.Columns["ID_STATUS_CON_F2"]));
                    if (e.Column.FieldName == "ID_STATUS_CON_F2")
                    {
                        if (StatusConF2 == "02")
                        {
                            e.Appearance.BackColor = Color.Yellow;
                        }
                        if (StatusConF2 == "03")
                        {
                            e.Appearance.BackColor = Color.GreenYellow;
                        }
                        if (StatusConF2 == "04")
                        {
                            e.Appearance.BackColor = Color.Green;
                        }
                    }
                    string StatusTer = Convert.ToString(gvData.GetRowCellValue(e.RowHandle, gvData.Columns["ID_STATUS_TER"]));
                    if (e.Column.FieldName == "ID_STATUS_TER")
                    {
                        if (StatusTer == "02")
                        {
                            e.Appearance.BackColor = Color.Yellow;
                        }
                        if (StatusTer == "03")
                        {
                            e.Appearance.BackColor = Color.GreenYellow;
                        }
                        if (StatusTer == "04")
                        {
                            e.Appearance.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void FRM_DEPLOYMENT_STATUS_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnQApproved_Click(object sender, EventArgs e)
        {
            bool Check = false;
            string DeploymentSection = Convert.ToString(gvData.GetFocusedRowCellValue("DEPLOYMENT_SECTION"));
            string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
            if (Constaint._access == "01")
            {
                FRM_APPROVED_DEPLOYMENT_CONTENT f = new FRM_APPROVED_DEPLOYMENT_CONTENT(DeploymentSection, Document_No, Rev, Check);
                f.ShowDialog();
                FRM_DEPLOYMENT_STATUS_Load(sender, e);
            }
            else
            {
                if (DeploymentSection == Constaint._sectionShort)
                {
                    FRM_APPROVED_DEPLOYMENT_CONTENT f = new FRM_APPROVED_DEPLOYMENT_CONTENT(DeploymentSection, Document_No, Rev, Check);
                    f.ShowDialog();
                    FRM_DEPLOYMENT_STATUS_Load(sender, e);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            bool Approved = false;
            bool Check = false;
            if (gvData.FocusedColumn.FieldName == "ID_STATUS_CON_F1")
            {
                string DeploymentSection = Convert.ToString(gvData.GetFocusedRowCellValue("DEPLOYMENT_SECTION"));
                string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
                if (Constaint._access == "01")
                {
                    FRM_DEPLOYMENT_RESULT f = new FRM_DEPLOYMENT_RESULT(DeploymentSection, Document_No, Rev, Check, "01", "F1", Approved);
                    f.ShowDialog();
                    FRM_DEPLOYMENT_STATUS_Load(sender, e);
                }
                else
                {
                    if (DeploymentSection == Constaint._sectionShort)
                    {
                        FRM_DEPLOYMENT_RESULT f = new FRM_DEPLOYMENT_RESULT(DeploymentSection, Document_No, Rev, Check, "01", "F1", Approved);
                        f.ShowDialog();
                        FRM_DEPLOYMENT_STATUS_Load(sender, e);
                    }
                }
            }
            if (gvData.FocusedColumn.FieldName == "ID_STATUS_CON_F2")
            {
                string DeploymentSection = Convert.ToString(gvData.GetFocusedRowCellValue("DEPLOYMENT_SECTION"));
                string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
                if (Constaint._access == "01")
                {
                    FRM_DEPLOYMENT_RESULT f = new FRM_DEPLOYMENT_RESULT(DeploymentSection, Document_No, Rev, Check, "02", "F2", Approved);
                    f.ShowDialog();
                    FRM_DEPLOYMENT_STATUS_Load(sender, e);
                }
                else
                {
                    if (DeploymentSection == Constaint._sectionShort)
                    {
                        FRM_DEPLOYMENT_RESULT f = new FRM_DEPLOYMENT_RESULT(DeploymentSection, Document_No, Rev, Check, "02", "F2", Approved);
                        f.ShowDialog();
                        FRM_DEPLOYMENT_STATUS_Load(sender, e);
                    }
                }
            }
            if (gvData.FocusedColumn.FieldName == "ID_STATUS_TER")
            {
                string DeploymentSection = Convert.ToString(gvData.GetFocusedRowCellValue("DEPLOYMENT_SECTION"));
                string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
                if (Constaint._access == "01")
                {
                    FRM_DEPLOYMENT_RESULT f = new FRM_DEPLOYMENT_RESULT(DeploymentSection, Document_No, Rev, Check, "03", "F2", Approved);
                    f.ShowDialog();
                    FRM_DEPLOYMENT_STATUS_Load(sender, e);
                }
                else
                {
                    if (DeploymentSection == Constaint._sectionShort)
                    {
                        FRM_DEPLOYMENT_RESULT f = new FRM_DEPLOYMENT_RESULT(DeploymentSection, Document_No, Rev, Check, "03", "F2", Approved);
                        f.ShowDialog();
                        FRM_DEPLOYMENT_STATUS_Load(sender, e);
                    }
                }
            }
        }
    }
}