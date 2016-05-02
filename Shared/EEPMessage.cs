using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEntrypoint
{
    public class EEPMessage
    {
        public EEPMessage(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
