using System;
using Akka.Actor;
using Shared;

namespace Ärende.Actors
{
    public class ArendeActor :ReceiveActor
    {

        public ArendeActor()
        {
            Receive<ArendeInfo>(message =>
            {
                message.HarVaritIÄrende = true;
                Console.WriteLine("HarVaritIÄrende:"+ message.HarVaritIÄrende);
                var ah = Context.ActorSelection("/user/Autohandlaggar");
                ah.Tell(message);
            });
        }
    }
}
