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
            this.StudFarm_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.StudFarm_BackButton = new System.Windows.Forms.Button();
            this.StudFarm_EditDataBaseButton = new System.Windows.Forms.Button();
            this.StudFarm_ViewDataBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudFarm_ActionChoiseLabel
            // 
            this.StudFarm_ActionChoiseLabel.AutoSize = true;
            this.StudFarm_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_ActionChoiseLabel.Location = new System.Drawing.Point(14, 10);
            this.StudFarm_ActionChoiseLabel.Name = "StudFarm_ActionChoiseLabel";
            this.StudFarm_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.StudFarm_ActionChoiseLabel.TabIndex = 13;
            this.StudFarm_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // StudFarm_BackButton
            // 
            this.StudFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_BackButton.Location = new System.Drawing.Point(801, 471);
            this.StudFarm_BackButton.Name = "StudFarm_BackButton";
            this.StudFarm_BackButton.Size = new System.Drawing.Size(118, 35);
            this.StudFarm_BackButton.TabIndex = 12;
            this.StudFarm_BackButton.Text = "Вернуться";
            this.StudFarm_BackButton.UseVisualStyleBackColor = true;
            // 
            // StudFarm_EditDataBaseButton
            // 
            this.StudFarm_EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_EditDataBaseButton.Location = new System.Drawing.Point(22, 168);
            this.StudFarm_EditDataBaseButton.Name = "StudFarm_EditDataBaseButton";
            this.StudFarm_EditDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.StudFarm_EditDataBaseButton.TabIndex = 11;
            this.StudFarm_EditDataBaseButton.Text = "Редактирование Базы Данных";
            this.StudFarm_EditDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // StudFarm_ViewDataBaseButton
            // 
            this.StudFarm_ViewDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudFarm_ViewDataBaseButton.Location = new System.Drawing.Point(22, 77);
            this.StudFarm_ViewDataBaseButton.Name = "StudFarm_ViewDataBaseButton";
            this.StudFarm_ViewDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.StudFarm_ViewDataBaseButton.TabIndex = 10;
            this.StudFarm_ViewDataBaseButton.Text = "Просмотр Базы Данных";
            this.StudFarm_ViewDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // StudFarmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.StudFarm_ActionChoiseLabel);
            this.Controls.Add(this.StudFarm_BackButton);
            this.Controls.Add(this.StudFarm_EditDataBaseButton);
            this.Controls.Add(this.StudFarm_ViewDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudFarmDB";
            this.Text = "Учет Лошадей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudFarm_ActionChoiseLabel;
        private System.Windows.Forms.Button StudFarm_BackButton;
        private System.Windows.Forms.Button StudFarm_EditDataBaseButton;
        private System.Windows.Forms.Button StudFarm_ViewDataBaseButton;
    }
}