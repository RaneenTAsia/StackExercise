// See https://aka.ms/new-console-template for more information
namespace CustomExtensions
{
    public static class Extensions
    {
        public static void printToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }
}
