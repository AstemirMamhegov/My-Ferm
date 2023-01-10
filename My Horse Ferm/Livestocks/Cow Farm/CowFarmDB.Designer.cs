namespace My_Horse_Ferm.Livestock.Cow_Farm
{
    partial class CowFarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CowFarm));
            this.CowFarm_BackButton = new System.Windows.Forms.Button();
            this.CowFarm_BreedDataBaseButton = new System.Windows.Forms.Button();
            this.CowFarm_ViewDataBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CowFarm_BackButton
            // 
            this.CowFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CowFarm_BackButton.Location = new System.Drawing.Point(214, 322);
            this.CowFarm_BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CowFarm_BackButton.Name = "CowFarm_BackButton";
            this.CowFarm_BackButton.Size = new System.Drawing.Size(118, 34);
            this.CowFarm_BackButton.TabIndex = 16;
            this.CowFarm_BackButton.Text = "Вернуться";
            this.CowFarm_BackButton.UseVisualStyleBackColor = true;
            this.CowFarm_BackButton.Click += new System.EventHandler(this.CowFarm_BackButton_Click);
            // 
            // CowFarm_BreedDataBaseButton
            // 
            this.CowFarm_BreedDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CowFarm_BreedDataBaseButton.Location = new System.Drawing.Point(23, 121);
            this.CowFarm_BreedDataBaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CowFarm_BreedDataBaseButton.Name = "CowFarm_BreedDataBaseButton";
            this.CowFarm_BreedDataBaseButton.Size = new System.Drawing.Size(310, 84);
            this.CowFarm_BreedDataBaseButton.TabIndex = 15;
            this.CowFarm_BreedDataBaseButton.Text = "Породы";
            this.CowFarm_BreedDataBaseButton.UseVisualStyleBackColor = true;
            this.CowFarm_BreedDataBaseButton.Click += new System.EventHandler(this.CowFarm_BreedDataBaseButton_Click);
            // 
            // CowFarm_ViewDataBaseButton
            // 
            this.CowFarm_ViewDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CowFarm_ViewDataBaseButton.Location = new System.Drawing.Point(23, 13);
            this.CowFarm_ViewDataBaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CowFarm_ViewDataBaseButton.Name = "CowFarm_ViewDataBaseButton";
            this.CowFarm_ViewDataBaseButton.Size = new System.Drawing.Size(310, 84);
            this.CowFarm_ViewDataBaseButton.TabIndex = 14;
            this.CowFarm_ViewDataBaseButton.Text = "Просмотр Базы Данных";
            this.CowFarm_ViewDataBaseButton.UseVisualStyleBackColor = true;
            this.CowFarm_ViewDataBaseButton.Click += new System.EventHandler(this.CowFarm_ViewDataBaseButton_Click);
            // 
            // CowFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(345, 400);
            this.Controls.Add(this.CowFarm_BackButton);
            this.Controls.Add(this.CowFarm_BreedDataBaseButton);
            this.Controls.Add(this.CowFarm_ViewDataBaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CowFarm";
            this.Text = "Коровья Ферма";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CowFarm_BackButton;
        private System.Windows.Forms.Button CowFarm_BreedDataBaseButton;
        private System.Windows.Forms.Button CowFarm_ViewDataBaseButton;
    }
}