using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearnObservable
{
    public class Observer : IObserver<int>
    {
        public void OnCompleted()
        {
            var ManagedThreadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Observation completed, current thread:{ManagedThreadId}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"The error: {error.Message}" );
        }

        public void OnNext(int value)
        {
            var ManagedThreadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"The value: {value},ManagedThreadId: {ManagedThreadId} ");
        }
    }
}
