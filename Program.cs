// This program will attempt to create a basic stack system from scratch
// Austen Hernandez
// 7.16.26

using Build_Stack.StackFile;

public class Program
{
    public static void Main()
    {
        SimpleStack actionHistory = new SimpleStack();
        actionHistory.Push("Move Forward");
        actionHistory.Push("Open Chest");
        actionHistory.Push("Drink Potion");
        Console.WriteLine($"{actionHistory.Pop()} undone.");
        actionHistory.Peek();
        actionHistory.PrintStack();
    }
}