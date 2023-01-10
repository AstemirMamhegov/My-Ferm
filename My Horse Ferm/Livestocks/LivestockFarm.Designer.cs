namespace My_Horse_Ferm
{
    partial class LivestockFarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivestockFarm));
            this.LivestockFarm_StudFarmButton = new System.Windows.Forms.Button();
            this.LivestockFarm_CowFarmButton = new System.Windows.Forms.Button();
            this.LivestockFarm_EtcButton = new System.Windows.Forms.Button();
            this.LivestockFarm_BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LivestockFarm_StudFarmButton
            // 
            this.LivestockFarm_StudFarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_StudFarmButton.Location = new System.Drawing.Point(6, 12);
            this.LivestockFarm_StudFarmButton.Name = "LivestockFarm_StudFarmButton";
            this.LivestockFarm_StudFarmButton.Size = new System.Drawing.Size(248, 73);
            this.LivestockFarm_StudFarmButton.TabIndex = 1;
            this.LivestockFarm_StudFarmButton.Text = "Конный Завод";
            this.LivestockFarm_StudFarmButton.UseVisualStyleBackColor = true;
            this.LivestockFarm_StudFarmButton.Click += new System.EventHandler(this.LivestockFarm_StudFarmButton_Click);
            // 
            // LivestockFarm_CowFarmButton
            // 
            this.LivestockFarm_CowFarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_CowFarmButton.Location = new System.Drawing.Point(6, 91);
            this.LivestockFarm_CowFarmButton.Name = "LivestockFarm_CowFarmButton";
            this.LivestockFarm_CowFarmButton.Size = new System.Drawing.Size(248, 73);
            this.LivestockFarm_CowFarmButton.TabIndex = 2;
            this.LivestockFarm_CowFarmButton.Text = "Коровья Ферма";
            this.LivestockFarm_CowFarmButton.UseVisualStyleBackColor = true;
            this.LivestockFarm_CowFarmButton.Click += new System.EventHandler(this.LivestockFarm_CowFarmButton_Click);
            // 
            // LivestockFarm_EtcButton
            // 
            this.LivestockFarm_EtcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_EtcButton.Location = new System.Drawing.Point(354, 12);
            this.LivestockFarm_EtcButton.Name = "LivestockFarm_EtcButton";
            this.LivestockFarm_EtcButton.Size = new System.Drawing.Size(248, 73);
            this.LivestockFarm_EtcButton.TabIndex = 3;
            this.LivestockFarm_EtcButton.Text = "Прочее";
            this.LivestockFarm_EtcButton.UseVisualStyleBackColor = true;
            // 
            // LivestockFarm_BackButton
            // 
            this.LivestockFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_BackButton.Location = new System.Drawing.Point(501, 272);
            this.LivestockFarm_BackButton.Name = "LivestockFarm_BackButton";
            this.LivestockFarm_BackButton.Size = new System.Drawing.Size(101, 30);
            this.LivestockFarm_BackButton.TabIndex = 10;
            this.LivestockFarm_BackButton.Text = "Вернуться";
            this.LivestockFarm_BackButton.UseVisualStyleBackColor = true;
            this.LivestockFarm_BackButton.Click += new System.EventHandler(this.LivestockFarm_BackButton_Click);
            // 
            // LivestockFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(609, 322);
            this.Controls.Add(this.LivestockFarm_BackButton);
            this.Controls.Add(this.LivestockFarm_EtcButton);
            this.Controls.Add(this.LivestockFarm_CowFarmButton);
            this.Controls.Add(this.LivestockFarm_StudFarmButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LivestockFarm";
            this.Text = "Учет Животных";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LivestockFarm_StudFarmButton;
        private System.Windows.Forms.Button LivestockFarm_CowFarmButton;
        private System.Windows.Forms.Button LivestockFarm_EtcButton;
        private System.Windows.Forms.Button LivestockFarm_BackButton;
    }
}