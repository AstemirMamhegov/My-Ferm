using My_Horse_Ferm.Table_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Horse_Ferm
{
    public class DBController
    {
        private static DBController instance = new DBController();
        private FarmContext farmContext = new FarmContext();

        public static DBController Instance
        {
            get
            {
                return instance;
            }
        }

        private DBController() { }

        public List<Person> Personals => farmContext.Personals.ToList();

        public void Update(Person person)
        {
            if (person.Id == 0)
                farmContext.Personals.Add(person);
            farmContext.SaveChanges();
        }

        public void Remove(Person person)
        {
            farmContext.Personals.Remove(person);
            farmContext.SaveChanges();
        }
    }
}
