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
    public partial class NewAddStudBreed : Form
    {
        private StudBreed StudBreed;

        public NewAddStudBreed(StudBreed studBreed = null)
        {
            InitializeComponent();

            if(studBreed != null)
            {
                this.StudBreed = studBreed;
                NewAddStudBreed_StudBreedComboBox.Text = studBreed.Name;
            }
        }

        /// <summary>
        /// Функция добавляющая запись в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAddStudBreed_OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewAddStudBreed_StudBreedComboBox.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (StudBreed == null)
            {
                if (DBController.Instance.StudBreeds.Any(t => t.Name == NewAddStudBreed_StudBreedComboBox.Text))
                {
                    MessageBox.Show("Должность с таким названием уже существует");
                    return;
                }
                StudBreed = new StudBreed();
            }

            StudBreed.Name = NewAddStudBreed_StudBreedComboBox.Text;
            DBController.Instance.Update(StudBreed);
            DialogResult = DialogResult.OK;
        }
    }
}
