namespace ElementPlacement
{
    partial class NewElement
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
            NewElementNameLabel = new System.Windows.Forms.Label();
            NewElementNameInput = new System.Windows.Forms.TextBox();
            NewElementParametersLabel = new System.Windows.Forms.Label();
            NewElementLengthLabel = new System.Windows.Forms.Label();
            NewElementWidthLabel = new System.Windows.Forms.Label();
            NewElementThicknessLabel = new System.Windows.Forms.Label();
            NewElementTempLabel = new System.Windows.Forms.Label();
            NewElementLengthInput = new System.Windows.Forms.TextBox();
            NewElementWidthInput = new System.Windows.Forms.TextBox();
            NewElementHeightInput = new System.Windows.Forms.TextBox();
            NewElementTempInput = new System.Windows.Forms.TextBox();
            NewElementBtn = new System.Windows.Forms.Button();
            AddNewElementFormLabel = new System.Windows.Forms.Label();
            NewElementMarkInput = new System.Windows.Forms.TextBox();
            NewElementMarkLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // NewElementNameLabel
            // 
            NewElementNameLabel.AutoSize = true;
            NewElementNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementNameLabel.Location = new System.Drawing.Point(23, 143);
            NewElementNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementNameLabel.Name = "NewElementNameLabel";
            NewElementNameLabel.Size = new System.Drawing.Size(338, 24);
            NewElementNameLabel.TabIndex = 0;
            NewElementNameLabel.Text = "Введите название нового элемента";
            // 
            // NewElementNameInput
            // 
            NewElementNameInput.Location = new System.Drawing.Point(507, 149);
            NewElementNameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementNameInput.Name = "NewElementNameInput";
            NewElementNameInput.Size = new System.Drawing.Size(389, 23);
            NewElementNameInput.TabIndex = 1;
            NewElementNameInput.TextChanged += NewElementNameInput_TextChanged;
            // 
            // NewElementParametersLabel
            // 
            NewElementParametersLabel.AutoSize = true;
            NewElementParametersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementParametersLabel.Location = new System.Drawing.Point(257, 199);
            NewElementParametersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementParametersLabel.Name = "NewElementParametersLabel";
            NewElementParametersLabel.Size = new System.Drawing.Size(353, 24);
            NewElementParametersLabel.TabIndex = 2;
            NewElementParametersLabel.Text = "Введите параметры нового элемента";
            // 
            // NewElementLengthLabel
            // 
            NewElementLengthLabel.AutoSize = true;
            NewElementLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementLengthLabel.Location = new System.Drawing.Point(169, 254);
            NewElementLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementLengthLabel.Name = "NewElementLengthLabel";
            NewElementLengthLabel.Size = new System.Drawing.Size(109, 24);
            NewElementLengthLabel.TabIndex = 3;
            NewElementLengthLabel.Text = "Длина (мм)";
            // 
            // NewElementWidthLabel
            // 
            NewElementWidthLabel.AutoSize = true;
            NewElementWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementWidthLabel.Location = new System.Drawing.Point(169, 315);
            NewElementWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementWidthLabel.Name = "NewElementWidthLabel";
            NewElementWidthLabel.Size = new System.Drawing.Size(121, 24);
            NewElementWidthLabel.TabIndex = 4;
            NewElementWidthLabel.Text = "Ширина (мм)";
            // 
            // NewElementThicknessLabel
            // 
            NewElementThicknessLabel.AutoSize = true;
            NewElementThicknessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementThicknessLabel.Location = new System.Drawing.Point(169, 379);
            NewElementThicknessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementThicknessLabel.Name = "NewElementThicknessLabel";
            NewElementThicknessLabel.Size = new System.Drawing.Size(119, 24);
            NewElementThicknessLabel.TabIndex = 5;
            NewElementThicknessLabel.Text = "Высота (мм)";
            // 
            // NewElementTempLabel
            // 
            NewElementTempLabel.AutoSize = true;
            NewElementTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementTempLabel.Location = new System.Drawing.Point(169, 439);
            NewElementTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementTempLabel.Name = "NewElementTempLabel";
            NewElementTempLabel.Size = new System.Drawing.Size(346, 48);
            NewElementTempLabel.TabIndex = 6;
            NewElementTempLabel.Text = "Максимальная температура нагрева \r\n(градусов по Цельсию)";
            // 
            // NewElementLengthInput
            // 
            NewElementLengthInput.Location = new System.Drawing.Point(659, 259);
            NewElementLengthInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementLengthInput.Name = "NewElementLengthInput";
            NewElementLengthInput.Size = new System.Drawing.Size(135, 23);
            NewElementLengthInput.TabIndex = 7;
            NewElementLengthInput.TextChanged += NewElementLengthInput_TextChanged;
            // 
            // NewElementWidthInput
            // 
            NewElementWidthInput.Location = new System.Drawing.Point(659, 321);
            NewElementWidthInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementWidthInput.Name = "NewElementWidthInput";
            NewElementWidthInput.Size = new System.Drawing.Size(135, 23);
            NewElementWidthInput.TabIndex = 8;
            NewElementWidthInput.TextChanged += NewElementWidthInput_TextChanged;
            // 
            // NewElementHeightInput
            // 
            NewElementHeightInput.Location = new System.Drawing.Point(659, 384);
            NewElementHeightInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementHeightInput.Name = "NewElementHeightInput";
            NewElementHeightInput.Size = new System.Drawing.Size(135, 23);
            NewElementHeightInput.TabIndex = 9;
            NewElementHeightInput.TextChanged += NewElementHeightInput_TextChanged;
            // 
            // NewElementTempInput
            // 
            NewElementTempInput.Location = new System.Drawing.Point(659, 444);
            NewElementTempInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementTempInput.Name = "NewElementTempInput";
            NewElementTempInput.Size = new System.Drawing.Size(135, 23);
            NewElementTempInput.TabIndex = 10;
            NewElementTempInput.TextChanged += NewElementTempInput_TextChanged;
            // 
            // NewElementBtn
            // 
            NewElementBtn.Location = new System.Drawing.Point(827, 486);
            NewElementBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementBtn.Name = "NewElementBtn";
            NewElementBtn.Size = new System.Drawing.Size(112, 37);
            NewElementBtn.TabIndex = 13;
            NewElementBtn.Text = "OK";
            NewElementBtn.UseVisualStyleBackColor = true;
            NewElementBtn.Click += NewElementBtn_Click;
            // 
            // AddNewElementFormLabel
            // 
            AddNewElementFormLabel.AutoSize = true;
            AddNewElementFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddNewElementFormLabel.Location = new System.Drawing.Point(304, 29);
            AddNewElementFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddNewElementFormLabel.Name = "AddNewElementFormLabel";
            AddNewElementFormLabel.Size = new System.Drawing.Size(281, 24);
            AddNewElementFormLabel.TabIndex = 16;
            AddNewElementFormLabel.Text = "Добавление нового элемента";
            // 
            // NewElementMarkInput
            // 
            NewElementMarkInput.Location = new System.Drawing.Point(507, 97);
            NewElementMarkInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewElementMarkInput.Name = "NewElementMarkInput";
            NewElementMarkInput.Size = new System.Drawing.Size(389, 23);
            NewElementMarkInput.TabIndex = 20;
            NewElementMarkInput.TextChanged += NewElementMarkInput_TextChanged;
            // 
            // NewElementMarkLabel
            // 
            NewElementMarkLabel.AutoSize = true;
            NewElementMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewElementMarkLabel.Location = new System.Drawing.Point(23, 91);
            NewElementMarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewElementMarkLabel.Name = "NewElementMarkLabel";
            NewElementMarkLabel.Size = new System.Drawing.Size(358, 24);
            NewElementMarkLabel.TabIndex = 19;
            NewElementMarkLabel.Text = "Введите маркировку нового элемента";
            // 
            // NewElement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(961, 544);
            Controls.Add(NewElementMarkInput);
            Controls.Add(NewElementMarkLabel);
            Controls.Add(AddNewElementFormLabel);
            Controls.Add(NewElementBtn);
            Controls.Add(NewElementTempInput);
            Controls.Add(NewElementHeightInput);
            Controls.Add(NewElementWidthInput);
            Controls.Add(NewElementLengthInput);
            Controls.Add(NewElementTempLabel);
            Controls.Add(NewElementThicknessLabel);
            Controls.Add(NewElementWidthLabel);
            Controls.Add(NewElementLengthLabel);
            Controls.Add(NewElementParametersLabel);
            Controls.Add(NewElementNameInput);
            Controls.Add(NewElementNameLabel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "NewElement";
            Text = "NewElement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label NewElementNameLabel;
        private System.Windows.Forms.TextBox NewElementNameInput;
        private System.Windows.Forms.Label NewElementParametersLabel;
        private System.Windows.Forms.Label NewElementLengthLabel;
        private System.Windows.Forms.Label NewElementWidthLabel;
        private System.Windows.Forms.Label NewElementThicknessLabel;
        private System.Windows.Forms.Label NewElementTempLabel;
        private System.Windows.Forms.TextBox NewElementLengthInput;
        private System.Windows.Forms.TextBox NewElementWidthInput;
        private System.Windows.Forms.TextBox NewElementHeightInput;
        private System.Windows.Forms.TextBox NewElementTempInput;
        private System.Windows.Forms.Button NewElementBtn;
        private System.Windows.Forms.Label AddNewElementFormLabel;
        private System.Windows.Forms.TextBox NewElementMarkInput;
        private System.Windows.Forms.Label NewElementMarkLabel;
    }
}