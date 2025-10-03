using System.Text.RegularExpressions;

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
            for (int i = 1; i <= n; i++)
            {
                    s += (3 * i - 1);

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
            for (double i = 1; i <= n; i++)
            {
                 s += (1 /  i);

            }
                answer = s;
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1; i <= n; i++)
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
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * a;
            }
            answer = result;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int P = 1;
            int n = 1;
            while (P <= L)
            {
                
                P *= n;
                n += 3;
            }
            answer = (n-3);
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double s = 1;
            double a = 1;
            
            while (a >= 0.0001)
            {
                a *= x * x;
                s += a; // 
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
                sum += (answer);
            }
            
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double h = -R + Math.Sqrt(R * R + L * L);
            answer = ((int)(h / v) + 1);
            // end

            return answer;
        }
    }

}

