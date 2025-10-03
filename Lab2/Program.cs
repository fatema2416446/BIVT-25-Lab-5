namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            double a = 0.001, b = 0.1, h = 0.001;
            double SS = 0;
            double SY = 0;

            // code here

            const double e = 1e-4;
            for (double x = a; x <= b; x += h)
            {
                SY += Math.Cos(x);
                double s = 0, v = 1, p1 = 1, p2 = 1, p3 = 1, j = 1;
                while (Math.Abs(v) >= e)
                {
                    v = p1 * p2 / p3;
                    s += v;
                    p1 *= -1;
                    p2 *= x * x;
                    p3 *= j * (j + 1);
                    j += 2;
                }
                SS += s;
            }
            SS = Math.Round(SS, 6);
            SY = Math.Round(SY, 6);
            Console.WriteLine(Convert.ToString(SS) + " " + Convert.ToString(SY));
        }
    }
}
