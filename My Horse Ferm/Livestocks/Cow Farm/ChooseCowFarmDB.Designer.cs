namespace My_Horse_Ferm.Livestock.Cow_Farm
{
    partial class ChooseCowFarmDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCowFarmDB));
            this.EditCowFarm_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.EditCowFarm_BackButton = new System.Windows.Forms.Button();
            this.EditCowFarm_EditDataBaseButton = new System.Windows.Forms.Button();
            this.EditCowFarm_AddDataBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditCowFarm_ActionChoiseLabel
            // 
            this.EditCowFarm_ActionChoiseLabel.AutoSize = true;
            this.EditCowFarm_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCowFarm_ActionChoiseLabel.Location = new System.Drawing.Point(14, 13);
            this.EditCowFarm_ActionChoiseLabel.Name = "EditCowFarm_ActionChoiseLabel";
            this.EditCowFarm_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.EditCowFarm_ActionChoiseLabel.TabIndex = 21;
            this.EditCowFarm_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // EditCowFarm_BackButton
            // 
            this.EditCowFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCowFarm_BackButton.Location = new System.Drawing.Point(801, 473);
            this.EditCowFarm_BackButton.Name = "EditCowFarm_BackButton";
            this.EditCowFarm_BackButton.Size = new System.Drawing.Size(118, 35);
            this.EditCowFarm_BackButton.TabIndex = 20;
            this.EditCowFarm_BackButton.Text = "Вернуться";
            this.EditCowFarm_BackButton.UseVisualStyleBackColor = true;
            this.EditCowFarm_BackButton.Click += new System.EventHandler(this.EditCowFarm_BackButton_Click);
            // 
            // EditCowFarm_EditDataBaseButton
            // 
            this.EditCowFarm_EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCowFarm_EditDataBaseButton.Location = new System.Drawing.Point(22, 171);
            this.EditCowFarm_EditDataBaseButton.Name = "EditCowFarm_EditDataBaseButton";
            this.EditCowFarm_EditDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.EditCowFarm_EditDataBaseButton.TabIndex = 19;
            this.EditCowFarm_EditDataBaseButton.Text = "Редактирование Базы Данных";
            this.EditCowFarm_EditDataBaseButton.UseVisualStyleBackColor = true;
            this.EditCowFarm_EditDataBaseButton.Click += new System.EventHandler(this.EditCowFarm_EditDataBaseButton_Click);
            // 
            // EditCowFarm_AddDataBaseButton
            // 
            this.EditCowFarm_AddDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCowFarm_AddDataBaseButton.Location = new System.Drawing.Point(22, 80);
            this.EditCowFarm_AddDataBaseButton.Name = "EditCowFarm_AddDataBaseButton";
            this.EditCowFarm_AddDataBaseButton.Size = new System.Drawing.Size(309, 84);
            this.EditCowFarm_AddDataBaseButton.TabIndex = 18;
            this.EditCowFarm_AddDataBaseButton.Text = "Добавление в  Базу Данных";
            this.EditCowFarm_AddDataBaseButton.UseVisualStyleBackColor = true;
            this.EditCowFarm_AddDataBaseButton.Click += new System.EventHandler(this.EditCowFarm_AddDataBaseButton_Click);
            // 
            // EditCowFarmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.EditCowFarm_ActionChoiseLabel);
            this.Controls.Add(this.EditCowFarm_BackButton);
            this.Controls.Add(this.EditCowFarm_EditDataBaseButton);
            this.Controls.Add(this.EditCowFarm_AddDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCowFarmDB";
            this.Text = "Просмотр и редактирование базы данных коровьей фермы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditCowFarm_ActionChoiseLabel;
        private System.Windows.Forms.Button EditCowFarm_BackButton;
        private System.Windows.Forms.Button EditCowFarm_EditDataBaseButton;
        private System.Windows.Forms.Button EditCowFarm_AddDataBaseButton;
    }
}