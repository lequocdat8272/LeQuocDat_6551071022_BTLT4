using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai21
{
    public class frmMain : Form
    {
        private MenuStrip menuStripMain;

        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Module 5: MDI Form";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            menuStripMain = new MenuStrip();
            this.MainMenuStrip = menuStripMain;
            this.Controls.Add(menuStripMain);

            var mnuHeThong = new ToolStripMenuItem("&Hệ Thống Bài Tập");

            var mnuModule1 = new ToolStripMenuItem("Module 1");
            var mnuBai1 = new ToolStripMenuItem("Bài 1", null, (s, e) => OpenChildForm<Bai1Form>());
            var mnuBai2 = new ToolStripMenuItem("Bài 2", null, (s, e) => OpenChildForm<Bai2Form>());
            var mnuBai3 = new ToolStripMenuItem("Bài 3", null, (s, e) => OpenChildForm<Bai3Form>());
            var mnuBai4 = new ToolStripMenuItem("Bài 4", null, (s, e) => OpenChildForm<Bai4Form>());
            mnuModule1.DropDownItems.AddRange(new ToolStripItem[] { mnuBai1, mnuBai2, mnuBai3, mnuBai4 });

            var mnuModule2 = new ToolStripMenuItem("Module 2");
            var mnuModule3 = new ToolStripMenuItem("Module 3");
            var mnuModule4 = new ToolStripMenuItem("Module 4");
            var mnuModule5 = new ToolStripMenuItem("Module 5");

            var sep = new ToolStripSeparator();
            var mnuDeTai = new ToolStripMenuItem("Đề tài", null, (s, e) => OpenProjectForm());
            var mnuKetThuc = new ToolStripMenuItem("&Kết Thúc", null, (s, e) => ExitApplication())
            {
                ShortcutKeys = Keys.Alt | Keys.F4
            };

            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuModule1, mnuModule2, mnuModule3, mnuModule4, mnuModule5, sep, mnuDeTai, mnuKetThuc });

            var mnuCongCu = new ToolStripMenuItem("&Công Cụ");
            var mnuSapXep = new ToolStripMenuItem("Sắp xếp cửa sổ");
            var mnuCascade = new ToolStripMenuItem("Cascade", null, (s, e) => this.LayoutMdi(MdiLayout.Cascade));
            var mnuTileH = new ToolStripMenuItem("Tile Horizontal", null, (s, e) => this.LayoutMdi(MdiLayout.TileHorizontal));
            var mnuTileV = new ToolStripMenuItem("Tile Vertical", null, (s, e) => this.LayoutMdi(MdiLayout.TileVertical));
            mnuSapXep.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileH, mnuTileV });
            mnuCongCu.DropDownItems.Add(mnuSapXep);

            var mnuTroGiup = new ToolStripMenuItem("&Trợ Giúp");
            var mnuAbout = new ToolStripMenuItem("&Thông Tin (About)", null, (s, e) => ShowAbout())
            {
                ShortcutKeys = Keys.F1
            };
            mnuTroGiup.DropDownItems.Add(mnuAbout);

            menuStripMain.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuCongCu, mnuTroGiup });
        }

        public void OpenChildForm<T>() where T : Form, new()
        {
            var existing = this.MdiChildren.FirstOrDefault(f => f is T);
            if (existing != null)
            {
                existing.Activate();
                return;
            }

            var form = new T { MdiParent = this };
            form.Show();
        }

        private void OpenProjectForm()
        {
            var p = new Form
            {
                Text = "Đề tài",
                Width = 500,
                Height = 300,
                StartPosition = FormStartPosition.CenterParent,
                MdiParent = this
            };
            var lbl = new Label
            {
                Text = "Tên đề tài: ...\nMôn học: ...\nHọ tên: ...",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            p.Controls.Add(lbl);
            p.Show();
        }

        private void ShowAbout()
        {
            using (var about = new frmAbout())
            {
                about.ShowDialog(this);
            }
        }

        private void ExitApplication()
        {
            var r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
