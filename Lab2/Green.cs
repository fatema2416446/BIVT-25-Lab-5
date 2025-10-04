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
            double s = 0;
            
            for (int i = 2; i <= n; i+=2)
            {
                
                s += ((double) i / (i + 1));
                
            }

            answer += s;

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            double s = 1;
            double a = 1 / x;

            // code here
            for (int i = 1; i <= n; i++)
            {
               
                s += a;
                a /= x;
            }

            answer += s;

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            
            // code here
            long s = 1; long x = 1;
            for (int i = 1; i <= n; i++)
            {
                s += x;
                x = x * (i + 1);
            }

            answer += s;

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;
            double chl = Math.Sin(x);
            double b = x;
            while (Math.Abs(chl) >= E)
            {
                answer += chl;
                n += 1;
                b *= x;
                chl = Math.Sin(n * b);
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            int n = 1;
            double b = x;

            // code here
            while (Math.Abs((1 / b) - (1 / (b / x))) > E)
            {
                n += 1;
                b *= x;
                answer = n;
            }

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;

            // code here
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i += 1;
            }
            

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (true)
            {
                if (L > Da)
                {
                    L /= 2;
                    answer += 1;
                }
                else
                {
                    break;
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
            for (double x = a; x <= b; x = Math.Round(x + h, 7))
            {

                SY+= Math.Atan(x); 

                SS+=x; 
                double last = x; 
                double x_to_power_of_i = 1;
                for (int i = 1; Math.Abs(last) >= E; i++)
                {
                    x_to_power_of_i *= x; 
                    last = x_to_power_of_i*x_to_power_of_i*x / (2*i+1); 
                    if (i%2==1)
                    {
                        last = -last;
                    }
                    SS+=last;

                }
            }
            

            // end

            return (SS, SY);
        }
    }
}
