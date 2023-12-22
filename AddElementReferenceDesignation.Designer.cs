namespace ElementPlacement
{
    partial class AddElementReferenceDesignation
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
            ElementReferenceLabel = new System.Windows.Forms.Label();
            CurrentElementDataLabel = new System.Windows.Forms.Label();
            ElementReferenceDesLabel = new System.Windows.Forms.Label();
            ElementReferenceDesignationtextBox1 = new System.Windows.Forms.TextBox();
            ElementReferenceDesignationBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ElementReferenceLabel
            // 
            ElementReferenceLabel.AutoSize = true;
            ElementReferenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ElementReferenceLabel.Location = new System.Drawing.Point(210, 24);
            ElementReferenceLabel.Name = "ElementReferenceLabel";
            ElementReferenceLabel.Size = new System.Drawing.Size(336, 48);
            ElementReferenceLabel.TabIndex = 0;
            ElementReferenceLabel.Text = "Введите позиционное обозначение\r\nданного элемента";
            ElementReferenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentElementDataLabel
            // 
            CurrentElementDataLabel.AutoSize = true;
            CurrentElementDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CurrentElementDataLabel.Location = new System.Drawing.Point(72, 114);
            CurrentElementDataLabel.Name = "CurrentElementDataLabel";
            CurrentElementDataLabel.Size = new System.Drawing.Size(204, 24);
            CurrentElementDataLabel.TabIndex = 1;
            CurrentElementDataLabel.Text = "Данные об элементе:";
            CurrentElementDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementReferenceDesLabel
            // 
            ElementReferenceDesLabel.AutoSize = true;
            ElementReferenceDesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ElementReferenceDesLabel.Location = new System.Drawing.Point(48, 249);
            ElementReferenceDesLabel.Name = "ElementReferenceDesLabel";
            ElementReferenceDesLabel.Size = new System.Drawing.Size(260, 24);
            ElementReferenceDesLabel.TabIndex = 2;
            ElementReferenceDesLabel.Text = "Позиционное обозначение:";
            ElementReferenceDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementReferenceDesignationtextBox1
            // 
            ElementReferenceDesignationtextBox1.Location = new System.Drawing.Point(453, 253);
            ElementReferenceDesignationtextBox1.Name = "ElementReferenceDesignationtextBox1";
            ElementReferenceDesignationtextBox1.Size = new System.Drawing.Size(218, 23);
            ElementReferenceDesignationtextBox1.TabIndex = 3;
            ElementReferenceDesignationtextBox1.TextChanged += ElementReferenceDesignationtextBox1_TextChanged;
            // 
            // ElementReferenceDesignationBtn
            // 
            ElementReferenceDesignationBtn.Location = new System.Drawing.Point(622, 339);
            ElementReferenceDesignationBtn.Name = "ElementReferenceDesignationBtn";
            ElementReferenceDesignationBtn.Size = new System.Drawing.Size(98, 40);
            ElementReferenceDesignationBtn.TabIndex = 4;
            ElementReferenceDesignationBtn.Text = "OK";
            ElementReferenceDesignationBtn.UseVisualStyleBackColor = true;
            ElementReferenceDesignationBtn.Click += ElementReferenceDesignationBtn_Click;
            // 
            // AddElementReferenceDesignation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(732, 391);
            Controls.Add(ElementReferenceDesignationBtn);
            Controls.Add(ElementReferenceDesignationtextBox1);
            Controls.Add(ElementReferenceDesLabel);
            Controls.Add(CurrentElementDataLabel);
            Controls.Add(ElementReferenceLabel);
            Name = "AddElementReferenceDesignation";
            Text = "AddElementReferenceDesignation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ElementReferenceLabel;
        private System.Windows.Forms.Label CurrentElementDataLabel;
        private System.Windows.Forms.Label ElementReferenceDesLabel;
        private System.Windows.Forms.TextBox ElementReferenceDesignationtextBox1;
        private System.Windows.Forms.Button ElementReferenceDesignationBtn;
    }
}