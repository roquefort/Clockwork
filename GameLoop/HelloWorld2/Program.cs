using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Danny");
            names.Add("Rhys");
            names.Add("fragglestick");
            names.Add("mum");

            var query = from name in names
                        where name == "Rhys"
                        orderby name ascending
                        select name;

            foreach (string sname in query)
            {
                Console.WriteLine(sname);
            }
          //  Console.WriteLine(query);
            Console.ReadKey();
        }
    }
}
