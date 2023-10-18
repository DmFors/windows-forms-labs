namespace lab_5_affine
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
            shift = new Button();
            rotateButton = new Button();
            rotateDegreeField = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            shiftDXField = new NumericUpDown();
            label = new Label();
            shiftDYField = new NumericUpDown();
            scaleKXField = new NumericUpDown();
            scaleKYField = new NumericUpDown();
            scaleButton = new Button();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)rotateDegreeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiftDXField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiftDYField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleKXField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleKYField).BeginInit();
            SuspendLayout();
            // 
            // shift
            // 
            shift.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shift.Location = new Point(374, 118);
            shift.Name = "shift";
            shift.Size = new Size(237, 84);
            shift.TabIndex = 7;
            shift.Text = "Shift";
            shift.UseVisualStyleBackColor = true;
            shift.Click += shift_Click;
            // 
            // rotateButton
            // 
            rotateButton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rotateButton.Location = new Point(28, 118);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(310, 84);
            rotateButton.TabIndex = 4;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // rotateDegreeField
            // 
            rotateDegreeField.DecimalPlaces = 1;
            rotateDegreeField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rotateDegreeField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            rotateDegreeField.Location = new Point(206, 8);
            rotateDegreeField.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            rotateDegreeField.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            rotateDegreeField.Name = "rotateDegreeField";
            rotateDegreeField.Size = new Size(132, 55);
            rotateDegreeField.TabIndex = 3;
            rotateDegreeField.Value = new decimal(new int[] { 360, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 48);
            label1.TabIndex = 13;
            label1.Text = "Degrees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(374, 2);
            label2.Name = "label2";
            label2.Size = new Size(66, 48);
            label2.TabIndex = 15;
            label2.Text = "dx:";
            // 
            // shiftDXField
            // 
            shiftDXField.DecimalPlaces = 1;
            shiftDXField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shiftDXField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            shiftDXField.Location = new Point(449, 1);
            shiftDXField.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            shiftDXField.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            shiftDXField.Name = "shiftDXField";
            shiftDXField.Size = new Size(162, 55);
            shiftDXField.TabIndex = 5;
            shiftDXField.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(374, 59);
            label.Name = "label";
            label.Size = new Size(66, 48);
            label.TabIndex = 17;
            label.Text = "dy:";
            // 
            // shiftDYField
            // 
            shiftDYField.DecimalPlaces = 1;
            shiftDYField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shiftDYField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            shiftDYField.Location = new Point(449, 57);
            shiftDYField.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            shiftDYField.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            shiftDYField.Name = "shiftDYField";
            shiftDYField.Size = new Size(162, 55);
            shiftDYField.TabIndex = 6;
            shiftDYField.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // scaleKXField
            // 
            scaleKXField.DecimalPlaces = 1;
            scaleKXField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleKXField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            scaleKXField.Location = new Point(746, 1);
            scaleKXField.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            scaleKXField.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            scaleKXField.Name = "scaleKXField";
            scaleKXField.Size = new Size(165, 55);
            scaleKXField.TabIndex = 8;
            scaleKXField.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // scaleKYField
            // 
            scaleKYField.DecimalPlaces = 1;
            scaleKYField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleKYField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            scaleKYField.Location = new Point(746, 56);
            scaleKYField.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            scaleKYField.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            scaleKYField.Name = "scaleKYField";
            scaleKYField.Size = new Size(165, 55);
            scaleKYField.TabIndex = 9;
            scaleKYField.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // scaleButton
            // 
            scaleButton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleButton.Location = new Point(672, 118);
            scaleButton.Name = "scaleButton";
            scaleButton.Size = new Size(239, 84);
            scaleButton.TabIndex = 10;
            scaleButton.Text = "Scale";
            scaleButton.UseVisualStyleBackColor = true;
            scaleButton.Click += scaleButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(672, 58);
            label4.Name = "label4";
            label4.Size = new Size(63, 48);
            label4.TabIndex = 21;
            label4.Text = "ky:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(672, 2);
            label3.Name = "label3";
            label3.Size = new Size(63, 48);
            label3.TabIndex = 19;
            label3.Text = "kx:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1497, 783);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(scaleButton);
            Controls.Add(label);
            Controls.Add(scaleKYField);
            Controls.Add(shiftDYField);
            Controls.Add(scaleKXField);
            Controls.Add(label2);
            Controls.Add(shiftDXField);
            Controls.Add(label1);
            Controls.Add(rotateDegreeField);
            Controls.Add(rotateButton);
            Controls.Add(shift);
            Name = "MainForm";
            Text = "Афинные преобразования";
            WindowState = FormWindowState.Maximized;
            Paint += MainForm_Paint;
            ((System.ComponentModel.ISupportInitialize)rotateDegreeField).EndInit();
            ((System.ComponentModel.ISupportInitialize)shiftDXField).EndInit();
            ((System.ComponentModel.ISupportInitialize)shiftDYField).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaleKXField).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaleKYField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shift;
        private Button rotateButton;
        private NumericUpDown rotateDegreeField;
        private Label label1;
        private Label label2;
        private NumericUpDown shiftDXField;
        private Label label;
        private NumericUpDown shiftDYField;
        private NumericUpDown scaleKXField;
        private NumericUpDown scaleKYField;
        private Button scaleButton;
        private Label label4;
        private Label label3;
    }
}