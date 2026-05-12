using GeneratorFakeData.Application.UseCase;
using GeneratorFakeData.Domain.Interfaces.Generators;
using GeneratorFakeData.Domain.Interfaces.Providers;
using GeneratorFakeData.Domain.Interfaces.Repository;
using GeneratorFakeData.Infrastructure.Generators;
using GeneratorFakeData.Infrastructure.Provider;
using GeneratorFakeData.Infrastructure.Repository;
using GeneratorFakeData.Presentation.Console;
using GeneratorFakeData.Presentation.Console.MainMenu;
using GeneratorFakeData.Presentation.Console.MainMenu.Options;
using GeneratorFakeData.Presentation.Input;

class Program
{
    static void Main()
    {
        var (generateIdentity, consoleIO) = Initialize("Users");

        Console.Clear();

        bool running = true;

        while (running)
        {
            DisplayMainMenu.Display();

            int option = InputParser.IntParser(consoleIO.ReadInput("Option: "));

            switch (option)
            {
                case 0:
                    running = ExitProgram.Exit();
                    break;

                case 1:
                    generateIdentity.Generate();
                    break;
            }
        }
    }

    static (GenerateIdentity, ConsoleIO) Initialize(string path)
    {
        ConsoleIO consoleIO = new ConsoleIO();

        INameProvider nameProvider = new NameProvider();
        IUserRepository userRepository = new UserRepository(path);

        INameGenerator nameGenerator = new NameGenerator(nameProvider);
        IDateTimeGenerator dateTimeGenerator = new DateTimeGenerator();
        IRGGenerator rGGenerator = new RGGenerator();
        ICPFGenerator cPFGenerator = new CPFGenerator();

        GenerateIdentityUseCase generateUseCase = new GenerateIdentityUseCase(
            nameGenerator,
            userRepository,
            dateTimeGenerator,
            rGGenerator,
            cPFGenerator
        );

        GenerateIdentity generateIdentity = new GenerateIdentity(consoleIO, generateUseCase);

        return (generateIdentity, consoleIO);
    }
}
