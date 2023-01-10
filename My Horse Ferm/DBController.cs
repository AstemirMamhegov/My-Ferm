using My_Horse_Ferm.ModelClasses.LivestocksModel.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
using My_Horse_Ferm.ModelClasses;
using My_Horse_Ferm.ModelClasses.LivestocksModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksTable.StudModel;
using My_Horse_Ferm.ModelClasses.PersonModel;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
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

        #region Update and remove

        //PERSON - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        public List<PersonTable> Personals => farmContext.Personals.ToList();
        /// <summary>
        /// Обновление базы данных человека
        /// </summary>
        public void Update(PersonTable person)
        {
            if (person.Id == 0)
                farmContext.Personals.Add(person);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных человека
        /// </summary>
        /// <param name="person"></param>
        public void Remove(PersonTable person)
        {
            farmContext.Personals.Remove(person);
            farmContext.SaveChanges();
        }

        public List<PeopleGender> PeopleGenders => farmContext.PeopleGenders.ToList();
        /// <summary>
        /// Обновление базы данных гендера людей
        /// </summary>
        public void Update(PeopleGender peopleGender)
        {
            if (peopleGender.Id == 0)
                farmContext.PeopleGenders.Add(peopleGender);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных гендера людей
        /// </summary>
        /// <param name="person"></param>
        public void Remove(PeopleGender peopleGender)
        {
            farmContext.PeopleGenders.Remove(peopleGender);
            farmContext.SaveChanges();
        }

        public List<SalaryManTable> SalaryMan => farmContext.SalaryMans.ToList();
        /// <summary>
        /// Обновление базы данных сотрудника
        /// </summary>
        public void Update(SalaryManTable salaryMan)
        {
            if (salaryMan.Id == 0)
                farmContext.SalaryMans.Add(salaryMan);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных сотрудника
        /// </summary>
        /// <param name="person"></param>
        public void Remove(SalaryManTable salaryMan)
        {
            farmContext.SalaryMans.Remove(salaryMan);
            farmContext.SaveChanges();
        }

        public List<JobTitle> JobTitles => farmContext.JobTitles.ToList();
        /// <summary>
        /// Обновление базы данных должностей персонала
        /// </summary>
        public void Update(JobTitle jobTitle)
        {
            if (jobTitle.Id == 0)
                farmContext.JobTitles.Add(jobTitle);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных должностей персонала
        /// </summary>
        /// <param name="person"></param>
        public void Remove(JobTitle jobTitle)
        {
            farmContext.JobTitles.Remove(jobTitle);
            farmContext.SaveChanges();
        }


        //LIVESTOCK - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        public List<LivestockTable> LivestockTables => farmContext.Livestockses.ToList();
        /// <summary>
        /// Обновление базы данных животных
        /// </summary>
        public void Update(LivestockTable livestockTable)
        {
            if(livestockTable.Id == 0)
                farmContext.Livestockses.Add(livestockTable);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных животных
        /// </summary>
        public void Remove(LivestockTable livestockTable)
        {
            farmContext.Livestockses.Remove(livestockTable);
            farmContext.SaveChanges();
        }


        //COW - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        public List<CowTable> CowTables => farmContext.CowTables.ToList();
        /// <summary>
        /// Обновление базы данных коров
        /// </summary>
        public void Update(CowTable cowTable)
        {
            if (cowTable.Id == 0)
                farmContext.CowTables.Add(cowTable);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных коров
        /// </summary>
        /// <param name="person"></param>
        public void Remove(CowTable cowTable)
        {
            farmContext.CowTables.Remove(cowTable);
            farmContext.SaveChanges();
        }

        public List<CowGender> CowGenders => farmContext.CowGenders.ToList();
        /// <summary>
        /// Обновление базы данных пола коров
        /// </summary>
        public void Update(CowGender cowGenders)
        {
            if (cowGenders.Id == 0)
                farmContext.CowGenders.Add(cowGenders);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных пола коров
        /// </summary>
        /// <param name="person"></param>
        public void Remove(CowGender cowGenders)
        {
            farmContext.CowGenders.Remove(cowGenders);
            farmContext.SaveChanges();
        }

        public List<CowBreed> CowBreeds => farmContext.CowBreeds.ToList();
        /// <summary>
        /// Обновление базы данных породы коров
        /// </summary>
        public void Update(CowBreed cowBreed)
        {
            if (cowBreed.Id == 0)
                farmContext.CowBreeds.Add(cowBreed);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных породы коров
        /// </summary>
        /// <param name="person"></param>
        public void Remove(CowBreed cowBreed)
        {
            farmContext.CowBreeds.Remove(cowBreed);
            farmContext.SaveChanges();
        }

        // STUD - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        public List<StudTable> StudTables => farmContext.StudTables.ToList();
        /// <summary>
        /// Обновление базы данных лошадей
        /// </summary>
        public void Update(StudTable studTable)
        {
            if (studTable.Id == 0)
                farmContext.StudTables.Add(studTable);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных лошадей
        /// </summary>
        /// <param name="person"></param>
        public void Remove(StudTable studTable)
        {
            farmContext.StudTables.Remove(studTable);
            farmContext.SaveChanges();
        }

        public List<StudGender> StudGenders => farmContext.StudGenders.ToList();
        /// <summary>
        /// Обновление базы данных пола лошадей
        /// </summary>
        public void Update(StudGender studGender)
        {
            if (studGender.Id == 0)
                farmContext.StudGenders.Add(studGender);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных лошадей
        /// </summary>
        /// <param name="person"></param>
        public void Remove(StudGender studGender)
        {
            farmContext.StudGenders.Remove(studGender);
            farmContext.SaveChanges();
        }

        public List<StudBreed> StudBreeds => farmContext.StudBreeds.ToList();
        /// <summary>
        /// Обновление базы данных породы лошадей
        /// </summary>
        public void Update(StudBreed studBreed)
        {
            if(studBreed.Id == 0)
                farmContext.StudBreeds.Add(studBreed);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных породы лошадей
        /// </summary>
        /// <param name="studBreed"></param>
        public void Remove(StudBreed studBreed)
        {
            farmContext.StudBreeds.Remove(studBreed);
            farmContext.SaveChanges();
        }

        public List<StudColor> StudColors => farmContext.StudColors.ToList();
        /// <summary>
        /// Обновление базы данных окраса лошадей
        /// </summary>
        public void Update(StudColor studColor)
        {
            if(studColor.Id == 0)
                farmContext.StudColors.Add(studColor);
            farmContext.SaveChanges();
        }
        /// <summary>
        /// Удаление записи в базе данных окраса лошадей
        /// </summary>
        /// <param name="studBreed"></param>
        public void Remove(StudColor studColor)
        {
            farmContext.StudColors.Remove(studColor);
            farmContext.SaveChanges();
        }


        #endregion
    }
}
