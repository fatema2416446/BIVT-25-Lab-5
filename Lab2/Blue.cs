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
            double ch = 1, zn = 1;
            answer = Math.Sin(x)/zn;
            for (int i = 2; i < n + 1; i++)
            {
                ch = Math.Sin(x * i);
                zn *= x;
                answer += ch / zn;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double pow1 = 1, pow2 = 1, f = 1;
            for (int i = 1; i < (n + 1); i++)
            {
                pow1 *= -1;
                pow2 *= 5;
                f *= i;
                answer += pow1 * (pow2 / f);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            // code here
            long a = 1, b = 0, sum = 0;
            for (int i = 0; i < (n - 1); i++)
            {
                answer = answer + a;
                sum = a;
                a = a + b;
                b = sum;
            }
            // end
            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long s = 0;
            while (s <= L)
            {
            s = s + (a + answer * h);
            answer = answer + 1;
            }
            answer--;
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
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch/ zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            do
            {
                S *= 2;
                answer += h;
            }
            while (S < L);
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double S1 = S, S2 = S, S3 = S;
            double distance = 0;
            for (int i = 1; i <= 7; i++)
            {
                a += S1;
                S1 += (S1 * (I/100));   
                
            }
            
            while (distance < 100)
            {
                b++;
                distance += S2;
                S2 += (S2 * (I/100));
            } 
            
            while (S3 <= 42)
            {
                c++;
                S3 += (S3 * (I/100));
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
                double elem = 1, s = 1;
                int i = 0, f = 1;
                x = Math.Round(x, 2);
                while (Math.Abs(elem) > E)
                {
                    elem = ((2 * i + 1) * s) / f;
                    SS += elem;
                    i++;
                    f *= i;
                    s *= x * x;
                }
                SY += (1 + 2 * x * x) * Math.Pow(Math.Exp(1), x * x);
            }
            // end

            return (SS, SY);
        }
    }
}




