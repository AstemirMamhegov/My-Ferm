namespace My_Horse_Ferm.Table_Classes.PersonModel
{
    public class PeopleGender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
