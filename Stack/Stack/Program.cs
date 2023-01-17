// See https://aka.ms/new-console-template for more information
using Stack;

Console.WriteLine("Hello, World!");
StackDS<int> stack = new StackDS<int>();
stack.push(1);
stack.push(2);
stack.push(3);
stack.push(4);
stack.push(5);
stack.push(6);
Console.WriteLine("First Stack");
stack.print();

Console.WriteLine("Peak:");
stack.peak();

stack.pop();
Console.WriteLine("Stack after pop");
stack.print();

stack.clear();
Console.WriteLine("Stack after clearing:");
stack.print();

Console.ReadLine();
