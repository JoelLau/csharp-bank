using AwesomeGICBank.Commands;
using AwesomeGICBank.Tests.Console;

namespace AwesomeGICBank.Tests.Commands
{
    public class MainMenuCommandTests
    {
        [Fact]
        public void Run_WithDefaults_PrintsHelloWorld()
        {
            // Arrange
            FakeConsole mockConsole = new();
            MainMenuCommands command = new(mockConsole);

            // Act
            command.Run();

            String output = mockConsole.ReadAndClearOutput();

            // Assert
            Assert.Contains("Welcome to AwesomeGIC Bank! What would you like to do?", output);
            Assert.Contains("[T] Input transactions", output);
            Assert.Contains("[I] Define interest rules", output);
            Assert.Contains("[P] Print statement", output);
            Assert.Contains("[Q] Quit", output);
        }
    }
}
