using My_Horse_Ferm.ModelClasses.PersonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm.Personal
{
    public partial class NewAddJobTitleDB : Form
    {
        private JobTitle jobTitle;

        public NewAddJobTitleDB(JobTitle jobTitle = null)
        {
            InitializeComponent();

            if(jobTitle !=null) 
            {
                this.jobTitle = jobTitle;
                NewAddJobTitle_JobTitleComboBox.Text = jobTitle.Name;
            }
        }

        /// <summary>
        /// Функция добавляющая запись в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAddJobTitle_OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewAddJobTitle_JobTitleComboBox.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (jobTitle == null)
            {
                if (DBController.Instance.JobTitles.Any(t => t.Name == NewAddJobTitle_JobTitleComboBox.Text))
                {
                    MessageBox.Show("Должность с таким названием уже существует");
                    return;
                }
                jobTitle = new JobTitle();
            }

            jobTitle.Name = NewAddJobTitle_JobTitleComboBox.Text;
            DBController.Instance.Update(jobTitle);
            DialogResult = DialogResult.OK;
        }
    }
}
