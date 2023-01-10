namespace My_Horse_Ferm
{
    partial class ActionsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionsMenu));
            this.ActionsMenu_BackButton = new System.Windows.Forms.Button();
            this.ActionsMenu_LivestockButton = new System.Windows.Forms.Button();
            this.ActionsMenu_PersonalButton = new System.Windows.Forms.Button();
            this.ActionsMenu_PropertyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionsMenu_BackButton
            // 
            this.ActionsMenu_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_BackButton.Location = new System.Drawing.Point(162, 249);
            this.ActionsMenu_BackButton.Name = "ActionsMenu_BackButton";
            this.ActionsMenu_BackButton.Size = new System.Drawing.Size(98, 35);
            this.ActionsMenu_BackButton.TabIndex = 4;
            this.ActionsMenu_BackButton.Text = "Вернуться";
            this.ActionsMenu_BackButton.UseVisualStyleBackColor = true;
            this.ActionsMenu_BackButton.Click += new System.EventHandler(this.ActionsMenu_BackButton_Click);
            // 
            // ActionsMenu_LivestockButton
            // 
            this.ActionsMenu_LivestockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_LivestockButton.Location = new System.Drawing.Point(12, 12);
            this.ActionsMenu_LivestockButton.Name = "ActionsMenu_LivestockButton";
            this.ActionsMenu_LivestockButton.Size = new System.Drawing.Size(248, 73);
            this.ActionsMenu_LivestockButton.TabIndex = 1;
            this.ActionsMenu_LivestockButton.Text = "Учет Животных";
            this.ActionsMenu_LivestockButton.UseVisualStyleBackColor = true;
            this.ActionsMenu_LivestockButton.Click += new System.EventHandler(this.ActionsMenu_LivestockButton_Click);
            // 
            // ActionsMenu_PersonalButton
            // 
            this.ActionsMenu_PersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_PersonalButton.Location = new System.Drawing.Point(12, 91);
            this.ActionsMenu_PersonalButton.Name = "ActionsMenu_PersonalButton";
            this.ActionsMenu_PersonalButton.Size = new System.Drawing.Size(248, 73);
            this.ActionsMenu_PersonalButton.TabIndex = 2;
            this.ActionsMenu_PersonalButton.Text = "Персонал";
            this.ActionsMenu_PersonalButton.UseVisualStyleBackColor = true;
            this.ActionsMenu_PersonalButton.Click += new System.EventHandler(this.ActionsMenu_PersonalButton_Click);
            // 
            // ActionsMenu_PropertyButton
            // 
            this.ActionsMenu_PropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_PropertyButton.Location = new System.Drawing.Point(12, 170);
            this.ActionsMenu_PropertyButton.Name = "ActionsMenu_PropertyButton";
            this.ActionsMenu_PropertyButton.Size = new System.Drawing.Size(248, 73);
            this.ActionsMenu_PropertyButton.TabIndex = 3;
            this.ActionsMenu_PropertyButton.Text = "Имущество";
            this.ActionsMenu_PropertyButton.UseVisualStyleBackColor = true;
            this.ActionsMenu_PropertyButton.Click += new System.EventHandler(this.ActionsMenu_PropertyButton_Click);
            // 
            // ActionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(268, 298);
            this.Controls.Add(this.ActionsMenu_PropertyButton);
            this.Controls.Add(this.ActionsMenu_PersonalButton);
            this.Controls.Add(this.ActionsMenu_LivestockButton);
            this.Controls.Add(this.ActionsMenu_BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionsMenu";
            this.Text = "Ферма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActionsMenu_BackButton;
        private System.Windows.Forms.Button ActionsMenu_LivestockButton;
        private System.Windows.Forms.Button ActionsMenu_PersonalButton;
        private System.Windows.Forms.Button ActionsMenu_PropertyButton;
    }
}