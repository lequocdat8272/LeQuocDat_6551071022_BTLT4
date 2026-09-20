using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveAsMenuItem;
        private ToolStripSeparator fileSeparator;
        private ToolStripMenuItem exitMenuItem;

        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem changeColorMenuItem;
        private ToolStripMenuItem defaultColorMenuItem;

        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutMenuItem;

        private ContextMenuStrip contextMenuForm;
        private ToolStripMenuItem ctxChangeColor;
        private ToolStripMenuItem ctxResetColor;
        private ToolStripSeparator ctxSeparator;
        private ToolStripMenuItem ctxExit;

        private ColorDialog colorDialog;

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
            mainMenu = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveAsMenuItem = new ToolStripMenuItem();
            fileSeparator = new ToolStripSeparator();
            exitMenuItem = new ToolStripMenuItem();
            formatMenu = new ToolStripMenuItem();
            changeColorMenuItem = new ToolStripMenuItem();
            defaultColorMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            contextMenuForm = new ContextMenuStrip(components);
            ctxChangeColor = new ToolStripMenuItem();
            ctxResetColor = new ToolStripMenuItem();
            ctxSeparator = new ToolStripSeparator();
            ctxExit = new ToolStripMenuItem();
            colorDialog = new ColorDialog();
            toolStripTextBox2 = new ToolStripTextBox();
            mainMenu.SuspendLayout();
            contextMenuForm.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileMenu, formatMenu, helpMenu, toolStripMenuItem1, toolStripTextBox1 });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(400, 31);
            mainMenu.TabIndex = 1;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem, saveAsMenuItem, fileSeparator, exitMenuItem, toolStripTextBox2 });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(46, 27);
            fileMenu.Text = "&File";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newMenuItem.Size = new Size(224, 26);
            newMenuItem.Text = "&New";
            newMenuItem.Click += NewMenuItem_Click;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openMenuItem.Size = new Size(224, 26);
            openMenuItem.Text = "&Open...";
            openMenuItem.Click += OpenMenuItem_Click;
            // 
            // saveAsMenuItem
            // 
            saveAsMenuItem.Name = "saveAsMenuItem";
            saveAsMenuItem.Size = new Size(224, 26);
            saveAsMenuItem.Text = "Save &As...";
            saveAsMenuItem.Click += SaveAsMenuItem_Click;
            // 
            // fileSeparator
            // 
            fileSeparator.Name = "fileSeparator";
            fileSeparator.Size = new Size(221, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitMenuItem.Size = new Size(224, 26);
            exitMenuItem.Text = "E&xit";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // formatMenu
            // 
            formatMenu.DropDownItems.AddRange(new ToolStripItem[] { changeColorMenuItem, defaultColorMenuItem });
            formatMenu.Name = "formatMenu";
            formatMenu.Size = new Size(70, 27);
            formatMenu.Text = "F&ormat";
            // 
            // changeColorMenuItem
            // 
            changeColorMenuItem.Name = "changeColorMenuItem";
            changeColorMenuItem.Size = new Size(224, 26);
            changeColorMenuItem.Text = "Change Form &Color";
            changeColorMenuItem.Click += ChangeColorMenuItem_Click;
            // 
            // defaultColorMenuItem
            // 
            defaultColorMenuItem.Name = "defaultColorMenuItem";
            defaultColorMenuItem.Size = new Size(224, 26);
            defaultColorMenuItem.Text = "Default Color";
            defaultColorMenuItem.Click += DefaultColorMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(55, 27);
            helpMenu.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(133, 26);
            aboutMenuItem.Text = "&About";
            aboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 27);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "Type here";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuForm
            // 
            contextMenuForm.ImageScalingSize = new Size(20, 20);
            contextMenuForm.Items.AddRange(new ToolStripItem[] { ctxChangeColor, ctxResetColor, ctxSeparator, ctxExit });
            contextMenuForm.Name = "contextMenuForm";
            contextMenuForm.Size = new Size(333, 82);
            // 
            // ctxChangeColor
            // 
            ctxChangeColor.Name = "ctxChangeColor";
            ctxChangeColor.Size = new Size(332, 24);
            ctxChangeColor.Text = "Đổi màu nền (Color)";
            ctxChangeColor.Click += ChangeColorMenuItem_Click;
            // 
            // ctxResetColor
            // 
            ctxResetColor.Name = "ctxResetColor";
            ctxResetColor.Size = new Size(332, 24);
            ctxResetColor.Text = "Khôi phục màu mặc định (Reset Color)";
            ctxResetColor.Click += DefaultColorMenuItem_Click;
            // 
            // ctxSeparator
            // 
            ctxSeparator.Name = "ctxSeparator";
            ctxSeparator.Size = new Size(329, 6);
            // 
            // ctxExit
            // 
            ctxExit.Name = "ctxExit";
            ctxExit.Size = new Size(332, 24);
            ctxExit.Text = "Thoát (Exit)";
            ctxExit.Click += ExitMenuItem_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.Text = "Type here";
            toolStripTextBox2.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            ClientSize = new Size(400, 300);
            ContextMenuStrip = contextMenuForm;
            Controls.Add(mainMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mainMenu;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_18";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            contextMenuForm.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
    }
}
