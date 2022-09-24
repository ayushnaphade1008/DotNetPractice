// See https://aka.ms/new-console-template for more information
using ExerciseStopWatch;
Console.WriteLine("StopWatch Excercise ");


Console.WriteLine("Start the Watch");
int iteration = 0;
string end = string.Empty;

do
{
    
    Console.WriteLine("Press 1 to Start");
    Console.WriteLine("Press 2 to End");
    int switchOn = Convert.ToInt32(Console.ReadLine());

    switch (switchOn)
    {
        case 1:
            if(iteration == 0)
            {
                StopWatch.Start();
                Console.WriteLine("StopWatch is Running");
                iteration=1;
                break;
            }
            else
            {
                Console.WriteLine("Oppss,U cant Start it twice");
            }
            
            break;
        case 2:
            if(iteration == 1)
            {
                Console.WriteLine($"EndTime is {StopWatch.End()}");
                iteration = 0;
            }
            else
            {
                Console.WriteLine("You cant End the Watch before Start");
                break;
            }
            
            break;
        default:
            Console.WriteLine("Perform Operation Again");
            break;
    }

    Console.WriteLine("Do you want to continue");
    end = Console.ReadLine();
    
}
while (end=="yes" || end=="Yes" || end=="YES");