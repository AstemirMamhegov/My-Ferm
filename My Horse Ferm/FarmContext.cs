using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Horse_Ferm.Table_Classes;
using My_Horse_Ferm.Table_Classes.PersonTable;

namespace My_Horse_Ferm
{
    public class FarmContext : DbContext

    {
        static FarmContext()
        {
            Database.SetInitializer(new MyContextInitializer());
        }

        public FarmContext() : base("MyFerm")
        {
        }

        public DbSet<Person> Personals { get; set; }
        public DbSet<SalaryMan> SalaryMans { get; set;}
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<PeopleGender> PeopleGenders { get; set; }
    }
}
