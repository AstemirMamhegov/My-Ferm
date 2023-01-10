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
    public partial class JobTitleViewDB : Form
    {
        public JobTitleViewDB()
        {
            InitializeComponent();
        }

        private void JobTitleViewDB_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        /// <summary>
        /// Кнопка меню отвечающая за открытие формы для добавления новой записи в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddJobTitleDB newAddJobTitleDB = new NewAddJobTitleDB();
            if( newAddJobTitleDB.ShowDialog() == DialogResult.OK)
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
                JobTitle jobTitle = dataGridView1.SelectedRows[0].DataBoundItem as JobTitle;

                if (DBController.Instance.SalaryMan.Any(j => j.JobTitle == jobTitle))
                {
                    MessageBox.Show("Данная должность уже используется");
                    return;
                }

                DBController.Instance.Remove(jobTitle);
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
        /// Функция вызывающая форму для редактирования конкретной, выбранной записи
        /// </summary>
        private void OpenRedact()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                JobTitle jobTitle = dataGridView1.SelectedRows[0].DataBoundItem as JobTitle;

                NewAddJobTitleDB newAddJobTitleDB = new NewAddJobTitleDB(jobTitle);
                if (newAddJobTitleDB.ShowDialog() == DialogResult.OK)
                    UpdateGrid();
            }
        }

        /// <summary>
        /// Функция обновляющая записи в базе данных
        /// </summary>
        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.JobTitles;
        }
    }
}
