using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.lblColor = new System.Windows.Forms.Label();
            this.dudColor = new System.Windows.Forms.DomainUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSampleText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            SuspendLayout();
            // 
            // Form1
            // 
            this.Text = "StepByStep2_12";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ClientSize = new Size(480, 240);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new Point(16, 16);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new Size(40, 20);
            this.lblColor.Text = "Color:";
            // 
            // dudColor
            // 
            this.dudColor.Location = new Point(80, 12);
            this.dudColor.Name = "dudColor";
            this.dudColor.Size = new Size(160, 24);
            this.dudColor.UpDownAlign = LeftRightAlignment.Left;
            this.dudColor.Wrap = true;
            // event hookup (handler implemented in Form1.cs)
            this.dudColor.SelectedItemChanged += new EventHandler(this.dudColor_SelectedItemChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new Point(16, 56);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new Size(36, 20);
            this.lblSize.Text = "Size:";
            // 
            // nudSize
            // 
            this.nudSize.Location = new Point(80, 52);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new Size(80, 24);
            this.nudSize.UpDownAlign = LeftRightAlignment.Right;
            this.nudSize.Minimum = 6;
            this.nudSize.Maximum = 72;
            this.nudSize.Value = 16;
            this.nudSize.DecimalPlaces = 0;
            this.nudSize.ValueChanged += new EventHandler(this.nudSize_ValueChanged);
            // 
            // lblSampleText
            // 
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Text = "Sample Text";
            this.lblSampleText.AutoSize = false;
            this.lblSampleText.Dock = DockStyle.Bottom;
            this.lblSampleText.Height = 120;
            this.lblSampleText.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSampleText.Font = new Font(this.Font.FontFamily, 16f, this.Font.Style);
            // 
            // Add controls
            // 
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.dudColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblSampleText);

            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DomainUpDown dudColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSampleText;
    }
}
