namespace lab_5_affine
{
    partial class InfoForm
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
            infoLabel = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            infoLabel.Location = new Point(56, 94);
            infoLabel.MaximumSize = new Size(700, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(687, 144);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Здесь будет отображаться текст предупреждения для пользователя или ошибки.\r\n";
            // 
            // okButton
            // 
            okButton.AutoSize = true;
            okButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(316, 380);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 58);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(okButton);
            Controls.Add(infoLabel);
            Name = "InfoForm";
            Text = "InfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private Button okButton;
    }
}