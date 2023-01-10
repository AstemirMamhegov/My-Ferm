using My_Horse_Ferm.ModelClasses.LivestocksModel.StudModel;
using My_Horse_Ferm.ModelClasses.LivestocksModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses.LivestocksTable.StudModel
{
    [Table("Stud")]
    public class StudTable : LivestockTable
    {
        public string Names { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        public double Height { get; set; }

        public StudBreed StudBreed { get; set; }
        public StudColor StudColor { get; set; }
        public StudGender StudGender { get; set; }
    }
}
