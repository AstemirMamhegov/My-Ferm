namespace My_Horse_Ferm.Table_Classes.PersonModel
{
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
