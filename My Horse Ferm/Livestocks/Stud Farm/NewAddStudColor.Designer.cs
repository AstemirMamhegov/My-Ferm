namespace My_Horse_Ferm.Livestocks.Stud_Farm
{
    partial class NewAddStudColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAddStudColor));
            this.NewAddStudColor_OKButton = new System.Windows.Forms.Button();
            this.NewAddStudColor_StudColorComboBox = new System.Windows.Forms.TextBox();
            this.NewAddStudColor_NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewAddStudColor_OKButton
            // 
            this.NewAddStudColor_OKButton.Location = new System.Drawing.Point(429, 97);
            this.NewAddStudColor_OKButton.Name = "NewAddStudColor_OKButton";
            this.NewAddStudColor_OKButton.Size = new System.Drawing.Size(104, 36);
            this.NewAddStudColor_OKButton.TabIndex = 17;
            this.NewAddStudColor_OKButton.Text = "ОК";
            this.NewAddStudColor_OKButton.UseVisualStyleBackColor = true;
            this.NewAddStudColor_OKButton.Click += new System.EventHandler(this.NewAddStudColor_OKButton_Click);
            // 
            // NewAddStudColor_StudColorComboBox
            // 
            this.NewAddStudColor_StudColorComboBox.Location = new System.Drawing.Point(188, 48);
            this.NewAddStudColor_StudColorComboBox.Name = "NewAddStudColor_StudColorComboBox";
            this.NewAddStudColor_StudColorComboBox.Size = new System.Drawing.Size(345, 20);
            this.NewAddStudColor_StudColorComboBox.TabIndex = 16;
            // 
            // NewAddStudColor_NameLabel
            // 
            this.NewAddStudColor_NameLabel.AutoSize = true;
            this.NewAddStudColor_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewAddStudColor_NameLabel.Location = new System.Drawing.Point(37, 51);
            this.NewAddStudColor_NameLabel.Name = "NewAddStudColor_NameLabel";
            this.NewAddStudColor_NameLabel.Size = new System.Drawing.Size(122, 20);
            this.NewAddStudColor_NameLabel.TabIndex = 15;
            this.NewAddStudColor_NameLabel.Text = "Наименование";
            // 
            // NewAddStudColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(579, 172);
            this.Controls.Add(this.NewAddStudColor_OKButton);
            this.Controls.Add(this.NewAddStudColor_StudColorComboBox);
            this.Controls.Add(this.NewAddStudColor_NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAddStudColor";
            this.Text = "Добавление нового окраса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAddStudColor_OKButton;
        private System.Windows.Forms.TextBox NewAddStudColor_StudColorComboBox;
        private System.Windows.Forms.Label NewAddStudColor_NameLabel;
    }
}