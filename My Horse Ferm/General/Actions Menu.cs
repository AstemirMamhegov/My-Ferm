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

        private void ActionsMenu_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }

        private void ActionsMenu_LivestockButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LivestockFarm livestockFarm = new LivestockFarm();
            livestockFarm.ShowDialog();
        }

        private void ActionsMenu_PersonalButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonalDB personalDB = new PersonalDB();
            personalDB.ShowDialog();
        }

        private void ActionsMenu_PropertyButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PropertyDB propertyDB = new PropertyDB();
            propertyDB.ShowDialog();
        }
    }
}
