using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDbHelper<string> mongoHelper = new MongoDbHelper<string>();
            mongoHelper.Insert("testName", "name");

            Console.ReadLine();
        }
    }
}
