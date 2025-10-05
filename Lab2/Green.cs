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
            if (n < 2)
            {
                answer = 0;
            }

            for (int k = 2; k <= n; k += 2)
            {
                answer += (double)k / (k + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++)
            {
                answer += Math.Pow(x, -i);
            }
            
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    f *= i;
                }
                answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int n = 1;
            // code here
            while (true)
            {
                double t=Math.Sin(n*Math.Pow(x, n));
                if (Math.Abs(t) < 1e-4)
                {
                    break;
                }

                answer += t;
                n++;

                if (n > 1000)
                {
                    break;
                }
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            answer++;
            double a = x;
            while (Math.Abs(1 / a - x / a) >= E)
            {
                answer++;
                a *= x;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
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
            double Da = 1e-10;
            while (L > Da)
            {
                L /= 2.0;
                answer++;
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
                SY += Math.Atan(x);
                int sn = -1;
                double mn = 1;
                for (int i = 0; ; i++)
                {
                    double s = -1 * sn * x * mn / (2 * i + 1);
                    SS += s;
                    sn *= -1;
                    mn *= x * x;
                    if (Math.Abs(s) < E)
                    {
                        break;
                    }
                }
            }
            // end

            return (SS, SY);
        }
    }
}
