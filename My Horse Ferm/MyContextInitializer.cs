using My_Horse_Ferm.Table_Classes.PersonTable;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace My_Horse_Ferm
{
    public class MyContextInitializer : DropCreateDatabaseIfModelChanges<FarmContext>
    {
        protected override void Seed(FarmContext context)
        {
            base.Seed(context);

            string[] jobTitles = { "Пастух", "Конюший", "Управляющий" };
           
            string[] peopleGenders = { "Мужской", "Женский"};

            context.SaveChanges();
        }
    }
}
