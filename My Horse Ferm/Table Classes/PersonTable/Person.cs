using My_Horse_Ferm.Table_Classes.PersonTable;
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
        public virtual PeopleGender PeopleGender { get; set; }
        public int Age { get; set; }


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
