﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Contrat;

namespace WCF.Client
{
    class Program
    {
        private static IService1 service = null;
        private static ChannelFactory<IService1> canal = null;
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            //service = new Service1();
            canal = new ChannelFactory<IService1>(
                new NetTcpBinding(),
                "net.tcp://localhost:2021/MesServicesWCF"
                );
            service = canal.CreateChannel();

            var resultat = service.Majusucule(s);
            Console.WriteLine(resultat);

            Console.ReadLine();
        }
    }
}
