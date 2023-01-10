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
            this.Personal_BackButton = new System.Windows.Forms.Button();
            this.Personal_ViewDataBaseButton = new System.Windows.Forms.Button();
            this.PersonalDB_JobTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Personal_BackButton
            // 
            this.Personal_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal_BackButton.Location = new System.Drawing.Point(215, 313);
            this.Personal_BackButton.Name = "Personal_BackButton";
            this.Personal_BackButton.Size = new System.Drawing.Size(118, 35);
            this.Personal_BackButton.TabIndex = 25;
            this.Personal_BackButton.Text = "Вернуться";
            this.Personal_BackButton.UseVisualStyleBackColor = true;
            this.Personal_BackButton.Click += new System.EventHandler(this.Personal_BackButton_Click);
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
            // PersonalDB_JobTitleButton
            // 
            this.PersonalDB_JobTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalDB_JobTitleButton.Location = new System.Drawing.Point(21, 196);
            this.PersonalDB_JobTitleButton.Name = "PersonalDB_JobTitleButton";
            this.PersonalDB_JobTitleButton.Size = new System.Drawing.Size(309, 84);
            this.PersonalDB_JobTitleButton.TabIndex = 27;
            this.PersonalDB_JobTitleButton.Text = "Должности";
            this.PersonalDB_JobTitleButton.UseVisualStyleBackColor = true;
            this.PersonalDB_JobTitleButton.Click += new System.EventHandler(this.PersonalDB_JobTitleButton_Click);
            // 
            // PersonalDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(348, 369);
            this.Controls.Add(this.PersonalDB_JobTitleButton);
            this.Controls.Add(this.Personal_BackButton);
            this.Controls.Add(this.Personal_ViewDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalDB";
            this.Text = "Сотрудники";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Personal_BackButton;
        private System.Windows.Forms.Button Personal_ViewDataBaseButton;
        private System.Windows.Forms.Button PersonalDB_JobTitleButton;
    }
}