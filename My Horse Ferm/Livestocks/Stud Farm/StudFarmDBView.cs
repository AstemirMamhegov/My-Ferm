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

namespace My_Horse_Ferm.Livestock.Stud_Farm
{
    public partial class StudFarmDBView : Form
    {
        public StudFarmDBView()
        {
            InitializeComponent();
        }

        private void StudFarmDBView_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            breedChooseComboBox.Items.Add("Все");
            breedChooseComboBox.Items.AddRange(DBController.Instance.StudBreeds.ToArray());
            breedChooseComboBox.SelectedIndex = 0;

            genderChooseComboBox.Items.Add("Все");
            genderChooseComboBox.Items.AddRange(DBController.Instance.StudGenders.ToArray());
            genderChooseComboBox.SelectedIndex = 0;

            colorStudComboBox.Items.Add("Все");
            colorStudComboBox.Items.AddRange(DBController.Instance.StudColors.ToArray());
            colorStudComboBox.SelectedIndex = 0;

            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Кнопка меню отвечающая за открытие формы для добавления новой записи в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddStudFarmDB newAddStudFarmDB = new NewAddStudFarmDB();

            if (newAddStudFarmDB.ShowDialog() == DialogResult.OK)
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
                StudTable studTable = dataGridView1.SelectedRows[0].DataBoundItem as StudTable;

                DBController.Instance.Remove(studTable);
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
                StudTable studTable = dataGridView1.SelectedRows[0].DataBoundItem as StudTable;

                NewAddStudFarmDB newAddStudFarmDB = new NewAddStudFarmDB(studTable);
                if (newAddStudFarmDB.ShowDialog() == DialogResult.OK)
                    UpdateGrid();
            }
        }

        /// <summary>
        /// Функция обновляющая записи в базе данных
        /// </summary>
        private void UpdateGrid()
        {
            var studTables = DBController.Instance.StudTables;

            if (breedChooseComboBox.Text != "Все")
            {
                StudBreed studBreed = breedChooseComboBox.SelectedItem as StudBreed;
                studTables = studTables.Where(s => s.StudBreed == studBreed).ToList();
            }
            if (genderChooseComboBox.Text != "Все")
            {
                StudGender studGender = genderChooseComboBox.SelectedItem as StudGender;
                studTables = studTables.Where(s => s.StudGender == studGender).ToList();
            }
            if (colorStudComboBox.Text != "Все")
            {
                StudColor studColor = colorStudComboBox.SelectedItem as StudColor;
                studTables = studTables.Where(s => s.StudColor == studColor).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studTables;
        }

        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
