using System;
using System.Timers;


//structure of C# Program
namespace codeyp
{
    class Program
    {
        private static Timer aTimer;
        static void Main(string[] args)
        {
            double interval = 1500.0;
            aTimer = new System.Timers.Timer(interval);

            // Hook up the event handler for the Elapsed event.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Only raise the event the first time Interval elapses.
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            // Ensure the event fires before the exit message appears.
            System.Threading.Thread.Sleep((int)interval * 2);
            Console.WriteLine("Press the Enter key to exit the program.");
            Console.ReadLine();
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//identifire : class,method,variable,function or any other user define entity  is called  an identifire.
/*
    public class Program
    {
        static void Main(string[] args)
        {
            int a; //variable name
        }
    } 
 */

//keyword : these are reserved term that the c# compiler has predefined,contextual keyword has special meaning in the context code like get,set,from etc
/*
    public class Program
    {
        static void Main(string[] args)
        {
            int a; //variable name
        }
    } 
 */