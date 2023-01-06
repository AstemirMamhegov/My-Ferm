using My_Horse_Ferm.Table_Classes;
using My_Horse_Ferm.Table_Classes.PersonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm.Personal
{
    public partial class NewAddPersonalDB : Form
    {
        private SalaryManTable salaryMan;

        public NewAddPersonalDB(SalaryManTable salaryMan = null)
        {
            InitializeComponent();

            NewAddPersonal_JobTitleComboBox.DataSource = DBController.Instance.JobTitles;
            NewAddPersonal_GenderComboBox.DataSource = DBController.Instance.PeopleGenders;

            if (salaryMan != null)
            {
                this.salaryMan = salaryMan;

                NewAddPersonal_LastNameTextBox.Text = salaryMan.LastName;
                NewAddPersonal_NameTextBox.Text = salaryMan.FirstName;
                NewAddPersonal_FatherNameTextBox.Text = salaryMan.MiddleName;
                NewAddPersonal_BirthdayDataTimePicker.Value = salaryMan.Birthday;
                NewAddPersonal_PhoneMaskedTextBox.Text = salaryMan.Phone;
                NewAddPersonal_EMailTextBox.Text = salaryMan.Email;
                NewAddPersonal_GenderComboBox.SelectedItem = salaryMan.PeopleGender;
                NewAddPersonal_JobTitleComboBox.SelectedItem = salaryMan.JobTitle;
                NewAddPerdsonal_SalaryNumericUpDown.Value = salaryMan.Salary;
                NewAddPersonal_ExperienceNumericUpDown.Value = salaryMan.Experience;

            }
        }

        private void NewAddPersonal_AddButton_Click(object sender, EventArgs e)
        {
            if(salaryMan == null)
                salaryMan = new SalaryManTable();

            salaryMan.LastName = NewAddPersonal_LastNameTextBox.Text;
            salaryMan.FirstName = NewAddPersonal_NameTextBox.Text;
            salaryMan.MiddleName = NewAddPersonal_FatherNameTextBox.Text;
            salaryMan.Birthday = NewAddPersonal_BirthdayDataTimePicker.Value;
            salaryMan.Phone = NewAddPersonal_PhoneMaskedTextBox.Text;
            salaryMan.Email = NewAddPersonal_EMailTextBox.Text;
            salaryMan.PeopleGender = NewAddPersonal_GenderComboBox.SelectedItem as PeopleGender;
            salaryMan.JobTitle = NewAddPersonal_JobTitleComboBox.SelectedItem as JobTitle;
            salaryMan.Salary = NewAddPerdsonal_SalaryNumericUpDown.Value;
            salaryMan.Experience = (int)NewAddPersonal_ExperienceNumericUpDown.Value;

            DBController.Instance.Update(salaryMan);
        }

        private void NewAddPersonalDB_Load(object sender, EventArgs e)
        {

        }

        private void NewAddPersonal_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChoosePersonalDB choosePersonalDBForm = new ChoosePersonalDB();
            choosePersonalDBForm.ShowDialog();
        }
    }
}
