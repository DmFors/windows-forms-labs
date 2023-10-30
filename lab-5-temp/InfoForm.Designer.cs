namespace lab_5_temp
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
            infoLabel.Location = new Point(84, 139);
            infoLabel.Margin = new Padding(4, 0, 4, 0);
            infoLabel.MaximumSize = new Size(1050, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(1025, 216);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Здесь будет отображаться текст предупреждения для пользователя или ошибки.\r\n";
            // 
            // okButton
            // 
            okButton.AutoSize = true;
            okButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(474, 562);
            okButton.Margin = new Padding(4, 4, 4, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(168, 86);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 666);
            Controls.Add(okButton);
            Controls.Add(infoLabel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "InfoForm";
            Text = "Информационное окно";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private Button okButton;
    }
}