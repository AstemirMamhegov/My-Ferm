namespace My_Horse_Ferm.Personal
{
    partial class PersonalDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalDB));
            this.Personal_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.Personal_BackButton = new System.Windows.Forms.Button();
            this.Personal_EditDataBaseButton = new System.Windows.Forms.Button();
            this.Personal_ViewDataBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Personal_ActionChoiseLabel
            // 
            this.Personal_ActionChoiseLabel.AutoSize = true;
            this.Personal_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal_ActionChoiseLabel.Location = new System.Drawing.Point(14, 13);
            this.Personal_ActionChoiseLabel.Name = "Personal_ActionChoiseLabel";
            this.Personal_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.Personal_ActionChoiseLabel.TabIndex = 26;
            this.Personal_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // Personal_BackButton
            // 
            this.Personal_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal_BackButton.Location = new System.Drawing.Point(801, 473);
            this.Personal_BackButton.Name = "Personal_BackButton";
            this.Personal_BackButton.Size = new System.Drawing.Size(118, 35);
            this.Personal_BackButton.TabIndex = 25;
            this.Personal_BackButton.Text = "Вернуться";
            this.Personal_BackButton.UseVisualStyleBackColor = true;
            this.Personal_BackButton.Click += new System.EventHandler(this.Personal_BackButton_Click);
            // 
            // Personal_EditDataBaseButton
            // 
            this.Personal_EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal_EditDataBaseButton.Location = new System.Drawing.Point(22, 171);
            this.Personal_EditDataBaseButton.Name = "Personal_EditDataBaseButton";
            this.Personal_EditDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.Personal_EditDataBaseButton.TabIndex = 24;
            this.Personal_EditDataBaseButton.Text = "Редактирование Базы Данных";
            this.Personal_EditDataBaseButton.UseVisualStyleBackColor = true;
            this.Personal_EditDataBaseButton.Click += new System.EventHandler(this.Personal_EditDataBaseButton_Click);
            // 
            // Personal_ViewDataBaseButton
            // 
            this.Personal_ViewDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal_ViewDataBaseButton.Location = new System.Drawing.Point(22, 80);
            this.Personal_ViewDataBaseButton.Name = "Personal_ViewDataBaseButton";
            this.Personal_ViewDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.Personal_ViewDataBaseButton.TabIndex = 23;
            this.Personal_ViewDataBaseButton.Text = "Просмотр Базы Данных";
            this.Personal_ViewDataBaseButton.UseVisualStyleBackColor = true;
            this.Personal_ViewDataBaseButton.Click += new System.EventHandler(this.Personal_ViewDataBaseButton_Click);
            // 
            // PersonalDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.Personal_ActionChoiseLabel);
            this.Controls.Add(this.Personal_BackButton);
            this.Controls.Add(this.Personal_EditDataBaseButton);
            this.Controls.Add(this.Personal_ViewDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalDB";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.PersonalDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Personal_ActionChoiseLabel;
        private System.Windows.Forms.Button Personal_BackButton;
        private System.Windows.Forms.Button Personal_EditDataBaseButton;
        private System.Windows.Forms.Button Personal_ViewDataBaseButton;
    }
}