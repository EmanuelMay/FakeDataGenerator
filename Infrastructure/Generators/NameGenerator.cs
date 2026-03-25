using GeneratorFakeData.Domain.Interfaces.Generators;
using GeneratorFakeData.Domain.Interfaces.Providers;

namespace GeneratorFakeData.Infrastructure.Generators
{
    public class NameGenerator : INameGenerator
    {
        private readonly INameProvider nameRepository;
        private readonly Random random = new Random();

        public NameGenerator(INameProvider nameRepository)
        {
            this.nameRepository = nameRepository;
        }

        public string GenerateName()
        {
            var primaryNames = this.nameRepository.GetPrimaryNames();
            var lastNames = this.nameRepository.GetLastNames();
            
            var primaryName = primaryNames[this.random.Next(primaryNames.Length)];
            var lastName = lastNames[this.random.Next(lastNames.Length)];

            return $"{primaryName} {lastName}";
        }

        public string GenerateMotherName()
        {
            var motherNames = this.nameRepository.GetMotherNames();
            var lastNames = this.nameRepository.GetLastNames();

            var primaryName = motherNames[this.random.Next(motherNames.Length)];
            var lastName = lastNames[this.random.Next(lastNames.Length)];

            return $"{primaryName} {lastName}";
        }
    }
}
