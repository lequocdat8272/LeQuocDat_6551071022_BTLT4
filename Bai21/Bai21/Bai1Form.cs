using System.Drawing;
using System.Windows.Forms;

namespace Bai21
{
    public class Bai1Form : Form
    {
        public Bai1Form()
        {
            this.Text = "Bài 1";
            this.Width = 600;
            this.Height = 400;
            InitializeContent();
        }

        private void InitializeContent()
        {
            var lbl = new Label
            {
                Text = "Nội dung Bài 1",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
        }
    }
}
