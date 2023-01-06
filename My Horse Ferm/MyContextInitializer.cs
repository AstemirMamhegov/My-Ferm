using My_Horse_Ferm.Table_Classes.LivestocksTable.CowModel;
using My_Horse_Ferm.Table_Classes.LivestocksTable.StudModel;
using My_Horse_Ferm.Table_Classes.PersonModel;
using System.Data.Entity;

namespace My_Horse_Ferm
{
    public class MyContextInitializer : DropCreateDatabaseIfModelChanges<FarmContext>
    {
        protected override void Seed(FarmContext context)
        {
            base.Seed(context);

            string[] jobTitles = { "Пастух", "Конюший", "Управляющий" };
            foreach (var name in jobTitles)
            {
                JobTitle jobTitle = new JobTitle();
                jobTitle.Name = name;
                context.JobTitles.Add(jobTitle);
            }

            string[] peopleGenders = { "Мужской", "Женский"};
            foreach (var name in peopleGenders)
            {
                PeopleGender peopleGender = new PeopleGender();
                peopleGender.Name = name;
                context.PeopleGenders.Add(peopleGender);
            }

            string[] studGenders = { "Конь", "Мерен", "Лошадь" };
            foreach(var name in studGenders)
            {
                StudGender studGender = new StudGender();
                studGender.Name = name;
                context.StudGenders.Add(studGender);
            }

            string[] cowGenders = { "Бык", "Бык-осеменитель", "Корова" };
            foreach(var name in cowGenders)
            {
                CowGender cowGender = new CowGender();
                cowGender.Name = name;
                context.CowGenders.Add(cowGender);
            }

            context.SaveChanges();
        }
    }
}
