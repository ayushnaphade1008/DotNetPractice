using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDbConnection
{
    public class OracleConnection : DbConnections
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connections Closed");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connections Opened");
        }
    }
}
