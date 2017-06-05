using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string html =
                @"select * from Table 
                    where id > 10
                    ";
            Console.WriteLine(html);

            string path = @"C:\xampp\htdoc\";
            Console.WriteLine(path);

            dynamic a = 3;
            dynamic b = 5;
            Console.WriteLine (a+b);
        }
    }
}
  