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
            for (int i = 1; i <= n; i++) 
            {
                answer += Math.Sin(x*i)/a;
                a *= x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            
            // code here
            long a = 5;
            long b = 1;
            int c = -1;
            for (int i = 1; i<=n;i++)
            {
                b *= i;
                answer += (double) c*a/b;
                a = 5*a;
                c= (-1)*c;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            long a = 0;
            long b = 1;
            for (int i = 0; i < (n-1); i++)
            {
                a += b;
                a = a + b;
                b = a - b;
                a = a - b;
                answer += a;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int i = 0;
            long s = 0;
            while (s <= L)
            {
                s += a + i * h;
                answer += 1;
                i++;
            }
            answer -= 1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
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
            while (S < L)
            {
                answer += h;
                S += S;
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
            double S1 = S;
            double k = 0;
            for (int i = 0; i < 7; i++)
            {
                a += S1;
                S1 = S1 + S1 * I * 0.01;
            }
            S1 = S;
            while (k < 100)
            {
                b += 1;
                k += S1;
                S1 = S1 + S1 * I * 0.01;
            }
            S1 = S;
            while (S1 <= 42)
            {
                c += 1;
                S1 = S1 + S1 * I * 0.01;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x = Math.Round(x + h, 7))
            {
                double Yi = 1;
                double Si = 1;
                int i = 0;

                double fx = 1;

                float fi = 1;
                while (Math.Abs(Si) >= E)
                {
                    Si = (((2 * i + 1) * (fx * fx)) / (fi));
                    i++;
                    fi *= i;
                    fx *= x;
                    SS += Si;

                    Yi = (1 + 2 * x * x) * Math.Pow(Math.E, (x * x));
                }
                SY += Yi;
            }
            // end

            return (SS, SY);
        }
    }
}
