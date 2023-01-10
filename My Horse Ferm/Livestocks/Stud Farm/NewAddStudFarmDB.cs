using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
using My_Horse_Ferm.ModelClasses;
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
    public partial class NewAddStudFarmDB : Form
    {
        private StudTable studTable;

        public NewAddStudFarmDB(StudTable studTable = null)
        {
            InitializeComponent();

            NewAddStudFarm_ColorComboBox.DataSource = DBController.Instance.StudColors;
            NewAddStudFarm_GenderComboBox.DataSource = DBController.Instance.StudGenders;
            NewAddStudFarm_BreedComboBox.DataSource = DBController.Instance.StudBreeds;

            if(studTable != null)
            {
                this.studTable = studTable;

                NewAddStudFarm_NameTextBox.Text = studTable.Names;
                NewAddStudFarm_FatherNameTextBox.Text = studTable.FatherName;
                NewAddStudFarm_MotherNameTextBox.Text = studTable.MotherName;
                NewAddStudFarm_BirthdayDataTimePicker.Value = studTable.Birthday;
                NewAddStudFarm_ColorComboBox.SelectedItem = studTable.StudColor;
                NewAddStudFarm_BreedComboBox.SelectedItem = studTable.StudBreed;
                NewAddStudFarm_GenderComboBox.SelectedItem = studTable.StudGender;
                NewAddStudFarm_HeightNumericUpDown.Value = (int)studTable.Height;
                NewAddStudFarm_WeightNumericUpDown.Value = (int)studTable.Weight;

            }
            
        }

        /// <summary>
        /// Функция добавляющая запись в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAddStudFarm_AddButton_Click(object sender, EventArgs e)
        {
            if (studTable == null)
                studTable = new StudTable();

            studTable.Names = NewAddStudFarm_NameTextBox.Text;
            studTable.FatherName = NewAddStudFarm_FatherNameTextBox.Text;
            studTable.MotherName = NewAddStudFarm_MotherNameTextBox.Text;
            studTable.Birthday = NewAddStudFarm_BirthdayDataTimePicker.Value;
            studTable.StudColor = NewAddStudFarm_ColorComboBox.SelectedItem as StudColor;
            studTable.StudBreed = NewAddStudFarm_BreedComboBox.SelectedItem as StudBreed;
            studTable.StudGender = NewAddStudFarm_GenderComboBox.SelectedItem as StudGender;
            studTable.Weight = (int)NewAddStudFarm_WeightNumericUpDown.Value;
            studTable.Height= (int)NewAddStudFarm_HeightNumericUpDown.Value;

            DBController.Instance.Update(studTable);
            DialogResult = DialogResult.OK;
        }
    }
}
