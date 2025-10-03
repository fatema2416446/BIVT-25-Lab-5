using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double) i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double a = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += a;
                a = a / x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 1;
            for (int i = 0; i <= (n); i++)
            {
                if (i == 0)
                {
                    a *= 1;
                }
                else
                {
                    a *= i;
                }
                answer += a;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double a = x;
            double n = 1;
            while (Math.Abs(Math.Sin(a)) > E)
            {
                answer += Math.Sin(a);
                n++;
                a /= (n - 1);
                a *= n;
                a *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double a = 1 / x;
            double b = 1;
            while (Math.Abs(a - b) > E)
            {
                n++;
                a /= x;
                b /= x;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int n = 0;
            while (L > Da)
            {
                L = L / 2;
                n++;
            }

            answer = n;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double s = 0;
            for (double x = a; x <= b + E; x += h)
            {
                s = 0;
                int p = 1;
                double pow = x;
                double den = 1;
                while (true)
                {
                    s += p * pow / den;
                    if (Math.Abs(p * pow / den) < E) break;
                    p = -p;
                    pow *= x * x;
                    den += 2;
                }

                SS += s;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}