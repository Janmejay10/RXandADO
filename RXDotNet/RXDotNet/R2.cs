using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RXDotNet
{
    class Observer : IObserver<int>
    {
        

        public void OnNext(int value)
        {
            // step 3: write a method tat will receive a value from the observable
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();

            Console.WriteLine($"Value received on thread {threadId}: {value}");
        }

        public void OnError(Exception Error)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"error reported on thread {threadId}: {Error.Message}");
        }

        public void OnCompleted()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"observation completed on thread {threadId}.");
        }
    }
}
