using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            lstLopA.Items.Add(ten);
            txtTen.Clear();
            txtTen.Focus();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            var items = lstLopA.SelectedItems.Cast<object>().ToArray();
            if (items.Length == 0) return;

            foreach (var it in items)
            {
                lstLopB.Items.Add(it);
                lstLopA.Items.Remove(it);
            }
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            var items = lstLopB.SelectedItems.Cast<object>().ToArray();
            if (items.Length == 0) return;

            foreach (var it in items)
            {
                lstLopA.Items.Add(it);
                lstLopB.Items.Remove(it);
            }
        }

        private void btnQuaPhaiTatCa_Click(object sender, EventArgs e)
        {
            var all = lstLopA.Items.Cast<object>().ToArray();
            if (all.Length == 0) return;

            foreach (var it in all)
            {
                lstLopB.Items.Add(it);
            }
            lstLopA.Items.Clear();
        }

        private void btnQuaTraiTatCa_Click(object sender, EventArgs e)
        {
            var all = lstLopB.Items.Cast<object>().ToArray();
            if (all.Length == 0) return;

            foreach (var it in all)
            {
                lstLopA.Items.Add(it);
            }
            lstLopB.Items.Clear();
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            var items = lstLopA.SelectedItems.Cast<object>().ToArray();
            if (items.Length == 0) return;
            foreach (var it in items)
            {
                lstLopA.Items.Remove(it);
            }
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            var items = lstLopB.SelectedItems.Cast<object>().ToArray();
            if (items.Length == 0) return;
            foreach (var it in items)
            {
                lstLopB.Items.Remove(it);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Bạn có chắc muốn kết thúc ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Menu handlers - delegate to existing button logic to avoid duplication
        private void menuCapNhatLopA_Click(object sender, EventArgs e) => btnCapNhat.PerformClick();

        private void menuCapNhatLopB_Click(object sender, EventArgs e)
        {
            var name = txtTen.Text?.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                lstLopB.Items.Add(name);
                txtTen.Clear();
                txtTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuChuyenSangA_Click(object sender, EventArgs e) => btnQuaTrai.PerformClick();
        private void menuChuyenSangB_Click(object sender, EventArgs e) => btnQuaPhai.PerformClick();
        private void menuChuyenTatCaSangA_Click(object sender, EventArgs e) => btnQuaTraiTatCa.PerformClick();
        private void menuChuyenTatCaSangB_Click(object sender, EventArgs e) => btnQuaPhaiTatCa.PerformClick();
        private void menuXoaLopA_Click(object sender, EventArgs e) => btnXoaLopA.PerformClick();
        private void menuXoaLopB_Click(object sender, EventArgs e) => btnXoaLopB.PerformClick();

        private void menuThongTin_Click(object sender, EventArgs e)
        {
            string info = "Họ tên: Nguyễn Văn A\nMã số: 12345678\nLớp: X1A\nĐề tài: Cập nhật 2 ListBox";
            MessageBox.Show(info, "Thông Tin Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuKetThuc_Click(object sender, EventArgs e) => btnKetThuc.PerformClick();
    }
}
