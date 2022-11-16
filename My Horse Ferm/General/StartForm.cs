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

        private void StartForm_ActionsMenuButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ActionsMenu actionsMenu = new ActionsMenu();
            actionsMenu.ShowDialog();
        }

        private void StartForm_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
