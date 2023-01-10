using My_Horse_Ferm.ModelClasses.LivestocksModel.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.CowModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm.Livestock.Cow_Farm
{
    public partial class CowFarmDBView : Form
    {
        public CowFarmDBView()
        {
            InitializeComponent();
        }

        private void CowFarmDBView_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            breedChooseComboBox.Items.Add("Все");
            breedChooseComboBox.Items.AddRange(DBController.Instance.CowBreeds.ToArray());
            breedChooseComboBox.SelectedIndex = 0;

            genderChooseComboBox.Items.Add("Все");
            genderChooseComboBox.Items.AddRange(DBController.Instance.CowGenders.ToArray());
            genderChooseComboBox.SelectedIndex = 0;

            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Кнопка меню отвечающая за открытие формы для добавления новой записи в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddCowFarmDB newAddCowFarmDB = new NewAddCowFarmDB();

            if (newAddCowFarmDB.ShowDialog() == DialogResult.OK)
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
                CowTable cowTable = dataGridView1.SelectedRows[0].DataBoundItem as CowTable;

                DBController.Instance.Remove(cowTable);
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
                CowTable cowTable = dataGridView1.SelectedRows[0].DataBoundItem as CowTable;

                NewAddCowFarmDB newAddCowFarmDB = new NewAddCowFarmDB(cowTable);
                if (newAddCowFarmDB.ShowDialog() == DialogResult.OK)
                    UpdateGrid();
            }
        }

        /// <summary>
        /// Функция обновляющая записи в базе данных
        /// </summary>
        private void UpdateGrid()
        {
            var cowTables = DBController.Instance.CowTables;

            if (breedChooseComboBox.Text != "Все")
            {
                CowBreed cowBreed = breedChooseComboBox.SelectedItem as CowBreed;
                cowTables = cowTables.Where(c => c.CowBreed == cowBreed).ToList();
            }
            if (genderChooseComboBox.Text != "Все")
            {
                CowGender cowGender = genderChooseComboBox.SelectedItem as CowGender;
                cowTables = cowTables.Where(c => c.CowGender == cowGender).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cowTables;
        }
    }
}
