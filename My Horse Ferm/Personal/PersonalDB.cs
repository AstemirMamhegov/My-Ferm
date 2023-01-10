using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm.Personal
{
    public partial class PersonalDB : Form
    {
        public PersonalDB()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция вызова формы базы данных персонала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Personal_ViewDataBaseButton_Click(object sender, EventArgs e)
        {
            PersonalViewDB personalViewDB = new PersonalViewDB();
            personalViewDB.ShowDialog();
        }

        /// <summary>
        /// Функция вызова базы данных должностей персонала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonalDB_JobTitleButton_Click(object sender, EventArgs e)
        {
            JobTitleViewDB jobTitleViewDB = new JobTitleViewDB();
            jobTitleViewDB.ShowDialog();
        }

        /// <summary>
        /// Функция возврата в меню выбора веток баз данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Personal_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ActionsMenu actionsMenu = new ActionsMenu();
            actionsMenu.ShowDialog();
        }

    }
}
