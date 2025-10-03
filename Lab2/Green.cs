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
            for (double i=0; i<=n; i+=2)
            {
                answer += (double) i / (i+1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer += 1;
            double z = 1;
            for (int i=1;i<=n ;i++)
            {
                z = z * x;
                answer += 1 / z;

            } 
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 1;
            answer += 1;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
                answer += a;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double sn;
            do
            {
                sn = Math.Sin(i * Math.Pow(x, i));
                answer += sn;
                i++;
            } while (Math.Abs(sn) > E);
            // end

                return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double rz = (1 - x) / Math.Pow(x, n);

            while (Math.Abs(rz) >= E) 
            {
                n++;
                rz = (1 - x) / Math.Pow(x, n);
            } 
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem<limit)
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
            int n = 0;
            while (L>Da)
            {
                L /= 2;
                n++;    
            }
            answer = n; 
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-12; x += h)
            {
                int i = 0;
                double rd=x;
                double s = 0;
                while (Math.Abs(rd) > E)
                {
                    rd = Math.Pow(-1, i) * (Math.Pow(x, 2 * i + 1) / (2 * i + 1));
                    s += rd;
                    i++;
                } 

                SS += s;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
