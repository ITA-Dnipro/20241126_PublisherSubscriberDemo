using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241126_PublisherSubscriberDemo
{
    //public delegate void IterationDelegate(int iterationNumber);
    public delegate void IterationDelegate(object sender, IterationEventArgs args);
}
