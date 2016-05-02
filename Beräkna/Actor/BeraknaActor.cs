using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Shared;

namespace Beräkna.Actor
{
    public class BeraknaActor : ReceiveActor
    {
        public BeraknaActor()
        {
            Receive<ArendeInfo>(message =>
            {
                message.HarVaritIBeräkna = true;
                Console.WriteLine("HarVaritIBeräkna:" + message.HarVaritIBeräkna);
                var ah = Context.ActorSelection("/user/Autohandlaggar");
                ah.Tell(message);
            });
        }
    }
}
