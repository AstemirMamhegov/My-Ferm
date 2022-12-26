using My_Horse_Ferm.Table_Classes;
using My_Horse_Ferm.Table_Classes.PersonTable;
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

        public List<SalaryMan> SalaryMan => farmContext.SalaryMans.ToList();

        /// <summary>
        /// Обновление базы данных сотрудника
        /// </summary>
        public void Update(SalaryMan salaryMan)
        {
            if (salaryMan.Id == 0)
                farmContext.SalaryMans.Add(salaryMan);
            farmContext.SaveChanges();
        }

        /// <summary>
        /// Удаление записи в базе данных сотрудника
        /// </summary>
        /// <param name="person"></param>
        public void Remove(SalaryMan salaryMan)
        {
            farmContext.SalaryMans.Remove(salaryMan);
            farmContext.SaveChanges();
        }

        public List<Person> Personals => farmContext.Personals.ToList();

        /// <summary>
        /// Обновление базы данных человека
        /// </summary>
        public void Update(Person person)
        {
            if (person.Id == 0)
                farmContext.Personals.Add(person);
            farmContext.SaveChanges();
        }

        /// <summary>
        /// Удаление записи в базе данных человека
        /// </summary>
        /// <param name="person"></param>
        public void Remove(Person person)
        {
            farmContext.Personals.Remove(person);
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

        #endregion
    }
}
