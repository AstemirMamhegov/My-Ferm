using My_Horse_Ferm.Livestock.Stud_Farm;
using My_Horse_Ferm.Livestocks.Stud_Farm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm
{
    public partial class StudFarmDB : Form
    {
        public StudFarmDB()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция для возврата в меню выбора веток животных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LivestockFarm livestockFarmForm = new LivestockFarm();
            livestockFarmForm.ShowDialog();
        }

        /// <summary>
        /// Кнопка вызова формы общей базы данных лошадей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudFarm_ViewDataBaseButton_Click(object sender, EventArgs e)
        {
            StudFarmDBView studFarmDBView = new StudFarmDBView();
            studFarmDBView.ShowDialog();
        }

        /// <summary>
        /// Кнопка вызова формы базы данных пород лошадей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudFarm_EditDataBaseButton_Click(object sender, EventArgs e)
        {
            StudBreedFarmDBView studBreedFarmDBView = new StudBreedFarmDBView();
            studBreedFarmDBView.ShowDialog();
        }

        /// <summary>
        /// Кнопка вызова формы базы данных окраса лошадей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudFarmDB_ColorButton_Click(object sender, EventArgs e)
        {
            StudColorFarmDBView studColorFarmDBView = new StudColorFarmDBView();
            studColorFarmDBView.ShowDialog();
        }
    }
}
