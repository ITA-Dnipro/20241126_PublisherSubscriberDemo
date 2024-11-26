namespace _20241126_PublisherSubscriberDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher p1 = new Publisher();

            Subscriber s1 = new Subscriber(p1);

            p1.Run();

            p1.NewIterationStart += Handler1;    //p1.Subscribe(Handler1);
            p1.NewIterationStart += Handler2;    // p1.Subscribe(Handler2);

            Console.WriteLine();
            p1.Run(5);

            Console.WriteLine();

            p1.NewIterationStart -= Handler1;    //p1.Unsubscribe(Handler1);

            Console.WriteLine();
            p1.Run();

            Console.WriteLine("TotalIterationCount: {0}", s1.TotalIterationCount);
        }

        //public static void Handler1(int iter)
        public static void Handler1(object sender, IterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\tstatic Program.Handler1(): i = {0}", iter);
            Console.WriteLine("\tstatic Program.Handler1(): i = {0}", args.IterationNumber);
        }
        
       // public static void Handler2(int iter)
        public static void Handler2(object sender, IterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\t\tstatic Program.Handler2(): i = {0}", iter);
            Console.WriteLine("\t\tstatic Program.Handler2(): i = {0}", args.IterationNumber);
        }
    }
}