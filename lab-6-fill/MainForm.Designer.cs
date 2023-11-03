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
            infoLabel = new Label();
            colorPreviewRect = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorPreviewRect).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Location = new Point(61, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(990, 752);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // fillSeedButton
            // 
            fillSeedButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fillSeedButton.Location = new Point(1082, 218);
            fillSeedButton.Name = "fillSeedButton";
            fillSeedButton.Size = new Size(363, 68);
            fillSeedButton.TabIndex = 1;
            fillSeedButton.Text = "Затравка";
            fillSeedButton.UseVisualStyleBackColor = true;
            fillSeedButton.Click += fillSeedButton_Click;
            // 
            // fillLineButton
            // 
            fillLineButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fillLineButton.Location = new Point(1082, 113);
            fillLineButton.Name = "fillLineButton";
            fillLineButton.Size = new Size(363, 68);
            fillLineButton.TabIndex = 3;
            fillLineButton.Text = "Построчно";
            fillLineButton.UseVisualStyleBackColor = true;
            fillLineButton.Click += fillLineButton_Click;
            // 
            // chooseColorButton
            // 
            chooseColorButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chooseColorButton.Location = new Point(1181, 27);
            chooseColorButton.Name = "chooseColorButton";
            chooseColorButton.Size = new Size(264, 68);
            chooseColorButton.TabIndex = 4;
            chooseColorButton.Text = "Выбрать цвет";
            chooseColorButton.UseVisualStyleBackColor = true;
            chooseColorButton.Click += chooseColorButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            infoLabel.Location = new Point(1082, 318);
            infoLabel.Margin = new Padding(2, 0, 2, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(603, 452);
            infoLabel.TabIndex = 5;
            infoLabel.Text = "Информация";
            // 
            // colorPreviewRect
            // 
            colorPreviewRect.BackColor = SystemColors.Control;
            colorPreviewRect.BorderStyle = BorderStyle.FixedSingle;
            colorPreviewRect.Location = new Point(1082, 35);
            colorPreviewRect.Margin = new Padding(2, 2, 2, 2);
            colorPreviewRect.Name = "colorPreviewRect";
            colorPreviewRect.Size = new Size(95, 52);
            colorPreviewRect.TabIndex = 6;
            colorPreviewRect.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1696, 920);
            Controls.Add(colorPreviewRect);
            Controls.Add(infoLabel);
            Controls.Add(chooseColorButton);
            Controls.Add(fillLineButton);
            Controls.Add(fillSeedButton);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Заливка фигуры";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorPreviewRect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button fillSeedButton;
        private Button fillLineButton;
        private Button chooseColorButton;
        private Label infoLabel;
        private PictureBox colorPreviewRect;
    }
}