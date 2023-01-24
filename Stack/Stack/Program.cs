// See https://aka.ms/new-console-template for more information
using Stack;

Console.WriteLine("Hello, World!");
Stack.Stack<int> stack = new Stack.Stack<int>();

Console.WriteLine($"First Push: {stack.Push(1)}");
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);
Console.WriteLine("First Stack");
stack.Print();

Console.WriteLine($"Peak: {stack.Peak()}");

Console.WriteLine($"First Pop: {stack.Pop()}");
Console.WriteLine("Stack after pop");
stack.Print();

Console.WriteLine($"Clear: {stack.Clear()}");
Console.WriteLine("Stack after clearing:");
stack.Print();

Console.ReadLine();
