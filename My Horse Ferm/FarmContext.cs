using My_Horse_Ferm.Table_Classes;
using My_Horse_Ferm.Table_Classes.LivestocksModel;
using My_Horse_Ferm.Table_Classes.LivestocksTable.CowModel;
using My_Horse_Ferm.Table_Classes.LivestocksTable.StudModel;
using My_Horse_Ferm.Table_Classes.PersonModel;
using System.Data.Entity;


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

        public DbSet<PersonTable> Personals { get; set; }
        public DbSet<PeopleGender> PeopleGenders { get; set; }
        public DbSet<SalaryManTable> SalaryMans { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<LivestockTable> Livestockses { get; set; }
        public DbSet<StudTable> StudTables { get; set; }
        public DbSet<StudGender> StudGenders { get; set;}
        public DbSet<CowTable> CowTables { get; set; }
        public DbSet<CowGender> CowGenders { get; set; }

    }
}
