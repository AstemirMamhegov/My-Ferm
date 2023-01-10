using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses.LivestocksTable.StudModel
{
    [Table("StudGender")]
    public class StudGender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
