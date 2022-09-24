// See https://aka.ms/new-console-template for more information
using ExerciseStackOverFlow;
Console.WriteLine("Stack over Flow");
Post post = new Post();
string vote = string.Empty;

    Console.WriteLine("Enter title");
    post.title = Console.ReadLine();
    Console.WriteLine("Enter Description");
    post.description = Console.ReadLine();
    post.dateCreated = DateTime.Now;
    Console.WriteLine($"Date Created {post.dateCreated}");

    
do
{
    Console.WriteLine("Enter Choice");
    Console.WriteLine("1.Up-Vote");
    Console.WriteLine("2.Down-Vote");
    int choice = Convert.ToInt32(Console.ReadLine());
    
        switch (choice)
        {
            case 1:
                post.upvote();
                break;
            case 2:
                post.downvote();
                break;
            default:
                Console.WriteLine("Enter Right Operation");
                break;
        }

        Console.WriteLine("Want To Vote Again");
        vote = Console.ReadLine();
    }
    while (vote == "yes");






