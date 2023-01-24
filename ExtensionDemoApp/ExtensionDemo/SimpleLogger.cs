// See https://aka.ms/new-console-template for more information



public class SimpleLogger : ISimpleLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
    public void Log(String message, string messageType)
    {
        Log($"{messageType}:{message}");
    }
}