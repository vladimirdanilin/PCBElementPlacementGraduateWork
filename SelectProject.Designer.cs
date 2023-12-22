namespace ElementPlacement
{
    partial class SelectProject
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
            ExistingProjectLavel = new System.Windows.Forms.Label();
            SelectProjectlistBox = new System.Windows.Forms.ListBox();
            DbOfExProjectPathLabel = new System.Windows.Forms.Label();
            OpenDbButton = new System.Windows.Forms.Button();
            openDbDialog = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // SelectProjectOKbtn
            // 
            SelectProjectOKbtn.Location = new System.Drawing.Point(467, 420);
            SelectProjectOKbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SelectProjectOKbtn.Name = "SelectProjectOKbtn";
            SelectProjectOKbtn.Size = new System.Drawing.Size(99, 39);
            SelectProjectOKbtn.TabIndex = 5;
            SelectProjectOKbtn.Text = "ОК";
            SelectProjectOKbtn.UseVisualStyleBackColor = true;
            SelectProjectOKbtn.Click += SelectProjectOKbtn_Click;
            // 
            // ExistingProjectLavel
            // 
            ExistingProjectLavel.AutoSize = true;
            ExistingProjectLavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ExistingProjectLavel.Location = new System.Drawing.Point(212, 23);
            ExistingProjectLavel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ExistingProjectLavel.Name = "ExistingProjectLavel";
            ExistingProjectLavel.Size = new System.Drawing.Size(178, 24);
            ExistingProjectLavel.TabIndex = 4;
            ExistingProjectLavel.Text = "Открытие проекта";
            // 
            // SelectProjectlistBox
            // 
            SelectProjectlistBox.FormattingEnabled = true;
            SelectProjectlistBox.ItemHeight = 15;
            SelectProjectlistBox.Location = new System.Drawing.Point(30, 130);
            SelectProjectlistBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SelectProjectlistBox.Name = "SelectProjectlistBox";
            SelectProjectlistBox.Size = new System.Drawing.Size(511, 259);
            SelectProjectlistBox.TabIndex = 3;
            SelectProjectlistBox.SelectedIndexChanged += SelectProjectlistBox_SelectedIndexChanged;
            // 
            // DbOfExProjectPathLabel
            // 
            DbOfExProjectPathLabel.AutoSize = true;
            DbOfExProjectPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DbOfExProjectPathLabel.Location = new System.Drawing.Point(30, 70);
            DbOfExProjectPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DbOfExProjectPathLabel.Name = "DbOfExProjectPathLabel";
            DbOfExProjectPathLabel.Size = new System.Drawing.Size(0, 24);
            DbOfExProjectPathLabel.TabIndex = 6;
            // 
            // OpenDbButton
            // 
            OpenDbButton.Location = new System.Drawing.Point(467, 65);
            OpenDbButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            OpenDbButton.Name = "OpenDbButton";
            OpenDbButton.Size = new System.Drawing.Size(99, 39);
            OpenDbButton.TabIndex = 7;
            OpenDbButton.Text = "Выбрать БД";
            OpenDbButton.UseVisualStyleBackColor = true;
            OpenDbButton.Click += OpenDbButton_Click;
            // 
            // openDbDialog
            // 
            openDbDialog.FileName = "openDbDialog";
            // 
            // SelectProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(579, 471);
            Controls.Add(OpenDbButton);
            Controls.Add(DbOfExProjectPathLabel);
            Controls.Add(SelectProjectOKbtn);
            Controls.Add(ExistingProjectLavel);
            Controls.Add(SelectProjectlistBox);
            Name = "SelectProject";
            Text = "SelectProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SelectProjectOKbtn;
        private System.Windows.Forms.Label ExistingProjectLavel;
        private System.Windows.Forms.ListBox SelectProjectlistBox;
        private System.Windows.Forms.Label DbOfExProjectPathLabel;
        private System.Windows.Forms.Button OpenDbButton;
        private System.Windows.Forms.OpenFileDialog openDbDialog;
    }
}