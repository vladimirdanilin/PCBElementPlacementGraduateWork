namespace ElementPlacement
{
    partial class SelectPCB
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
            this.SelectPCBlistBox = new System.Windows.Forms.ListBox();
            this.SelectPCBlabel = new System.Windows.Forms.Label();
            this.SelectPcbOKbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectPCBlistBox
            // 
            this.SelectPCBlistBox.FormattingEnabled = true;
            this.SelectPCBlistBox.Location = new System.Drawing.Point(55, 67);
            this.SelectPCBlistBox.Name = "SelectPCBlistBox";
            this.SelectPCBlistBox.Size = new System.Drawing.Size(364, 225);
            this.SelectPCBlistBox.TabIndex = 0;
            this.SelectPCBlistBox.SelectedIndexChanged += new System.EventHandler(this.SelectPCBlistBox_SelectedIndexChanged);
            // 
            // SelectPCBlabel
            // 
            this.SelectPCBlabel.AutoSize = true;
            this.SelectPCBlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectPCBlabel.Location = new System.Drawing.Point(114, 21);
            this.SelectPCBlabel.Name = "SelectPCBlabel";
            this.SelectPCBlabel.Size = new System.Drawing.Size(246, 24);
            this.SelectPCBlabel.TabIndex = 1;
            this.SelectPCBlabel.Text = "Выберите печатную плату";
            // 
            // SelectPcbOKbtn
            // 
            this.SelectPcbOKbtn.Location = new System.Drawing.Point(378, 321);
            this.SelectPcbOKbtn.Name = "SelectPcbOKbtn";
            this.SelectPcbOKbtn.Size = new System.Drawing.Size(85, 34);
            this.SelectPcbOKbtn.TabIndex = 2;
            this.SelectPcbOKbtn.Text = "ОК";
            this.SelectPcbOKbtn.UseVisualStyleBackColor = true;
            this.SelectPcbOKbtn.Click += new System.EventHandler(this.SelectPcbOKbtn_Click);
            // 
            // SelectPCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 367);
            this.Controls.Add(this.SelectPcbOKbtn);
            this.Controls.Add(this.SelectPCBlabel);
            this.Controls.Add(this.SelectPCBlistBox);
            this.Name = "SelectPCB";
            this.Text = "SelectPCB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SelectPCBlistBox;
        private System.Windows.Forms.Label SelectPCBlabel;
        private System.Windows.Forms.Button SelectPcbOKbtn;
    }
}