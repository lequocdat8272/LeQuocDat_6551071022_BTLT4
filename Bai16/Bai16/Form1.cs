using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // File menu handlers
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn New", "Thông báo");
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn Open", "Thông báo");
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn Save As", "Thông báo");
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        // Format & Context handlers
        private void ChangeColorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void DefaultColorMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        // Help
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Bài 16: Xây dựng hệ thống menu (MenuStrip và ContextMenuStrip)" +
                           "\nTác giả: (tên bạn)" +
                           "\nMô tả: Ví dụ minh họa MenuStrip và ContextMenuStrip trong Windows Forms.";
            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
