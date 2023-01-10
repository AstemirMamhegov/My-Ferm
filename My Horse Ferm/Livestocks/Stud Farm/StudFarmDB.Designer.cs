namespace My_Horse_Ferm
{
    partial class StudFarmDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudFarmDB));
            this.StudFarm_BackButton = new System.Windows.Forms.Button();
            this.StudFarm_ViewDataBaseButton = new System.Windows.Forms.Button();
            this.StudFarm_EditDataBaseButton = new System.Windows.Forms.Button();
            this.StudFarmDB_ColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudFarm_BackButton
            // 
            this.StudFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_BackButton.Location = new System.Drawing.Point(203, 318);
            this.StudFarm_BackButton.Name = "StudFarm_BackButton";
            this.StudFarm_BackButton.Size = new System.Drawing.Size(118, 35);
            this.StudFarm_BackButton.TabIndex = 12;
            this.StudFarm_BackButton.Text = "Вернуться";
            this.StudFarm_BackButton.UseVisualStyleBackColor = true;
            this.StudFarm_BackButton.Click += new System.EventHandler(this.StudFarm_BackButton_Click);
            // 
            // StudFarm_ViewDataBaseButton
            // 
            this.StudFarm_ViewDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_ViewDataBaseButton.Location = new System.Drawing.Point(12, 12);
            this.StudFarm_ViewDataBaseButton.Name = "StudFarm_ViewDataBaseButton";
            this.StudFarm_ViewDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.StudFarm_ViewDataBaseButton.TabIndex = 1;
            this.StudFarm_ViewDataBaseButton.Text = "Просмотр Базы Данных";
            this.StudFarm_ViewDataBaseButton.UseVisualStyleBackColor = true;
            this.StudFarm_ViewDataBaseButton.Click += new System.EventHandler(this.StudFarm_ViewDataBaseButton_Click);
            // 
            // StudFarm_EditDataBaseButton
            // 
            this.StudFarm_EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_EditDataBaseButton.Location = new System.Drawing.Point(12, 103);
            this.StudFarm_EditDataBaseButton.Name = "StudFarm_EditDataBaseButton";
            this.StudFarm_EditDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.StudFarm_EditDataBaseButton.TabIndex = 2;
            this.StudFarm_EditDataBaseButton.Text = "Породы лошадей";
            this.StudFarm_EditDataBaseButton.UseVisualStyleBackColor = true;
            this.StudFarm_EditDataBaseButton.Click += new System.EventHandler(this.StudFarm_EditDataBaseButton_Click);
            // 
            // StudFarmDB_ColorButton
            // 
            this.StudFarmDB_ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarmDB_ColorButton.Location = new System.Drawing.Point(12, 193);
            this.StudFarmDB_ColorButton.Name = "StudFarmDB_ColorButton";
            this.StudFarmDB_ColorButton.Size = new System.Drawing.Size(309, 84);
            this.StudFarmDB_ColorButton.TabIndex = 3;
            this.StudFarmDB_ColorButton.Text = "Окрас Лошадей";
            this.StudFarmDB_ColorButton.UseVisualStyleBackColor = true;
            this.StudFarmDB_ColorButton.Click += new System.EventHandler(this.StudFarmDB_ColorButton_Click);
            // 
            // StudFarmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(346, 419);
            this.Controls.Add(this.StudFarmDB_ColorButton);
            this.Controls.Add(this.StudFarm_BackButton);
            this.Controls.Add(this.StudFarm_EditDataBaseButton);
            this.Controls.Add(this.StudFarm_ViewDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudFarmDB";
            this.Text = "Учет Лошадей";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StudFarm_BackButton;
        private System.Windows.Forms.Button StudFarm_ViewDataBaseButton;
        private System.Windows.Forms.Button StudFarm_EditDataBaseButton;
        private System.Windows.Forms.Button StudFarmDB_ColorButton;
    }
}