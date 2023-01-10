using My_Horse_Ferm.ModelClasses.LivestocksModel.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
using My_Horse_Ferm.ModelClasses;
using My_Horse_Ferm.ModelClasses.LivestocksModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.StudModel;
using My_Horse_Ferm.ModelClasses.PersonModel;
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

        // Person Tables
        public DbSet<PersonTable> Personals { get; set; }
        public DbSet<PeopleGender> PeopleGenders { get; set; }
        public DbSet<SalaryManTable> SalaryMans { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }

        // Livestock Tables
        public DbSet<LivestockTable> Livestockses { get; set; }

        // Stud Tsbles
        public DbSet<StudTable> StudTables { get; set; }
        public DbSet<StudGender> StudGenders { get; set;}
        public DbSet<StudColor> StudColors { get; set; }
        public DbSet<StudBreed> StudBreeds { get; set; }

        // Cow Tables
        public DbSet<CowTable> CowTables { get; set; }
        public DbSet<CowGender> CowGenders { get; set; }
        public DbSet<CowBreed> CowBreeds { get; set; }


    }
}
