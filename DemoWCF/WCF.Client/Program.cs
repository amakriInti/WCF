using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Contrat;

namespace WCF.Client
{
    // netsh http add urlacl url=http://+:2022/MesServicesWCF user=aliface\alima
    // netsh http delete urlacl url=http://+:2022/MesServicesWCF
    class Program
    {
        private static IService1 service = null;
        private static ChannelFactory<IService1> canal = null;
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            //service = new Service1();
            canal = new ChannelFactory<IService1>("MonAcces");

            service = canal.CreateChannel();

            var resultat = service.Majusucule(s);
            Console.WriteLine(resultat);

            Console.ReadLine();
        }
    }
}
