using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rxnet17
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(Console.WriteLine,
            ex => Console.WriteLine("subject OnError : {0}", ex),
            () => Console.WriteLine("Subject completed"));
            var any = subject.Any();
            any.Subscribe(b => Console.WriteLine("The subject has any values? {0}", b),
            ex => Console.WriteLine(".Any() OnError : {0}", ex),
            () => Console.WriteLine(".Any() completed"));
            subject.OnNext(1);
           // subject.OnError(new Exception());
            Console.Read();
        }
    }
}
