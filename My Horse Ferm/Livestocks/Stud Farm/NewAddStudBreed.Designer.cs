namespace My_Horse_Ferm.Livestocks.Stud_Farm
{
    partial class NewAddStudBreed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAddStudBreed));
            this.NewAddStudBreed_OKButton = new System.Windows.Forms.Button();
            this.NewAddStudBreed_StudBreedComboBox = new System.Windows.Forms.TextBox();
            this.NewAddStudBreed_NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewAddStudBreed_OKButton
            // 
            this.NewAddStudBreed_OKButton.Location = new System.Drawing.Point(441, 99);
            this.NewAddStudBreed_OKButton.Name = "NewAddStudBreed_OKButton";
            this.NewAddStudBreed_OKButton.Size = new System.Drawing.Size(104, 36);
            this.NewAddStudBreed_OKButton.TabIndex = 14;
            this.NewAddStudBreed_OKButton.Text = "ОК";
            this.NewAddStudBreed_OKButton.UseVisualStyleBackColor = true;
            this.NewAddStudBreed_OKButton.Click += new System.EventHandler(this.NewAddStudBreed_OKButton_Click);
            // 
            // NewAddStudBreed_StudBreedComboBox
            // 
            this.NewAddStudBreed_StudBreedComboBox.Location = new System.Drawing.Point(200, 50);
            this.NewAddStudBreed_StudBreedComboBox.Name = "NewAddStudBreed_StudBreedComboBox";
            this.NewAddStudBreed_StudBreedComboBox.Size = new System.Drawing.Size(345, 20);
            this.NewAddStudBreed_StudBreedComboBox.TabIndex = 13;
            // 
            // NewAddStudBreed_NameLabel
            // 
            this.NewAddStudBreed_NameLabel.AutoSize = true;
            this.NewAddStudBreed_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewAddStudBreed_NameLabel.Location = new System.Drawing.Point(49, 53);
            this.NewAddStudBreed_NameLabel.Name = "NewAddStudBreed_NameLabel";
            this.NewAddStudBreed_NameLabel.Size = new System.Drawing.Size(122, 20);
            this.NewAddStudBreed_NameLabel.TabIndex = 12;
            this.NewAddStudBreed_NameLabel.Text = "Наименование";
            // 
            // NewAddStudBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(587, 203);
            this.Controls.Add(this.NewAddStudBreed_OKButton);
            this.Controls.Add(this.NewAddStudBreed_StudBreedComboBox);
            this.Controls.Add(this.NewAddStudBreed_NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAddStudBreed";
            this.Text = "Добавление новой породы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAddStudBreed_OKButton;
        private System.Windows.Forms.TextBox NewAddStudBreed_StudBreedComboBox;
        private System.Windows.Forms.Label NewAddStudBreed_NameLabel;
    }
}