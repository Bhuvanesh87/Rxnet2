using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rxnet11
    {
        static void Main(string[] args)
        {
            var evenNumbers = Observable.Range(0, 10)
                              .Where(i => i % 2 == 0)
                               .Subscribe(
                                Console.WriteLine,
                                () => Console.WriteLine("Completed"));
            Console.Read();
        }

      }
}
