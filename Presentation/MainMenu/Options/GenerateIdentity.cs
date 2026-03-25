using GeneratorFakeData.Application.Common;
using GeneratorFakeData.Application.UseCase;
using GeneratorFakeData.Presentation.Input;

namespace GeneratorFakeData.Presentation.Console.MainMenu.Options
{
    public class GenerateIdentity
    {
        private readonly ConsoleIO consoleIO;
        private readonly GenerateIdentityUseCase generateIdentityUseCase;

        public GenerateIdentity(ConsoleIO consoleIO, GenerateIdentityUseCase generateIdentityUseCase)
        {
            this.consoleIO = consoleIO;
            this.generateIdentityUseCase = generateIdentityUseCase;
        }

        public void Generate()
        {
            this.consoleIO.Clear();

            this.consoleIO.WriteLine("=== Generate Identity ===\n");
            int quantity = InputParser.IntParser(this.consoleIO.ReadInput("Quantity: "));

            Result result = this.generateIdentityUseCase.Execute(quantity);

            this.consoleIO.WriteLine($"\n{result.Message}\n");
        }
    }
}
