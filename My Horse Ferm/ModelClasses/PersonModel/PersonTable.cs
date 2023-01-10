using My_Horse_Ferm.ModelClasses.PersonModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses
{
    [Table("Personal")]
    public abstract class PersonTable
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual PeopleGender PeopleGender { get; set; }


        public string FIO
        {
            get
            {
                return $"{LastName} {FirstName} {MiddleName}";
            }
        }

        public override string ToString()
        {
            return FIO;
        }
       
    }
}
