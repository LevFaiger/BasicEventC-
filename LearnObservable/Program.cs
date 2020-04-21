using System;
using System.Reactive.Linq;
using System.Threading;

namespace LearnObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            var ManagedThreadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"ManagedThreadId : {ManagedThreadId}");
            var observable = Observable.Range(5, 9);
            var subscription = observable.Subscribe(new Observer());
            subscription.Dispose();
        }
    }
}
