namespace lab_1
{
    partial class MainForm
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
            saveButton.Location = new Point(690, 353);
            saveButton.Margin = new Padding(5, 6, 5, 6);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(382, 93);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 44);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 4, 0, 4);
            menuStrip1.Size = new Size(1522, 24);
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
            menuStrip2.Padding = new Padding(12, 4, 0, 4);
            menuStrip2.Size = new Size(1522, 44);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { редактированиеToolStripMenuItem1, выходToolStripMenuItem1 });
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(90, 36);
            файлToolStripMenuItem1.Text = "Файл";
            // 
            // редактированиеToolStripMenuItem1
            // 
            редактированиеToolStripMenuItem1.Name = "редактированиеToolStripMenuItem1";
            редактированиеToolStripMenuItem1.Size = new Size(328, 44);
            редактированиеToolStripMenuItem1.Text = "Редактирование";
            редактированиеToolStripMenuItem1.Click += РедактированиеToolStripMenuItem1_Click;
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(328, 44);
            выходToolStripMenuItem1.Text = "Выход";
            выходToolStripMenuItem1.Click += ВыходToolStripMenuItem1_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { авторПрограммыToolStripMenuItem, оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(126, 36);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // авторПрограммыToolStripMenuItem
            // 
            авторПрограммыToolStripMenuItem.Name = "авторПрограммыToolStripMenuItem";
            авторПрограммыToolStripMenuItem.Size = new Size(348, 44);
            авторПрограммыToolStripMenuItem.Text = "Автор программы";
            авторПрограммыToolStripMenuItem.Click += АвторПрограммыToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(348, 44);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += ОПрограммеToolStripMenuItem_Click;
            // 
            // authorNameTextBox
            // 
            authorNameTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            authorNameTextBox.Location = new Point(429, 186);
            authorNameTextBox.Margin = new Padding(4);
            authorNameTextBox.Name = "authorNameTextBox";
            authorNameTextBox.PlaceholderText = "Имя автора";
            authorNameTextBox.Size = new Size(670, 93);
            authorNameTextBox.TabIndex = 3;
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            authorNameLabel.ForeColor = Color.White;
            authorNameLabel.Location = new Point(25, 186);
            authorNameLabel.Margin = new Padding(4, 0, 4, 0);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(396, 86);
            authorNameLabel.TabIndex = 4;
            authorNameLabel.Text = "Имя автора:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1522, 1075);
            Controls.Add(authorNameLabel);
            Controls.Add(authorNameTextBox);
            Controls.Add(saveButton);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
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