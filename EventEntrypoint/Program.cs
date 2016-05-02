using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Autohandläggaren;
using Shared;

namespace EventEntrypoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var autohandlaggaren = new Initalize();
            autohandlaggaren.InitalizeActorSystem();
            // skicka till autohandläggaren

            var message = new EEPMessage("HEJ HEJ");

            autohandlaggaren.GetWcfContract(message);

            Console.ReadLine();

        }
    }
}
