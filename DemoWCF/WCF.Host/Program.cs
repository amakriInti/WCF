using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Contrat;
using WCF.Services;

namespace WCF.Host
{
    class Program
    {
        private static ServiceHost hote1 = new ServiceHost(typeof(Service1));
        static void Main(string[] args)
        {
            hote1.AddServiceEndpoint(
                typeof(IService1),
                new NetTcpBinding(),
                "net.tcp://localhost:2021/MesServicesWCF"
                );
            hote1.Open();

            Console.WriteLine("Je suis prêt");
            Console.ReadLine();

            hote1.Close();
        }
    }
}
