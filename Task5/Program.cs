try
{
    var stack = new Stack<int>();
    
    stack.Push(0);
    stack.Push(2);

    System.Console.WriteLine(stack.Pop());
    System.Console.WriteLine("Oxiron element udalit shid!");
    System.Console.WriteLine(stack.Peek());
}
catch
{
    System.Console.WriteLine("Hatogiro isloh kuned!");
}