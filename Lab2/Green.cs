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
            for (double i = 2; i <= n; i += 2)
                answer += i / (i + 1);
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer += 1;
            double temp = 1 / x;
            for (int i = 1; i <= n; i++)
            {
                answer += temp;
                temp /= x;
            }
                
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            long temp = 1;
            for (int i = 1; i <= n; i++)
            {
                temp *= i;
                answer += temp;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double xPow = x;
            while (true)
            {
                if (i > 1)
                    xPow *= x;
                
                double sin = Math.Sin(xPow * i);
                if (Math.Abs(sin) < E)
                    break;
                
                answer += sin;
                i++;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double xPow = 1;
            while (true)
            {
                double last = 1 / xPow;
                xPow *= x;
                double current = 1 / xPow;
                answer++;

                if (Math.Abs(last - current) < E)
                    break;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (true)
            {
                if (elem < limit)
                {
                    elem *= 2;
                    answer += elem;
                    i++;
                }
                else
                    break;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (true)
            {
                if (L < Da)
                    break;
                else
                {
                    answer++;
                    L /= 2;
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
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double temp;
                double sum = 0;

                do
                {
                    temp = Math.Pow(-1, i) * (Math.Pow(x, 2 * i + 1) / (2 * i + 1));
                    sum += temp;
                    i++;
                } while (Math.Abs(temp) > E);
                
                SS += sum;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
