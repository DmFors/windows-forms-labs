namespace lab_3
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
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            типГраницыToolStripMenuItem1 = new ToolStripMenuItem();
            непрерывнаяToolStripMenuItem = new ToolStripMenuItem();
            пунктирнаяToolStripMenuItem1 = new ToolStripMenuItem();
            толщинаГраницыToolStripMenuItem = new ToolStripMenuItem();
            pt5BorderMenu = new ToolStripMenuItem();
            pt10BorderMenu = new ToolStripMenuItem();
            pt15BorderMenu = new ToolStripMenuItem();
            цветЗаливкиToolStripMenuItem = new ToolStripMenuItem();
            цветГраницыToolStripMenuItem = new ToolStripMenuItem();
            типЛинииToolStripMenuItem = new ToolStripMenuItem();
            fillColorDialog = new ColorDialog();
            borderColorDialog = new ColorDialog();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { типГраницыToolStripMenuItem1, толщинаГраницыToolStripMenuItem, цветЗаливкиToolStripMenuItem, цветГраницыToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(234, 132);
            // 
            // типГраницыToolStripMenuItem1
            // 
            типГраницыToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { непрерывнаяToolStripMenuItem, пунктирнаяToolStripMenuItem1 });
            типГраницыToolStripMenuItem1.Name = "типГраницыToolStripMenuItem1";
            типГраницыToolStripMenuItem1.Size = new Size(233, 32);
            типГраницыToolStripMenuItem1.Text = "Тип границы";
            // 
            // непрерывнаяToolStripMenuItem
            // 
            непрерывнаяToolStripMenuItem.Name = "непрерывнаяToolStripMenuItem";
            непрерывнаяToolStripMenuItem.Size = new Size(228, 34);
            непрерывнаяToolStripMenuItem.Text = "Непрерывная";
            непрерывнаяToolStripMenuItem.Click += непрерывнаяToolStripMenuItem_Click;
            // 
            // пунктирнаяToolStripMenuItem1
            // 
            пунктирнаяToolStripMenuItem1.Name = "пунктирнаяToolStripMenuItem1";
            пунктирнаяToolStripMenuItem1.Size = new Size(228, 34);
            пунктирнаяToolStripMenuItem1.Text = "Пунктирная";
            пунктирнаяToolStripMenuItem1.Click += пунктирнаяToolStripMenuItem_Click;
            // 
            // толщинаГраницыToolStripMenuItem
            // 
            толщинаГраницыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pt5BorderMenu, pt10BorderMenu, pt15BorderMenu });
            толщинаГраницыToolStripMenuItem.Name = "толщинаГраницыToolStripMenuItem";
            толщинаГраницыToolStripMenuItem.Size = new Size(233, 32);
            толщинаГраницыToolStripMenuItem.Text = "Толщина границы";
            // 
            // pt5BorderMenu
            // 
            pt5BorderMenu.Name = "pt5BorderMenu";
            pt5BorderMenu.Size = new Size(270, 34);
            pt5BorderMenu.Text = "5 пт";
            pt5BorderMenu.Click += pt5BorderMenu_Click;
            // 
            // pt10BorderMenu
            // 
            pt10BorderMenu.Name = "pt10BorderMenu";
            pt10BorderMenu.Size = new Size(270, 34);
            pt10BorderMenu.Text = "10 пт";
            pt10BorderMenu.Click += pt10BorderMenu_Click;
            // 
            // pt15BorderMenu
            // 
            pt15BorderMenu.Name = "pt15BorderMenu";
            pt15BorderMenu.Size = new Size(270, 34);
            pt15BorderMenu.Text = "15 пт";
            pt15BorderMenu.Click += pt15BorderMenu_Click;
            // 
            // цветЗаливкиToolStripMenuItem
            // 
            цветЗаливкиToolStripMenuItem.Name = "цветЗаливкиToolStripMenuItem";
            цветЗаливкиToolStripMenuItem.Size = new Size(233, 32);
            цветЗаливкиToolStripMenuItem.Text = "Цвет заливки";
            цветЗаливкиToolStripMenuItem.Click += цветЗаливкиToolStripMenuItem_Click;
            // 
            // цветГраницыToolStripMenuItem
            // 
            цветГраницыToolStripMenuItem.Name = "цветГраницыToolStripMenuItem";
            цветГраницыToolStripMenuItem.Size = new Size(233, 32);
            цветГраницыToolStripMenuItem.Text = "Цвет границы";
            цветГраницыToolStripMenuItem.Click += цветГраницыToolStripMenuItem_Click;
            // 
            // типЛинииToolStripMenuItem
            // 
            типЛинииToolStripMenuItem.Name = "типЛинииToolStripMenuItem";
            типЛинииToolStripMenuItem.Size = new Size(32, 19);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Лабораторная работа #3";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem типЛинииToolStripMenuItem;
        private ToolStripMenuItem типГраницыToolStripMenuItem1;
        private ToolStripMenuItem непрерывнаяToolStripMenuItem;
        private ToolStripMenuItem пунктирнаяToolStripMenuItem1;
        private ToolStripMenuItem толщинаГраницыToolStripMenuItem;
        private ToolStripMenuItem pt5BorderMenu;
        private ToolStripMenuItem pt10BorderMenu;
        private ToolStripMenuItem pt15BorderMenu;
        private ToolStripMenuItem цветЗаливкиToolStripMenuItem;
        private ToolStripMenuItem цветГраницыToolStripMenuItem;
        private ColorDialog fillColorDialog;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private ColorDialog borderColorDialog;
    }
}