namespace ElementPlacement
{
    partial class PCBMargins
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
            MarginXTextbox = new System.Windows.Forms.TextBox();
            MarginXLabel = new System.Windows.Forms.Label();
            PCBMarginsFormLabel = new System.Windows.Forms.Label();
            MarginYTextbox = new System.Windows.Forms.TextBox();
            MarginYLabel = new System.Windows.Forms.Label();
            MarginsOkbtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // MarginXTextbox
            // 
            MarginXTextbox.Location = new System.Drawing.Point(398, 87);
            MarginXTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MarginXTextbox.Name = "MarginXTextbox";
            MarginXTextbox.Size = new System.Drawing.Size(85, 23);
            MarginXTextbox.TabIndex = 43;
            MarginXTextbox.TextChanged += MarginXTextbox_TextChanged;
            // 
            // MarginXLabel
            // 
            MarginXLabel.AutoSize = true;
            MarginXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MarginXLabel.Location = new System.Drawing.Point(17, 83);
            MarginXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MarginXLabel.Name = "MarginXLabel";
            MarginXLabel.Size = new System.Drawing.Size(237, 24);
            MarginXLabel.TabIndex = 42;
            MarginXLabel.Text = "Введите отступ по оси X";
            // 
            // PCBMarginsFormLabel
            // 
            PCBMarginsFormLabel.AutoSize = true;
            PCBMarginsFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PCBMarginsFormLabel.Location = new System.Drawing.Point(33, 18);
            PCBMarginsFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PCBMarginsFormLabel.Name = "PCBMarginsFormLabel";
            PCBMarginsFormLabel.Size = new System.Drawing.Size(441, 24);
            PCBMarginsFormLabel.TabIndex = 41;
            PCBMarginsFormLabel.Text = "Добавление отступов от краев печатной платы";
            // 
            // MarginYTextbox
            // 
            MarginYTextbox.Location = new System.Drawing.Point(398, 130);
            MarginYTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MarginYTextbox.Name = "MarginYTextbox";
            MarginYTextbox.Size = new System.Drawing.Size(85, 23);
            MarginYTextbox.TabIndex = 40;
            MarginYTextbox.TextChanged += MarginYTextbox_TextChanged;
            // 
            // MarginYLabel
            // 
            MarginYLabel.AutoSize = true;
            MarginYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MarginYLabel.Location = new System.Drawing.Point(17, 126);
            MarginYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MarginYLabel.Name = "MarginYLabel";
            MarginYLabel.Size = new System.Drawing.Size(235, 24);
            MarginYLabel.TabIndex = 39;
            MarginYLabel.Text = "Введите отступ по оси Y";
            // 
            // MarginsOkbtn
            // 
            MarginsOkbtn.Location = new System.Drawing.Point(398, 205);
            MarginsOkbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MarginsOkbtn.Name = "MarginsOkbtn";
            MarginsOkbtn.Size = new System.Drawing.Size(99, 41);
            MarginsOkbtn.TabIndex = 44;
            MarginsOkbtn.Text = "OK";
            MarginsOkbtn.UseVisualStyleBackColor = true;
            MarginsOkbtn.Click += MarginsOkbtn_Click;
            // 
            // PCBMargins
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(510, 258);
            Controls.Add(MarginsOkbtn);
            Controls.Add(MarginXTextbox);
            Controls.Add(MarginXLabel);
            Controls.Add(PCBMarginsFormLabel);
            Controls.Add(MarginYTextbox);
            Controls.Add(MarginYLabel);
            Name = "PCBMargins";
            Text = "PCBMargins";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox MarginXTextbox;
        private System.Windows.Forms.Label MarginXLabel;
        private System.Windows.Forms.Label PCBMarginsFormLabel;
        private System.Windows.Forms.TextBox MarginYTextbox;
        private System.Windows.Forms.Label MarginYLabel;
        private System.Windows.Forms.Button MarginsOkbtn;
    }
}