// See https://aka.ms/new-console-template for more information



public interface ISimpleLogger
{
    void Log(string message);
    void Log(string message, string messageType);
}