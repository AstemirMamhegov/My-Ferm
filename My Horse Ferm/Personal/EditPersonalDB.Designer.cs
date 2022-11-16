namespace My_Horse_Ferm.Personal
{
    partial class EditPersonalDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPersonalDB));
            this.EditPersonal_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.EditPersonal_BackButton = new System.Windows.Forms.Button();
            this.EditPersonal_EditDataBaseButton = new System.Windows.Forms.Button();
            this.EditPersonal_AddDataBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditPersonal_ActionChoiseLabel
            // 
            this.EditPersonal_ActionChoiseLabel.AutoSize = true;
            this.EditPersonal_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPersonal_ActionChoiseLabel.Location = new System.Drawing.Point(14, 13);
            this.EditPersonal_ActionChoiseLabel.Name = "EditPersonal_ActionChoiseLabel";
            this.EditPersonal_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.EditPersonal_ActionChoiseLabel.TabIndex = 25;
            this.EditPersonal_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // EditPersonal_BackButton
            // 
            this.EditPersonal_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPersonal_BackButton.Location = new System.Drawing.Point(801, 473);
            this.EditPersonal_BackButton.Name = "EditPersonal_BackButton";
            this.EditPersonal_BackButton.Size = new System.Drawing.Size(118, 35);
            this.EditPersonal_BackButton.TabIndex = 24;
            this.EditPersonal_BackButton.Text = "Вернуться";
            this.EditPersonal_BackButton.UseVisualStyleBackColor = true;
            // 
            // EditPersonal_EditDataBaseButton
            // 
            this.EditPersonal_EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPersonal_EditDataBaseButton.Location = new System.Drawing.Point(22, 171);
            this.EditPersonal_EditDataBaseButton.Name = "EditPersonal_EditDataBaseButton";
            this.EditPersonal_EditDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.EditPersonal_EditDataBaseButton.TabIndex = 23;
            this.EditPersonal_EditDataBaseButton.Text = "Редактирование Базы Данных";
            this.EditPersonal_EditDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // EditPersonal_AddDataBaseButton
            // 
            this.EditPersonal_AddDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPersonal_AddDataBaseButton.Location = new System.Drawing.Point(22, 80);
            this.EditPersonal_AddDataBaseButton.Name = "EditPersonal_AddDataBaseButton";
            this.EditPersonal_AddDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.EditPersonal_AddDataBaseButton.TabIndex = 22;
            this.EditPersonal_AddDataBaseButton.Text = "Добавление в Базу Данных";
            this.EditPersonal_AddDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // EditPersonalDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.EditPersonal_ActionChoiseLabel);
            this.Controls.Add(this.EditPersonal_BackButton);
            this.Controls.Add(this.EditPersonal_EditDataBaseButton);
            this.Controls.Add(this.EditPersonal_AddDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPersonalDB";
            this.Text = "База данных сотрудников фермы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditPersonal_ActionChoiseLabel;
        private System.Windows.Forms.Button EditPersonal_BackButton;
        private System.Windows.Forms.Button EditPersonal_EditDataBaseButton;
        private System.Windows.Forms.Button EditPersonal_AddDataBaseButton;
    }
}