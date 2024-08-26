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

namespace Document_Control.FORM.ADMIN
{
    public partial class FRM_ADD_ACCESS_MANGER : DevExpress.XtraEditors.XtraForm
    {
        public FRM_ADD_ACCESS_MANGER()
        {
            InitializeComponent();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string queryCheck = "SELECT u.USER_ID, u.FULLNAME, u.FACTORY, s.SECTION_SHORT_NAME, a.ACCESS FROM TBL_ACCOUNT u LEFT JOIN TBL_SECTION_MST s ON u.SECTION_ID = s.SECTION_ID LEFT JOIN TBL_ACCESS a ON u.ID_ACCESS = a.ID_ACCESS WHERE u.USER_ID = '" + txtMaNV.Text + "'";
                DataTable dataCheck = DBUtils._getData(queryCheck);
                txtTen.Text = Convert.ToString(dataCheck.Rows[0]["FULLNAME"]);
                txtBoPhan.Text = Convert.ToString(dataCheck.Rows[0]["SECTION_SHORT_NAME"]);
                txtNhaMay.Text = Convert.ToString(dataCheck.Rows[0]["FACTORY"]);
                txtQuyen.Text = Convert.ToString(dataCheck.Rows[0]["ACCESS"]);
            }
            catch
            {
                txtNhaMay.Text = "";
                txtBoPhan.Text = "";
                txtQuyen.Text = "";
                txtTen.Text = "";
            }
        }

        private void FRM_ADD_ACCESS_MANGER_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                string queryLoadSection = "SELECT * FROM TBL_SECTION_MST";
                DataTable dataSection = DBUtils._getData(queryLoadSection);
                txtSectionAdd.DataSource = dataSection;
                txtSectionAdd.ValueMember = "SECTION_ID";
                txtSectionAdd.DisplayMember = "SECTION_SHORT_NAME";
                txtSectionAdd.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM TBL_SECTION_MANAGER";
                DataTable Data = DBUtils._getData(query);
                gcData.DataSource = Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSectionAdd.Text.Trim()))
                {
                    MessageBox.Show("Chọn bộ phận phê duyệt!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtTen.Text.Trim()))
                {
                    MessageBox.Show("Nhận thông tin nhân viên!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string queryCheck = "SELECT * FROM TBL_SECTION_MANAGER WHERE ID_MANAGER = '" + txtMaNV.Text + "' AND SECTION_SHORT_NAME = '" + txtSectionAdd.Text + "'";
                DataTable dataCheck = DBUtils._getData(queryCheck);
                if (dataCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Manager đã có quyền phê duyệt bộ phận này trước đó!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string queryAdd = "INSERT INTO TBL_SECTION_MANAGER (ID_MANAGER, FULLNAME, SECTION_SHORT_NAME, SECTION_ID) " +
                        "VALUES (@ID_MANAGER, @FULLNAME, @SECTION_SHORT_NAME, @SECTION_ID)";
                using (SqlConnection _conn = new SqlConnection(DBUtils._stringConnection))
                {
                    _conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryAdd, _conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_MANAGER", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@FULLNAME", txtTen.Text);
                        cmd.Parameters.AddWithValue("@SECTION_SHORT_NAME", txtSectionAdd.Text);
                        cmd.Parameters.AddWithValue("@SECTION_ID", txtSectionAdd.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm bộ phận phê duyệt thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ClearData()
        {
            txtMaNV.Clear();
            txtTen.Clear();
            txtBoPhan.Clear();
            txtNhaMay.Clear();
            txtQuyen.Clear();
            txtSectionAdd.SelectedIndex = -1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xóa quyền phê duyệt?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string queryDelete = "DELETE TBL_SECTION_MANAGER WHERE ID_IDENTITY = '" + Convert.ToString(gvData.GetFocusedRowCellValue("ID_IDENTITY")) + "'";
                    using (SqlConnection conn = new SqlConnection(DBUtils._stringConnection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                LoadData();
                            }
                        }
                    }
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
    }
}