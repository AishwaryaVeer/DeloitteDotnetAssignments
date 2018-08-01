using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CardInfoLibrary;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Validate));
            host.Open();
            Console.WriteLine("Server Started....");
            Console.WriteLine("Press any key to close server");
            Console.ReadLine();
        }
    }
}
