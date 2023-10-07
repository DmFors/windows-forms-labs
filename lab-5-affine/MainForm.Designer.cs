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
            changePivot = new Button();
            scaleButton = new Button();
            undoButton = new Button();
            redoButton = new Button();
            rotateDegreeField = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            shiftDXField = new NumericUpDown();
            label = new Label();
            shiftDYField = new NumericUpDown();
            label3 = new Label();
            scaleKXField = new NumericUpDown();
            label4 = new Label();
            scaleKYField = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)rotateDegreeField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiftDXField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiftDYField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleKXField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleKYField).BeginInit();
            SuspendLayout();
            // 
            // shift
            // 
            shift.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shift.Location = new Point(651, 146);
            shift.Name = "shift";
            shift.Size = new Size(277, 74);
            shift.TabIndex = 7;
            shift.Text = "Сдвинуть";
            shift.UseVisualStyleBackColor = true;
            shift.Click += shift_Click;
            // 
            // rotateButton
            // 
            rotateButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rotateButton.Location = new Point(321, 146);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(296, 74);
            rotateButton.TabIndex = 4;
            rotateButton.Text = "Повернуть";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // changePivot
            // 
            changePivot.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            changePivot.Location = new Point(12, 126);
            changePivot.Name = "changePivot";
            changePivot.Size = new Size(277, 94);
            changePivot.TabIndex = 2;
            changePivot.Text = "Сменить опорную точку";
            changePivot.UseVisualStyleBackColor = true;
            changePivot.Click += changePivot_Click;
            // 
            // scaleButton
            // 
            scaleButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleButton.Location = new Point(978, 146);
            scaleButton.Name = "scaleButton";
            scaleButton.Size = new Size(318, 74);
            scaleButton.TabIndex = 10;
            scaleButton.Text = "Масштабировать";
            scaleButton.UseVisualStyleBackColor = true;
            scaleButton.Click += scaleButton_Click;
            // 
            // undoButton
            // 
            undoButton.Enabled = false;
            undoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            undoButton.Location = new Point(12, 19);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(130, 74);
            undoButton.TabIndex = 0;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // redoButton
            // 
            redoButton.Enabled = false;
            redoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            redoButton.Location = new Point(159, 19);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(130, 74);
            redoButton.TabIndex = 1;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = true;
            redoButton.Click += redoButton_Click;
            // 
            // rotateDegreeField
            // 
            rotateDegreeField.DecimalPlaces = 1;
            rotateDegreeField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rotateDegreeField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            rotateDegreeField.Location = new Point(491, 17);
            rotateDegreeField.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            rotateDegreeField.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            rotateDegreeField.Name = "rotateDegreeField";
            rotateDegreeField.Size = new Size(126, 55);
            rotateDegreeField.TabIndex = 3;
            rotateDegreeField.Value = new decimal(new int[] { 360, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(321, 19);
            label1.Name = "label1";
            label1.Size = new Size(164, 48);
            label1.TabIndex = 13;
            label1.Text = "Градусы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(651, 10);
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
            shiftDXField.Location = new Point(723, 8);
            shiftDXField.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            shiftDXField.Name = "shiftDXField";
            shiftDXField.Size = new Size(126, 55);
            shiftDXField.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(651, 73);
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
            shiftDYField.Location = new Point(723, 71);
            shiftDYField.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            shiftDYField.Name = "shiftDYField";
            shiftDYField.Size = new Size(126, 55);
            shiftDYField.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(984, 19);
            label3.Name = "label3";
            label3.Size = new Size(63, 48);
            label3.TabIndex = 19;
            label3.Text = "kx:";
            // 
            // scaleKXField
            // 
            scaleKXField.DecimalPlaces = 1;
            scaleKXField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleKXField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            scaleKXField.Location = new Point(1056, 17);
            scaleKXField.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            scaleKXField.Name = "scaleKXField";
            scaleKXField.Size = new Size(126, 55);
            scaleKXField.TabIndex = 8;
            scaleKXField.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(984, 80);
            label4.Name = "label4";
            label4.Size = new Size(63, 48);
            label4.TabIndex = 21;
            label4.Text = "ky:";
            // 
            // scaleKYField
            // 
            scaleKYField.DecimalPlaces = 1;
            scaleKYField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleKYField.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            scaleKYField.Location = new Point(1056, 78);
            scaleKYField.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            scaleKYField.Name = "scaleKYField";
            scaleKYField.Size = new Size(126, 55);
            scaleKYField.TabIndex = 9;
            scaleKYField.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 1444);
            Controls.Add(label4);
            Controls.Add(scaleKYField);
            Controls.Add(label3);
            Controls.Add(scaleKXField);
            Controls.Add(label);
            Controls.Add(shiftDYField);
            Controls.Add(label2);
            Controls.Add(shiftDXField);
            Controls.Add(label1);
            Controls.Add(rotateDegreeField);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(scaleButton);
            Controls.Add(changePivot);
            Controls.Add(rotateButton);
            Controls.Add(shift);
            Name = "MainForm";
            Text = "Афинные преобразования";
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
        private Button changePivot;
        private Button scaleButton;
        private Button undoButton;
        private Button redoButton;
        private NumericUpDown rotateDegreeField;
        private Label label1;
        private Label label2;
        private NumericUpDown shiftDXField;
        private Label label;
        private NumericUpDown shiftDYField;
        private Label label3;
        private NumericUpDown scaleKXField;
        private Label label4;
        private NumericUpDown scaleKYField;
    }
}