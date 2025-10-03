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

            // code here

            for (int i = 0; i < n; i++)
            {
                answer += (p + h * i) * (p + h * i);
            }

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

            const double e = 1e-4;
            double a1 = 1, a2 = 2, b1 = 1, b2 = 1;
            while (Math.Abs(a2 / b2 - a1 / b1) >= e)
            {
                (a1, a2) = (a2, a1 + a2);
                (b1, b2) = (b2, b1 + b2);
            }
            answer = a2 / b2;

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;

            // code here

            const double e = 1e-4;
            while (Math.Abs(b) >= e)
            {
                b *= q;
                answer++;
            }

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

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

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code 

            double g = 1, s = 0;
            for (int i = 0; i < 8 * 8; i++)
            {
                s += g / 15000000;
                g *= 2;
            }
            answer = (long)s;

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            double sum = S, p = 0;
            int m = 0;
            while (sum < S * 2)
            {
                m++;
                if ((m - 1) % 12 == 0)
                {
                    p = sum * d / 1200;
                }
                sum += p;
            }
            answer = m;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            const double e = 1e-4;
            for (double x = a; x <= b + 0.0001; x += h)
            {
                double s = 0, v = 1, p1 = 1, p2 = 1, p3 = 1, j = 1;
                while (Math.Abs(v) >= e)
                {
                    v = p1 * p2 / p3;
                    s += v;
                    p1 *= -1;
                    p2 *= x * x;
                    p3 *= j * (j + 1);
                    j += 2;
                }
                SS += s;
                SY += Math.Cos(x);
            }

            // end

            return (SS, SY);
        }
    }
}