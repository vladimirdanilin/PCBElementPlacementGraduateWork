namespace ElementPlacement
{
    partial class NewPCB
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
            NewPCBTableInput = new System.Windows.Forms.TextBox();
            NewPCBTableLabel = new System.Windows.Forms.Label();
            AddNewPCBFormLabel = new System.Windows.Forms.Label();
            NewPCBDbPathLabel = new System.Windows.Forms.Label();
            PCBDbInputBtn = new System.Windows.Forms.Button();
            NewPCBBtn = new System.Windows.Forms.Button();
            NewPCBdblabel = new System.Windows.Forms.Label();
            NewPCBWidthInput = new System.Windows.Forms.TextBox();
            NewPCBLengthInput = new System.Windows.Forms.TextBox();
            NewPCBWidthLabel = new System.Windows.Forms.Label();
            NewPCBLengthLabel = new System.Windows.Forms.Label();
            NewPCBParametersLabel = new System.Windows.Forms.Label();
            NewPCBNameInput = new System.Windows.Forms.TextBox();
            NewPCBNameLabel = new System.Windows.Forms.Label();
            DbPcbFileDialog = new System.Windows.Forms.OpenFileDialog();
            NewPCBIDInput = new System.Windows.Forms.TextBox();
            NewPCBIDLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // NewPCBTableInput
            // 
            NewPCBTableInput.Location = new System.Drawing.Point(524, 264);
            NewPCBTableInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewPCBTableInput.Name = "NewPCBTableInput";
            NewPCBTableInput.Size = new System.Drawing.Size(389, 23);
            NewPCBTableInput.TabIndex = 36;
            NewPCBTableInput.TextChanged += NewPCBTableInput_TextChanged;
            // 
            // NewPCBTableLabel
            // 
            NewPCBTableLabel.AutoSize = true;
            NewPCBTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBTableLabel.Location = new System.Drawing.Point(40, 259);
            NewPCBTableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBTableLabel.Name = "NewPCBTableLabel";
            NewPCBTableLabel.Size = new System.Drawing.Size(259, 24);
            NewPCBTableLabel.TabIndex = 35;
            NewPCBTableLabel.Text = "Введите название таблицы";
            // 
            // AddNewPCBFormLabel
            // 
            AddNewPCBFormLabel.AutoSize = true;
            AddNewPCBFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddNewPCBFormLabel.Location = new System.Drawing.Point(321, 20);
            AddNewPCBFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddNewPCBFormLabel.Name = "AddNewPCBFormLabel";
            AddNewPCBFormLabel.Size = new System.Drawing.Size(330, 24);
            AddNewPCBFormLabel.TabIndex = 34;
            AddNewPCBFormLabel.Text = "Добавление новой печатной платы";
            // 
            // NewPCBDbPathLabel
            // 
            NewPCBDbPathLabel.AutoSize = true;
            NewPCBDbPathLabel.Location = new System.Drawing.Point(520, 201);
            NewPCBDbPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBDbPathLabel.Name = "NewPCBDbPathLabel";
            NewPCBDbPathLabel.Size = new System.Drawing.Size(0, 15);
            NewPCBDbPathLabel.TabIndex = 33;
            // 
            // PCBDbInputBtn
            // 
            PCBDbInputBtn.Location = new System.Drawing.Point(824, 179);
            PCBDbInputBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PCBDbInputBtn.Name = "PCBDbInputBtn";
            PCBDbInputBtn.Size = new System.Drawing.Size(90, 37);
            PCBDbInputBtn.TabIndex = 32;
            PCBDbInputBtn.Text = "Выбрать";
            PCBDbInputBtn.UseVisualStyleBackColor = true;
            PCBDbInputBtn.Click += PCBDbInputBtn_Click;
            // 
            // NewPCBBtn
            // 
            NewPCBBtn.Location = new System.Drawing.Point(848, 463);
            NewPCBBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewPCBBtn.Name = "NewPCBBtn";
            NewPCBBtn.Size = new System.Drawing.Size(112, 37);
            NewPCBBtn.TabIndex = 31;
            NewPCBBtn.Text = "OK";
            NewPCBBtn.UseVisualStyleBackColor = true;
            NewPCBBtn.Click += NewPCBBtn_Click;
            // 
            // NewPCBdblabel
            // 
            NewPCBdblabel.AutoSize = true;
            NewPCBdblabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBdblabel.Location = new System.Drawing.Point(40, 188);
            NewPCBdblabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBdblabel.Name = "NewPCBdblabel";
            NewPCBdblabel.Size = new System.Drawing.Size(319, 24);
            NewPCBdblabel.TabIndex = 30;
            NewPCBdblabel.Text = "Укажите, в какую БД добавить ПП";
            // 
            // NewPCBWidthInput
            // 
            NewPCBWidthInput.Location = new System.Drawing.Point(684, 429);
            NewPCBWidthInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewPCBWidthInput.Name = "NewPCBWidthInput";
            NewPCBWidthInput.Size = new System.Drawing.Size(135, 23);
            NewPCBWidthInput.TabIndex = 27;
            NewPCBWidthInput.TextChanged += NewPCBWidthInput_TextChanged;
            // 
            // NewPCBLengthInput
            // 
            NewPCBLengthInput.Location = new System.Drawing.Point(684, 366);
            NewPCBLengthInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewPCBLengthInput.Name = "NewPCBLengthInput";
            NewPCBLengthInput.Size = new System.Drawing.Size(135, 23);
            NewPCBLengthInput.TabIndex = 26;
            NewPCBLengthInput.TextChanged += NewPCBLengthInput_TextChanged;
            // 
            // NewPCBWidthLabel
            // 
            NewPCBWidthLabel.AutoSize = true;
            NewPCBWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBWidthLabel.Location = new System.Drawing.Point(194, 423);
            NewPCBWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBWidthLabel.Name = "NewPCBWidthLabel";
            NewPCBWidthLabel.Size = new System.Drawing.Size(121, 24);
            NewPCBWidthLabel.TabIndex = 23;
            NewPCBWidthLabel.Text = "Ширина (мм)";
            // 
            // NewPCBLengthLabel
            // 
            NewPCBLengthLabel.AutoSize = true;
            NewPCBLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBLengthLabel.Location = new System.Drawing.Point(194, 362);
            NewPCBLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBLengthLabel.Name = "NewPCBLengthLabel";
            NewPCBLengthLabel.Size = new System.Drawing.Size(109, 24);
            NewPCBLengthLabel.TabIndex = 22;
            NewPCBLengthLabel.Text = "Длина (мм)";
            // 
            // NewPCBParametersLabel
            // 
            NewPCBParametersLabel.AutoSize = true;
            NewPCBParametersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBParametersLabel.Location = new System.Drawing.Point(282, 306);
            NewPCBParametersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBParametersLabel.Name = "NewPCBParametersLabel";
            NewPCBParametersLabel.Size = new System.Drawing.Size(284, 24);
            NewPCBParametersLabel.TabIndex = 21;
            NewPCBParametersLabel.Text = "Введите параметры новой ПП";
            // 
            // NewPCBNameInput
            // 
            NewPCBNameInput.Location = new System.Drawing.Point(524, 125);
            NewPCBNameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewPCBNameInput.Name = "NewPCBNameInput";
            NewPCBNameInput.Size = new System.Drawing.Size(389, 23);
            NewPCBNameInput.TabIndex = 20;
            NewPCBNameInput.TextChanged += NewPCBNameInput_TextChanged;
            // 
            // NewPCBNameLabel
            // 
            NewPCBNameLabel.AutoSize = true;
            NewPCBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBNameLabel.Location = new System.Drawing.Point(40, 119);
            NewPCBNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBNameLabel.Name = "NewPCBNameLabel";
            NewPCBNameLabel.Size = new System.Drawing.Size(269, 24);
            NewPCBNameLabel.TabIndex = 19;
            NewPCBNameLabel.Text = "Введите название новой ПП";
            // 
            // DbPcbFileDialog
            // 
            DbPcbFileDialog.FileName = "DbPcbFileDialog";
            // 
            // NewPCBIDInput
            // 
            NewPCBIDInput.Location = new System.Drawing.Point(524, 72);
            NewPCBIDInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewPCBIDInput.Name = "NewPCBIDInput";
            NewPCBIDInput.Size = new System.Drawing.Size(389, 23);
            NewPCBIDInput.TabIndex = 38;
            NewPCBIDInput.TextChanged += NewPCBIDInput_TextChanged;
            // 
            // NewPCBIDLabel
            // 
            NewPCBIDLabel.AutoSize = true;
            NewPCBIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewPCBIDLabel.Location = new System.Drawing.Point(40, 66);
            NewPCBIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewPCBIDLabel.Name = "NewPCBIDLabel";
            NewPCBIDLabel.Size = new System.Drawing.Size(216, 24);
            NewPCBIDLabel.TabIndex = 37;
            NewPCBIDLabel.Text = "Введите код новой ПП";
            // 
            // NewPCB
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(974, 513);
            Controls.Add(NewPCBIDInput);
            Controls.Add(NewPCBIDLabel);
            Controls.Add(NewPCBTableInput);
            Controls.Add(NewPCBTableLabel);
            Controls.Add(AddNewPCBFormLabel);
            Controls.Add(NewPCBDbPathLabel);
            Controls.Add(PCBDbInputBtn);
            Controls.Add(NewPCBBtn);
            Controls.Add(NewPCBdblabel);
            Controls.Add(NewPCBWidthInput);
            Controls.Add(NewPCBLengthInput);
            Controls.Add(NewPCBWidthLabel);
            Controls.Add(NewPCBLengthLabel);
            Controls.Add(NewPCBParametersLabel);
            Controls.Add(NewPCBNameInput);
            Controls.Add(NewPCBNameLabel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "NewPCB";
            Text = "NewPCB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox NewPCBTableInput;
        private System.Windows.Forms.Label NewPCBTableLabel;
        private System.Windows.Forms.Label AddNewPCBFormLabel;
        private System.Windows.Forms.Label NewPCBDbPathLabel;
        private System.Windows.Forms.Button PCBDbInputBtn;
        private System.Windows.Forms.Button NewPCBBtn;
        private System.Windows.Forms.Label NewPCBdblabel;
        private System.Windows.Forms.TextBox NewPCBWidthInput;
        private System.Windows.Forms.TextBox NewPCBLengthInput;
        private System.Windows.Forms.Label NewPCBWidthLabel;
        private System.Windows.Forms.Label NewPCBLengthLabel;
        private System.Windows.Forms.Label NewPCBParametersLabel;
        private System.Windows.Forms.TextBox NewPCBNameInput;
        private System.Windows.Forms.Label NewPCBNameLabel;
        private System.Windows.Forms.OpenFileDialog DbPcbFileDialog;
        private System.Windows.Forms.TextBox NewPCBIDInput;
        private System.Windows.Forms.Label NewPCBIDLabel;
    }
}