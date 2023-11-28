using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stringedsfg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            Thread thread = new Thread(() =>
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.ToString());
                }
            });
            thread.Start();
            thread.Join();
            Console.WriteLine("Main flow enden work.");
        }
    }
}
