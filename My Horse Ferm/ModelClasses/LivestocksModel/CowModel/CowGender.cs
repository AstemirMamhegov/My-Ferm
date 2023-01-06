namespace My_Horse_Ferm.Table_Classes.LivestocksTable.CowModel
{
    public class CowGender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
