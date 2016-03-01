using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bozejko_lab1
{
    class Calculations
    {
        
        public int celling(double x)
        {
            //if (x <= 0) return (int)x;
            //return ((int)x) + 1;
            int i = 0;

            if (x >= 0)
            {
                while (i < x)
                {
                    i++;
                }
                return i;
            }
            else
            {
                while (i >= x)
                {
                    i--;
                }
                return i+1;
            }

        }

        public int floor(double x)
        {
            //if (x >= 0) return (int)x;
            //return ((int)x-1);

            int i = 0;
            if (x >= 0)
            {
                while (i <= x)
                {
                    i++;
                }
                return i-1;
            }
            else
            {
                while (i > x)
                {
                    i--;
                }
                return i;
            }


        }

        public int modulo(int x, int y)
        {
            int k = 0;
            int temp = k * y;
            
            while (temp<=x)
            {
                k++;
                temp = k * y;
            }
            if (temp > x) k--;

            return x-k*y;
        }

        public double frac(double x)
        {
            return x - this.floor(x);
        }

        public List<int> primes(int n)
        {
            bool[] numbers = new bool[n+1];

            for (int i = 2; i <= n; i++) numbers[i] = true;

            int max = (int)Math.Sqrt(n);

            for (int i = 2; i <= max; i++)
            {
                if (numbers[i])
                {
                    int j = i + i;
                    while (j <= n)
                    {
                        numbers[j] = false;
                        j += i;
                    }
                }
            }

            List<int> primes = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (numbers[i]) primes.Add(i);
            }

            return primes;

        }
    }
}
