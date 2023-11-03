namespace lab_6_fill
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
            pictureBox1 = new PictureBox();
            fillSeedButton = new Button();
            fillLineButton = new Button();
            chooseColorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Location = new Point(92, 27);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1485, 1113);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // fillSeedButton
            // 
            fillSeedButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fillSeedButton.Location = new Point(1623, 322);
            fillSeedButton.Margin = new Padding(4, 5, 4, 5);
            fillSeedButton.Name = "fillSeedButton";
            fillSeedButton.Size = new Size(544, 101);
            fillSeedButton.TabIndex = 1;
            fillSeedButton.Text = "Затравка";
            fillSeedButton.UseVisualStyleBackColor = true;
            fillSeedButton.Click += fillSeedButton_Click;
            // 
            // fillLineButton
            // 
            fillLineButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fillLineButton.Location = new Point(1623, 167);
            fillLineButton.Margin = new Padding(4, 5, 4, 5);
            fillLineButton.Name = "fillLineButton";
            fillLineButton.Size = new Size(544, 101);
            fillLineButton.TabIndex = 3;
            fillLineButton.Text = "Построчно";
            fillLineButton.UseVisualStyleBackColor = true;
            fillLineButton.Click += fillLineButton_Click;
            // 
            // chooseColorButton
            // 
            chooseColorButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chooseColorButton.Location = new Point(1623, 27);
            chooseColorButton.Margin = new Padding(4, 5, 4, 5);
            chooseColorButton.Name = "chooseColorButton";
            chooseColorButton.Size = new Size(544, 101);
            chooseColorButton.TabIndex = 4;
            chooseColorButton.Text = "Выбрать цвет";
            chooseColorButton.UseVisualStyleBackColor = true;
            chooseColorButton.Click += chooseColorButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2544, 1361);
            Controls.Add(chooseColorButton);
            Controls.Add(fillLineButton);
            Controls.Add(fillSeedButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Заливка фигуры";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button fillSeedButton;
        private Button fillLineButton;
        private Button chooseColorButton;
    }
}