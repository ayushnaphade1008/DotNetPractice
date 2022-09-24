using ExerciseDbConnection;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Db Connections");
DbConnections dbConnections;
DbCommand command;
string contin=string.Empty;
int index = 0;
int index1 = 0;


do
{

    Console.WriteLine("For Which Database YOu want to Perform operations");
    Console.WriteLine("1.For Oracle Connection");
    Console.WriteLine("2.For SQL Connection");
    int switch_on = Convert.ToInt32(Console.ReadLine());
    //dbConnections.connectionString = Console.ReadLine();
   string strOracle=string.Empty;
    string strsql = string.Empty;


    switch (switch_on)
    {
        case 1:
            do
            {
                Console.WriteLine("Welcome to Oracle Data Base");
                Console.WriteLine("Want to Open Connection");
                Console.WriteLine("1.Open");
                Console.WriteLine("2.Close");
                int connection = Convert.ToInt32(Console.ReadLine());
                string con = Console.ReadLine();
                
                dbConnections = new OracleConnection(con);
                switch (connection)
                {
                    case 1:
                        if (index == 0)
                        {

                            dbConnections.Open();
                            DbCommand dbCommand = new DbCommand("dfdf",dbConnections);
                            dbCommand.Execute();
                            index = 1;

                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Oracle Connection Cant Open Twice");
                        }
                        break;
                    case 2:
                        if (index == 1)
                        {
                            dbConnections.Close();
                            index = 0;
                        }
                        else
                        {
                            Console.WriteLine("Oracle Connection Cant Close Twice");
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Press enter to Perform Same fr Oracle");
                Console.WriteLine("to stop press any key");
                strOracle=Console.ReadLine();   
                
            }
            while (strOracle==string.Empty || strOracle=="" || strOracle==null);
            break;
        case 2:
            do 
            {
                Console.WriteLine("Welcome to SQL Data Base");
                Console.WriteLine("Want to Open Connection");
                Console.WriteLine("1.Open");
                Console.WriteLine("2.Close");
                int connection1 = Convert.ToInt32(Console.ReadLine());

               
                dbConnections = new SqlConnection("ayushkjhfhfdfdfdkjkfhkdjs");

                switch (connection1)
                {
                    case 1:
                        if (index1 == 0)
                        {

                            dbConnections.Open();
                            DbCommand dbCommand = new DbCommand("dfdf", dbConnections);
                            dbCommand.Execute();
                            index1 = 1;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Oracle Connection Cant Open Twice");
                        }
                        break;
                    case 2:
                        if (index1 == 1)
                        {
                            dbConnections.Close();
                            index1 = 0;
                        }
                        else
                        {
                            Console.WriteLine("Oraacle Connection Cant Close Twice");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter Again");
                        break;
                }

                Console.WriteLine("Press enter to Perform Same fr Oracle");
                Console.WriteLine("to stop press any key");
                strOracle = Console.ReadLine();

            }
            while (strsql == string.Empty || strsql == "" || strsql == null);
            break;
        default:
            Console.WriteLine("Enter Correct Operation");
            break;

    }
    Console.WriteLine("Press yes to continue");
    contin = Console.ReadLine();
}
while(contin=="yes");

