namespace ElementPlacement
{
    partial class NewDatabaseForm
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
            NewDatabaseNameLabel = new System.Windows.Forms.Label();
            NewDBNameInput = new System.Windows.Forms.TextBox();
            DatabasePathLabel = new System.Windows.Forms.Label();
            DBPathbtn = new System.Windows.Forms.Button();
            DBPathLabel = new System.Windows.Forms.Label();
            DBPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            DbDataSave = new System.Windows.Forms.Button();
            DatabaseFormLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // NewDatabaseNameLabel
            // 
            NewDatabaseNameLabel.AutoSize = true;
            NewDatabaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewDatabaseNameLabel.Location = new System.Drawing.Point(13, 199);
            NewDatabaseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewDatabaseNameLabel.Name = "NewDatabaseNameLabel";
            NewDatabaseNameLabel.Size = new System.Drawing.Size(484, 24);
            NewDatabaseNameLabel.TabIndex = 0;
            NewDatabaseNameLabel.Text = "Введите название файла создаваемой базы данных";
            // 
            // NewDBNameInput
            // 
            NewDBNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            NewDBNameInput.Location = new System.Drawing.Point(83, 248);
            NewDBNameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewDBNameInput.Name = "NewDBNameInput";
            NewDBNameInput.Size = new System.Drawing.Size(335, 23);
            NewDBNameInput.TabIndex = 1;
            NewDBNameInput.TextChanged += NewDBNameInput_TextChanged_1;
            // 
            // DatabasePathLabel
            // 
            DatabasePathLabel.AutoSize = true;
            DatabasePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DatabasePathLabel.Location = new System.Drawing.Point(13, 90);
            DatabasePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DatabasePathLabel.Name = "DatabasePathLabel";
            DatabasePathLabel.Size = new System.Drawing.Size(490, 24);
            DatabasePathLabel.TabIndex = 2;
            DatabasePathLabel.Text = "Укажите путь сохранения создаваемой базы данных";
            // 
            // DBPathbtn
            // 
            DBPathbtn.Location = new System.Drawing.Point(346, 135);
            DBPathbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DBPathbtn.Name = "DBPathbtn";
            DBPathbtn.Size = new System.Drawing.Size(156, 38);
            DBPathbtn.TabIndex = 4;
            DBPathbtn.Text = "Выбрать путь";
            DBPathbtn.UseVisualStyleBackColor = true;
            DBPathbtn.Click += DBPathbtn_Click;
            // 
            // DBPathLabel
            // 
            DBPathLabel.AutoSize = true;
            DBPathLabel.Location = new System.Drawing.Point(13, 147);
            DBPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DBPathLabel.Name = "DBPathLabel";
            DBPathLabel.Size = new System.Drawing.Size(0, 15);
            DBPathLabel.TabIndex = 5;
            // 
            // DbDataSave
            // 
            DbDataSave.Location = new System.Drawing.Point(377, 300);
            DbDataSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DbDataSave.Name = "DbDataSave";
            DbDataSave.Size = new System.Drawing.Size(120, 40);
            DbDataSave.TabIndex = 6;
            DbDataSave.Text = "OK";
            DbDataSave.UseVisualStyleBackColor = true;
            DbDataSave.Click += DbDataSave_Click;
            // 
            // DatabaseFormLabel
            // 
            DatabaseFormLabel.AutoSize = true;
            DatabaseFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DatabaseFormLabel.Location = new System.Drawing.Point(146, 23);
            DatabaseFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DatabaseFormLabel.Name = "DatabaseFormLabel";
            DatabaseFormLabel.Size = new System.Drawing.Size(220, 24);
            DatabaseFormLabel.TabIndex = 7;
            DatabaseFormLabel.Text = "Создание базы данных";
            // 
            // NewDatabaseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(515, 352);
            Controls.Add(DatabaseFormLabel);
            Controls.Add(DbDataSave);
            Controls.Add(DBPathLabel);
            Controls.Add(DBPathbtn);
            Controls.Add(DatabasePathLabel);
            Controls.Add(NewDBNameInput);
            Controls.Add(NewDatabaseNameLabel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "NewDatabaseForm";
            Text = "CreateDatabase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label NewDatabaseNameLabel;
        private System.Windows.Forms.TextBox NewDBNameInput;
        private System.Windows.Forms.Label DatabasePathLabel;
        private System.Windows.Forms.Button DBPathbtn;
        private System.Windows.Forms.Label DBPathLabel;
        private System.Windows.Forms.FolderBrowserDialog DBPathBrowserDialog;
        private System.Windows.Forms.Button DbDataSave;
        private System.Windows.Forms.Label DatabaseFormLabel;
    }
}