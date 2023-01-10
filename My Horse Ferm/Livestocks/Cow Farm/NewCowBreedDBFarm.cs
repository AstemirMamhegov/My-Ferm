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
    public partial class NewCowBreedDBFarm : Form
    {
        private CowBreed cowBreed;

        public NewCowBreedDBFarm(CowBreed cowBreed = null)
        {
            InitializeComponent();

            if (cowBreed != null)
            {
                this.cowBreed = cowBreed;
                NewAddCowBreed_CowBreedComboBox.Text = cowBreed.Name;
            }
        }

        /// <summary>
        /// Функция добавляющая запись в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAddCowBreed_OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewAddCowBreed_CowBreedComboBox.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (cowBreed == null)
            {
                if (DBController.Instance.CowBreeds.Any(t => t.Name == NewAddCowBreed_CowBreedComboBox.Text))
                {
                    MessageBox.Show("Должность с таким названием уже существует");
                    return;
                }
                cowBreed = new CowBreed();
            }

            cowBreed.Name = NewAddCowBreed_CowBreedComboBox.Text;
            DBController.Instance.Update(cowBreed);

            DialogResult = DialogResult.OK;
        }
    }
}
