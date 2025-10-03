using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double cur_x = 1;
            int i = 1;
            while (n > 0)
            {
                answer += (Math.Sin(i * x)/cur_x);
                cur_x *= x;
                n--;
                i++;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double cur_n = -5, fac_n = 1;
            double value;
            for (int i = 2; i <= n+1; i++)
            {
                value = (double)cur_n / fac_n;
                cur_n *= -5;
                fac_n *= i;
                answer += value;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fib_ra = 0, fib_gor = 1;
            while (n > 1)
            {
                answer += fib_gor;
                fib_gor = fib_gor + fib_ra;
                fib_ra = fib_gor - fib_ra;
                n--;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long s = 0; 
            int c = 0;
            do
            {
                s += (a + (h * c));
                c++;
            } while (s <= L);
            answer = c - 1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                answer += h;
                S *= 2;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double dist = 0;
            int i = 1, f_b = 0, f_c = 0;
            if (S > 42)
            {
                c = 0;
                f_c = 1;
            }
            do
            {
                dist += S;
                if (i == 7)
                {
                    a = dist;
                }
                if ((dist >= 100) && (f_b == 0)) 
                {
                    b = i;
                    f_b = 1;
                }
                S = ((S / 100) * (100 + I));
                if ((S > 42) && (f_c == 0))
                {
                    c = i;
                    f_c = 1;
                }
                i++;
            } while (a * b * f_c == 0);
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double e = 0.0001;
            while (a <= b + e)
            {
                double a_pow = 1;
                long fuc = 1;
                int i = 0;
                do
                {
                    if (i != 0)
                    {
                        fuc *= i;
                    }
                    SS += ((i * 2 + 1) * a_pow / fuc);
                    a_pow *= (a * a);
                    i++;
                } while (Math.Abs((i * 2 + 1) * a_pow / fuc) >= e);
                SY += ((1 + 2 * a * a) * Math.Pow(Math.E, a * a));
                a += h;
            }
            // end

            return (SS, SY);
        }
    }
}