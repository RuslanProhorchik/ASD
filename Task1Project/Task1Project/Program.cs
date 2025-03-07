using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //NativeGCDTest(8723462536745223, 765412221883);
            //NativeGCDTest(2973948729384212, 87268364827634);
            //NativeGCDTest(1098304287349821, 125367765723);
            //NativeGCDTest(2987349872934234, 78238486224);

            //NativeGCDTest(1500000, 1000000);
            //EuclidGCDTest(1500000, 1000000);

            //for (int i = 0; i < 10; i++)
            //{
            //    FibRecursiveTest(i);
            //}

            //FibRecursiveTest(15);
            //FibRecursiveTest(25);
            //FibRecursiveTest(30);

            //for (int i = 0; i < 10; i++)
            //{
            //    FibArrayTest(i);
            //}

            //FibRecursiveTest(3);
            //FibArrayTest(3);

            FibRecursiveTest(40);
            FibRecursiveTest(45);
            FibRecursiveTest(50);

            FibArrayTest(40);
            FibArrayTest(45);
            FibArrayTest(50);


            //FibArrayTest(100);
            //FibArrayTest(250);
            //FibArrayTest(500);
            //FibArrayTest(1000);
            //FibArrayTest(5000);

            Console.ReadKey();
        }

        static void NativeGCDTest(long a, long b)
        {
            Console.WriteLine();
            Console.Write($"Native GCD test a={a}, b={b}");
            using (var item = Meter.Job())
            {
                Console.Write($" gcd={CustomAlg.NativeGCD(a, b)}");                
            }                
        }

        static void EuclidGCDTest(long a, long b)
        {
            Console.WriteLine();
            Console.Write($"Euclid GCD test a={a}, b={b}");
            using (var item = Meter.Job())
            {
                Console.Write($" gcd={CustomAlg.EuclidGCD(a, b)}");
            }
        }

        static void FibRecursiveTest(ulong N)
        {
            Console.WriteLine();
            Console.Write($"Fib Recursive test N={N}");
            using (var item = Meter.Job())
            {
                Console.Write($" Fib={CustomAlg.FibRecursive(N)}");
            }
        }

        static void FibArrayTest(ulong N)
        {
            Console.WriteLine();
            Console.Write($"Fib Array test N={N}");
            using (var item = Meter.Job())
            {
                Console.Write($" Fib={CustomAlg.FibArray(N)}");
            }
        }

    }
}
