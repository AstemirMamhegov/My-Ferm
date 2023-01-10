using My_Horse_Ferm.ModelClasses;
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
using My_Horse_Ferm.ModelClasses.PersonModel;

namespace My_Horse_Ferm.Personal
{
    public partial class PersonalViewDB : Form
    {
        public PersonalViewDB()
        {
            InitializeComponent();
        }

        private void PersonalViewDB_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            jobTitleComboBox.Items.Add("Все");
            jobTitleComboBox.Items.AddRange(DBController.Instance.JobTitles.ToArray());
            jobTitleComboBox.SelectedIndex = 0;

            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Кнопка меню отвечающая за открытие формы для добавления новой записи в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddPersonalDB form = new NewAddPersonalDB();
            if (form.ShowDialog() == DialogResult.OK)
                UpdateGrid();
        }
        /// <summary>
        /// Кнопка меню отвечающая за редактирование конкретной записи выбранной в базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRedact();
        }
        /// <summary>
        /// Кнопка меню отвечающая за удаление конкретной, выбранной записи из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SalaryManTable salaryMan = dataGridView1.SelectedRows[0].DataBoundItem as SalaryManTable;

                DBController.Instance.Remove(salaryMan);
                UpdateGrid();
            }
        }
        /// <summary>
        /// Кнопка меню отвечающая за обновление базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        /// <summary>
        /// Функция позволяющая двойным нажатием вызвать функцию OpenRedact()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenRedact();
        }

        /// <summary>
        /// Функция фильтрующая записи в базе данных в зависимости от выбранной записи в комбо боксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        /// <summary>
        /// Функция вызывающая форму для редактирования конкретной, выбранной записи
        /// </summary>
        private void OpenRedact()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SalaryManTable salaryMan = dataGridView1.SelectedRows[0].DataBoundItem as SalaryManTable;

                NewAddPersonalDB form = new NewAddPersonalDB(salaryMan);
                if (form.ShowDialog() == DialogResult.OK)
                    UpdateGrid();
            }
        }

        /// <summary>
        /// Функция обновляющая записи в базе данных
        /// </summary>
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
    }
}
