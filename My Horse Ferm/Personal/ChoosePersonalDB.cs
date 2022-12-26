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
    public partial class ChoosePersonalDB : Form
    {
        public ChoosePersonalDB()
        {
            InitializeComponent();
        }

        private void EditPersonal_BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PersonalViewDB personalViewDBForm = new PersonalViewDB();
            personalViewDBForm.ShowDialog();
        }

        private void EditPersonal_AddDataBaseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewAddPersonalDB newAddPersonalDB = new NewAddPersonalDB();
            newAddPersonalDB.ShowDialog();
        }
    }
}
