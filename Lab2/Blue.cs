using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
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

            for (int i = 0; i < n; i++)
            {
                answer += ((Math.Sin((i + 1) * x)) / Math.Pow(x, i));
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            int k = -1;
            long a = 1, b = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= 5;
                answer += k * ((double)a / b);
                k *= -1;
                b = b * (i + 1);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            long answer1 = 0;
            long answer2 = 1;
            for (int i = 0; i < n; i++)
            {
                answer = answer1 + answer2;
                answer1 = answer2;
                answer2 = answer;

            }
            answer -= 1;
            if (answer == -1)
            {
                answer = 0;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            int s = 0;
            while ( s <= L)
            {
                s += (a + h * answer);
                answer += 1;
            }
            answer -= 1;
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

            while (S <= L)
            {
                S *= 2;
                answer += h;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            double s = 0, s1 = S, s2 = S;
            for (int i = 0; i < 7; i++)
            {
                a += S;
                S += (S * (I / 100));
            }
            while (s < 100)
            {
                b += 1;
                s += s1;
                s1 += (s1 * (I / 100));
            }
            while (s2 < 42)
            {
                c += 1;
                s2 += (s2 * (I / 100));
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            double eps = 0.0001;
            for (double x = a; x <= b + 1e-10; x += h)
            {
                int i = 0;
                double s = 0, f = 1, p = 1,m = 0;
                double p1 = x * x;
                do
                {
                    m = (2 * i + 1) * p / f;
                    s += m;
                    i += 1;
                    f *= i;
                    p *= p1;
                }
                while (Math.Abs(m) >= eps);
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}
