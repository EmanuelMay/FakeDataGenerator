using GeneratorFakeData.Application.Common;
using GeneratorFakeData.Domain.Interfaces.Generators;
using GeneratorFakeData.Domain.Interfaces.Repository;
using GeneratorFakeData.Domain.Models;

namespace GeneratorFakeData.Application.UseCase
{
    public class GenerateIdentityUseCase
    {
        private readonly INameGenerator nameGenerator;
        private readonly IUserRepository userRepository;
        private readonly IDateTimeGenerator dateTimeGenerator;
        private readonly IRGGenerator rGGenerator;
        private readonly ICPFGenerator cPFGenerator;

        public GenerateIdentityUseCase(
            INameGenerator nameGenerator,
            IUserRepository userRepository,
            IDateTimeGenerator dateTimeGenerator,
            IRGGenerator rGGenerator,
            ICPFGenerator cPFGenerator)
        {
            this.nameGenerator = nameGenerator;
            this.userRepository = userRepository;
            this.dateTimeGenerator = dateTimeGenerator;
            this.rGGenerator = rGGenerator;
            this.cPFGenerator = cPFGenerator;
        }

        public Result Execute(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var birthDate = this.dateTimeGenerator.Generate();

                var user = new UserData
                {
                    Name = this.nameGenerator.GenerateName(),
                    BirthDate = birthDate,
                    CPF = this.cPFGenerator.Generate(),
                    RG = this.rGGenerator.Generate(),
                    MotherName = this.nameGenerator.GenerateMotherName()
                };

                this.userRepository.Save(user);
            }

            return Result.Ok("Users created successfully!");
        }
    }
}
