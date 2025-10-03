using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

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
            double i = 2;
            while (i <= n)
            {
                answer += i / (i + 1);
                i += 2;
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            int i = 0;
            double zn = 1;
            while (i <= n)
            {

                answer += 1 / zn;
                zn *= x;
                i++;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fac = 1;
            answer = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
                answer += fac;   
            } 
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double member = 1, arg = x;
            for (int i = 1; Math.Abs(member) >= 0.0001; i++)
            {
                member = Math.Sin(i * arg);
                arg *= x;
                answer += member;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double zn1 = x, zn2 = 1;
            int n = 1;
            answer = n;
            while (Math.Abs(1/zn1 - 1/zn2) >= 0.0001)
            {
                zn1 *= x;
                zn2 *= x;
                n++;
                answer = n;
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
            int count = 0;
            while (L > 0.0000000001)
            {
                L /= 2;
                count++;
                answer = count;
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
                double member = x, ch = x, sum = 0;
                int sign = 1;
                int i = 0;
                while (Math.Abs(member) >= 0.0001)
                {
                    member = sign * ch / (2 * i + 1);
                    sum += member;
                    i++;
                    ch = ch * x * x;
                    sign *= (-1);
                }
                SS += sum;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}