using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241126_PublisherSubscriberDemo
{
    public class IterationEventArgs: EventArgs
    {
        public IterationEventArgs(int iteration) 
        {
            IterationNumber = iteration;
        }

        public int IterationNumber { get; private set; }
    }
}
