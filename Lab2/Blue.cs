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
            double a = 1;
            for (int i = 0; i < n; i++)
            {
                answer += Math.Sin(x * (i + 1)) / a;
                a *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double o = -1;
            double c = 5;
            double last = 1;
            double next = 2;
            for (int i = 0; i < n; i++)
            {
                answer += o * c / last;
                o *= -1;
                c *= 5;
                last *= next;
                next += 1;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long current = 1; 
            long previous = 0;
            for (int i = 0; i < n; i++)
            {
                answer += previous;
                long sum = previous + current; 
                previous = current; 
                current = sum;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long s = 0;
            int n = 0;
            while (s + a + h * n <= L)
            {
                s += (a + h * n);
                n++;
            }
            answer = n;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0; double zn = 1;
            double elem = ch / zn;
            int i = 1;

            // code here
            ch += i;
            zn *= x;
            answer += elem;
            elem = ch / zn;
            i++;
            while (elem >0.0001)
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
            int time = 0;
            // code here
            while (S < L)
            {
                S *= 2;
                time += h;
            }
            answer = time;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            double norm = S;
            double summ = S;
            int count = 1;
            // code here
            a = norm;
            for (int i = 1; i < 7; i++)
            {
                norm *= (1 + I / 100);
                a += norm;
            }
            norm = S;
            while (summ <100)
            {
                norm *= (1 + I / 100);
                summ += norm;
                count++;
            }
            b = count;
            norm = S;
            while (norm <= 42)
            {
                norm *= (1 + I / 100);
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b+1e-12; x+=h)
            {
                int i = 0;
                double power = 1;
                int factorial = 1;

                do
                {
                    if (i > 0)
                    {
                        factorial *= i;
                        power *= x * x;
                    }
                    SS += (2 * i + 1) * power / factorial;
                    i++;
                }
                while ((2 * i + 1) * power / factorial >= E);

                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }

}



