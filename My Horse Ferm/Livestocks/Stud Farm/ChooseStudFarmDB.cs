using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Horse_Ferm.Livestock.Stud_Farm
{
    public partial class ChooseStudFarmDB : Form
    {
        public ChooseStudFarmDB()
        {
            InitializeComponent();
        }

        private void EditStudFarm_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StudFarmDB studFarmDBForm = new StudFarmDB();
            studFarmDBForm.ShowDialog();
        }

        private void EditStudFarm_AddDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewAddStudFarmDB newAddStudFarmDBForm = new NewAddStudFarmDB();
            newAddStudFarmDBForm.ShowDialog();
        }
    }
}
