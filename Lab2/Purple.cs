using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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
            for (int i = 1; i <= n; i++)
            {
                answer += (p + (i - 1) * h) * (p + (i - 1) * h);
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
                quotient++;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a = 1, b = 1, c = 2;
            while (Math.Abs((c / b) - (b / a)) > E)
            {
                (a, b, c) = (b, c, (b + c));
            }
            answer = c / b;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            answer++;
            while (Math.Abs(b) >= E)
            {
                answer++;
                b *= q;
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

            // code here
            double s = 1, x = 0;
            for (int i = 1; i < 64; i++)
            {
                s *= 2;
                x += s / 15000000;
            }
            answer = Convert.ToInt64(x);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double ds = S * 2, procent = S * ((d / 100.0) / 12);
            int month = 0;
            while (S < ds)
            {
                answer++;
                month++;
                S += procent;
                if (month == 12)
                {
                    month = 0;
                    procent = S * ((d / 100.0) / 12);
                }
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                double s = 0, c = 1, f = 1;
                int count = 0;
                while (Math.Abs(c) >= E)
                {
                    c = Math.Pow(-1, count) * Math.Pow(x, 2 * count) / f;
                    s += c;
                    count++;
                    f *= (2 * count) * (2 * count - 1);
                }
                SY += Math.Cos(x);
                SS += s;
            }
            // end

            return (SS, SY);
        }
    }
}