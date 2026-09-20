using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai21
{
    public class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Thông Tin";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(420, 240);

            var lbl = new Label
            {
                Text = "Thông tin sinh viên:\nHọ tên: [Tên Sinh Viên]\nMã số: [MSSV]\nĐề tài: Tạo ứng dụng MDI liên kết các bài tập\nMôn học: Windows Forms",
                Dock = DockStyle.Top,
                Height = 140,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10)
            };
            this.Controls.Add(lbl);

            var btnOk = new Button
            {
                Text = "OK",
                Width = 80,
                Height = 30,
                Left = (this.ClientSize.Width - 80) / 2,
                Top = 150,
                Anchor = AnchorStyles.Bottom
            };
            btnOk.Click += (s, e) => this.Close();
            this.Controls.Add(btnOk);
        }
    }
}
