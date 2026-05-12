namespace GeneratorFakeData.Presentation.Console
{
    public class ConsoleIO
    {
        public void Clear()
        {
            System.Console.Clear();
        }

        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Write(string message)
        {
            System.Console.Write(message);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine() ?? "";
        }

        public string ReadInput(string message)
        {
            System.Console.Write(message);
            return System.Console.ReadLine() ?? "";
        }
    }
}
