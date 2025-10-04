namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int i = 0; (i * 3 + 2) <= (3 * n - 1); i++)
            {
                s += i * 3 + 2;
            }
           
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            for (double  i = 1; i <= n; i++)
            {
                s += 1 /i ;
            }
            
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
             answer = 1;
            for (int i = 1; i <= n; i++)
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
            answer = 1;
            for (int i=1; i <=b; i++)
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
            int k = 1;
            for (int n = 1; k <= L; n+=3)
            {
                k*=n;
                answer = n;
            }
            
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double v = 1;
            double s = 1;
            for (int i = 1; (Math.Abs(v) >= Math.Pow(10, -4)); i++)
            { 
                v *= x*x;
                s += v;
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
            for (; sum < n;)
            {
                answer++;
                sum += answer;
            }
            return answer;
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            int t = 0;
            while((v * t + R) * (v * t + R) <= L * L + R*R)
            {
                t++;
            }
            answer = t;
            // end

            return answer;
        }
    }

}
