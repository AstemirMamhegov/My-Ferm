using My_Horse_Ferm.Table_Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using My_Horse_Ferm.Table_Classes.PersonModel;

namespace My_Horse_Ferm.Personal
{
    public partial class PersonalViewDB : Form
    {
        public PersonalViewDB()
        {
            InitializeComponent();
        }


        private void UpdateGrid()
        {
            var salaryMans = DBController.Instance.SalaryMan;

            if (jobTitleComboBox.Text != "Все")
            {
                JobTitle jobTitle = jobTitleComboBox.SelectedItem as JobTitle;
                salaryMans = salaryMans.Where(j => j.JobTitle == jobTitle).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = salaryMans;
        }

        private void PersonalView_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonalDB personalDB = new PersonalDB();
            personalDB.ShowDialog();
        }

        private void PersonalViewDB_Load(object sender, EventArgs e)
        {
            jobTitleComboBox.Items.Add("Все");
            jobTitleComboBox.Items.AddRange(DBController.Instance.JobTitles.ToArray());
            jobTitleComboBox.SelectedIndex = 0;

            UpdateGrid();
        }

        private void PersonaView_QueryButton_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddPersonalDB form = new NewAddPersonalDB();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SalaryManTable salaryMan = dataGridView1.SelectedRows[0].DataBoundItem as SalaryManTable;

                NewAddPersonalDB form = new NewAddPersonalDB(salaryMan);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateGrid();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                SalaryManTable salaryMan = dataGridView1.SelectedRows[0].DataBoundItem as SalaryManTable;

                DBController.Instance.Remove(salaryMan);
                UpdateGrid();
            }
        }

        private void jobTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
