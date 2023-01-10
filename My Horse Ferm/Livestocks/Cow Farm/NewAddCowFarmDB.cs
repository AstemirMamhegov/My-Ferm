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
    public partial class NewAddCowFarmDB : Form
    {
        private CowTable cowTable;

        public NewAddCowFarmDB(CowTable cowTable = null)
        {
            InitializeComponent();

            NewAddCowFarm_BreedComboBox.DataSource = DBController.Instance.CowBreeds;
            NewAddCowFarm_GenderComboBox.DataSource = DBController.Instance.CowGenders;

            if (cowTable != null)
            {
                this.cowTable = cowTable;

                NewAddCowFarm_SerialNumberNumericUpDown.Value = cowTable.OrdinalNumber;
                NewAddCowFarm_BirthdayDateTimePicker.Value = cowTable.Birthday;
                NewAddCowFarm_WeightNumericUpDown.Value = cowTable.Weight;
                NewAddCowFarm_BreedComboBox.SelectedItem = cowTable.CowBreed;
                NewAddCowFarm_GenderComboBox.SelectedItem = cowTable.CowGender;
            }
        }

        /// <summary>
        /// Функция добавляющая запись в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAddCowFarm_AddButton_Click(object sender, EventArgs e)
        {
            if (cowTable == null)
                cowTable = new CowTable();


            cowTable.OrdinalNumber = (int)NewAddCowFarm_SerialNumberNumericUpDown.Value;
            cowTable.Birthday = NewAddCowFarm_BirthdayDateTimePicker.Value;
            cowTable.Weight = (int)NewAddCowFarm_WeightNumericUpDown.Value;
            cowTable.CowBreed = NewAddCowFarm_BreedComboBox.SelectedItem as CowBreed;
            cowTable.CowGender = NewAddCowFarm_GenderComboBox.SelectedItem as CowGender;

            DBController.Instance.Update(cowTable);
            DialogResult = DialogResult.OK;
        }
    }
}
