﻿namespace My_Horse_Ferm
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
            this.LivestockFarm_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.LivestockFarm_BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LivestockFarm_StudFarmButton
            // 
            this.LivestockFarm_StudFarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_StudFarmButton.Location = new System.Drawing.Point(12, 67);
            this.LivestockFarm_StudFarmButton.Name = "LivestockFarm_StudFarmButton";
            this.LivestockFarm_StudFarmButton.Size = new System.Drawing.Size(248, 73);
            this.LivestockFarm_StudFarmButton.TabIndex = 6;
            this.LivestockFarm_StudFarmButton.Text = "Конный Завод";
            this.LivestockFarm_StudFarmButton.UseVisualStyleBackColor = true;
            // 
            // LivestockFarm_CowFarmButton
            // 
            this.LivestockFarm_CowFarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_CowFarmButton.Location = new System.Drawing.Point(12, 146);
            this.LivestockFarm_CowFarmButton.Name = "LivestockFarm_CowFarmButton";
            this.LivestockFarm_CowFarmButton.Size = new System.Drawing.Size(248, 73);
            this.LivestockFarm_CowFarmButton.TabIndex = 7;
            this.LivestockFarm_CowFarmButton.Text = "Коровья Ферма";
            this.LivestockFarm_CowFarmButton.UseVisualStyleBackColor = true;
            // 
            // LivestockFarm_EtcButton
            // 
            this.LivestockFarm_EtcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_EtcButton.Location = new System.Drawing.Point(12, 225);
            this.LivestockFarm_EtcButton.Name = "LivestockFarm_EtcButton";
            this.LivestockFarm_EtcButton.Size = new System.Drawing.Size(248, 73);
            this.LivestockFarm_EtcButton.TabIndex = 8;
            this.LivestockFarm_EtcButton.Text = "Прочее";
            this.LivestockFarm_EtcButton.UseVisualStyleBackColor = true;
            // 
            // LivestockFarm_ActionChoiseLabel
            // 
            this.LivestockFarm_ActionChoiseLabel.AutoSize = true;
            this.LivestockFarm_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_ActionChoiseLabel.Location = new System.Drawing.Point(5, 9);
            this.LivestockFarm_ActionChoiseLabel.Name = "LivestockFarm_ActionChoiseLabel";
            this.LivestockFarm_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.LivestockFarm_ActionChoiseLabel.TabIndex = 9;
            this.LivestockFarm_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // LivestockFarm_BackButton
            // 
            this.LivestockFarm_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivestockFarm_BackButton.Location = new System.Drawing.Point(687, 408);
            this.LivestockFarm_BackButton.Name = "LivestockFarm_BackButton";
            this.LivestockFarm_BackButton.Size = new System.Drawing.Size(101, 30);
            this.LivestockFarm_BackButton.TabIndex = 13;
            this.LivestockFarm_BackButton.Text = "Вернуться";
            this.LivestockFarm_BackButton.UseVisualStyleBackColor = true;
            // 
            // LivestockFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LivestockFarm_BackButton);
            this.Controls.Add(this.LivestockFarm_ActionChoiseLabel);
            this.Controls.Add(this.LivestockFarm_EtcButton);
            this.Controls.Add(this.LivestockFarm_CowFarmButton);
            this.Controls.Add(this.LivestockFarm_StudFarmButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LivestockFarm";
            this.Text = "Учет Животных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LivestockFarm_StudFarmButton;
        private System.Windows.Forms.Button LivestockFarm_CowFarmButton;
        private System.Windows.Forms.Button LivestockFarm_EtcButton;
        private System.Windows.Forms.Label LivestockFarm_ActionChoiseLabel;
        private System.Windows.Forms.Button LivestockFarm_BackButton;
    }
}