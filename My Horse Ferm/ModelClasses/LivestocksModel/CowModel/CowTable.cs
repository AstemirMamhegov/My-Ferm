using My_Horse_Ferm.Table_Classes.LivestocksModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.Table_Classes.LivestocksTable.CowModel
{
    [Table("Cow")]
    public class CowTable : LivestockTable
    {
        public CowGender cowGender { get; set; }
    }
}
