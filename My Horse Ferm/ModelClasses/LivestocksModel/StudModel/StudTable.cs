using My_Horse_Ferm.Table_Classes.LivestocksModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.Table_Classes.LivestocksTable.StudModel
{
    [Table("Stud")]
    public class StudTable : LivestockTable
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Color { get; set; }
        public StudGender studGender { get; set; }
    }
}
