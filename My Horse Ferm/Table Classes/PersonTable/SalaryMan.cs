using My_Horse_Ferm.Table_Classes.PersonTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Horse_Ferm.Table_Classes
{
    [Table("SalaryMan")]
    public class SalaryMan : Person
    {
        public virtual JobTitle JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int Experience { get; set; }

    }
}
