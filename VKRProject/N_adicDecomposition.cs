using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace VKRProject
{
    internal class N_adicDecomposition
    {
        //Конструкторы
        public N_adicDecomposition() { }
        public N_adicDecomposition(BigInteger N1, BigInteger u1, int p1)
        {
            h = N1;
            m = u1;
            N = p1;
        }

        //Свойства
        public BigInteger h { private set; get; } = 0;
        public BigInteger m { private set; get; } = 0;
        public int N { set; get; } = 0;


        //Рекуретная функция НОД
        static BigInteger GCD(BigInteger x, BigInteger y)
        {
            if (y == 0)
                return x;
            else
                return GCD(y, x % y);
        }

        //Поиск обратного элемента по модулю
        static (BigInteger, BigInteger, BigInteger) gcdex(BigInteger a, BigInteger b)
        {
            if (a == 0)
                return (b, 0, 1);
            (BigInteger gcd, BigInteger x, BigInteger y) = gcdex(b % a, a);
            return (gcd, y - (b / a) * x, x);
        }
        static BigInteger inverse(BigInteger a, BigInteger m)
        {
            (BigInteger g, BigInteger x, BigInteger y) = gcdex(a, m);
            return g > 1 ? 0 : (x % m + m) % m;
        }

        public BigInteger[] Decompose()
        {
            BigInteger q = h / m;
            BigInteger f = h;
            if (f > 0)
            {
                f = f - ((q + 1) * m);
            }
            else if (f < 0)
            {
                f = f - (q * m);
            }

            int T = 1;
            BigInteger temp = N;
            for (int i = 1; i < m; i++)
            {
                if ((temp % m) == 1)
                {
                    break;
                }
                if (N == m - 1)
                {
                    break;
                }
                temp *= N;
                T++;
            }
            BigInteger NPow = 1;
            BigInteger inverseM = inverse(m, N);

            BigInteger[] a = new BigInteger[T];
            BigInteger[] M = new BigInteger[T];


            M[0] = f;
            a[0] = (f * inverseM) % N;
            if (a[0] < 0)
            {
                a[0] = (N + a[0]) % N;
            }

            for (int i = 1; i < T; i++)
            {
                M[i] = M[i - 1] - a[i - 1] * NPow * m;
                NPow *= N;
                a[i] = (M[i] / NPow * inverseM) % N;
                if (a[i] < 0)
                {
                    a[i] = (N + a[i]) % N;
                }
            }

            return a;
        }
    }
}
