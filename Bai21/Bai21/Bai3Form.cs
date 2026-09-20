using System.Drawing;
using System.Windows.Forms;

namespace Bai21
{
    public class Bai3Form : Form
    {
        public Bai3Form()
        {
            this.Text = "Bài 3";
            this.Width = 600;
            this.Height = 400;
            var lbl = new Label
            {
                Text = "Nội dung Bài 3",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
        }
    }
}
