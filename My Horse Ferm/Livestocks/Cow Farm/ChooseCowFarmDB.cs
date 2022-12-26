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
    public partial class ChooseCowFarmDB : Form
    {
        public ChooseCowFarmDB()
        {
            InitializeComponent();
        }

        private void EditCowFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CowFarm cowFarmForm = new CowFarm();
            cowFarmForm.ShowDialog();
        }

        private void EditCowFarm_AddDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewAddCowFarmDB newAddCowFarmDBForm = new NewAddCowFarmDB();
            newAddCowFarmDBForm.ShowDialog();
        }

        private void EditCowFarm_EditDataBaseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
