using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStopWatch
{
    public class StopWatch
    {
        
        static TimeSpan EndTime;
        static DateTime StartTime;


        public static void Start()
        {
            StartTime = DateTime.Now;
        }
        public static TimeSpan End()
        {
            EndTime= DateTime.Now - StartTime;
            return EndTime;
        }
    }
}
