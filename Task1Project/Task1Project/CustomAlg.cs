using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Project
{
    internal class CustomAlg
    {
        public static long NativeGCD(long a, long b)
        {
            long gcd = 1;
            long d = 2;

            try
            {
                var maxValue = Math.Max(a, b);
                
                for (d = 2; d <= maxValue; d++)
                {
                    if ((a % d == 0) && (b % d == 0))
                    {
                        gcd = d;
                        //Console.WriteLine(gcd.ToString());
                    }                    
                }

                return gcd;
            }
            catch { }
            {
                Console.WriteLine($"NativeGCD Error!!! d={d}, gdc={gcd}");
                return gcd;
            }
        }

        public static long EuclidGCD(long a, long b)
        {
            try
            {
                if((a < 0) || (b < 0)) return 0;

                if (a == 0) return b;
                if (b == 0) return a;

                if (a >= b) return EuclidGCD(a % b, b);
                if (b > a) return EuclidGCD(a, b % a);
            }
            catch { }
            {
                Console.WriteLine($"EuclidGCD Error!!! a={a}, b={b}");
                return 0;
            }
        }

        public static ulong FibRecursive(ulong N)
        {
            try
            {
                if (N <= 0) return 0;
                else if (N == 1) return 1;
                else 
                {
                    return FibRecursive(N - 1) + FibRecursive(N - 2);
                }
            }
            catch { }
            {
                Console.WriteLine($"FibRecursive Error!!! N={N}");
                return 0;
            }
        }

        public static ulong FibArray(ulong N)
        {
            try
            {
                if (N <= 0) return 0;               
                else if (N == 1) return 1;
                else
                {
                    ulong[] F = new ulong[N+1];

                    F[0] = 0; F[1] = 1;

                    for (ulong i = 2; i < N+1; i++) {
                        F[i] = F[i-1] + F[i-2];
                    }
                    
                    return F[N];
                }
            }
            catch { }
            {
                Console.WriteLine($"FibArray Error!!! N={N}");
                return 0;
            }
        }

    }
}
