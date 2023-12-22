namespace ElementPlacement
{
    partial class NetsInputData
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
            NetsInputDataFormLabel = new System.Windows.Forms.Label();
            NetsInputPathLabel = new System.Windows.Forms.Label();
            NetsInputSelectBtn = new System.Windows.Forms.Button();
            NetsInputLabel = new System.Windows.Forms.Label();
            openNetFileDialog = new System.Windows.Forms.OpenFileDialog();
            NetOkBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // NetsInputDataFormLabel
            // 
            NetsInputDataFormLabel.AutoSize = true;
            NetsInputDataFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NetsInputDataFormLabel.Location = new System.Drawing.Point(184, 33);
            NetsInputDataFormLabel.Name = "NetsInputDataFormLabel";
            NetsInputDataFormLabel.Size = new System.Drawing.Size(444, 24);
            NetsInputDataFormLabel.TabIndex = 0;
            NetsInputDataFormLabel.Text = "Загрузка данных о межсоединениях элементов";
            NetsInputDataFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NetsInputPathLabel
            // 
            NetsInputPathLabel.AutoSize = true;
            NetsInputPathLabel.Location = new System.Drawing.Point(354, 119);
            NetsInputPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NetsInputPathLabel.Name = "NetsInputPathLabel";
            NetsInputPathLabel.Size = new System.Drawing.Size(0, 15);
            NetsInputPathLabel.TabIndex = 36;
            // 
            // NetsInputSelectBtn
            // 
            NetsInputSelectBtn.Location = new System.Drawing.Point(670, 108);
            NetsInputSelectBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NetsInputSelectBtn.Name = "NetsInputSelectBtn";
            NetsInputSelectBtn.Size = new System.Drawing.Size(90, 37);
            NetsInputSelectBtn.TabIndex = 35;
            NetsInputSelectBtn.Text = "Выбрать";
            NetsInputSelectBtn.UseVisualStyleBackColor = true;
            NetsInputSelectBtn.Click += NetsInputSelectBtn_Click;
            // 
            // NetsInputLabel
            // 
            NetsInputLabel.AutoSize = true;
            NetsInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NetsInputLabel.Location = new System.Drawing.Point(25, 100);
            NetsInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NetsInputLabel.Name = "NetsInputLabel";
            NetsInputLabel.Size = new System.Drawing.Size(276, 48);
            NetsInputLabel.TabIndex = 34;
            NetsInputLabel.Text = "Выберите txt-файл, хранящий \r\nданные о межсоединениях";
            NetsInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openNetFileDialog
            // 
            openNetFileDialog.FileName = "openNetFileDialog";
            // 
            // NetOkBtn
            // 
            NetOkBtn.Location = new System.Drawing.Point(670, 401);
            NetOkBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NetOkBtn.Name = "NetOkBtn";
            NetOkBtn.Size = new System.Drawing.Size(90, 37);
            NetOkBtn.TabIndex = 37;
            NetOkBtn.Text = "OK";
            NetOkBtn.UseVisualStyleBackColor = true;
            NetOkBtn.Click += NetOkBtn_Click;
            // 
            // NetsInputData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(NetOkBtn);
            Controls.Add(NetsInputPathLabel);
            Controls.Add(NetsInputSelectBtn);
            Controls.Add(NetsInputLabel);
            Controls.Add(NetsInputDataFormLabel);
            Name = "NetsInputData";
            Text = "NetsInputData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label NetsInputDataFormLabel;
        private System.Windows.Forms.Label NetsInputPathLabel;
        private System.Windows.Forms.Button NetsInputSelectBtn;
        private System.Windows.Forms.Label NetsInputLabel;
        private System.Windows.Forms.OpenFileDialog openNetFileDialog;
        private System.Windows.Forms.Button NetOkBtn;
    }
}