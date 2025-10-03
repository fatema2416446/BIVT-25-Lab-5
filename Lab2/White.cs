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
            for (int a = 2; a <= 3*n - 1;a+= 3)
            {
                s = s + a;
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
            for (double a = 1;a <= n;a++)
            {
                s = s + 1 / a;
            }
            answer = s; 
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1;i <= n; i++)
            {
                s *= i;
            }
            answer = s;

            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long s = 1; 
            for (int i =1;i<=b;i ++)
            {
                s *= a;
            }
            answer = s;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            for(int i =1; true;i+=3)
            {
                p *= i;
                if (p > L)
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
            double s = 0;
            for (int i= 0;true;i+=2 )
            {
                s += Math.Pow(x,i);
                if (Math.Pow(x, i)  <  E)
                {
                    answer = s; 
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
