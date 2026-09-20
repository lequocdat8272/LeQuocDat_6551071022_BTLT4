using System.Drawing;
using System.Windows.Forms;

namespace Bai21
{
    public class Bai4Form : Form
    {
        public Bai4Form()
        {
            this.Text = "Bài 4";
            this.Width = 600;
            this.Height = 400;
            var lbl = new Label
            {
                Text = "Nội dung Bài 4",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
        }
    }
}
