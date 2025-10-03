using System.Collections.Generic;
using System.ComponentModel;
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
            double x1 = 1;
            for (int i = 1; i <= n; i++)
            {
                answer = answer + (Math.Sin(i * x) / x1);
                x1 = x1 * x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double k = -1;
            double c = 5;
            double p = 1;
            for (int i = 1; i <= n; i++)
            {
                answer = answer + (k * c / p);
                k = (-1) * k;
                c = c * 5;
                p = p * (i + 1);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long prev = 0;
            long res = 1;
            long f;
            for (int i = 0; i < n; i++)
            {
                f = res;
                answer += prev;
                res = res + prev;
                prev = f;

            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int i = 0; s <= L; i++)
            {
                if (s >= L)
                {
                    break;
                }
                else
                {
                    s = s + (a + i * h);
                    if (s <= L)
                    {
                        answer++;
                    }

                }

            }
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
            for (int i = 1; S < L; i++)
            {
                S = 2 * S;
                if (S >= L)
                {
                    answer = h * i;
                }
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
            double sum = S;
            double q = (1 + I / 100);
            double ss = S;
            for(int i = 0; i < 6; i++)
            {
                ss *= q;
                sum += ss;
            }
            a = sum;
            sum = S;
            ss = S;
            int k = 0;
            while(sum<100)
            {
                ss *= q;
                sum += ss;
                k++;
            }
            b = k + 1;
            sum = S;
            ss = S;
            k = 0;
            while (ss<42)
            {
                ss *= q;
                sum += ss;
                k++;
            }
            c = k;
            
            
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double epsilon = 0.0001;

            // code here

            for(double x=a;x<=b+E;x+=h)
            {
                double sumX = 0;
                double p = 1;
                int i =0;
                int pZ = 1;
                double pX = 1;
                bool flag = false;
                do
                {
                    sumX += p;
                    i++;
                    pZ *= i;
                    pX = pX * x * x;
                    p = ((2 * i + 1) * pX) / pZ;
                    if (Math.Abs(p) < epsilon && !flag)
                    {
                        flag = true;
                    }
                    else if(flag)
                    {
                        break;
                    }
                } while (true);
                SS += sumX;
                SY += ((1 + 2 * x * x) * Math.Exp(x * x));
            }
            // end

            return (SS, SY);
        }
    }
}