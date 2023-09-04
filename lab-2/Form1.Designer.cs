namespace lab_2
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
            FigureTypeComboBox = new ComboBox();
            LineTypeListBox = new ListBox();
            label1 = new Label();
            AddLineType = new Button();
            LineTypeTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UserChoiceTextBox = new TextBox();
            ShowUserChoiceButton = new Button();
            SuspendLayout();
            // 
            // FigureTypeComboBox
            // 
            FigureTypeComboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FigureTypeComboBox.FormattingEnabled = true;
            FigureTypeComboBox.Location = new Point(614, 395);
            FigureTypeComboBox.Name = "FigureTypeComboBox";
            FigureTypeComboBox.Size = new Size(470, 62);
            FigureTypeComboBox.TabIndex = 0;
            FigureTypeComboBox.SelectedIndexChanged += FigureTypeComboBox_SelectedIndexChanged;
            // 
            // LineTypeListBox
            // 
            LineTypeListBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LineTypeListBox.FormattingEnabled = true;
            LineTypeListBox.ItemHeight = 54;
            LineTypeListBox.Location = new Point(59, 131);
            LineTypeListBox.Name = "LineTypeListBox";
            LineTypeListBox.Size = new Size(470, 328);
            LineTypeListBox.TabIndex = 1;
            LineTypeListBox.SelectedIndexChanged += LineTypeListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(614, 46);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 2;
            label1.Text = "Тип линии";
            // 
            // AddLineType
            // 
            AddLineType.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AddLineType.Location = new Point(877, 207);
            AddLineType.Name = "AddLineType";
            AddLineType.Size = new Size(207, 70);
            AddLineType.TabIndex = 3;
            AddLineType.Text = "Добавить";
            AddLineType.UseVisualStyleBackColor = true;
            AddLineType.Click += AddLineType_Click;
            // 
            // LineTypeTextBox
            // 
            LineTypeTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LineTypeTextBox.Location = new Point(614, 118);
            LineTypeTextBox.Name = "LineTypeTextBox";
            LineTypeTextBox.Size = new Size(470, 61);
            LineTypeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(489, 482);
            label2.Name = "label2";
            label2.Size = new Size(228, 54);
            label2.TabIndex = 6;
            label2.Text = "Ваш выбор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 46);
            label3.Name = "label3";
            label3.Size = new Size(396, 54);
            label3.TabIndex = 8;
            label3.Text = "Список типов линий";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(614, 324);
            label4.Name = "label4";
            label4.Size = new Size(391, 54);
            label4.TabIndex = 9;
            label4.Text = "Список типов фигур";
            // 
            // UserChoiceTextBox
            // 
            UserChoiceTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserChoiceTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UserChoiceTextBox.Location = new Point(55, 612);
            UserChoiceTextBox.Multiline = true;
            UserChoiceTextBox.Name = "UserChoiceTextBox";
            UserChoiceTextBox.ReadOnly = true;
            UserChoiceTextBox.ScrollBars = ScrollBars.Vertical;
            UserChoiceTextBox.Size = new Size(1097, 356);
            UserChoiceTextBox.TabIndex = 10;
            // 
            // ShowUserChoiceButton
            // 
            ShowUserChoiceButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ShowUserChoiceButton.Location = new Point(368, 987);
            ShowUserChoiceButton.Name = "ShowUserChoiceButton";
            ShowUserChoiceButton.Size = new Size(470, 70);
            ShowUserChoiceButton.TabIndex = 11;
            ShowUserChoiceButton.Text = "Посмотреть";
            ShowUserChoiceButton.UseVisualStyleBackColor = true;
            ShowUserChoiceButton.Click += ShowUserChoiceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 1112);
            Controls.Add(ShowUserChoiceButton);
            Controls.Add(UserChoiceTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LineTypeTextBox);
            Controls.Add(AddLineType);
            Controls.Add(label1);
            Controls.Add(LineTypeListBox);
            Controls.Add(FigureTypeComboBox);
            Name = "Form1";
            Text = "Лабораторная работа #2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FigureTypeComboBox;
        private ListBox LineTypeListBox;
        private Label label1;
        private Button AddLineType;
        private TextBox LineTypeTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UserChoiceTextBox;
        private Button ShowUserChoiceButton;
    }
}