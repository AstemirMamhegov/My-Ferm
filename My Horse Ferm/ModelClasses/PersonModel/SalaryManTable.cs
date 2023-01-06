using My_Horse_Ferm.Table_Classes.PersonModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.Table_Classes
{
    [Table("SalaryMan")]
    public class SalaryManTable : PersonTable
    {
        public virtual JobTitle JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int Experience { get; set; }

    }
}
