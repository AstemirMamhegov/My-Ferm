using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Horse_Ferm.Table_Classes
{
    [Table("Personal")]
    public abstract class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public PeopleGender PeopleGender { get; set; }
        public string Age { get; set; }
        public string JobTitle { get; set; }
        public string Salary { get; set; }
        public string Experience { get; set; }

        public string Sex
        {
            get
            {
                switch (PeopleGender)
                {
                    case PeopleGender.Male:
                        return "Мужской";
                    case PeopleGender.Female:
                        return "Женский";
                }
                return "Неизвестно";
            }
        }
    }
}
