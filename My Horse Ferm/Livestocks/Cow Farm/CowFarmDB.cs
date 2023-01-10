using My_Horse_Ferm.Livestocks.Cow_Farm;
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
    public partial class CowFarm : Form
    {
        public CowFarm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция для возврата в меню выбора веток животных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LivestockFarm livestockFarmForm = new LivestockFarm();
            livestockFarmForm.ShowDialog();
        }

        /// <summary>
        /// Кнопка вызова формы общей базы данных коров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowFarm_ViewDataBaseButton_Click(object sender, EventArgs e)
        {
            CowFarmDBView cowFarmDBView = new CowFarmDBView();
            cowFarmDBView.ShowDialog();
        }
        /// <summary>
        /// Кнопка вызова формы базы данных пород коров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowFarm_BreedDataBaseButton_Click(object sender, EventArgs e)
        {
            CowBreedView editCowFarmDBForm = new CowBreedView();
            editCowFarmDBForm.ShowDialog();
        }
    }
}
