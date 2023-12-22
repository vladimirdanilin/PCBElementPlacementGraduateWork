namespace ElementPlacement
{
    partial class AddElementsToProject
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
            SelectProjectOKbtn = new System.Windows.Forms.Button();
            AddElementsToProjectLabel = new System.Windows.Forms.Label();
            SelectElementsForAddingListbox = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // SelectProjectOKbtn
            // 
            SelectProjectOKbtn.Location = new System.Drawing.Point(542, 479);
            SelectProjectOKbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SelectProjectOKbtn.Name = "SelectProjectOKbtn";
            SelectProjectOKbtn.Size = new System.Drawing.Size(99, 39);
            SelectProjectOKbtn.TabIndex = 10;
            SelectProjectOKbtn.Text = "ОК";
            SelectProjectOKbtn.UseVisualStyleBackColor = true;
            SelectProjectOKbtn.Click += SelectProjectOKbtn_Click;
            // 
            // AddElementsToProjectLabel
            // 
            AddElementsToProjectLabel.AutoSize = true;
            AddElementsToProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddElementsToProjectLabel.Location = new System.Drawing.Point(125, 20);
            AddElementsToProjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddElementsToProjectLabel.Name = "AddElementsToProjectLabel";
            AddElementsToProjectLabel.Size = new System.Drawing.Size(402, 48);
            AddElementsToProjectLabel.TabIndex = 9;
            AddElementsToProjectLabel.Text = "Выберите элементы, которые необходимо \r\nдобавить в текущий проект";
            AddElementsToProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectElementsForAddingListbox
            // 
            SelectElementsForAddingListbox.FormattingEnabled = true;
            SelectElementsForAddingListbox.ItemHeight = 15;
            SelectElementsForAddingListbox.Location = new System.Drawing.Point(32, 80);
            SelectElementsForAddingListbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SelectElementsForAddingListbox.Name = "SelectElementsForAddingListbox";
            SelectElementsForAddingListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            SelectElementsForAddingListbox.Size = new System.Drawing.Size(587, 379);
            SelectElementsForAddingListbox.TabIndex = 8;
            SelectElementsForAddingListbox.SelectedIndexChanged += SelectElementsForAddingListbox_SelectedIndexChanged;
            // 
            // AddElementsToProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(654, 530);
            Controls.Add(SelectProjectOKbtn);
            Controls.Add(AddElementsToProjectLabel);
            Controls.Add(SelectElementsForAddingListbox);
            Name = "AddElementsToProject";
            Text = "AddElementsToProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button SelectProjectOKbtn;
        private System.Windows.Forms.Label AddElementsToProjectLabel;
        private System.Windows.Forms.ListBox SelectElementsForAddingListbox;
    }
}