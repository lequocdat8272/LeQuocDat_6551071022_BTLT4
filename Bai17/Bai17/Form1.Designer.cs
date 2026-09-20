namespace Bai14
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
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            txtTen = new TextBox();
            label1 = new Label();
            btnCapNhat = new Button();
            btnQuaPhai = new Button();
            btnQuaPhaiTatCa = new Button();
            btnQuaTrai = new Button();
            btnQuaTraiTatCa = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            menuStripMain = new MenuStrip();
            menuCapNhat = new ToolStripMenuItem();
            menuCapNhatLopA = new ToolStripMenuItem();
            menuCapNhatLopB = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuChuyenSangA = new ToolStripMenuItem();
            menuChuyenSangB = new ToolStripMenuItem();
            menuChuyenTatCaSangA = new ToolStripMenuItem();
            menuChuyenTatCaSangB = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuXoaLopA = new ToolStripMenuItem();
            menuXoaLopB = new ToolStripMenuItem();
            menuHeThong = new ToolStripMenuItem();
            menuThongTin = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuKetThuc = new ToolStripMenuItem();
            SuspendLayout();
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(57, 98);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(282, 264);
            lstLopA.TabIndex = 0;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(404, 98);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(293, 264);
            lstLopB.TabIndex = 1;
            // 
            // textBox1
            // 
            txtTen.Location = new Point(123, 53);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(468, 27);
            txtTen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 56);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên SV:";
            // 
            // button1
            // 
            btnCapNhat.Location = new Point(603, 52);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnQuaPhai
            // 
            btnQuaPhai.Location = new Point(345, 118);
            btnQuaPhai.Name = "btnQuaPhai";
            btnQuaPhai.Size = new Size(40, 30);
            btnQuaPhai.TabIndex = 5;
            btnQuaPhai.Text = ">";
            btnQuaPhai.UseVisualStyleBackColor = true;
            btnQuaPhai.Click += btnQuaPhai_Click;
            // 
            // btnQuaPhaiTatCa
            // 
            btnQuaPhaiTatCa.Location = new Point(345, 158);
            btnQuaPhaiTatCa.Name = "btnQuaPhaiTatCa";
            btnQuaPhaiTatCa.Size = new Size(40, 30);
            btnQuaPhaiTatCa.TabIndex = 6;
            btnQuaPhaiTatCa.Text = ">>";
            btnQuaPhaiTatCa.UseVisualStyleBackColor = true;
            btnQuaPhaiTatCa.Click += btnQuaPhaiTatCa_Click;
            // 
            // btnQuaTrai
            // 
            btnQuaTrai.Location = new Point(345, 198);
            btnQuaTrai.Name = "btnQuaTrai";
            btnQuaTrai.Size = new Size(40, 30);
            btnQuaTrai.TabIndex = 7;
            btnQuaTrai.Text = "<";
            btnQuaTrai.UseVisualStyleBackColor = true;
            btnQuaTrai.Click += btnQuaTrai_Click;
            // 
            // btnQuaTraiTatCa
            // 
            btnQuaTraiTatCa.Location = new Point(345, 238);
            btnQuaTraiTatCa.Name = "btnQuaTraiTatCa";
            btnQuaTraiTatCa.Size = new Size(40, 30);
            btnQuaTraiTatCa.TabIndex = 8;
            btnQuaTraiTatCa.Text = "<<";
            btnQuaTraiTatCa.UseVisualStyleBackColor = true;
            btnQuaTraiTatCa.Click += btnQuaTraiTatCa_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(57, 378);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(120, 30);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(345, 378);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(120, 30);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(577, 378);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(120, 30);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] {
            menuCapNhat,
            menuHeThong});
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 28);
            menuStripMain.TabIndex = 12;
            menuStripMain.Text = "menuStripMain";
            // 
            // menuCapNhat
            // 
            menuCapNhat.DropDownItems.AddRange(new ToolStripItem[] {
            menuCapNhatLopA,
            menuCapNhatLopB,
            toolStripSeparator1,
            menuChuyenSangA,
            menuChuyenSangB,
            menuChuyenTatCaSangA,
            menuChuyenTatCaSangB,
            toolStripSeparator2,
            menuXoaLopA,
            menuXoaLopB});
            menuCapNhat.Name = "menuCapNhat";
            menuCapNhat.Size = new Size(84, 24);
            menuCapNhat.Text = "&Cập Nhật";
            // 
            // menuCapNhatLopA
            // 
            menuCapNhatLopA.Name = "menuCapNhatLopA";
            menuCapNhatLopA.Size = new Size(280, 26);
            menuCapNhatLopA.Text = "Cập Nhật Lớp &A";
            menuCapNhatLopA.Click += menuCapNhatLopA_Click;
            // 
            // menuCapNhatLopB
            // 
            menuCapNhatLopB.Name = "menuCapNhatLopB";
            menuCapNhatLopB.Size = new Size(280, 26);
            menuCapNhatLopB.Text = "Cập Nhật Lớp &B";
            menuCapNhatLopB.Click += menuCapNhatLopB_Click;
            // 
            // menuChuyenSangA
            // 
            menuChuyenSangA.Name = "menuChuyenSangA";
            menuChuyenSangA.Size = new Size(280, 26);
            menuChuyenSangA.Text = "Chuyển phần tử chọn sang lớp A";
            menuChuyenSangA.Click += menuChuyenSangA_Click;
            // 
            // menuChuyenSangB
            // 
            menuChuyenSangB.Name = "menuChuyenSangB";
            menuChuyenSangB.Size = new Size(280, 26);
            menuChuyenSangB.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            menuChuyenSangB.Click += menuChuyenSangB_Click;
            // 
            // menuChuyenTatCaSangA
            // 
            menuChuyenTatCaSangA.Name = "menuChuyenTatCaSangA";
            menuChuyenTatCaSangA.Size = new Size(280, 26);
            menuChuyenTatCaSangA.Text = "Chuyển hết ds sang lớp A";
            menuChuyenTatCaSangA.Click += menuChuyenTatCaSangA_Click;
            // 
            // menuChuyenTatCaSangB
            // 
            menuChuyenTatCaSangB.Name = "menuChuyenTatCaSangB";
            menuChuyenTatCaSangB.Size = new Size(280, 26);
            menuChuyenTatCaSangB.Text = "Chuyển Hết ds Sang Lớp B";
            menuChuyenTatCaSangB.Click += menuChuyenTatCaSangB_Click;
            // 
            // menuXoaLopA
            // 
            menuXoaLopA.Name = "menuXoaLopA";
            menuXoaLopA.Size = new Size(280, 26);
            menuXoaLopA.Text = "Xóa Danh Sách Lớp A";
            menuXoaLopA.Click += menuXoaLopA_Click;
            // 
            // menuXoaLopB
            // 
            menuXoaLopB.Name = "menuXoaLopB";
            menuXoaLopB.Size = new Size(280, 26);
            menuXoaLopB.Text = "Xóa Danh Sách Lớp B";
            menuXoaLopB.Click += menuXoaLopB_Click;
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] {
            menuThongTin,
            toolStripSeparator3,
            menuKetThuc});
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(86, 24);
            menuHeThong.Text = "&Hệ Thống";
            // 
            // menuThongTin
            // 
            menuThongTin.Name = "menuThongTin";
            menuThongTin.ShortcutKeys = Keys.F1;
            menuThongTin.Size = new Size(224, 26);
            menuThongTin.Text = "&Thông Tin";
            menuThongTin.Click += menuThongTin_Click;
            // 
            // menuKetThuc
            // 
            menuKetThuc.Name = "menuKetThuc";
            menuKetThuc.ShortcutKeys = Keys.Alt | Keys.F4;
            menuKetThuc.Size = new Size(224, 26);
            menuKetThuc.Text = "&Kết Thúc";
            menuKetThuc.Click += menuKetThuc_Click;

            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnQuaTraiTatCa);
            Controls.Add(btnQuaTrai);
            Controls.Add(btnQuaPhaiTatCa);
            Controls.Add(btnQuaPhai);
            Controls.Add(btnCapNhat);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            AcceptButton = btnCapNhat;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLopA;
        private ListBox lstLopB;
        private TextBox txtTen;
        private Label label1;
        private Button btnCapNhat;
        private Button btnQuaPhai;
        private Button btnQuaPhaiTatCa;
        private Button btnQuaTrai;
        private Button btnQuaTraiTatCa;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuCapNhat;
        private ToolStripMenuItem menuCapNhatLopA;
        private ToolStripMenuItem menuCapNhatLopB;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuChuyenSangA;
        private ToolStripMenuItem menuChuyenSangB;
        private ToolStripMenuItem menuChuyenTatCaSangA;
        private ToolStripMenuItem menuChuyenTatCaSangB;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuXoaLopA;
        private ToolStripMenuItem menuXoaLopB;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuThongTin;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuKetThuc;
    }
}
