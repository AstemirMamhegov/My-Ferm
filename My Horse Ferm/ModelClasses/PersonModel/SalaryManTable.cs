using My_Horse_Ferm.ModelClasses.PersonModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses
{
    [Table("SalaryMan")]
    public class SalaryManTable : PersonTable
    {
        public virtual JobTitle JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int Experience { get; set; }

    }
}
