using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        private object counst;

        public double Task1(int n)
        {
            double answer = 0;
            for (int i =2; i <= n; i +=2)
            {
                answer += (double)i / (i +1);
            }
            // code here

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i =0; i <= n; i++)
            {
                answer += Math.Pow(x, -i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long f = 1;
            // code here
            for (int i = 0; i <= n; i ++)
            {
                if (i > 0) f *= i;
                answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int k = 1;
            double T = 0;
            
            do
            {
                T = Math.Sin(k * Math.Pow(x, k));
                if (Math.Abs(T) > E)
                    answer += T;
                k++;

            } while (Math.Abs(T) >= E);
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            answer += 1;
            double c = 1.0/x;
            double p = 1.0;
            while (Math.Abs(c-p) >= E )
            {
                answer++;
                p = c;
                c /= x;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1, i = 0;
            // code here
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
            double cL = L;
            while (cL > Da)
            {
                cL = cL / 2;
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
            for (double x = a; x <= b + E; x += h)
            {
                double s = 0.0;
                int i = 0;
                double t = x;
                while (true) 
                {
                    double c = Math.Pow(-1, i) * Math.Pow(x, 2*i+1)/ (2*i+1);
                    s+= c;
                    if (Math.Abs(c) < E)
                    {
                        break;
                    }
                    i++;
                    t += c;
          
                 
                } 
                double y = Math.Atan(x);
                SS += s;
                SY += y;
            }
         
            // end

            return (SS, SY);
        }
    }
}