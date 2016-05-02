using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Shared;

namespace Autohandläggaren.Actors
{
    public class AutohandlaggarActor : ReceiveActor
    {
        public AutohandlaggarActor()
        {
            Receive<ArendeInfo>(message =>
            {

                if (message.HarVaritIBeräkna)
                {
                    //skicka till ärende
                    Console.WriteLine("Skicka till Ärende");
                    var arende = Context.ActorSelection("/user/Arende");
                    arende.Tell(message);

                }
                if (message.HarVaritIÄrende)
                {
                    //completa!
                    Console.WriteLine("Completa!");
                    Console.ReadLine();
                }
            });
        }
    }
}
