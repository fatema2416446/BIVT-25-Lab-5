using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            // code here
            for (int i =0; i<n; i++)
            {
                answer += (p + i * h) * (p + i * h);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a>=b)
            {
                a = a - b;
                quotient += 1;
            }
            remainder = a;

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a1 = 1.0;
            double b1 = 2.0;
            double c1;
            double a2 = 1.0;
            double b2 = 1.0;
            double c2;
            while (true) {
                c1 = a1 + b1;
                a1 = b1;
                b1 = c1;
                c2 = a2 + b2;
                a2 = b2;
                b2 = c2;
                if (Math.Abs(b1/b2-a1/a2) < 0.0001)
                {
                    answer = b1 / b2;
                    break;
                }
                }
                // end

                return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double t = 1;
            for (int i =0; Math.Abs(b*t)>=0.0001;i++)
            {
                t *= q;
                answer += 1;
            }
            answer += 1;
            // end

            return answer;
        }

        public int Task5(int a, int b)
        {
            int answer = 0;
            // code here
            long number = a;
            while (b>0)
            {
                number *= b;
                b--;
            }
            while (number>=10)
            {
                number /= 10;
                answer++;
            }

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            int cell = 1;              
            ulong grainsOnCell = 1;     
            ulong totalGrains = 0;

            while (cell <= 64)         
            {
                totalGrains += grainsOnCell;   
                grainsOnCell *= 2;             
                cell++;
            }

            double grams = totalGrains / 15.0;     
            double tons = grams / 1_000_000.0;     

            answer = (long)tons;   
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double s1 =S;
            double monthPrc = S * d / 100.0 / 12.0;
            while (S < 2*s1)
            {
                S += monthPrc;
                answer++;
                if (answer % 12 == 0)
                {
                    monthPrc = S * d / 100.0 / 12.0;
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
            for (double x=a; x <= b+0.0001; x += h)
            {
                int p = 1;
                double ch = 1;
                double zn = 1;
                for (int i=1; Math.Abs(p * ch / zn) >= 0.0001;i++)
                {
                    SS += p * ch / zn;
                    
                    p *= -1;
                    ch *= x * x;
                    zn *= (2 * i) * (2 * i - 1);
                }
                //SS += p * ch / zn;
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}