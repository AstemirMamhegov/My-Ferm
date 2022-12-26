using My_Horse_Ferm.Livestock.Stud_Farm;
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

        private void StudFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LivestockFarm livestockFarmForm = new LivestockFarm();
            livestockFarmForm.ShowDialog();
        }

        private void StudFarm_EditDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChooseStudFarmDB editStudFarmDBForm = new ChooseStudFarmDB();
            editStudFarmDBForm.ShowDialog();
        }
    }
}
