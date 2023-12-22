namespace ElementPlacement
{
    partial class GAForm
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
            this.GAFormNameLabel = new System.Windows.Forms.Label();
            this.NumOfSpeciesLabel = new System.Windows.Forms.Label();
            this.MutationLabel = new System.Windows.Forms.Label();
            this.FitnessStagnationLabel = new System.Windows.Forms.Label();
            this.NumOfSpeciesTextbox = new System.Windows.Forms.TextBox();
            this.MutationTextbox = new System.Windows.Forms.TextBox();
            this.FitnessStTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GAFormNameLabel
            // 
            this.GAFormNameLabel.AutoSize = true;
            this.GAFormNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GAFormNameLabel.Location = new System.Drawing.Point(89, 35);
            this.GAFormNameLabel.Name = "GAFormNameLabel";
            this.GAFormNameLabel.Size = new System.Drawing.Size(503, 24);
            this.GAFormNameLabel.TabIndex = 0;
            this.GAFormNameLabel.Text = "Введите параметры работы генетического алгоритма";
            // 
            // NumOfSpeciesLabel
            // 
            this.NumOfSpeciesLabel.AutoSize = true;
            this.NumOfSpeciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfSpeciesLabel.Location = new System.Drawing.Point(16, 101);
            this.NumOfSpeciesLabel.Name = "NumOfSpeciesLabel";
            this.NumOfSpeciesLabel.Size = new System.Drawing.Size(257, 24);
            this.NumOfSpeciesLabel.TabIndex = 1;
            this.NumOfSpeciesLabel.Text = "Кол-во особей в популяции";
            // 
            // MutationLabel
            // 
            this.MutationLabel.AutoSize = true;
            this.MutationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutationLabel.Location = new System.Drawing.Point(16, 164);
            this.MutationLabel.Name = "MutationLabel";
            this.MutationLabel.Size = new System.Drawing.Size(105, 24);
            this.MutationLabel.TabIndex = 2;
            this.MutationLabel.Text = "% мутации";
            // 
            // FitnessStagnationLabel
            // 
            this.FitnessStagnationLabel.AutoSize = true;
            this.FitnessStagnationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FitnessStagnationLabel.Location = new System.Drawing.Point(16, 229);
            this.FitnessStagnationLabel.Name = "FitnessStagnationLabel";
            this.FitnessStagnationLabel.Size = new System.Drawing.Size(502, 48);
            this.FitnessStagnationLabel.TabIndex = 3;
            this.FitnessStagnationLabel.Text = "Кол-во поколений, на протяжении которого значение \r\nфункции пригодности остается " +
    "неизменным";
            // 
            // NumOfSpeciesTextbox
            // 
            this.NumOfSpeciesTextbox.Location = new System.Drawing.Point(557, 105);
            this.NumOfSpeciesTextbox.Name = "NumOfSpeciesTextbox";
            this.NumOfSpeciesTextbox.Size = new System.Drawing.Size(100, 20);
            this.NumOfSpeciesTextbox.TabIndex = 4;
            this.NumOfSpeciesTextbox.TextChanged += new System.EventHandler(this.NumOfSpeciesTextbox_TextChanged);
            // 
            // MutationTextbox
            // 
            this.MutationTextbox.Location = new System.Drawing.Point(557, 169);
            this.MutationTextbox.Name = "MutationTextbox";
            this.MutationTextbox.Size = new System.Drawing.Size(100, 20);
            this.MutationTextbox.TabIndex = 5;
            this.MutationTextbox.TextChanged += new System.EventHandler(this.MutationTextbox_TextChanged);
            // 
            // FitnessStTextbox
            // 
            this.FitnessStTextbox.Location = new System.Drawing.Point(557, 257);
            this.FitnessStTextbox.Name = "FitnessStTextbox";
            this.FitnessStTextbox.Size = new System.Drawing.Size(100, 20);
            this.FitnessStTextbox.TabIndex = 6;
            this.FitnessStTextbox.TextChanged += new System.EventHandler(this.FitnessStTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FitnessStTextbox);
            this.Controls.Add(this.MutationTextbox);
            this.Controls.Add(this.NumOfSpeciesTextbox);
            this.Controls.Add(this.FitnessStagnationLabel);
            this.Controls.Add(this.MutationLabel);
            this.Controls.Add(this.NumOfSpeciesLabel);
            this.Controls.Add(this.GAFormNameLabel);
            this.Name = "GAForm";
            this.Text = "GAForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GAFormNameLabel;
        private System.Windows.Forms.Label NumOfSpeciesLabel;
        private System.Windows.Forms.Label MutationLabel;
        private System.Windows.Forms.Label FitnessStagnationLabel;
        private System.Windows.Forms.TextBox NumOfSpeciesTextbox;
        private System.Windows.Forms.TextBox MutationTextbox;
        private System.Windows.Forms.TextBox FitnessStTextbox;
        private System.Windows.Forms.Button button1;
    }
}