using System.Diagnostics.SymbolStore;
using System.Threading.Channels;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
            }

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            for(double i = 1; i <= n; i++)
            {
                answer += 1 / i;
            }

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            
            for(int i = 1; i <= n; i++)
            {
                answer *=  i;
            }

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;
            for(int i = 0; i < b; i++)
            {
                answer *= a;
            }

            

            return answer;
        }
        public int Task5(int L)
        {
            int n = 1;
            int p = 1;
            while(p <= L)
            {
                n += 3;
                p *= n;
            }

            return n;
        }
        public double Task6(double x)
        {
            double answer = 0;
            
                for(double i = 1; i > 0.0001; i *= x*x)
                {
                if ((x > -1) && (x < 1))
                {
                    answer += i;
                
                }
                    
                }
            return answer;
        } 
        
        public int Task7(int n)
        {
            
            int answer = 0;
            int sum = 0;
            while(sum < n)
            {
                answer++;
                sum += answer;
            }

            return answer;
        }
        public int Task8(double L, double V)
        {
            int t = 0;
            const double R = 6371.0; 
            while(Math.Sqrt(V * t* ( V* t + 2 * R))<= L)
            {
                t++;
            }

            return t;
        }
    }


   

}
