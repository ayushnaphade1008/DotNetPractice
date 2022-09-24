using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEngine
{
    public interface IActivities
    {
        void Execute();
    }
    public class WorkFlowEngine
    {
       List<IActivities> activities = new List<IActivities>();

       public void Run()
        {
            foreach (var item in activities)
            {
                item.Execute();

            }

        }
    }

}
