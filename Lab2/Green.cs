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
            for (int i = 2; i <= n; i+= 2)
            {
                answer+=((double)i/(i+1.0));

            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            if (x == 0)
                return 0; 
            
            double currentTerm = 1.0; 
            for (int i = 0; i <= n; i++)
            {
                answer += currentTerm;
                currentTerm /= x; 
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                    factorial *= i;
                answer += factorial;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int k = 1;
            double term;
            
            do
            {
                double p = Math.Pow(x, k);
                term = Math.Sin(k * p);
                answer += term;
                k++;
            }
            while (Math.Abs(term) >= E && k < 10000);  
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            if (Math.Abs(x) <= 1)
                return 0;
                
            int n = 1;
            double p = 1.0 / x;
            double difference;
            
            do
            {
                n++;
                double b = 1.0 /Math.Pow(x, n);
                difference = Math.Abs(b - p);
                p = b;
            }
            while (difference >= E && n < 10000);
            
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
            double i  = L;
            
            while (i > Da)
            {
                i /= 2;
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
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double temp;
                double sum = 0;

                do
                {
                    temp = Math.Pow(-1, i) * (Math.Pow(x, 2 * i + 1) / (2 * i + 1));
                    sum += temp;
                    i++;
                } while (Math.Abs(temp) > E);
    
                SS += sum;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
