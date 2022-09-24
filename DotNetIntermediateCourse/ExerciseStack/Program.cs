// See https://aka.ms/new-console-template for more information
using ExerciseStack;
Console.WriteLine("Stack Implementations");

Stack stack = new Stack();

do
{
    Console.WriteLine("Enter Operation");
    Console.WriteLine("1.PUSH");
    Console.WriteLine("2.POP");
    Console.WriteLine("3.Clear()");
    Console.WriteLine("4.Show()");
    Console.WriteLine();
    int switch_on = Convert.ToInt32(Console.ReadLine());

    switch (switch_on)
    {
        case 1:
            Console.Write("Enter Element : ");
            object value= Console.ReadLine();
            Console.WriteLine();
            stack.Push(value);
            Console.WriteLine();
            break;
        case 2:
            stack.Pop();
            Console.WriteLine();
            break;
        case 3:
           stack.ClearStack();
            Console.WriteLine();
            break;
        case 4:
            stack.show();
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Select Proper Option");
            break;

    }
}
while(true);