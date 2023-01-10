using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses.PersonModel
{
    [Table("JobTitle")]
    public class JobTitle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
