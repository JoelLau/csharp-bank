using AwesomeGICBank.Console;
using AwesomeGICBank.Commands;

SystemConsole console = new();
MainMenuCommands mainMenuCommands = new(console);

mainMenuCommands.Run();
