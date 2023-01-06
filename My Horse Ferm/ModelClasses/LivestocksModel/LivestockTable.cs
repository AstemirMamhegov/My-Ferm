using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Horse_Ferm.Table_Classes.LivestocksModel
{
    [Table("Livestocks")]
    public abstract class LivestockTable
    {
        public int Id { get; set; }
        public int OrdinalNumber { get; set; }
        public double Weight { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; }
    }
}
