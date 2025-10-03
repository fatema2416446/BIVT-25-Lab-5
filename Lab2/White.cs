using System.Reflection.Metadata;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int s = 0, a = 2;
            for (int i = 1; i <= n; i++)
            {
                s = s + a;
                a = a + 3;
                answer = s;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            const double a = 1;
            double b = 1;
            for (int i = 1; i <= n; i++)
            { 
                s = s + (a / b);
                b = b + 1;
                answer = s;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    f = 1;
                    answer = f;
                }
                else
                {
                    answer = i * f;
                    f = i * f;
                }
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            int a = 1;
            while(p <=  L)
            {
                a = a + 3;
                p = p * a;
                answer = a;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double s = 1;
            double k = 1;
            do
            {
                k = k * x * x;
                s = s + k;
                answer = s;
            } while (k >= 0.0001);
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            for (int sum = 0; sum < n;)
            {
                answer++;
                sum += answer;
            }
                // end

                return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            int t = 0;
            do
            {
                t++;
                double h = v * t;
                double g = Math.Sqrt((R + h) * (R + h) - R * R);
                answer = t;
                if (g > L)
                    break;
            } while (true);
            // end

            return answer;
        }
    }

}
