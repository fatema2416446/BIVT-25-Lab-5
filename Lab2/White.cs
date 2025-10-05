using System.Runtime.ExceptionServices;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int current = 2;
            for (int i = 0; i < n; i = i + 1)
            {
                answer += current;
                current += 3;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i = i + 1)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= n; i=i+1)
            {
                answer = answer * i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= b; i=i+1)
            {
                answer = answer * a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
           for (int i = 1;i<=L;p += 3)
            {
                i = p * i;
                answer = p;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double p = 1;
            while (p >= E)
            {
                answer += p;
                p *= x * x;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n)
            {
                answer = answer + 1;
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
            double h = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(L, 2)) - R;
            double time = h / v;
            answer = (int)Math.Ceiling(time);
            // end

            return answer;
        }
    }

}
