using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDbConnection
{
    public abstract class DbConnections
    {
        private string connectionString;
        public TimeSpan timeSpan { get; set; }

        public DbConnections(string connectionString)
        {

            this.connectionString = connectionString;
            

        }
        
        public abstract void Open();
        public abstract void Close();
    }
}
