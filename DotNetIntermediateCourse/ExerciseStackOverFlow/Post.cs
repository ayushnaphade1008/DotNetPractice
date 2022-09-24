using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStackOverFlow
{
    public class Post
    {
        public string title { get; set; }
        public string description { get; set; }

        public DateTime dateCreated { get; set; }

       private int votes = 0;



        public void upvote()
        {
            votes++;
            Console.WriteLine($"Current Votes for Post-title {title} is {votes}");

        }

        public void downvote()
        {
            votes--;

            Console.WriteLine($"Current Votes for Post-title {title} is {votes}");

        }
    }
}
