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
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer = 1;
            double step = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += (1 / x) * step;
                step = (1 / x) * step;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += (i * fact);
                fact = fact * i;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double newX = 1;
            double a = 1;
            while (Math.Abs(a) >= E)
            {
                newX = newX * x;
                a = Math.Sin(i * newX);
                answer += a;
                i++;

            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            answer = 2;
            double a = 1 / (x * x);
            double b = 1 / x;
            while (Math.Abs(a - b) >= E)
            {
                b = a;
                a = a / x;
                answer++;
            }
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
            while (L > Da)
            {
                L = L / 2;
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
            for (double x = a; x <= b + 0.000001; x += h)
            {
                int i = 0;//Указатель степни с которой начинать
                double p = -1;//Степень,определяющая знак
                double num = 1;//x в степени 2i
                double Chislo_num_i = 1;
                while (Math.Abs(Chislo_num_i) >= E)
                {
                    Chislo_num_i = -p * x * num / (2 * i + 1);
                    SS += Chislo_num_i;
                    num = num * x * x;
                    i++;
                    p = -p;
                }
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}