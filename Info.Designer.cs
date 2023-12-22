namespace ElementPlacement
{
    partial class Info
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
            InfoRusLabel = new System.Windows.Forms.Label();
            InfoNameLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // InfoRusLabel
            // 
            InfoRusLabel.AutoSize = true;
            InfoRusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InfoRusLabel.Location = new System.Drawing.Point(36, 46);
            InfoRusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            InfoRusLabel.Name = "InfoRusLabel";
            InfoRusLabel.Size = new System.Drawing.Size(470, 120);
            InfoRusLabel.TabIndex = 0;
            InfoRusLabel.Text = "Данное ПО позволяет решать задачу размещения \r\nразногабаритных элементов на печатных платах \r\nс учетом теплового критерия и критерия \r\nминимизации суммарной длины \r\nмежсоединений элементов.";
            InfoRusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoNameLabel
            // 
            InfoNameLabel.AutoSize = true;
            InfoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InfoNameLabel.Location = new System.Drawing.Point(14, 291);
            InfoNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            InfoNameLabel.Name = "InfoNameLabel";
            InfoNameLabel.Size = new System.Drawing.Size(498, 24);
            InfoNameLabel.TabIndex = 1;
            InfoNameLabel.Text = "Разработчик: Данилин Владимир Александрович 4414";
            InfoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(540, 348);
            Controls.Add(InfoNameLabel);
            Controls.Add(InfoRusLabel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Info";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label InfoRusLabel;
        private System.Windows.Forms.Label InfoNameLabel;
    }
}