using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241126_PublisherSubscriberDemo
{
    public class Publisher
    {
        private IterationDelegate _newIterationStart;

        //public void Subscribe(IterationDelegate handler)
        //{
        //    _newIterationStart += handler;
        //}

        //public void Unsubscribe(IterationDelegate handler)
        //{
        //    _newIterationStart -= handler;
        //}

        public event IterationDelegate NewIterationStart
        {
            add  // Subscribe
            { 
                _newIterationStart += value;
            }
            remove   // Unsubscribe
            { 
                _newIterationStart -= value; 
            }
        }

        public void Run(int iterationCount = 3)
        {
            for (int i = 0; i < iterationCount; i++) 
            {
                if (_newIterationStart != null)
                {
                    //_newIterationStart(i);
                    _newIterationStart(this, new IterationEventArgs(i));
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Publisher.Run(): i = {0}", i);
            }
        }
    }
}
