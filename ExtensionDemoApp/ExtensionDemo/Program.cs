// See https://aka.ms/new-console-template for more information



using CustomExtensions;

"This is a demo".printToConsole();
ISimpleLogger Logger= new SimpleLogger();
Logger.Log("Test Error", "ERror");
Logger.LogError("This is an error");
Logger.LogWarning("This is a warning");
