namespace My_Horse_Ferm.Livestocks.Cow_Farm
{
    partial class NewCowBreedDBFarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCowBreedDBFarm));
            this.NewAddCowBreed_OKButton = new System.Windows.Forms.Button();
            this.NewAddCowBreed_CowBreedComboBox = new System.Windows.Forms.TextBox();
            this.NewAddCowBreed_NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewAddCowBreed_OKButton
            // 
            this.NewAddCowBreed_OKButton.Location = new System.Drawing.Point(451, 113);
            this.NewAddCowBreed_OKButton.Name = "NewAddCowBreed_OKButton";
            this.NewAddCowBreed_OKButton.Size = new System.Drawing.Size(104, 36);
            this.NewAddCowBreed_OKButton.TabIndex = 17;
            this.NewAddCowBreed_OKButton.Text = "ОК";
            this.NewAddCowBreed_OKButton.UseVisualStyleBackColor = true;
            this.NewAddCowBreed_OKButton.Click += new System.EventHandler(this.NewAddCowBreed_OKButton_Click);
            // 
            // NewAddCowBreed_CowBreedComboBox
            // 
            this.NewAddCowBreed_CowBreedComboBox.Location = new System.Drawing.Point(210, 64);
            this.NewAddCowBreed_CowBreedComboBox.Name = "NewAddCowBreed_CowBreedComboBox";
            this.NewAddCowBreed_CowBreedComboBox.Size = new System.Drawing.Size(345, 20);
            this.NewAddCowBreed_CowBreedComboBox.TabIndex = 16;
            // 
            // NewAddCowBreed_NameLabel
            // 
            this.NewAddCowBreed_NameLabel.AutoSize = true;
            this.NewAddCowBreed_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewAddCowBreed_NameLabel.Location = new System.Drawing.Point(59, 67);
            this.NewAddCowBreed_NameLabel.Name = "NewAddCowBreed_NameLabel";
            this.NewAddCowBreed_NameLabel.Size = new System.Drawing.Size(122, 20);
            this.NewAddCowBreed_NameLabel.TabIndex = 15;
            this.NewAddCowBreed_NameLabel.Text = "Наименование";
            // 
            // NewCowBreedDBFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(630, 213);
            this.Controls.Add(this.NewAddCowBreed_OKButton);
            this.Controls.Add(this.NewAddCowBreed_CowBreedComboBox);
            this.Controls.Add(this.NewAddCowBreed_NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewCowBreedDBFarm";
            this.Text = "Добавление новой породы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAddCowBreed_OKButton;
        private System.Windows.Forms.TextBox NewAddCowBreed_CowBreedComboBox;
        private System.Windows.Forms.Label NewAddCowBreed_NameLabel;
    }
}