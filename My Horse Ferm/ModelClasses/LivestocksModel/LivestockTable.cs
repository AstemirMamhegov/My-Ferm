using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.ModelClasses.LivestocksModel
{
    [Table("Livestocks")]
    public abstract class LivestockTable
    {
        public int Id { get; set; }
        public int OrdinalNumber { get; set; }
        public int Weight { get; set; }
        public DateTime Birthday { get; set; }
    }
}
