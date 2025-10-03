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
            if (n >= 1)
            {
                answer += Math.Sin(x);
            }

            double xPower = 1.0;

            for (int i = 2; i <= n; i++)
            {
                xPower *= x;
                answer += Math.Sin(i * x) / xPower;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double term = 1;

            for (int i = 1; i <= n; i++)
            {
                term *= -5.0 / i;
                answer += term;
            }
            // end

                return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0) return answer;

            long a = 0, b = 1;
            answer = a; // первое число Фибоначчи

            for (int i = 2; i <= n; i++)
            {
                answer += b; // добавляем текущее число Фибоначчи к сумме
                long next = a + b;
                a = b;
                b = next;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            int n = 0;
            while (n * (2 * a + (n - 1) * h) / 2 <= L)
            {
                n++;
            }
            answer = n - 1;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = 0;
            int i = 1;

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn; 
                i++;
            }
            while (elem > 0.0001);
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
            double tempS = S;
            for (int i = 1; i <= 7; i++)
            {
                a += S;
                S += (S * (I / 100.0));
            }
            S = tempS;
            double total = 0;
            while (total <= 100)
            {
                total += S;
                S += (S * (I / 100));
                b += 1;
            }
            S = tempS;
            while (S <= 42)
            {
                c += 1;
                S += (S * (I / 100));

            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            const double eps = 0.0001;

            if (h <= 0) return (SS, SY);

            for (double x = a; x <= b + 1e-12; x += h)
            {
                double Sx = 0.0;
                int i = 0;
                double term;
                double fact = 1.0;  
                double xpow = 1.0;  
                int maxIter = 1000;

                do
                {
                    term = (2 * i + 1) * xpow / fact;
                    Sx += term;

                    i++;
                    if (i > maxIter) break;

                    fact *= i;           
                    xpow *= x * x;    
                }
                while (Math.Abs(term) >= eps);

                SS += Sx;

                double y = (1.0 + 2.0 * x * x) * Math.Exp(x * x);
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}