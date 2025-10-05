using System;

namespace Lab2
{
    public class Green()
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        
        public double Task1(int n)
        {
            double answer = 0;

            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            return answer;
        }

        public double Task2(int n, double x)
        {
            double s = 1, p = 1;
            for (int i = 1; i <= n; i++)
            {
                s += 1 / (x * p);
                p *= x;
            }
            return s;
        }

        public long Task3(int n)
        {
            long s = 1, p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
                s += p;
            }
            return s;
        }

        public double Task4(double x)
        {
            double s = 0, k = Math.Sin(x)   ;
            double p = 1;
            double i = 1;
            while (Math.Abs(k) >= 0.0001)
            {
                k = Math.Sin(i * x * p);
                s = s + k;
                p *= x;
                i += 1;
            }
            return s;
        }

        public int Task5(double x)
        {
            int n = 1;
            double prev = 1.0;
            double current = 1.0 / x;

            while (Math.Abs(current - prev) >= E)
            {
                n += 1;
                prev = current;
                current /= x;
            }
            return n;
        }

        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;

            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
            }

            return answer;
        }

        public int Task7(double L)
        {
            int count = 0;
            double current = L;

            while (current > Da)
            {
                current /= 2;
                count += 1;
            }

            return count;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 1e-10; x += h)
            {
                double s = 0;
                int i = 0;
                double xSquared = x * x;
                double chislit = x;    
                double znamenat = 1;   

                while (true)
                {
                    double term = chislit / znamenat;

                    if (i % 2 == 1)
                    {
                        term = -term;
                    }

                    s += term;

                    if (Math.Abs(term) < E)
                    {
                        break;
                    }

                    i += 1;
                    chislit *= xSquared;
                    znamenat += 2;         
                }
                SS += s;
                SY += Math.Atan(x);
            }

            return (SS, SY);
        }
    }
}