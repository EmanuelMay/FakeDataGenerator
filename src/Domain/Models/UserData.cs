namespace GeneratorFakeData.Domain.Models
{
    public class UserData
    {
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; } = "";
        public string RG { get; set; } = "";
        public string MotherName { get; set; } = "";
        public int Age {
            get
            {
                var age = DateTime.Now.Year - BirthDate.Year;

                if (DateTime.Now < BirthDate.AddYears(age))
                    age--;

                return age;
            }
        }
    }
}
