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
    class R3
    {
        static void Main(string[] args)
        {
            //step1: create an observable

            var observable = Observable.Range(5, 8);

            IObserver<int> observer = Observer.Create<int>(
                //step3:receive a value from the observable via OnNext hadler
                Console.WriteLine, /*OnNext handler*/
                (error) => { Console.WriteLine($"Error:{error.Message}"); }, /* OnError Handle*/
                () => { Console.WriteLine("observation completed"); } /*OnComplete handler*/

                );


            //step2: subscribe to the observable
            var subscription = observable.Subscribe(observer)               
            Console.ReadKey();

            //step4:
            //dispose off the subscription when you are done observing
            subscription.Dispose();
        }
    }
}
