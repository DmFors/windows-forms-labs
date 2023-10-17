namespace lab_4
{
    partial class CreateFigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FigureTypeComboBox = new ComboBox();
            TextBoxX1 = new TextBox();
            TextBoxX2 = new TextBox();
            FigureLabel = new Label();
            DrawFigureButton = new Button();
            TextBoxY2 = new TextBox();
            TextBoxHeight = new TextBox();
            TextBoxWidth = new TextBox();
            TextBoxY1 = new TextBox();
            ParameterTipLabel = new Label();
            SuspendLayout();
            // 
            // FigureTypeComboBox
            // 
            FigureTypeComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FigureTypeComboBox.FormattingEnabled = true;
            FigureTypeComboBox.Location = new Point(240, 103);
            FigureTypeComboBox.Margin = new Padding(4);
            FigureTypeComboBox.Name = "FigureTypeComboBox";
            FigureTypeComboBox.Size = new Size(488, 58);
            FigureTypeComboBox.TabIndex = 1;
            FigureTypeComboBox.SelectedIndexChanged += FigureTypeComboBox_SelectedIndexChanged;
            // 
            // TextBoxX1
            // 
            TextBoxX1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxX1.Location = new Point(296, 277);
            TextBoxX1.Margin = new Padding(4);
            TextBoxX1.Name = "TextBoxX1";
            TextBoxX1.PlaceholderText = "x1";
            TextBoxX1.Size = new Size(170, 57);
            TextBoxX1.TabIndex = 2;
            TextBoxX1.TextAlign = HorizontalAlignment.Center;
            TextBoxX1.Visible = false;
            // 
            // TextBoxX2
            // 
            TextBoxX2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxX2.Location = new Point(296, 366);
            TextBoxX2.Margin = new Padding(4);
            TextBoxX2.Name = "TextBoxX2";
            TextBoxX2.PlaceholderText = "x2";
            TextBoxX2.Size = new Size(170, 57);
            TextBoxX2.TabIndex = 4;
            TextBoxX2.TextAlign = HorizontalAlignment.Center;
            TextBoxX2.Visible = false;
            // 
            // FigureLabel
            // 
            FigureLabel.AutoSize = true;
            FigureLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FigureLabel.ForeColor = Color.White;
            FigureLabel.Location = new Point(78, 106);
            FigureLabel.Margin = new Padding(4, 0, 4, 0);
            FigureLabel.Name = "FigureLabel";
            FigureLabel.Size = new Size(154, 51);
            FigureLabel.TabIndex = 13;
            FigureLabel.Text = "Фигура:";
            // 
            // DrawFigureButton
            // 
            DrawFigureButton.Enabled = false;
            DrawFigureButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DrawFigureButton.Location = new Point(439, 576);
            DrawFigureButton.Margin = new Padding(4);
            DrawFigureButton.Name = "DrawFigureButton";
            DrawFigureButton.Size = new Size(274, 81);
            DrawFigureButton.TabIndex = 8;
            DrawFigureButton.Text = "Нарисовать";
            DrawFigureButton.UseVisualStyleBackColor = true;
            DrawFigureButton.Click += DrawFigureButton_Click;
            // 
            // TextBoxY2
            // 
            TextBoxY2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxY2.Location = new Point(542, 366);
            TextBoxY2.Margin = new Padding(4);
            TextBoxY2.Name = "TextBoxY2";
            TextBoxY2.PlaceholderText = "y2";
            TextBoxY2.Size = new Size(170, 57);
            TextBoxY2.TabIndex = 5;
            TextBoxY2.TextAlign = HorizontalAlignment.Center;
            TextBoxY2.Visible = false;
            // 
            // TextBoxHeight
            // 
            TextBoxHeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxHeight.Location = new Point(542, 457);
            TextBoxHeight.Margin = new Padding(4);
            TextBoxHeight.Name = "TextBoxHeight";
            TextBoxHeight.PlaceholderText = "Высота";
            TextBoxHeight.Size = new Size(170, 57);
            TextBoxHeight.TabIndex = 7;
            TextBoxHeight.TextAlign = HorizontalAlignment.Center;
            TextBoxHeight.Visible = false;
            // 
            // TextBoxWidth
            // 
            TextBoxWidth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxWidth.Location = new Point(296, 457);
            TextBoxWidth.Margin = new Padding(4);
            TextBoxWidth.Name = "TextBoxWidth";
            TextBoxWidth.PlaceholderText = "Ширина";
            TextBoxWidth.Size = new Size(170, 57);
            TextBoxWidth.TabIndex = 6;
            TextBoxWidth.TextAlign = HorizontalAlignment.Center;
            TextBoxWidth.Visible = false;
            // 
            // TextBoxY1
            // 
            TextBoxY1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxY1.Location = new Point(542, 277);
            TextBoxY1.Margin = new Padding(4);
            TextBoxY1.Name = "TextBoxY1";
            TextBoxY1.PlaceholderText = "y1";
            TextBoxY1.Size = new Size(170, 57);
            TextBoxY1.TabIndex = 3;
            TextBoxY1.TextAlign = HorizontalAlignment.Center;
            TextBoxY1.Visible = false;
            // 
            // ParameterTipLabel
            // 
            ParameterTipLabel.AutoSize = true;
            ParameterTipLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ParameterTipLabel.ForeColor = Color.White;
            ParameterTipLabel.Location = new Point(78, 194);
            ParameterTipLabel.Margin = new Padding(4, 0, 4, 0);
            ParameterTipLabel.Name = "ParameterTipLabel";
            ParameterTipLabel.Size = new Size(481, 51);
            ParameterTipLabel.TabIndex = 14;
            ParameterTipLabel.Text = "Параметры (целые числа):";
            ParameterTipLabel.Visible = false;
            // 
            // CreateFigureForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(766, 671);
            Controls.Add(ParameterTipLabel);
            Controls.Add(TextBoxY1);
            Controls.Add(TextBoxWidth);
            Controls.Add(TextBoxHeight);
            Controls.Add(TextBoxY2);
            Controls.Add(TextBoxX2);
            Controls.Add(DrawFigureButton);
            Controls.Add(FigureLabel);
            Controls.Add(TextBoxX1);
            Controls.Add(FigureTypeComboBox);
            Margin = new Padding(4);
            Name = "CreateFigureForm";
            Text = "Создание фигуры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FigureTypeComboBox;
        private TextBox TextBoxX1;
        private TextBox TextBoxX2;
        private Label FigureLabel;
        private Button DrawFigureButton;
        private TextBox TextBoxY2;
        private TextBox TextBoxHeight;
        private TextBox TextBoxWidth;
        private TextBox TextBoxY1;
        private Label ParameterTipLabel;
    }
}