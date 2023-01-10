namespace My_Horse_Ferm.Personal
{
    partial class NewAddJobTitleDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAddJobTitleDB));
            this.NewAddJobTitle_JobTitleComboBox = new System.Windows.Forms.TextBox();
            this.NewAddJobTitle_NameLabel = new System.Windows.Forms.Label();
            this.NewAddJobTitle_OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAddJobTitle_JobTitleComboBox
            // 
            this.NewAddJobTitle_JobTitleComboBox.Location = new System.Drawing.Point(211, 66);
            this.NewAddJobTitle_JobTitleComboBox.Name = "NewAddJobTitle_JobTitleComboBox";
            this.NewAddJobTitle_JobTitleComboBox.Size = new System.Drawing.Size(345, 20);
            this.NewAddJobTitle_JobTitleComboBox.TabIndex = 8;
            // 
            // NewAddJobTitle_NameLabel
            // 
            this.NewAddJobTitle_NameLabel.AutoSize = true;
            this.NewAddJobTitle_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewAddJobTitle_NameLabel.Location = new System.Drawing.Point(60, 69);
            this.NewAddJobTitle_NameLabel.Name = "NewAddJobTitle_NameLabel";
            this.NewAddJobTitle_NameLabel.Size = new System.Drawing.Size(122, 20);
            this.NewAddJobTitle_NameLabel.TabIndex = 7;
            this.NewAddJobTitle_NameLabel.Text = "Наименование";
            // 
            // NewAddJobTitle_OKButton
            // 
            this.NewAddJobTitle_OKButton.Location = new System.Drawing.Point(452, 115);
            this.NewAddJobTitle_OKButton.Name = "NewAddJobTitle_OKButton";
            this.NewAddJobTitle_OKButton.Size = new System.Drawing.Size(104, 36);
            this.NewAddJobTitle_OKButton.TabIndex = 11;
            this.NewAddJobTitle_OKButton.Text = "ОК";
            this.NewAddJobTitle_OKButton.UseVisualStyleBackColor = true;
            this.NewAddJobTitle_OKButton.Click += new System.EventHandler(this.NewAddJobTitle_OKButton_Click);
            // 
            // NewAddJobTitleDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(583, 174);
            this.Controls.Add(this.NewAddJobTitle_OKButton);
            this.Controls.Add(this.NewAddJobTitle_JobTitleComboBox);
            this.Controls.Add(this.NewAddJobTitle_NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAddJobTitleDB";
            this.Text = "Добавление новых должностей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewAddJobTitle_JobTitleComboBox;
        private System.Windows.Forms.Label NewAddJobTitle_NameLabel;
        private System.Windows.Forms.Button NewAddJobTitle_OKButton;
    }
}