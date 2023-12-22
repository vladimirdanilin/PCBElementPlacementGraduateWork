namespace ElementPlacement
{
    partial class ElementsOfProject
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
            ElementsOfProjectFormLabel = new System.Windows.Forms.Label();
            ElementsOfProjectLabel = new System.Windows.Forms.Label();
            ElementsOfProjectOKbtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ElementsOfProjectFormLabel
            // 
            ElementsOfProjectFormLabel.AutoSize = true;
            ElementsOfProjectFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ElementsOfProjectFormLabel.Location = new System.Drawing.Point(103, 47);
            ElementsOfProjectFormLabel.Name = "ElementsOfProjectFormLabel";
            ElementsOfProjectFormLabel.Size = new System.Drawing.Size(539, 24);
            ElementsOfProjectFormLabel.TabIndex = 0;
            ElementsOfProjectFormLabel.Text = "В выбранном проекте присутствуют следующие элементы";
            // 
            // ElementsOfProjectLabel
            // 
            ElementsOfProjectLabel.AutoSize = true;
            ElementsOfProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ElementsOfProjectLabel.Location = new System.Drawing.Point(12, 86);
            ElementsOfProjectLabel.Name = "ElementsOfProjectLabel";
            ElementsOfProjectLabel.Size = new System.Drawing.Size(107, 24);
            ElementsOfProjectLabel.TabIndex = 1;
            ElementsOfProjectLabel.Text = "Элементы:";
            // 
            // ElementsOfProjectOKbtn
            // 
            ElementsOfProjectOKbtn.Location = new System.Drawing.Point(1127, 667);
            ElementsOfProjectOKbtn.Name = "ElementsOfProjectOKbtn";
            ElementsOfProjectOKbtn.Size = new System.Drawing.Size(101, 37);
            ElementsOfProjectOKbtn.TabIndex = 2;
            ElementsOfProjectOKbtn.Text = "OK";
            ElementsOfProjectOKbtn.UseVisualStyleBackColor = true;
            ElementsOfProjectOKbtn.Click += ElementsOfProjectOKbtn_Click;
            // 
            // ElementsOfProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1240, 716);
            Controls.Add(ElementsOfProjectOKbtn);
            Controls.Add(ElementsOfProjectLabel);
            Controls.Add(ElementsOfProjectFormLabel);
            Name = "ElementsOfProject";
            Text = "ElementsOfProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ElementsOfProjectFormLabel;
        private System.Windows.Forms.Label ElementsOfProjectLabel;
        private System.Windows.Forms.Button ElementsOfProjectOKbtn;
    }
}