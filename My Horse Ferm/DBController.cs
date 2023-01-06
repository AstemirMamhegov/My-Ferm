using My_Horse_Ferm.Table_Classes;
using My_Horse_Ferm.Table_Classes.LivestocksTable.CowModel;
using My_Horse_Ferm.Table_Classes.LivestocksTable.StudModel;
using My_Horse_Ferm.Table_Classes.PersonModel;
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

        #region Update and remove

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
        /// Обновление базы данных человека
        /// </summary>
        public void Update(PeopleGender peopleGender)
        {
            if (peopleGender.Id == 0)
                farmContext.PeopleGenders.Add(peopleGender);
            farmContext.SaveChanges();
        }

        /// <summary>
        /// Удаление записи в базе данных человека
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
        /// Обновление базы данных человека
        /// </summary>
        public void Update(JobTitle jobTitle)
        {
            if (jobTitle.Id == 0)
                farmContext.JobTitles.Add(jobTitle);
            farmContext.SaveChanges();
        }

        /// <summary>
        /// Удаление записи в базе данных человека
        /// </summary>
        /// <param name="person"></param>
        public void Remove(JobTitle jobTitle)
        {
            farmContext.JobTitles.Remove(jobTitle);
            farmContext.SaveChanges();
        }

        public List<CowTable> CowTables => farmContext.CowTables.ToList();

        /// <summary>
        /// Обновление базы данных человека
        /// </summary>
        public void Update(CowTable cowTable)
        {
            if (cowTable.Id == 0)
                farmContext.CowTables.Add(cowTable);
            farmContext.SaveChanges();
        }

        /// <summary>
        /// Удаление записи в базе данных человека
        /// </summary>
        /// <param name="person"></param>
        public void Remove(CowTable cowTable)
        {
            farmContext.CowTables.Remove(cowTable);
            farmContext.SaveChanges();
        }

        public List<CowGender> CowGenders => farmContext.CowGenders.ToList();

        /// <summary>
        /// Обновление базы данных человека
        /// </summary>
        public void Update(CowGender cowGenders)
        {
            if (cowGenders.Id == 0)
                farmContext.CowGenders.Add(cowGenders);
            farmContext.SaveChanges();
        }

        /// <summary>
        /// Удаление записи в базе данных человека
        /// </summary>
        /// <param name="person"></param>
        public void Remove(CowGender cowGenders)
        {
            farmContext.CowGenders.Remove(cowGenders);
            farmContext.SaveChanges();
        }

        public List<StudTable> StudTables => farmContext.StudTables.ToList();

        public void Update(StudTable studTable)
        {
            if (studTable.Id == 0)
                farmContext.StudTables.Add(studTable);
            farmContext.SaveChanges();
        }

        public void Delete(StudTable studTable)
        {
            farmContext.StudTables.Remove(studTable);
            farmContext.SaveChanges();
        }

        public List<StudGender> StudGenders => farmContext.StudGenders.ToList();

        public void Update(StudGender studGender)
        {
            if (studGender.Id == 0)
                farmContext.StudGenders.Add(studGender);
            farmContext.SaveChanges();
        }

        public void Delete(StudGender studGender)
        {
            farmContext.StudGenders.Remove(studGender);
            farmContext.SaveChanges();
        }

        #endregion
    }
}
