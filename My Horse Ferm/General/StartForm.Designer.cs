namespace My_Horse_Ferm
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartForm_ActionsMenuButton = new System.Windows.Forms.Button();
            this.StartForm_ExitButton = new System.Windows.Forms.Button();
            this.StartForm_AppNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartForm_ActionsMenuButton
            // 
            this.StartForm_ActionsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartForm_ActionsMenuButton.Location = new System.Drawing.Point(290, 215);
            this.StartForm_ActionsMenuButton.Name = "StartForm_ActionsMenuButton";
            this.StartForm_ActionsMenuButton.Size = new System.Drawing.Size(248, 73);
            this.StartForm_ActionsMenuButton.TabIndex = 0;
            this.StartForm_ActionsMenuButton.Text = "Начало Работы";
            this.StartForm_ActionsMenuButton.UseVisualStyleBackColor = true;
            this.StartForm_ActionsMenuButton.Click += new System.EventHandler(this.StartForm_ActionsMenuButton_Click);
            // 
            // StartForm_ExitButton
            // 
            this.StartForm_ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartForm_ExitButton.Location = new System.Drawing.Point(290, 294);
            this.StartForm_ExitButton.Name = "StartForm_ExitButton";
            this.StartForm_ExitButton.Size = new System.Drawing.Size(248, 73);
            this.StartForm_ExitButton.TabIndex = 1;
            this.StartForm_ExitButton.Text = "Выход";
            this.StartForm_ExitButton.UseVisualStyleBackColor = true;
            this.StartForm_ExitButton.Click += new System.EventHandler(this.StartForm_ExitButton_Click);
            // 
            // StartForm_AppNameLabel
            // 
            this.StartForm_AppNameLabel.AutoSize = true;
            this.StartForm_AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartForm_AppNameLabel.Location = new System.Drawing.Point(169, 9);
            this.StartForm_AppNameLabel.Name = "StartForm_AppNameLabel";
            this.StartForm_AppNameLabel.Size = new System.Drawing.Size(498, 37);
            this.StartForm_AppNameLabel.TabIndex = 2;
            this.StartForm_AppNameLabel.Text = "Ферма имени Мамхегова Хачима";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(843, 506);
            this.Controls.Add(this.StartForm_AppNameLabel);
            this.Controls.Add(this.StartForm_ExitButton);
            this.Controls.Add(this.StartForm_ActionsMenuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Моя любимая ферма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartForm_ActionsMenuButton;
        private System.Windows.Forms.Button StartForm_ExitButton;
        private System.Windows.Forms.Label StartForm_AppNameLabel;
    }
}

