using AwesomeGICBank.Console;


namespace AwesomeGICBank.Commands
{
    public class MainMenuCommands(IConsole console) : ICommand
    {
        private readonly IConsole _console = console;

        const String MAIN_MENU_PROMPT = @"Welcome to AwesomeGIC Bank! What would you like to do?
[T] Input transactions 
[I] Define interest rules
[P] Print statement
[Q] Quit
> ";

        public void Run()
        {
            _console.WriteLine(MAIN_MENU_PROMPT);
        }
    }
}
