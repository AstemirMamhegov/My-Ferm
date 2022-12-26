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
            UpdateGrid();
        }

        private void PersonaView_QueryButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
