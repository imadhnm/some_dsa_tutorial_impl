// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// var list = new LinkedList<int>();
// list.AddFirst(0);
// list.AddLast(1);

// list.Print();
// list.Remove(1);
// // list.Reverse();
// list.Print();

// var stack = new ArrayStack<int>(5);

var stack = new LinkedListStack<int>();
stack.Push(8);
stack.Push(4);
stack.Push(3);
stack.Push(7);
stack.Push(10);

Console.WriteLine(stack.Peek());
stack.Print();

Console.WriteLine(stack.Pop());

Console.WriteLine(stack.Peek());

stack.Print();

Console.WriteLine(stack.Pop());

Console.WriteLine(stack.Peek());

stack.Print();
