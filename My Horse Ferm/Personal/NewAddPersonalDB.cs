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
        public NewAddPersonalDB()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C# project\\My Horse Ferm\\My Horse Ferm\\Tables\\MyHorseFarm.mdf;Integrated Security=True;Connect Timeout=30";

        private void NewAddPersonal_AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Personal(member_id, last_name, first_name, father_name" +
                  " birthday, age, job_title, salary, experience)" +
                  " values('" + NewAddPersonal_LastNameTextBox.Text.ToString() + "','" + NewAddPersonal_NameTextBox.Text.ToString() + "','" 
                  + NewAddPersonal_FatherNameTextBox.Text.ToString() + "','" + NewAddPersonal_BirthdayDataTimePicker.Text.ToString() + "','" 
                  + NewAddPersonal_AgeNumericUpDown.Text.ToString() + "','" + NewAddPersonal_JobTitleComboBox.Text.ToString() + "','" 
                  + NewAddPerdsonal_SalaryNumericUpDown.Text.ToString() + "','" + NewAddPersonal_ExperienceNumericUpDown.Text.ToString() + "') ";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection was successful!");
            }

            con.Close();
        }

        private void NewAddPersonalDB_Load(object sender, EventArgs e)
        {

        }
    }
}
