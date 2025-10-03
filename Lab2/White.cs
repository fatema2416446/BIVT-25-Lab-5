namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            
            for (int i = 1; i <= n; i ++)
            {
                answer += 3 * i - 1;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for(int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for(int i = 1; i <= n; i++ )
            {
                answer *= i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            answer = result;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int n = 1;
            for (int i = 1; true; i+=3)
            {
                n *= i;
                if (n > L)
                {
                    answer = i;
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
            double e = 0.0001;
            double s = 0;
            double t = 1;
            int n = 0;
            while (t >= e)
            {
                s += t;
                n++;
                t = Math.Pow(x, 2*n);
            }
            answer = s;
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
            if (v <= 0)
            {
                answer = 0;

            }
            else
            {
                double t = (Math.Sqrt(R * R + L * L) - R) / v;
                answer = (int)Math.Floor(t) + 1;
            }
            // end

            return answer;
        }
    }

}
