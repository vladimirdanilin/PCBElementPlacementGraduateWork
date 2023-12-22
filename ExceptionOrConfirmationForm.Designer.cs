namespace ElementPlacement
{
    partial class ExceptionOrConfirmationForm
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
            ExceptionLabel = new System.Windows.Forms.Label();
            Exceptionbtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ExceptionLabel
            // 
            ExceptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            ExceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ExceptionLabel.Location = new System.Drawing.Point(0, 0);
            ExceptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ExceptionLabel.Name = "ExceptionLabel";
            ExceptionLabel.Size = new System.Drawing.Size(492, 329);
            ExceptionLabel.TabIndex = 0;
            ExceptionLabel.Text = "ExceptionLabel";
            ExceptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exceptionbtn
            // 
            Exceptionbtn.Location = new System.Drawing.Point(377, 275);
            Exceptionbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Exceptionbtn.Name = "Exceptionbtn";
            Exceptionbtn.Size = new System.Drawing.Size(102, 40);
            Exceptionbtn.TabIndex = 1;
            Exceptionbtn.Text = "OK";
            Exceptionbtn.UseVisualStyleBackColor = true;
            Exceptionbtn.Click += Exceptionbtn_Click;
            // 
            // ExceptionOrConfirmationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(492, 329);
            Controls.Add(Exceptionbtn);
            Controls.Add(ExceptionLabel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ExceptionOrConfirmationForm";
            Text = "Exception";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label ExceptionLabel;
        private System.Windows.Forms.Button Exceptionbtn;
    }
}