using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rxnet14
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Where(_=>false);
            var noElements = subject.IgnoreElements();
           subject.Subscribe(
            i => Console.WriteLine("subject.OnNext({0})", i),
            () => Console.WriteLine("subject.OnCompleted()"));  
            noElements.Subscribe(
            i => Console.WriteLine("noElements.OnNext({0})", i),
            () => Console.WriteLine("noElements.OnCompleted()"));  
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnCompleted();
            Console.Read();
        }
    }
}
