namespace GeneratorFakeData.Domain.Interfaces.Providers
{
    public interface INameProvider
    {
        public string[] GetPrimaryNames();

        public string[] GetLastNames();

        public string[] GetMotherNames();
    }
}
