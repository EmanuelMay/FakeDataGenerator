namespace GeneratorFakeData.Presentation.Console.MainMenu.Options
{
    public class ExitProgram
    {
        public static bool Exit()
        {
            System.Console.Clear();
            System.Console.WriteLine("Finished program.");
            return false;
        }
    }
}
