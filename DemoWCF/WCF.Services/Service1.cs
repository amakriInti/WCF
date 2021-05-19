using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Contrat;

namespace WCF.Services
{

    public class Service1 : IService1
    {
        public string Majusucule(string s)
        {
            return s.ToUpper();
        }
    }
}
