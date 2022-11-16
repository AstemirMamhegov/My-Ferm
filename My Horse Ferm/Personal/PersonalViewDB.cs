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
            var personals = DBController.Instance.Personals;

            //if (comboBoxCourse.Text != "Все" && comboBoxCourse.Text != "")
            //{
            //    int course = int.Parse(comboBoxCourse.Text);
            //    students = students.Where(t => t.Course == course).ToList();
            //}

            //if (comboBoxDirection.Text != "Все" && comboBoxDirection.Text != "")
            //{
            //    Direction direction = comboBoxDirection.SelectedItem as Direction;
            //    students = students.Where(t => t.Direction == direction).ToList();
            //}

            //if (comboBoxGroup.Text != "Все" && comboBoxGroup.Text != "")
            //{
            //    Group group = comboBoxGroup.SelectedItem as Group;
            //    students = students.Where(t => t.Group == group).ToList();
            //}

            //if (comboBoxMark.Text != "Все" && comboBoxMark.Text != "")
            //{
            //    if (comboBoxMark.SelectedIndex == 1)
            //        students = students.Where(t => t.Marks.Count(p => p.Mark == 5) >= 0.75 * t.Marks.Count && t.Marks.Count(p => p.Mark < 4) == 0).ToList();
            //    else if (comboBoxMark.SelectedIndex == 2)
            //        students = students.Where(t => t.Marks.Count(p => p.Mark == 5) < 0.75 * t.Marks.Count && t.Marks.Count(p => p.Mark < 4) == 0).ToList();
            //    else if (comboBoxMark.SelectedIndex == 3)
            //        students = students.Where(t => t.Marks.Count(p => p.Mark == 3) > 0 && t.Marks.Count(p => p.Mark == 2) == 0).ToList();
            //    else
            //        students = students.Where(t => t.Marks.Count(p => p.Mark == 2) > 0).ToList();
            //}

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personals;
        }

        private void PersonalView_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonalDB personalDB = new PersonalDB();
            personalDB.ShowDialog();
        }

        private void PersonalViewDB_Load(object sender, EventArgs e)
        {
            
        }

    }
}
