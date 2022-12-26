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

        private void LivestockFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            ActionsMenu actionsMenuForm = new ActionsMenu();
            actionsMenuForm.ShowDialog();
        }

        private void LivestockFarm_StudFarmButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StudFarmDB studFarmDBForm = new StudFarmDB();
            studFarmDBForm.ShowDialog();
        }

        private void LivestockFarm_CowFarmButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CowFarm cowFarmForm = new CowFarm();
            cowFarmForm.ShowDialog();
        }
    }
}
