using My_Horse_Ferm.Livestock.Cow_Farm;
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
    public partial class LivestockFarm : Form
    {
        public LivestockFarm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция позволяющая открыть вернуться в меню выборки веток баз данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LivestockFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            ActionsMenu actionsMenuForm = new ActionsMenu();
            actionsMenuForm.ShowDialog();
        }
        /// <summary>
        /// Функция позволяющая открыть ветку баз данных лошадей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LivestockFarm_StudFarmButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StudFarmDB studFarmDBForm = new StudFarmDB();
            studFarmDBForm.ShowDialog();
        }
        /// <summary>
        /// Функция позволяющая открыть ветку баз данных коров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LivestockFarm_CowFarmButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CowFarm cowFarmForm = new CowFarm();
            cowFarmForm.ShowDialog();
        }
    }
}
