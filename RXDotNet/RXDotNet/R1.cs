using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RXDotNet
{
    class R1
    {
        static void Main(string[] args)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();

            Console.WriteLine($"Program started on main thread with Id {threadId}....");
            // step1: Creating the observable
            var observable = Observable.Range(5, 8);

            // step2: subscribe to the observable
            var subscription = observable.Subscribe(new Observer());

            Console.ReadKey();

            // step4: dispose the subscription when you don't want to listen anymore
            subscription.Dispose();
        }
    }
}
