using System.Drawing;
using System.Windows.Forms;

namespace Bai21
{
    public class Bai2Form : Form
    {
        public Bai2Form()
        {
            this.Text = "Bài 2";
            this.Width = 600;
            this.Height = 400;
            var lbl = new Label
            {
                Text = "Nội dung Bài 2",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
        }
    }
}
