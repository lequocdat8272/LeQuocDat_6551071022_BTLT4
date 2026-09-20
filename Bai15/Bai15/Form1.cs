using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load colors into DomainUpDown
            dudColor.Items.Clear();
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Yellow");
            dudColor.Items.Add("Orange");
            dudColor.Items.Add("Purple");

            // Default selection: Green
            dudColor.SelectedIndex = 2;

            // Ensure nud default
            nudSize.Value = 16;

            UpdateSampleText();
        }

        private void dudColor_SelectedItemChanged(object? sender, EventArgs e)
        {
            UpdateSampleText();
        }

        private void nudSize_ValueChanged(object? sender, EventArgs e)
        {
            UpdateSampleText();
        }

        private void UpdateSampleText()
        {
            string colorName = dudColor.Text?.Trim() ?? string.Empty;
            Color c = Color.FromName(colorName);
            if (c.IsKnownColor || c.ToArgb() != 0)
                lblSampleText.ForeColor = c;
            else
                lblSampleText.ForeColor = Color.Black;

            float newSize = (float)nudSize.Value;
            var family = lblSampleText.Font.FontFamily;
            var style = lblSampleText.Font.Style;
            lblSampleText.Font = new Font(family, newSize, style);
        }
    }
}
