namespace My_Horse_Ferm.Livestock.Stud_Farm
{
    partial class EditStudFarmDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudFarmDB));
            this.EditStudFarm_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.EditStudFarm_BackButton = new System.Windows.Forms.Button();
            this.EditStudFarm_EditDataBaseButton = new System.Windows.Forms.Button();
            this.EditStudFarm_AddDataBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditStudFarm_ActionChoiseLabel
            // 
            this.EditStudFarm_ActionChoiseLabel.AutoSize = true;
            this.EditStudFarm_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditStudFarm_ActionChoiseLabel.Location = new System.Drawing.Point(14, 13);
            this.EditStudFarm_ActionChoiseLabel.Name = "EditStudFarm_ActionChoiseLabel";
            this.EditStudFarm_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.EditStudFarm_ActionChoiseLabel.TabIndex = 21;
            this.EditStudFarm_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // EditStudFarm_BackButton
            // 
            this.EditStudFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditStudFarm_BackButton.Location = new System.Drawing.Point(801, 473);
            this.EditStudFarm_BackButton.Name = "EditStudFarm_BackButton";
            this.EditStudFarm_BackButton.Size = new System.Drawing.Size(118, 35);
            this.EditStudFarm_BackButton.TabIndex = 20;
            this.EditStudFarm_BackButton.Text = "Вернуться";
            this.EditStudFarm_BackButton.UseVisualStyleBackColor = true;
            // 
            // EditStudFarm_EditDataBaseButton
            // 
            this.EditStudFarm_EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditStudFarm_EditDataBaseButton.Location = new System.Drawing.Point(22, 171);
            this.EditStudFarm_EditDataBaseButton.Name = "EditStudFarm_EditDataBaseButton";
            this.EditStudFarm_EditDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.EditStudFarm_EditDataBaseButton.TabIndex = 19;
            this.EditStudFarm_EditDataBaseButton.Text = "Редактирование Базы Данных";
            this.EditStudFarm_EditDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // EditStudFarm_AddDataBaseButton
            // 
            this.EditStudFarm_AddDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditStudFarm_AddDataBaseButton.Location = new System.Drawing.Point(22, 80);
            this.EditStudFarm_AddDataBaseButton.Name = "EditStudFarm_AddDataBaseButton";
            this.EditStudFarm_AddDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.EditStudFarm_AddDataBaseButton.TabIndex = 18;
            this.EditStudFarm_AddDataBaseButton.Text = "Добавление в Базу Данных";
            this.EditStudFarm_AddDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // EditStudFarmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.EditStudFarm_ActionChoiseLabel);
            this.Controls.Add(this.EditStudFarm_BackButton);
            this.Controls.Add(this.EditStudFarm_EditDataBaseButton);
            this.Controls.Add(this.EditStudFarm_AddDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudFarmDB";
            this.Text = "Просмотр и редактирование базы данных лошадей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditStudFarm_ActionChoiseLabel;
        private System.Windows.Forms.Button EditStudFarm_BackButton;
        private System.Windows.Forms.Button EditStudFarm_EditDataBaseButton;
        private System.Windows.Forms.Button EditStudFarm_AddDataBaseButton;
    }
}