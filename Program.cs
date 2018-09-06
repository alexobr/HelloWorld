using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is:");
            Console.WriteLine(DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
