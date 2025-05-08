using System.Text;
using AwesomeGICBank.Console;

namespace AwesomeGICBank.Tests.Console
{
    public class FakeConsole : IConsole
    {
        private readonly StringBuilder _output = new();

        public void WriteLine(string message)
        {
            _output.AppendLine(message);
        }

        public string ReadAndClearOutput()
        {
            return _output.ToString();
        }
    }
}
