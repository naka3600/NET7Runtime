using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{

    [DllImport("libc")]
    private static extern int sigaction(Signal sig, SignalAction act, SignalAction oldact);

    private delegate void SignalAction(int signal);

    private enum Signal
    {
        SIGINT = 2,
        SIGTERM = 15
    }
        
    static void Main(string[] args)
    {

        SignalAction signalHandler = SignalHandler;
        sigaction(Signal.SIGINT, signalHandler, null);
        sigaction(Signal.SIGTERM, signalHandler, null);

        Console.WriteLine("Starting myapp...");
        while (true)
        {
            Console.WriteLine("myapp is running...");
            Thread.Sleep(5000);
        }
    }

    private static void SignalHandler(int signal)
    {
        Console.WriteLine("receive signal");
    }
}
