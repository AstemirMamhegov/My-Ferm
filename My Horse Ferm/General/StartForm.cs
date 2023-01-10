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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция перехода со стартовой формы в форму выбора ветки баз данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_ActionsMenuButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ActionsMenu actionsMenu = new ActionsMenu();
            actionsMenu.ShowDialog();
        }
        /// <summary>
        /// Функция сворачивания формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
