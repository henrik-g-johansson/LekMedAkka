using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Autohandläggaren.Actors;
using Beräkna.Actor;
using EventEntrypoint;
using Shared;
using Ärende.Actors;

namespace Autohandläggaren
{
    public class Initalize
    {
        private ActorSystem FordonsskattActorSystem;
        // Sätt upp aktörsystemet, tar emot alla meddelanden och skyfflar dem vidare!

        public void InitalizeActorSystem()
        {
            FordonsskattActorSystem = ActorSystem.Create("FordonsskattActorSystem");

            FordonsskattActorSystem.ActorOf(Props.Create<AutohandlaggarActor>(), "Autohandlaggar");
            FordonsskattActorSystem.ActorOf(Props.Create<ArendeActor>(), "Arende");
            FordonsskattActorSystem.ActorOf(Props.Create<BeraknaActor>(), "Berakna");

        }

        public void GetWcfContract(EEPMessage message)
        {
            Console.WriteLine("EEP-meddelande: " + message.Message);

            Console.WriteLine("Får wcf anrop...");
            //konvertera EEP till autohandlaggaren
            var arendeInfo = new ArendeInfo();

            var beraknaActor = FordonsskattActorSystem.ActorSelection("/user/Berakna");
            Console.WriteLine("Skickar till BeraknaActor");
            beraknaActor.Tell(arendeInfo);

        }
    }
}
