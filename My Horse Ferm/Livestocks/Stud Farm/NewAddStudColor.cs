using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
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
    public partial class NewAddStudColor : Form
    {
        private StudColor studColor;

        public NewAddStudColor(StudColor studColor = null)
        {
            InitializeComponent();
            if(studColor != null)
            {
                this.studColor = studColor;
                NewAddStudColor_StudColorComboBox.Text = studColor.Name;
            }
        }

        /// <summary>
        /// Функция добавляющая запись в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAddStudColor_OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewAddStudColor_StudColorComboBox.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (studColor == null)
            {
                if (DBController.Instance.StudColors.Any(s => s.Name == NewAddStudColor_StudColorComboBox.Text))
                {
                    MessageBox.Show("Должность с таким названием уже существует");
                    return;
                }
                studColor = new StudColor();
            }

            studColor.Name = NewAddStudColor_StudColorComboBox.Text;
            DBController.Instance.Update(studColor);
            DialogResult = DialogResult.OK;
        }
    }
}
