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
            // figureTypeComboBox
            // 
            FigureTypeComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FigureTypeComboBox.FormattingEnabled = true;
            FigureTypeComboBox.Location = new Point(170, 83);
            FigureTypeComboBox.Name = "figureTypeComboBox";
            FigureTypeComboBox.Size = new Size(321, 46);
            FigureTypeComboBox.TabIndex = 1;
            FigureTypeComboBox.SelectedIndexChanged += FigureTypeComboBox_SelectedIndexChanged;
            // 
            // textBoxX1
            // 
            TextBoxX1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxX1.Location = new Point(170, 206);
            TextBoxX1.Name = "textBoxX1";
            TextBoxX1.PlaceholderText = "x1";
            TextBoxX1.Size = new Size(132, 45);
            TextBoxX1.TabIndex = 2;
            TextBoxX1.TextAlign = HorizontalAlignment.Center;
            TextBoxX1.Visible = false;
            // 
            // textBoxX2
            // 
            TextBoxX2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxX2.Location = new Point(170, 276);
            TextBoxX2.Name = "textBoxX2";
            TextBoxX2.PlaceholderText = "x2";
            TextBoxX2.Size = new Size(132, 45);
            TextBoxX2.TabIndex = 4;
            TextBoxX2.TextAlign = HorizontalAlignment.Center;
            TextBoxX2.Visible = false;
            // 
            // figureLabel
            // 
            FigureLabel.AutoSize = true;
            FigureLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FigureLabel.Location = new Point(60, 83);
            FigureLabel.Name = "figureLabel";
            FigureLabel.Size = new Size(114, 38);
            FigureLabel.TabIndex = 13;
            FigureLabel.Text = "Фигура:";
            // 
            // drawFigureButton
            // 
            DrawFigureButton.Enabled = false;
            DrawFigureButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DrawFigureButton.Location = new Point(280, 440);
            DrawFigureButton.Name = "drawFigureButton";
            DrawFigureButton.Size = new Size(211, 63);
            DrawFigureButton.TabIndex = 8;
            DrawFigureButton.Text = "Нарисовать";
            DrawFigureButton.UseVisualStyleBackColor = true;
            DrawFigureButton.Click += DrawFigureButton_Click;
            // 
            // textBoxY2
            // 
            TextBoxY2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxY2.Location = new Point(359, 276);
            TextBoxY2.Name = "textBoxY2";
            TextBoxY2.PlaceholderText = "y2";
            TextBoxY2.Size = new Size(132, 45);
            TextBoxY2.TabIndex = 5;
            TextBoxY2.TextAlign = HorizontalAlignment.Center;
            TextBoxY2.Visible = false;
            // 
            // textBoxHeight
            // 
            TextBoxHeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxHeight.Location = new Point(359, 347);
            TextBoxHeight.Name = "textBoxHeight";
            TextBoxHeight.PlaceholderText = "Высота";
            TextBoxHeight.Size = new Size(132, 45);
            TextBoxHeight.TabIndex = 7;
            TextBoxHeight.TextAlign = HorizontalAlignment.Center;
            TextBoxHeight.Visible = false;
            // 
            // textBoxWidth
            // 
            TextBoxWidth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxWidth.Location = new Point(170, 347);
            TextBoxWidth.Name = "textBoxWidth";
            TextBoxWidth.PlaceholderText = "Ширина";
            TextBoxWidth.Size = new Size(132, 45);
            TextBoxWidth.TabIndex = 6;
            TextBoxWidth.TextAlign = HorizontalAlignment.Center;
            TextBoxWidth.Visible = false;
            // 
            // textBoxY1
            // 
            TextBoxY1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxY1.Location = new Point(359, 206);
            TextBoxY1.Name = "textBoxY1";
            TextBoxY1.PlaceholderText = "y1";
            TextBoxY1.Size = new Size(132, 45);
            TextBoxY1.TabIndex = 3;
            TextBoxY1.TextAlign = HorizontalAlignment.Center;
            TextBoxY1.Visible = false;
            // 
            // ParameterTipLabel
            // 
            ParameterTipLabel.AutoSize = true;
            ParameterTipLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ParameterTipLabel.Location = new Point(60, 148);
            ParameterTipLabel.Name = "ParameterTipLabel";
            ParameterTipLabel.Size = new Size(357, 38);
            ParameterTipLabel.TabIndex = 14;
            ParameterTipLabel.Text = "Параметры (целые числа):";
            ParameterTipLabel.Visible = false;
            // 
            // CreateFigureForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 524);
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