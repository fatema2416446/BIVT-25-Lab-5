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

            for (int i = 2; i <= n; i += 2)
            {
                double a = (double)i / (i + 1);
                answer += a;
            }

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            double a = 1.0;
            for (int i = 0; i <= n; i++)
            {
                answer += a;
                a /= x;
            }
            
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            long fact = 1;
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }
            answer = sum;

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int n = 1;
            double current_x_power = x;
            while (true)
            {
                double otv = Math.Sin(n * current_x_power);
                if (Math.Abs(otv) < E)
                {
                    break;
                }

                answer += otv;
                n++;
                current_x_power *= x;

            }

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            int n = 1;
            double a = 0;
            double current_x_power = x;

            while (true)
            {
                double otv = 1 / current_x_power;
                if (Math.Abs(otv - a) < E)
                {
                    answer = n; break;
                }
                a = otv;
                n++;
                current_x_power *= x;
            }

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            for (int i = 0; ; i++)
            {
                if (elem < limit)
                {
                    elem *= 2;
                    answer += elem;
                }
                else
                {

                    break;
                }

            }

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            double current_L = L;
            int n = 0;
            for (; current_L > Da; n++)
            {
                current_L /= 2;


            }
            answer = n;
            Console.WriteLine(answer);

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 0.00001; x += h)
            {
                int i = 0; 
                double c = -1;
                double current_x = 1;
                double s = 1;
                while (Math.Abs(s) >= E)
                {
                    s = -c * x * current_x / (2 * i + 1);
                    SS += s;
                    current_x = current_x * x * x;
                    i++;
                    c *= -1;
                }
                SY += Math.Atan(x);
            }

            return (SS, SY);
        }
    }
}
