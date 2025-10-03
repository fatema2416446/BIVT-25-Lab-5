using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        private int Abs(int x)
        {
            if (x >= 0) return x;
            return -x;
        }
        private double Abs(double x)
        {
            if (x >= 0) return x;
            return -x;
        }

        private int Pow(int a, int b)
        {
            if (b == 0) return 1;
            if ((b & 1) == 1) return Pow(a, b - 1) * a;
            int temp = Pow(a, b >> 1);
            return temp * temp;
        }
        private double Pow(double a, int b)
        {
            if (b == 0) return 1;
            if ((b & 1) == 1) return Pow(a, b - 1) * a;
            double temp = Pow(a, b >> 1);
            return temp * temp;
        }

        private int fact(int n)
        {
            int ans = 1;
            for (int i = 2; i <= n; i++)
                ans *= i;
            return ans;
        }

        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer += Pow((p + (i - 1) * h), 2);
            }

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            while (a >= b)
            {
                quotient++;
                a -= b;
            }
            remainder = a;
            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            int a = 1, b = 2;
            while (10000 * Abs(b * (b - a) - a * a) > (b - a) * a)
            {
                b = b + a;
                a = b - a;
            }
            answer = (double)(b) / (double)(a);
            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            int l = 0, r = (int)(1e4);
            while (r - l > 1)
            {
                int m = (l + r) >> 1;
                if (Abs(Pow(q, m) * b) >= 1e-4)
                    l = m;
                else
                    r = m;
            }
            answer = r + 1;

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            while (b > 0)
                a *= b--;
            while (a > 10) {
                a /= 10;
                answer++;
            }

            return answer;
        }
        public long Task6()
        {
            ulong answer = 0;

            for (int i = 0; i < 64; i++)
                answer += (ulong)(1 << i);
            answer /= 15000000;
            return (long)answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            if (S == 0)
                return 0;

            double cnt = S;
            d /= 100;
            double yoy = S * d;
            while (cnt < 2 * S)
            {
                if (answer % 12 == 0)
                    yoy = cnt * d;
                cnt += yoy / 12;
                answer++;
            }
            //Console.WriteLine(answer + " " + cnt / S);
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            const String debugFile = @"C:\temp\debug.txt";
            //using (StreamWriter writer = new StreamWriter(debugFile, append:true))
            //{
                for (double x = a; x < b + 0.0001; x += h)
                {
                    int i = 0;
                    while (true)
                    {
                        double cur = (i % 2 == 0 ? 1 : -1) * Pow(x, 2 * i) / fact(2 * i);
                        
                        //writer.WriteLine(cur);
                        //break;
                        SS += cur;
                        i++;
                        if (Abs(cur) < 0.0001)
                            break;
                    }

                    SY += Math.Cos(x);
                }
                //writer.WriteLine(SS + " " + SY);
            //}
            return (SS, SY);
        }
    }
}