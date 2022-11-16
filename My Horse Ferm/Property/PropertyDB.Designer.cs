namespace My_Horse_Ferm.Property
{
    partial class PropertyDB
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
            this.ActionsMenu_ActionChoiseLabel = new System.Windows.Forms.Label();
            this.ActionsMenu_PropertyButton = new System.Windows.Forms.Button();
            this.ActionsMenu_PersonalButton = new System.Windows.Forms.Button();
            this.ActionsMenu_LivestockButton = new System.Windows.Forms.Button();
            this.ActionsMenu_BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionsMenu_ActionChoiseLabel
            // 
            this.ActionsMenu_ActionChoiseLabel.AutoSize = true;
            this.ActionsMenu_ActionChoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_ActionChoiseLabel.Location = new System.Drawing.Point(9, 11);
            this.ActionsMenu_ActionChoiseLabel.Name = "ActionsMenu_ActionChoiseLabel";
            this.ActionsMenu_ActionChoiseLabel.Size = new System.Drawing.Size(319, 37);
            this.ActionsMenu_ActionChoiseLabel.TabIndex = 10;
            this.ActionsMenu_ActionChoiseLabel.Text = "ВЫБОР ДЕЙСТВИЯ";
            // 
            // ActionsMenu_PropertyButton
            // 
            this.ActionsMenu_PropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_PropertyButton.Location = new System.Drawing.Point(16, 227);
            this.ActionsMenu_PropertyButton.Name = "ActionsMenu_PropertyButton";
            this.ActionsMenu_PropertyButton.Size = new System.Drawing.Size(248, 73);
            this.ActionsMenu_PropertyButton.TabIndex = 9;
            this.ActionsMenu_PropertyButton.Text = "Имущество";
            this.ActionsMenu_PropertyButton.UseVisualStyleBackColor = true;
            // 
            // ActionsMenu_PersonalButton
            // 
            this.ActionsMenu_PersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_PersonalButton.Location = new System.Drawing.Point(16, 148);
            this.ActionsMenu_PersonalButton.Name = "ActionsMenu_PersonalButton";
            this.ActionsMenu_PersonalButton.Size = new System.Drawing.Size(248, 73);
            this.ActionsMenu_PersonalButton.TabIndex = 8;
            this.ActionsMenu_PersonalButton.Text = "Персонал";
            this.ActionsMenu_PersonalButton.UseVisualStyleBackColor = true;
            // 
            // ActionsMenu_LivestockButton
            // 
            this.ActionsMenu_LivestockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_LivestockButton.Location = new System.Drawing.Point(16, 69);
            this.ActionsMenu_LivestockButton.Name = "ActionsMenu_LivestockButton";
            this.ActionsMenu_LivestockButton.Size = new System.Drawing.Size(248, 73);
            this.ActionsMenu_LivestockButton.TabIndex = 7;
            this.ActionsMenu_LivestockButton.Text = "Учет Животных";
            this.ActionsMenu_LivestockButton.UseVisualStyleBackColor = true;
            // 
            // ActionsMenu_BackButton
            // 
            this.ActionsMenu_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsMenu_BackButton.Location = new System.Drawing.Point(694, 405);
            this.ActionsMenu_BackButton.Name = "ActionsMenu_BackButton";
            this.ActionsMenu_BackButton.Size = new System.Drawing.Size(98, 35);
            this.ActionsMenu_BackButton.TabIndex = 6;
            this.ActionsMenu_BackButton.Text = "Вернуться";
            this.ActionsMenu_BackButton.UseVisualStyleBackColor = true;
            // 
            // PropertyDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActionsMenu_ActionChoiseLabel);
            this.Controls.Add(this.ActionsMenu_PropertyButton);
            this.Controls.Add(this.ActionsMenu_PersonalButton);
            this.Controls.Add(this.ActionsMenu_LivestockButton);
            this.Controls.Add(this.ActionsMenu_BackButton);
            this.Name = "PropertyDB";
            this.Text = "PropertyDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActionsMenu_ActionChoiseLabel;
        private System.Windows.Forms.Button ActionsMenu_PropertyButton;
        private System.Windows.Forms.Button ActionsMenu_PersonalButton;
        private System.Windows.Forms.Button ActionsMenu_LivestockButton;
        private System.Windows.Forms.Button ActionsMenu_BackButton;
    }
}