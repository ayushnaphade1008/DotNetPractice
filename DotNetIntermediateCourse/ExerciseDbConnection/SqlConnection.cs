using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDbConnection
{
    public class SqlConnection : DbConnections
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Constructor of SqlConnection");
        }

        public override void Close()
        {
            Console.WriteLine("SQL connection Closed");
        }

        public override void Open()
        {
            Console.WriteLine("SQL connection Opened");
        }
    }
}
