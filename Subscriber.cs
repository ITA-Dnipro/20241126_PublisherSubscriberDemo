using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241126_PublisherSubscriberDemo
{
    public class Subscriber
    {
        private int _totalIterationCount = 0;

        public int TotalIterationCount
        {
            get 
            { 
                return _totalIterationCount; 
            }
        }

        public Subscriber(Publisher p)
        {
            p.NewIterationStart += Calculate;
        }

        //private void Calculate(int iter)
        //private void Calculate(object sender, IterationEventArgs args)
        private void Calculate(object sender, EventArgs args)
        {
            _totalIterationCount++;
        }
    }
}
