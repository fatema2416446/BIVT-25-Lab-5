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
            for (int i = 0; i < n; ++i)
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
                quotient += 1;
                a -= b;
            }
            remainder += a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a = 1, b = 2;
            while (Math.Abs((a + b) / b - b / a) >= E)
            {
                b = a + b;
                a = b - a;
            }
            answer = (a + b) / b;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            answer += 1;
            double res = b;
            while (Math.Abs(res) > 0.0001)
            {
                res *= q;
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

            // code here
            int i = 0;
            ulong sum = 0;
            ulong res = 1;
            while (i < 64)
            {
                i++;
                sum += res;
                res *= 2;
            }
            sum /= 15000000;
            answer = (long)sum;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double res = S * 2;
            double Year = S * (d / 100.0);
            int i = 0;
            while (S < res)
            {
                i++;
                if (i % 12 == 0)
                    Year = S * (d / 100.0);
                S += Year/12.0;
            }
            answer = i;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + E)
            {
                double el = 1.0;
                SS += el;
                for (int i = 1; Math.Abs(el) >= E; ++i)
                {
                    el = el * (-1) * x * x / i / 2 / (2 * i - 1);
                    SS += el;
                }
                SY += Math.Cos(x);
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}