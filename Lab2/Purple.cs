using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                answer += (p + (i * h)) * (p + (i * h));
            }
            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            while (a >= b)
            {
                a -= b;
                quotient++;
                
            }

            remainder = Math.Abs(a);

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            int lastch1 = 1, lastch2 = 2, lastzn1 = 1, lastzn2 = 1, s = 0;
            while (true)
            {
                lastch2 = lastch1 + lastch2;
                lastch1 = lastch2 - lastch1;
                lastzn2 = lastzn1 + lastzn2;
                lastzn1 = lastzn2 - lastzn1;
                double x = (double)lastch2 / lastzn2;
                double y = (double)lastch1 / lastzn1;
                if (Math.Abs(x - y) <= 0.0001)
                {
                    return x;
                    break;
                }
            }
            
        }
        public int Task4(double b, double q)
        {
            int answer = 1;
            double last = b;
            while (true)
            {
                if (Math.Abs(last) < 0.0001)
                {
                    return answer;
                    break;
                }
                last = last * q;
                answer++;
            }
            
            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            return answer;
        }
        public long Task6()
        {
            double answer = 1, last = 1;
            for (int i = 0; i <= 62; i++)
            {
                last *= 2;
                answer = answer + last;
            }

            double y = answer / 15000000;
            
            return (long)y;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            if (S != 0)
            {
                double proc = S * d / 1200;
                double prevS = S;
                while (prevS < 2 * S)
                {
                    if (answer % 12 == 0)
                        proc = prevS * d / 1200;
                    answer += 1;
                    prevS += proc;
                }
            }
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            for (double x = a; x <= b + 0.0001; x += h)
            {
                double elem = 1;
                long fact = 1;
                double ch = 1;
                int i = 0;
                while (Math.Abs(elem) >= 0.0001)
                {
                    int sign = (i % 2 == 0) ? 1 : -1;
                    elem = ch * sign / fact;
                    ch = ch * x * x;
                    SS += elem;
                    i++;
                    fact = fact * (2 * i - 1) * 2 * i;
                }

                SY += Math.Cos(x);

            }
            return (SS, SY);
        }
    }
}