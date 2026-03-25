namespace GeneratorFakeData.Presentation.Input
{
    public class InputParser
    {
        public static int IntParser(string input)
        {
            int value;

            while (!int.TryParse(input, out value))
            {
                System.Console.WriteLine("Insert a valid number.");
                input = System.Console.ReadLine() ?? "";
            }

            return value;
        }
    }
}
