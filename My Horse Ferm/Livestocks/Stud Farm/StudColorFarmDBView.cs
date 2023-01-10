using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.StudModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm.Livestocks.Stud_Farm
{
    public partial class StudColorFarmDBView : Form
    {
        public StudColorFarmDBView()
        {
            InitializeComponent();
        }


        private void StudColorFarmDBView_Load(object sender, EventArgs e)
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
            NewAddStudColor newAddStudColor = new NewAddStudColor();
            if (newAddStudColor.ShowDialog() == DialogResult.OK)
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
                StudColor studColor = dataGridView1.SelectedRows[0].DataBoundItem as StudColor;

                DBController.Instance.Remove(studColor);
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
                StudColor studColor = dataGridView1.SelectedRows[0].DataBoundItem as StudColor;

                NewAddStudColor newAddStudColor = new NewAddStudColor(studColor);
                if (newAddStudColor.ShowDialog() == DialogResult.OK)
                    UpdateGrid();
            }
        }

        /// <summary>
        /// Функция обновляющая записи в базе данных
        /// </summary>
        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.StudColors;
        }
    }
}
