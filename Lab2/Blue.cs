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
            for (double i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                answer += Math.Pow(-1, i) * Math.Pow(5, i) / f;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int f(int x)
            {
                if (x == 0 || x == 1)
                {
                    return x;
                }
                return f(x - 1) + f(x - 2);
            }
            for (int i = 0; i <= (n - 1); i++)
            {
                answer += f(i);
            }
            // end

                return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int n = 1;
            int s = 0;
            while (s + a + (n - 1) * h <= L)
            {
                s += a + (n - 1) * h;
                n++;
                answer++;
            }
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
            ch += i;
            zn *= x;
            answer += elem;
            elem = ch / zn;
            i++;
            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                S *= 2;
                answer += h;
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
            double q = 1 + I / 100;
            a = (S * (Math.Pow(q, 7) - 1)) / (q - 1);
            b = (int)(Math.Ceiling(Math.Log(100 * (q - 1) / S + 1, q)));
            if (S <= 42)
            {
                c = (int)(Math.Floor(Math.Log(42 / S, q) + 2)) - 1;
            }
            // end

                return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x += h)
            {
                int i = 0;
                double f = 1;
                x = Math.Round(x, 4);
                while (Math.Abs((2 * i + 1) * Math.Pow(x, 2 * i) / f) >= 0.0001)
                {
                    SS += (2 * i + 1) * Math.Pow(x, 2 * i) / f;
                    i++;
                    f *= i;
                }
                SS += (2 * i + 1) * Math.Pow(x, 2 * i) / f;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}
