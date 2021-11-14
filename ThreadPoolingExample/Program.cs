using System;
using System.Threading;


namespace ThreadPoolingExample
{
    class Program
    {           

        static void Main(string[] args)
        {

            string msg = "Hello";
            WaitCallback wc = new WaitCallback(Printf);
            ThreadPool.QueueUserWorkItem(wc, msg);
            Console.ReadLine();

        
        }

        public static void Printf(object ms) 
        {
            while(true){
                Console.WriteLine($"{DateTime.Now} {ms}");
                Thread.Sleep(1000);
            }
        }

    }
}
