namespace My_Horse_Ferm.Table_Classes.LivestocksTable.StudModel
{
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
