namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int a = 2; a <= 3 * n - 1; a += 3)
            {
                answer += a;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (double a = 1; a <= n; a++)
            {
                answer += (1 / a);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
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
            int answer = 1;
            int p = 1;

            // code here
            for (int n = 1; true; n += 3)
            {
                p *= n;
                if (p > L)
                {
                    answer = n;
                    break;
                }
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            for (int a = 0; true; a += 2)
            {
                double i = Math.Pow(x, a);
                answer += i;
                if (i < E)
                {
                    
                    break;
                }
                
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
            double a = ((Math.Sqrt(R * R + L * L)) - R) / (v);
            answer = (int)Math.Ceiling(a);
            // end

            return answer;
        }
    }

}