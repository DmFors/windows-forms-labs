namespace lab_1
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
            saveButton = new Button();
            printDialog1 = new PrintDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            редактированиеToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            редактированиеToolStripMenuItem1 = new ToolStripMenuItem();
            выходToolStripMenuItem1 = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            авторПрограммыToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            authorNameTextBox = new TextBox();
            authorNameLabel = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(531, 276);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(294, 73);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 35);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1171, 24);
            menuStrip1.TabIndex = 1;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(32, 19);
            // 
            // редактированиеToolStripMenuItem
            // 
            редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            редактированиеToolStripMenuItem.Size = new Size(32, 19);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(32, 19);
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem1, справкаToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(9, 3, 0, 3);
            menuStrip2.Size = new Size(1171, 35);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { редактированиеToolStripMenuItem1, выходToolStripMenuItem1 });
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(69, 29);
            файлToolStripMenuItem1.Text = "Файл";
            // 
            // редактированиеToolStripMenuItem1
            // 
            редактированиеToolStripMenuItem1.Name = "редактированиеToolStripMenuItem1";
            редактированиеToolStripMenuItem1.Size = new Size(248, 34);
            редактированиеToolStripMenuItem1.Text = "Редактирование";
            редактированиеToolStripMenuItem1.Click += редактированиеToolStripMenuItem1_Click;
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(248, 34);
            выходToolStripMenuItem1.Text = "Выход";
            выходToolStripMenuItem1.Click += выходToolStripMenuItem1_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { авторПрограммыToolStripMenuItem, оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(97, 29);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // авторПрограммыToolStripMenuItem
            // 
            авторПрограммыToolStripMenuItem.Name = "авторПрограммыToolStripMenuItem";
            авторПрограммыToolStripMenuItem.Size = new Size(268, 34);
            авторПрограммыToolStripMenuItem.Text = "Автор программы";
            авторПрограммыToolStripMenuItem.Click += авторПрограммыToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(268, 34);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // authorNameTextBox
            // 
            authorNameTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            authorNameTextBox.Location = new Point(309, 145);
            authorNameTextBox.Name = "authorNameTextBox";
            authorNameTextBox.Size = new Size(516, 71);
            authorNameTextBox.TabIndex = 3;
            authorNameTextBox.Text = "Пример автора";
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            authorNameLabel.Location = new Point(19, 145);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(294, 65);
            authorNameLabel.TabIndex = 4;
            authorNameLabel.Text = "Имя автора:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1171, 840);
            Controls.Add(authorNameLabel);
            Controls.Add(authorNameTextBox);
            Controls.Add(saveButton);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Лабораторная работа #1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private PrintDialog printDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem файлToolStripMenuItem2;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem3;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem выToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem авторПрограммыToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem редактированиеToolStripMenuItem1;
        private TextBox authorNameTextBox;
        private Label authorNameLabel;
    }
}