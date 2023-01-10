using My_Horse_Ferm.ModelClasses.LivestocksModel.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.StudModel;
using My_Horse_Ferm.ModelClasses.PersonModel;
using System.Data.Entity;

namespace My_Horse_Ferm
{
    public class MyContextInitializer : DropCreateDatabaseIfModelChanges<FarmContext>
    {
        protected override void Seed(FarmContext context)
        {
            base.Seed(context);

            //Person
            string[] jobTitles = { "Пастух", "Конюший", "Управляющий" };
            foreach (var name in jobTitles)
            {
                JobTitle jobTitle = new JobTitle();
                jobTitle.Name = name;
                context.JobTitles.Add(jobTitle);
            }

            string[] peopleGenders = { "Мужской", "Женский" };
            foreach (var name in peopleGenders)
            {
                PeopleGender peopleGender = new PeopleGender();
                peopleGender.Name = name;
                context.PeopleGenders.Add(peopleGender);
            }

            //Stud
            string[] studGenders = { "Конь", "Мерен", "Лошадь" };
            foreach (var name in studGenders)
            {
                StudGender studGender = new StudGender();
                studGender.Name = name;
                context.StudGenders.Add(studGender);
            }

            string[] studColors = { "Черный", "Гнедой", "Белый" };
            foreach (var name in studColors)
            {
                StudColor studColor = new StudColor();
                studColor.Name = name;
                context.StudColors.Add(studColor);
            }

            string[] studBreeds = { "Кабардинская", "Чистокровная", "Арабская" };
            foreach (var name in studBreeds)
            {
                StudBreed studBreed = new StudBreed();
                studBreed.Name = name;
                context.StudBreeds.Add(studBreed);
            }

            //Cow
            string[] cowGenders = { "Бык", "Бык-осеменитель", "Корова" };
            foreach (var name in cowGenders)
            {
                CowGender cowGender = new CowGender();
                cowGender.Name = name;
                context.CowGenders.Add(cowGender);
            }

            string[] cowBreeds = { "Ангус", "Обычная" };
            foreach (var name in cowBreeds)
            {
                CowBreed cowBreed = new CowBreed();
                cowBreed.Name = name;
                context.CowBreeds.Add(cowBreed);
            }

            context.SaveChanges();
        }
    }
}
