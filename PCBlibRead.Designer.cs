namespace ElementPlacement
{
    partial class PCBlibRead
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
            PCBlibFormLabel = new System.Windows.Forms.Label();
            PCBlibFormOKbtn = new System.Windows.Forms.Button();
            NameOfCurrentElement = new System.Windows.Forms.Label();
            LengthOfCurrentElement = new System.Windows.Forms.Label();
            WidthOfCurrentElement = new System.Windows.Forms.Label();
            CurrentElementTLabel = new System.Windows.Forms.Label();
            CurrentElementHeightLabel = new System.Windows.Forms.Label();
            CurrentElementMarkingLabel = new System.Windows.Forms.Label();
            PCBlibElementNameTextBox = new System.Windows.Forms.TextBox();
            PCBlibElementTTextBox = new System.Windows.Forms.TextBox();
            PCBlibElementHeightTextBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // PCBlibFormLabel
            // 
            PCBlibFormLabel.AutoSize = true;
            PCBlibFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PCBlibFormLabel.Location = new System.Drawing.Point(76, 25);
            PCBlibFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PCBlibFormLabel.Name = "PCBlibFormLabel";
            PCBlibFormLabel.Size = new System.Drawing.Size(572, 24);
            PCBlibFormLabel.TabIndex = 2;
            PCBlibFormLabel.Text = "Внесите недостающую информацию о загружаемом элементе";
            // 
            // PCBlibFormOKbtn
            // 
            PCBlibFormOKbtn.Location = new System.Drawing.Point(596, 455);
            PCBlibFormOKbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PCBlibFormOKbtn.Name = "PCBlibFormOKbtn";
            PCBlibFormOKbtn.Size = new System.Drawing.Size(99, 39);
            PCBlibFormOKbtn.TabIndex = 9;
            PCBlibFormOKbtn.Text = "ОК";
            PCBlibFormOKbtn.UseVisualStyleBackColor = true;
            PCBlibFormOKbtn.Click += PCBlibFormOKbtn_Click;
            // 
            // NameOfCurrentElement
            // 
            NameOfCurrentElement.AutoSize = true;
            NameOfCurrentElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NameOfCurrentElement.Location = new System.Drawing.Point(42, 84);
            NameOfCurrentElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameOfCurrentElement.Name = "NameOfCurrentElement";
            NameOfCurrentElement.Size = new System.Drawing.Size(119, 24);
            NameOfCurrentElement.TabIndex = 10;
            NameOfCurrentElement.Text = "Маркировка";
            // 
            // LengthOfCurrentElement
            // 
            LengthOfCurrentElement.AutoSize = true;
            LengthOfCurrentElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LengthOfCurrentElement.Location = new System.Drawing.Point(42, 132);
            LengthOfCurrentElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LengthOfCurrentElement.Name = "LengthOfCurrentElement";
            LengthOfCurrentElement.Size = new System.Drawing.Size(66, 24);
            LengthOfCurrentElement.TabIndex = 11;
            LengthOfCurrentElement.Text = "Длина";
            // 
            // WidthOfCurrentElement
            // 
            WidthOfCurrentElement.AutoSize = true;
            WidthOfCurrentElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            WidthOfCurrentElement.Location = new System.Drawing.Point(42, 182);
            WidthOfCurrentElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            WidthOfCurrentElement.Name = "WidthOfCurrentElement";
            WidthOfCurrentElement.Size = new System.Drawing.Size(78, 24);
            WidthOfCurrentElement.TabIndex = 12;
            WidthOfCurrentElement.Text = "Ширина";
            // 
            // CurrentElementTLabel
            // 
            CurrentElementTLabel.AutoSize = true;
            CurrentElementTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CurrentElementTLabel.Location = new System.Drawing.Point(42, 367);
            CurrentElementTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CurrentElementTLabel.Name = "CurrentElementTLabel";
            CurrentElementTLabel.Size = new System.Drawing.Size(359, 24);
            CurrentElementTLabel.TabIndex = 15;
            CurrentElementTLabel.Text = "Максимальная температура элемента:";
            // 
            // CurrentElementHeightLabel
            // 
            CurrentElementHeightLabel.AutoSize = true;
            CurrentElementHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CurrentElementHeightLabel.Location = new System.Drawing.Point(42, 320);
            CurrentElementHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CurrentElementHeightLabel.Name = "CurrentElementHeightLabel";
            CurrentElementHeightLabel.Size = new System.Drawing.Size(172, 24);
            CurrentElementHeightLabel.TabIndex = 14;
            CurrentElementHeightLabel.Text = "Высота элемента:";
            // 
            // CurrentElementMarkingLabel
            // 
            CurrentElementMarkingLabel.AutoSize = true;
            CurrentElementMarkingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CurrentElementMarkingLabel.Location = new System.Drawing.Point(42, 271);
            CurrentElementMarkingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CurrentElementMarkingLabel.Name = "CurrentElementMarkingLabel";
            CurrentElementMarkingLabel.Size = new System.Drawing.Size(193, 24);
            CurrentElementMarkingLabel.TabIndex = 13;
            CurrentElementMarkingLabel.Text = "Название элемента:";
            // 
            // PCBlibElementNameTextBox
            // 
            PCBlibElementNameTextBox.Location = new System.Drawing.Point(498, 275);
            PCBlibElementNameTextBox.Name = "PCBlibElementNameTextBox";
            PCBlibElementNameTextBox.Size = new System.Drawing.Size(179, 23);
            PCBlibElementNameTextBox.TabIndex = 16;
            PCBlibElementNameTextBox.TextChanged += PCBlibElementMarkingTextBox_TextChanged;
            // 
            // PCBlibElementTTextBox
            // 
            PCBlibElementTTextBox.Location = new System.Drawing.Point(498, 371);
            PCBlibElementTTextBox.Name = "PCBlibElementTTextBox";
            PCBlibElementTTextBox.Size = new System.Drawing.Size(179, 23);
            PCBlibElementTTextBox.TabIndex = 17;
            PCBlibElementTTextBox.TextChanged += PCBlibElementTTextBox_TextChanged;
            // 
            // PCBlibElementHeightTextBox
            // 
            PCBlibElementHeightTextBox.Location = new System.Drawing.Point(498, 324);
            PCBlibElementHeightTextBox.Name = "PCBlibElementHeightTextBox";
            PCBlibElementHeightTextBox.Size = new System.Drawing.Size(179, 23);
            PCBlibElementHeightTextBox.TabIndex = 18;
            PCBlibElementHeightTextBox.TextChanged += PCBlibElementHeightTextBox_TextChanged;
            // 
            // PCBlibRead
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(708, 506);
            Controls.Add(PCBlibElementHeightTextBox);
            Controls.Add(PCBlibElementTTextBox);
            Controls.Add(PCBlibElementNameTextBox);
            Controls.Add(CurrentElementTLabel);
            Controls.Add(CurrentElementHeightLabel);
            Controls.Add(CurrentElementMarkingLabel);
            Controls.Add(WidthOfCurrentElement);
            Controls.Add(LengthOfCurrentElement);
            Controls.Add(NameOfCurrentElement);
            Controls.Add(PCBlibFormOKbtn);
            Controls.Add(PCBlibFormLabel);
            Name = "PCBlibRead";
            Text = "PCBlibRead";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PCBlibFormLabel;
        private System.Windows.Forms.Button PCBlibFormOKbtn;
        private System.Windows.Forms.Label NameOfCurrentElement;
        private System.Windows.Forms.Label LengthOfCurrentElement;
        private System.Windows.Forms.Label WidthOfCurrentElement;
        private System.Windows.Forms.Label CurrentElementTLabel;
        private System.Windows.Forms.Label CurrentElementHeightLabel;
        private System.Windows.Forms.Label CurrentElementMarkingLabel;
        private System.Windows.Forms.TextBox PCBlibElementNameTextBox;
        private System.Windows.Forms.TextBox PCBlibElementTTextBox;
        private System.Windows.Forms.TextBox PCBlibElementHeightTextBox;
    }
}