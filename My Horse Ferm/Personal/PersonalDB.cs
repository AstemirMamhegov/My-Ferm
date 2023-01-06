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

        private void Personal_ViewDataBaseButton_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            PersonalViewDB personalViewDB = new PersonalViewDB();
            personalViewDB.ShowDialog();
        }


        private void Personal_EditDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChoosePersonalDB editPersonalDB = new ChoosePersonalDB();
            editPersonalDB.ShowDialog();
        }

        private void Personal_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ActionsMenu actionsMenu = new ActionsMenu();
            actionsMenu.ShowDialog();
        }

        private void PersonalDB_Load(object sender, EventArgs e)
        {

        }
    }
}
