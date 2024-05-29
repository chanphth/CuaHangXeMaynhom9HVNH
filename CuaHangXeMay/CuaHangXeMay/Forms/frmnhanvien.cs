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
    public partial class frmnhanvien : Form
    {
        DataTable tblNV;
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            Functions.ketnoi();
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT manhanvien, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh FROM tblnhanvien";
            tblNV = Functions.getdatatotable(sql);
            gridnhanvien.DataSource = tblNV;
            gridnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            gridnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            gridnhanvien.Columns[2].HeaderText = "Giới tính";
            gridnhanvien.Columns[3].HeaderText = "Địa chỉ";
            gridnhanvien.Columns[4].HeaderText = "Điện thoại";
            gridnhanvien.Columns[5].HeaderText = "Ngày sinh";
            gridnhanvien.Columns[0].Width = 100;
            gridnhanvien.Columns[1].Width = 150;
            gridnhanvien.Columns[2].Width = 100;
            gridnhanvien.Columns[3].Width = 150;
            gridnhanvien.Columns[4].Width = 100;
            gridnhanvien.Columns[5].Width = 100;
            gridnhanvien.AllowUserToAddRows = false;
            gridnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void gridnhanvien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = gridnhanvien.CurrentRow.Cells["Manhanvien"].Value.ToString();
            txtTennhanvien.Text = gridnhanvien.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            if (gridnhanvien.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
            txtDiachi.Text = gridnhanvien.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = gridnhanvien.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskNgaysinh.Text = gridnhanvien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }
        private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            mskNgaysinh.Text = "";
            mskDienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.isdate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT manhanvien FROM tblnhanvien WHERE manhanvien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Functions.checkey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO tblnhanvien(manhanvien,tennhanvien,gioitinh, diachi, dienthoai, ngaysinh) VALUES(N'" + txtManhanvien.Text.Trim() + "', N'" + txtTennhanvien.Text.Trim() + "', N'" + gt + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', '" + Functions.convertdatetime(mskNgaysinh.Text) + "')";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.isdate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblnhanvien SET  tennhanvien=N'" + txtTennhanvien.Text.Trim().ToString() +"',Diachi=N'" + txtDiachi.Text.Trim().ToString() +"',Dienthoai='" + mskDienthoai.Text.ToString() + "',Gioitinh=N'" + gt +"',Ngaysinh='" + Functions.convertdatetime(mskNgaysinh.Text) + "' WHERE manhanvien=N'" + txtManhanvien.Text + "'";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblnhanvien WHERE manhanvien=N'" + txtManhanvien.Text + "'";
                Functions.runsql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
