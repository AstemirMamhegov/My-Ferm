using My_Horse_Ferm.ModelClasses.LivestocksModel.CowModel;
using My_Horse_Ferm.ModelClasses.LivestocksModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses.LivestocksTable.CowModel
{
    [Table("Cow")]
    public class CowTable : LivestockTable
    {
        public CowGender CowGender { get; set; }
        public CowBreed CowBreed { get; set; }
    }
}
