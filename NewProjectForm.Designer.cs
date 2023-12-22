namespace ElementPlacement
{
    partial class NewProjectForm
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
            ProjectFormLabel = new System.Windows.Forms.Label();
            NewProjectSave = new System.Windows.Forms.Button();
            DBPathProjectLabel = new System.Windows.Forms.Label();
            DBProjectPathbtn = new System.Windows.Forms.Button();
            DatabasePathLabel = new System.Windows.Forms.Label();
            NewProjectNameInput = new System.Windows.Forms.TextBox();
            NewProjectNameLabel = new System.Windows.Forms.Label();
            ProjectIdTextbox = new System.Windows.Forms.TextBox();
            ProjectIDlabel = new System.Windows.Forms.Label();
            ProjectDbFileDialog = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // ProjectFormLabel
            // 
            ProjectFormLabel.AutoSize = true;
            ProjectFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ProjectFormLabel.Location = new System.Drawing.Point(163, 26);
            ProjectFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ProjectFormLabel.Name = "ProjectFormLabel";
            ProjectFormLabel.Size = new System.Drawing.Size(177, 24);
            ProjectFormLabel.TabIndex = 14;
            ProjectFormLabel.Text = "Создание проекта";
            // 
            // NewProjectSave
            // 
            NewProjectSave.Location = new System.Drawing.Point(394, 332);
            NewProjectSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewProjectSave.Name = "NewProjectSave";
            NewProjectSave.Size = new System.Drawing.Size(120, 40);
            NewProjectSave.TabIndex = 13;
            NewProjectSave.Text = "OK";
            NewProjectSave.UseVisualStyleBackColor = true;
            NewProjectSave.Click += NewProjectSave_Click;
            // 
            // DBPathProjectLabel
            // 
            DBPathProjectLabel.AutoSize = true;
            DBPathProjectLabel.Location = new System.Drawing.Point(30, 127);
            DBPathProjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DBPathProjectLabel.Name = "DBPathProjectLabel";
            DBPathProjectLabel.Size = new System.Drawing.Size(0, 15);
            DBPathProjectLabel.TabIndex = 12;
            // 
            // DBProjectPathbtn
            // 
            DBProjectPathbtn.Location = new System.Drawing.Point(358, 115);
            DBProjectPathbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DBProjectPathbtn.Name = "DBProjectPathbtn";
            DBProjectPathbtn.Size = new System.Drawing.Size(156, 38);
            DBProjectPathbtn.TabIndex = 11;
            DBProjectPathbtn.Text = "Выбрать путь";
            DBProjectPathbtn.UseVisualStyleBackColor = true;
            DBProjectPathbtn.Click += DBProjectPathbtn_Click;
            // 
            // DatabasePathLabel
            // 
            DatabasePathLabel.AutoSize = true;
            DatabasePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DatabasePathLabel.Location = new System.Drawing.Point(89, 78);
            DatabasePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DatabasePathLabel.Name = "DatabasePathLabel";
            DatabasePathLabel.Size = new System.Drawing.Size(312, 24);
            DatabasePathLabel.TabIndex = 10;
            DatabasePathLabel.Text = "Укажите путь путь к базе данных";
            // 
            // NewProjectNameInput
            // 
            NewProjectNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            NewProjectNameInput.Location = new System.Drawing.Point(100, 285);
            NewProjectNameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewProjectNameInput.Name = "NewProjectNameInput";
            NewProjectNameInput.Size = new System.Drawing.Size(335, 23);
            NewProjectNameInput.TabIndex = 9;
            NewProjectNameInput.TextChanged += NewProjectNameInput_TextChanged;
            // 
            // NewProjectNameLabel
            // 
            NewProjectNameLabel.AutoSize = true;
            NewProjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewProjectNameLabel.Location = new System.Drawing.Point(145, 235);
            NewProjectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewProjectNameLabel.Name = "NewProjectNameLabel";
            NewProjectNameLabel.Size = new System.Drawing.Size(256, 24);
            NewProjectNameLabel.TabIndex = 8;
            NewProjectNameLabel.Text = "Введите название проекта";
            // 
            // ProjectIdTextbox
            // 
            ProjectIdTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ProjectIdTextbox.Location = new System.Drawing.Point(358, 185);
            ProjectIdTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ProjectIdTextbox.Name = "ProjectIdTextbox";
            ProjectIdTextbox.Size = new System.Drawing.Size(116, 23);
            ProjectIdTextbox.TabIndex = 16;
            ProjectIdTextbox.TextChanged += ProjectIdTextbox_TextChanged;
            // 
            // ProjectIDlabel
            // 
            ProjectIDlabel.AutoSize = true;
            ProjectIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ProjectIDlabel.Location = new System.Drawing.Point(41, 181);
            ProjectIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ProjectIDlabel.Name = "ProjectIDlabel";
            ProjectIDlabel.Size = new System.Drawing.Size(203, 24);
            ProjectIDlabel.TabIndex = 15;
            ProjectIDlabel.Text = "Введите код проекта";
            // 
            // ProjectDbFileDialog
            // 
            ProjectDbFileDialog.FileName = "ProjectDbFileDialog";
            // 
            // NewProjectForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(531, 390);
            Controls.Add(ProjectIdTextbox);
            Controls.Add(ProjectIDlabel);
            Controls.Add(ProjectFormLabel);
            Controls.Add(NewProjectSave);
            Controls.Add(DBPathProjectLabel);
            Controls.Add(DBProjectPathbtn);
            Controls.Add(DatabasePathLabel);
            Controls.Add(NewProjectNameInput);
            Controls.Add(NewProjectNameLabel);
            Name = "NewProjectForm";
            Text = "NewProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ProjectFormLabel;
        private System.Windows.Forms.Button NewProjectSave;
        private System.Windows.Forms.Label DBPathProjectLabel;
        private System.Windows.Forms.Button DBProjectPathbtn;
        private System.Windows.Forms.Label DatabasePathLabel;
        private System.Windows.Forms.TextBox NewProjectNameInput;
        private System.Windows.Forms.Label NewProjectNameLabel;
        private System.Windows.Forms.TextBox ProjectIdTextbox;
        private System.Windows.Forms.Label ProjectIDlabel;
        private System.Windows.Forms.OpenFileDialog ProjectDbFileDialog;
    }
}