using CuaHangXeMay.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXeMay.Forms
{
    public partial class frmkhachhang : Form
    {
        DataTable tblkhachhang;
        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            Functions.ketnoi();
            txtmakhach.Enabled = false;
            btluu.Enabled = false;
            btboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT makhach, tenkhach, diachi, dienthoai FROM tblkhachhang";
            tblkhachhang = Functions.getdatatotable(sql);
            gridkhachhang.DataSource = tblkhachhang;
            gridkhachhang.Columns[0].HeaderText = "Mã khách";
            gridkhachhang.Columns[1].HeaderText = "Tên khách";
            gridkhachhang.Columns[2].HeaderText = "Địa chỉ";
            gridkhachhang.Columns[3].HeaderText = "Điện thoại";
            gridkhachhang.Columns[0].Width = 100;
            gridkhachhang.Columns[1].Width = 150;
            gridkhachhang.Columns[2].Width = 150;
            gridkhachhang.Columns[3].Width = 150;
           
        }

        private void gridkhachhang_Click(object sender, EventArgs e)
        {
            if (btthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtmakhach.Text = gridkhachhang.CurrentRow.Cells["makhach"].Value.ToString();
            txttenkhach.Text = gridkhachhang.CurrentRow.Cells["tenkhach"].Value.ToString();
            txtdiachi.Text = gridkhachhang.CurrentRow.Cells["diachi"].Value.ToString();
            mskdienthoai.Text = gridkhachhang.CurrentRow.Cells["dienthoai"].Value.ToString();
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btboqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btboqua.Enabled = true;
            btluu.Enabled = true;
            btthem.Enabled = false;
            ResetValues();
            txtmakhach.Enabled = true;
            txtmakhach.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtmakhach.Focus();
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "SELECT Makhach FROM tblkhachhang WHERE makhach=N'" + txtmakhach.Text.Trim() + "'";
            if (Functions.checkey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                txtmakhach.Text = "";
                return;
            }
            sql = "INSERT INTO tblkhachhang(makhach,tenkhach,diachi,dienthoai) VALUES (N'" +txtmakhach.Text.Trim() + "',N'" + txttenkhach.Text.Trim() + "',N'" +txtdiachi.Text.Trim() + "','" + mskdienthoai.Text + "')";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btxoa.Enabled = true;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btboqua.Enabled = false;
            btluu.Enabled = false;
            txtmakhach.Enabled = false;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "UPDATE tblkhachhang SET  Tenkhach=N'" + txttenkhach.Text.Trim().ToString()
                  + "',Diachi=N'" + txtdiachi.Text.Trim().ToString() + "',Dienthoai='" +
                mskdienthoai.Text.ToString() + "' WHERE Makhach=N'" + txtmakhach.Text + "'";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btboqua.Enabled = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblkhachhang WHERE Makhach=N'" + txtmakhach.Text + "'";
                Functions.runsql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btboqua.Enabled = false;
            btthem.Enabled = true;
            btxoa.Enabled = true;
            btsua.Enabled = true;
            btluu.Enabled = false;
            txtmakhach.Enabled = false;
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
