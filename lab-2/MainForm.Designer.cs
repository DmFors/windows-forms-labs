namespace lab_2
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
            FigureTypeComboBox.Location = new Point(798, 506);
            FigureTypeComboBox.Margin = new Padding(4);
            FigureTypeComboBox.Name = "FigureTypeComboBox";
            FigureTypeComboBox.Size = new Size(610, 79);
            FigureTypeComboBox.TabIndex = 0;
            FigureTypeComboBox.SelectedIndexChanged += FigureTypeComboBox_SelectedIndexChanged;
            // 
            // LineTypeListBox
            // 
            LineTypeListBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LineTypeListBox.ForeColor = Color.Black;
            LineTypeListBox.FormattingEnabled = true;
            LineTypeListBox.ItemHeight = 71;
            LineTypeListBox.Location = new Point(77, 168);
            LineTypeListBox.Margin = new Padding(4);
            LineTypeListBox.Name = "LineTypeListBox";
            LineTypeListBox.Size = new Size(610, 359);
            LineTypeListBox.TabIndex = 1;
            LineTypeListBox.SelectedIndexChanged += LineTypeListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(798, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 72);
            label1.TabIndex = 2;
            label1.Text = "Тип линии";
            // 
            // AddLineType
            // 
            AddLineType.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AddLineType.Location = new Point(1103, 265);
            AddLineType.Margin = new Padding(4);
            AddLineType.Name = "AddLineType";
            AddLineType.Size = new Size(306, 90);
            AddLineType.TabIndex = 3;
            AddLineType.Text = "Добавить";
            AddLineType.UseVisualStyleBackColor = true;
            AddLineType.Click += AddLineType_Click;
            // 
            // LineTypeTextBox
            // 
            LineTypeTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LineTypeTextBox.Location = new Point(798, 151);
            LineTypeTextBox.Margin = new Padding(4);
            LineTypeTextBox.Name = "LineTypeTextBox";
            LineTypeTextBox.Size = new Size(610, 78);
            LineTypeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(636, 617);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(308, 72);
            label2.TabIndex = 6;
            label2.Text = "Ваш выбор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(536, 72);
            label3.TabIndex = 8;
            label3.Text = "Список типов линий";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(798, 415);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(531, 72);
            label4.TabIndex = 9;
            label4.Text = "Список типов фигур";
            // 
            // UserChoiceTextBox
            // 
            UserChoiceTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserChoiceTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UserChoiceTextBox.Location = new Point(72, 783);
            UserChoiceTextBox.Margin = new Padding(4);
            UserChoiceTextBox.Multiline = true;
            UserChoiceTextBox.Name = "UserChoiceTextBox";
            UserChoiceTextBox.ReadOnly = true;
            UserChoiceTextBox.ScrollBars = ScrollBars.Vertical;
            UserChoiceTextBox.Size = new Size(1426, 455);
            UserChoiceTextBox.TabIndex = 10;
            // 
            // ShowUserChoiceButton
            // 
            ShowUserChoiceButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ShowUserChoiceButton.Location = new Point(478, 1263);
            ShowUserChoiceButton.Margin = new Padding(4);
            ShowUserChoiceButton.Name = "ShowUserChoiceButton";
            ShowUserChoiceButton.Size = new Size(611, 90);
            ShowUserChoiceButton.TabIndex = 11;
            ShowUserChoiceButton.Text = "Посмотреть";
            ShowUserChoiceButton.UseVisualStyleBackColor = true;
            ShowUserChoiceButton.Click += ShowUserChoiceButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1578, 1423);
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
            Margin = new Padding(4);
            Name = "MainForm";
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