namespace AwesomeGICBank.Console
{
    public class SystemConsole : IConsole
    {
        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
