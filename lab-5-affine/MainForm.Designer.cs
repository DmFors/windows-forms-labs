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
            scaleKX = new TextBox();
            scaleKY = new TextBox();
            shiftDY = new TextBox();
            shiftDX = new TextBox();
            undo = new Button();
            rotateDegree = new TextBox();
            SuspendLayout();
            // 
            // shift
            // 
            shift.Location = new Point(393, 86);
            shift.Name = "shift";
            shift.Size = new Size(277, 74);
            shift.TabIndex = 1;
            shift.Text = "Сдвинуть";
            shift.UseVisualStyleBackColor = true;
            shift.Click += shift_Click;
            // 
            // rotateButton
            // 
            rotateButton.Location = new Point(63, 89);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(277, 74);
            rotateButton.TabIndex = 2;
            rotateButton.Text = "Повернуть";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // changePivot
            // 
            changePivot.Location = new Point(1043, 86);
            changePivot.Name = "changePivot";
            changePivot.Size = new Size(277, 74);
            changePivot.TabIndex = 3;
            changePivot.Text = "Сменить опорную точку";
            changePivot.UseVisualStyleBackColor = true;
            changePivot.Click += changePivot_Click;
            // 
            // scaleButton
            // 
            scaleButton.Location = new Point(720, 86);
            scaleButton.Name = "scaleButton";
            scaleButton.Size = new Size(277, 74);
            scaleButton.TabIndex = 4;
            scaleButton.Text = "Сжать/Растянуть";
            scaleButton.UseVisualStyleBackColor = true;
            scaleButton.Click += scaleButton_Click;
            // 
            // scaleKX
            // 
            scaleKX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleKX.Location = new Point(720, 10);
            scaleKX.Name = "scaleKX";
            scaleKX.PlaceholderText = "kx";
            scaleKX.Size = new Size(95, 55);
            scaleKX.TabIndex = 5;
            // 
            // scaleKY
            // 
            scaleKY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scaleKY.Location = new Point(899, 10);
            scaleKY.Name = "scaleKY";
            scaleKY.PlaceholderText = "ky";
            scaleKY.Size = new Size(95, 55);
            scaleKY.TabIndex = 6;
            // 
            // shiftDY
            // 
            shiftDY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shiftDY.Location = new Point(575, 10);
            shiftDY.Name = "shiftDY";
            shiftDY.PlaceholderText = "dy";
            shiftDY.Size = new Size(95, 55);
            shiftDY.TabIndex = 8;
            // 
            // shiftDX
            // 
            shiftDX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shiftDX.Location = new Point(393, 10);
            shiftDX.Name = "shiftDX";
            shiftDX.PlaceholderText = "dx";
            shiftDX.Size = new Size(95, 55);
            shiftDX.TabIndex = 7;
            // 
            // undo
            // 
            undo.Enabled = false;
            undo.Location = new Point(63, 10);
            undo.Name = "undo";
            undo.Size = new Size(110, 74);
            undo.TabIndex = 9;
            undo.Text = "Отменить";
            undo.UseVisualStyleBackColor = true;
            undo.Click += undo_Click;
            // 
            // rotateDegree
            // 
            rotateDegree.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rotateDegree.Location = new Point(202, 10);
            rotateDegree.Name = "rotateDegree";
            rotateDegree.PlaceholderText = "degrees";
            rotateDegree.Size = new Size(138, 55);
            rotateDegree.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 809);
            Controls.Add(rotateDegree);
            Controls.Add(undo);
            Controls.Add(shiftDY);
            Controls.Add(shiftDX);
            Controls.Add(scaleKY);
            Controls.Add(scaleKX);
            Controls.Add(scaleButton);
            Controls.Add(changePivot);
            Controls.Add(rotateButton);
            Controls.Add(shift);
            Name = "MainForm";
            Text = "Афинные преобразования";
            Paint += MainForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shift;
        private Button rotateButton;
        private Button changePivot;
        private Button scaleButton;
        private TextBox scaleKX;
        private TextBox scaleKY;
        private TextBox shiftDY;
        private TextBox shiftDX;
        private Button undo;
        private TextBox rotateDegree;
    }
}