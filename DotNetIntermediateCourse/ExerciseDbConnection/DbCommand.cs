using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDbConnection
{
    public class DbCommand
    {
        private string instruction=string.Empty;
        private DbConnections dbConnections;
        public DbCommand(string instruction,DbConnections dbConnection)
        {
            this.instruction = instruction;
            this.dbConnections = dbConnection;
        }

        public void Execute()
        {
            Console.WriteLine("Execued");
        }
    }
}
