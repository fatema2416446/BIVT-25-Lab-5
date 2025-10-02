using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            int j = 2;
            answer = Math.Sin(x);
            answer = Math.Round(answer, 6);
            for (;i != n;)
            {
                if (n == 1)
                    return answer;
                answer = Math.Round(answer += (Math.Sin(x * j)) / (Math.Pow(x, i)), 6);
                i++;
                j++;
            }
            // end
            Console.WriteLine(answer);
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int i = 0;
            double k = 1;
            double S = 0;
            if (n == 0)
                return answer;

            for (; i != n;)
            {
                i++;
                k *= i;
                S += Math.Pow(-1, i) * Math.Pow(5, i) / k;
                //S += (-1 ^ i) * ((5 ^ i) / k); 
            }
            
            answer = S;
            Console.WriteLine(S);
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n == 0 || n == 1)
                return answer;
            int ch1 = 0;
            int ch2 = 1;
            int ch3 = 0;
            int sum = 1;
            for (int i = 2; i != n;)
            {
                i++;
                ch3 = ch1 + ch2;
                sum += ch3;
                ch1 = ch2;
                ch2 = ch3;
            }
            answer = sum;
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            double S = 0;
            int i = 0;
            S += a;
            do
            {
                i++;
                S += a + i * h;
            }
            while (S <= L);
            Console.WriteLine(i);
            answer = i;
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
            }
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int t = 0;
            do
            {
                t += h;
                S *= 2;
            }
            while (S <= L);
            Console.WriteLine(t);
            answer = t;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double d1 = 0;
            double d2 = 0;
            d1 += S;
            a += S;
            for (int i = 1; i != 7; i++)
            {
                d2 = d1 + (d1 * 0.01) * I;
                a += d2;
                d1 = d2;
            }
            double a2 = 0;
            int i2 = 1;
            d1 = 0;
            d2 = 0;
            d1 += S;
            a2 += S;
            while (a2 <= 100)
            {
                i2++;
                d2 = d1 + (d1 * 0.01) * I;
                a2 += d2;
                d1 = d2;
                
            }
            b = i2;
            d1 = 0;
            d2 = 0;
            double a3 = 0;
            int i3 = 0;
            d1 += S;
            a3 += S;
            while (d1 < 42 || d2 < 42)
            {
                i3++;
                d2 = d1 + (d1 * 0.01) * I;
                a3 += d2;
                d1 = d2;
            }
            c = i3;
            if (S > 42)
                c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            for (double x = a; x <= b + E; x += h)
            {
                SY += (1 + (2.0 * x * x)) * Math.Exp(x * x);
                double it = 1, fac = 1, um = 1;
                int i = 0;
                while (Math.Abs(it) >= E)
                {
                    it = ((2 * i + 1) * um) / fac;
                    SS += it;
                    i++;
                    fac *= i;
                    um *= x * x;
                    // end
                }
            }
                    return (SS, SY);
        }
    }
}
