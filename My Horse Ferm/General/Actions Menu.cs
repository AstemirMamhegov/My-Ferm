using My_Horse_Ferm.Personal;
using My_Horse_Ferm.Livestock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Horse_Ferm.Property;

namespace My_Horse_Ferm
{
    public partial class ActionsMenu : Form
    {
        public ActionsMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция позволяющая вернуться в к стартовой форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionsMenu_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }
        /// <summary>
        /// функция позволяющая перети к ветке баз данных различных животных разводимых на ферме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionsMenu_LivestockButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LivestockFarm livestockFarm = new LivestockFarm();
            livestockFarm.ShowDialog();
        }
        /// <summary>
        /// функция пощволяющая перейти к ветке баз данных персонала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionsMenu_PersonalButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonalDB personalDB = new PersonalDB();
            personalDB.ShowDialog();
        }
        /// <summary>
        /// пока еще думаем да
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionsMenu_PropertyButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PropertyDB propertyDB = new PropertyDB();
            propertyDB.ShowDialog();
        }
    }
}
