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

        private void CowFarm_ViewDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void CowFarm_EditDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChooseCowFarmDB editCowFarmDBForm = new ChooseCowFarmDB();
            editCowFarmDBForm.ShowDialog();
        }

        private void CowFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LivestockFarm livestockFarmForm = new LivestockFarm();
            livestockFarmForm.ShowDialog();
        }
    }
}
