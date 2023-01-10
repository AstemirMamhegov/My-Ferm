using My_Horse_Ferm.ModelClasses.LivestocksModel.CowModel;
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

namespace My_Horse_Ferm.Livestocks.Cow_Farm
{
    public partial class CowBreedView : Form
    {
        public CowBreedView()
        {
            InitializeComponent();
        }

        private void CowBreedView_Load(object sender, EventArgs e)
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
            NewCowBreedDBFarm newCowBreedDBFarm = new NewCowBreedDBFarm();
            if (newCowBreedDBFarm.ShowDialog() == DialogResult.OK)
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
                CowBreed cowBreed = dataGridView1.SelectedRows[0].DataBoundItem as CowBreed;

                DBController.Instance.Remove(cowBreed);
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
        public void OpenRedact()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CowBreed cowBreed = dataGridView1.SelectedRows[0].DataBoundItem as CowBreed;

                NewCowBreedDBFarm newCowBreedDBFarm = new NewCowBreedDBFarm(cowBreed);
                if (newCowBreedDBFarm.ShowDialog() == DialogResult.OK)
                    UpdateGrid();
            }
        }

        /// <summary>
        /// Функция обновляющая записи в базе данных
        /// </summary>
        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.CowBreeds;
        }

    }
}
