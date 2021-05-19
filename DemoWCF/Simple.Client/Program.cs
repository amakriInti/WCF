using Simple.Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = Console.ReadLine();
            Service1Client service = new Service1Client();

            var resultat = service.Minuscule(s);
            Console.WriteLine(resultat);

            Console.ReadLine();
        }
    }
}
