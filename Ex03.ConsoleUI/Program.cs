
namespace Ex03.ConsoleUI
{
    // $G$ DSN-001 (-5) Missing base energy provider class with concrete Electric/Gas derived classes.
    internal class Program
    {
        public static void Main()
        {
            // $G$ CSS-999 (-3) Missing blank line after local variable
            UserInterface userInterface = new UserInterface();
            userInterface.RunGarage();
        }
    }
}
