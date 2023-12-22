namespace ElementPlacement
{
    partial class ChooseCriterion
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
            ChooseCriterionOkBtn = new System.Windows.Forms.Button();
            ChooseCriterionFormLabel = new System.Windows.Forms.Label();
            WarmthradioButton = new System.Windows.Forms.RadioButton();
            LengthradioButton = new System.Windows.Forms.RadioButton();
            BothCriteriaradioButton = new System.Windows.Forms.RadioButton();
            kforcriterionlabel = new System.Windows.Forms.Label();
            criterionFormulaLabel = new System.Windows.Forms.Label();
            criterionw1label = new System.Windows.Forms.Label();
            criterionw2label = new System.Windows.Forms.Label();
            w1TextBox = new System.Windows.Forms.TextBox();
            w2TextBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // ChooseCriterionOkBtn
            // 
            ChooseCriterionOkBtn.Location = new System.Drawing.Point(670, 425);
            ChooseCriterionOkBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChooseCriterionOkBtn.Name = "ChooseCriterionOkBtn";
            ChooseCriterionOkBtn.Size = new System.Drawing.Size(99, 39);
            ChooseCriterionOkBtn.TabIndex = 12;
            ChooseCriterionOkBtn.Text = "ОК";
            ChooseCriterionOkBtn.UseVisualStyleBackColor = true;
            ChooseCriterionOkBtn.Click += ChooseCriterionOkBtn_Click;
            // 
            // ChooseCriterionFormLabel
            // 
            ChooseCriterionFormLabel.AutoSize = true;
            ChooseCriterionFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ChooseCriterionFormLabel.Location = new System.Drawing.Point(165, 30);
            ChooseCriterionFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ChooseCriterionFormLabel.Name = "ChooseCriterionFormLabel";
            ChooseCriterionFormLabel.Size = new System.Drawing.Size(429, 24);
            ChooseCriterionFormLabel.TabIndex = 11;
            ChooseCriterionFormLabel.Text = "Выберите критерий расчета целевой функции";
            ChooseCriterionFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WarmthradioButton
            // 
            WarmthradioButton.AutoSize = true;
            WarmthradioButton.Location = new System.Drawing.Point(87, 98);
            WarmthradioButton.Name = "WarmthradioButton";
            WarmthradioButton.Size = new System.Drawing.Size(133, 19);
            WarmthradioButton.TabIndex = 13;
            WarmthradioButton.TabStop = true;
            WarmthradioButton.Text = "Тепловой критерий";
            WarmthradioButton.UseVisualStyleBackColor = true;
            WarmthradioButton.CheckedChanged += WarmthradioButton_CheckedChanged;
            // 
            // LengthradioButton
            // 
            LengthradioButton.AutoSize = true;
            LengthradioButton.Location = new System.Drawing.Point(87, 136);
            LengthradioButton.Name = "LengthradioButton";
            LengthradioButton.Size = new System.Drawing.Size(215, 19);
            LengthradioButton.TabIndex = 14;
            LengthradioButton.TabStop = true;
            LengthradioButton.Text = "Длина межсоединений элементов";
            LengthradioButton.UseVisualStyleBackColor = true;
            LengthradioButton.CheckedChanged += LengthradioButton_CheckedChanged;
            // 
            // BothCriteriaradioButton
            // 
            BothCriteriaradioButton.AutoSize = true;
            BothCriteriaradioButton.Location = new System.Drawing.Point(87, 173);
            BothCriteriaradioButton.Name = "BothCriteriaradioButton";
            BothCriteriaradioButton.Size = new System.Drawing.Size(101, 19);
            BothCriteriaradioButton.TabIndex = 15;
            BothCriteriaradioButton.TabStop = true;
            BothCriteriaradioButton.Text = "Оба критерия";
            BothCriteriaradioButton.UseVisualStyleBackColor = true;
            BothCriteriaradioButton.CheckedChanged += BothCriteriaradioButton_CheckedChanged;
            // 
            // kforcriterionlabel
            // 
            kforcriterionlabel.AutoSize = true;
            kforcriterionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kforcriterionlabel.Location = new System.Drawing.Point(87, 210);
            kforcriterionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kforcriterionlabel.Name = "kforcriterionlabel";
            kforcriterionlabel.Size = new System.Drawing.Size(479, 24);
            kforcriterionlabel.TabIndex = 16;
            kforcriterionlabel.Text = "Укажите весовые коэффициенты [0;1] для формулы:";
            kforcriterionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criterionFormulaLabel
            // 
            criterionFormulaLabel.AutoSize = true;
            criterionFormulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            criterionFormulaLabel.Location = new System.Drawing.Point(574, 210);
            criterionFormulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            criterionFormulaLabel.Name = "criterionFormulaLabel";
            criterionFormulaLabel.Size = new System.Drawing.Size(177, 24);
            criterionFormulaLabel.TabIndex = 17;
            criterionFormulaLabel.Text = "F = w1 x Q + w2 x L";
            criterionFormulaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criterionw1label
            // 
            criterionw1label.AutoSize = true;
            criterionw1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            criterionw1label.Location = new System.Drawing.Point(87, 263);
            criterionw1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            criterionw1label.Name = "criterionw1label";
            criterionw1label.Size = new System.Drawing.Size(55, 24);
            criterionw1label.TabIndex = 18;
            criterionw1label.Text = "w1 = ";
            criterionw1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criterionw2label
            // 
            criterionw2label.AutoSize = true;
            criterionw2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            criterionw2label.Location = new System.Drawing.Point(87, 317);
            criterionw2label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            criterionw2label.Name = "criterionw2label";
            criterionw2label.Size = new System.Drawing.Size(50, 24);
            criterionw2label.TabIndex = 19;
            criterionw2label.Text = "w2 =";
            criterionw2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // w1TextBox
            // 
            w1TextBox.Location = new System.Drawing.Point(149, 263);
            w1TextBox.Name = "w1TextBox";
            w1TextBox.Size = new System.Drawing.Size(100, 23);
            w1TextBox.TabIndex = 20;
            w1TextBox.TextChanged += w1TextBox_TextChanged;
            // 
            // w2TextBox
            // 
            w2TextBox.Location = new System.Drawing.Point(149, 321);
            w2TextBox.Name = "w2TextBox";
            w2TextBox.Size = new System.Drawing.Size(100, 23);
            w2TextBox.TabIndex = 21;
            w2TextBox.TextChanged += w2TextBox_TextChanged;
            // 
            // ChooseCriterion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 476);
            Controls.Add(w2TextBox);
            Controls.Add(w1TextBox);
            Controls.Add(criterionw2label);
            Controls.Add(criterionw1label);
            Controls.Add(criterionFormulaLabel);
            Controls.Add(kforcriterionlabel);
            Controls.Add(BothCriteriaradioButton);
            Controls.Add(LengthradioButton);
            Controls.Add(WarmthradioButton);
            Controls.Add(ChooseCriterionOkBtn);
            Controls.Add(ChooseCriterionFormLabel);
            Name = "ChooseCriterion";
            Text = "ChooseCriterion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ChooseCriterionOkBtn;
        private System.Windows.Forms.Label ChooseCriterionFormLabel;
        private System.Windows.Forms.RadioButton WarmthradioButton;
        private System.Windows.Forms.RadioButton LengthradioButton;
        private System.Windows.Forms.RadioButton BothCriteriaradioButton;
        private System.Windows.Forms.Label kforcriterionlabel;
        private System.Windows.Forms.Label criterionFormulaLabel;
        private System.Windows.Forms.Label criterionw1label;
        private System.Windows.Forms.Label criterionw2label;
        private System.Windows.Forms.TextBox w1TextBox;
        private System.Windows.Forms.TextBox w2TextBox;
    }
}