namespace TEST_pactice
{
    public class TestRecursive
    {
        // Power
        public static double Power( int a , int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * Power(a, b - 1);
            }
        }
        
        
        // sum of Series
        // Series = 5+10+15+....5*n,n>0
        public static int SeriesIs5(int n)
        {
            if (n == 1)
            {
                return 5;
            }

            return 5 * n + SeriesIs5(n - 1);
        }
        // sum of Series
        public static int Series(int m,int n)
        {
            if (n == 1)
            {
                return m;
            }

            return m * n + Series(m,n - 1);
        }
        //Fibonacci
        //1,1,2,3,5,8,13,...
        public double Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        
        //find sum of numbers form 1 to n
        public static int Sum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + Sum(n - 1);
        }
        
        //rewrite to recursive function

        // int function(int n)
        // {
        //     var sum = 0;
        //     var i = 0;
        //     for ( ; i < n; i++)
        //         sum = sum + 2 * i;
        //         return sum;
        // }

        public static int Function(int n)
        {
            if (n <= 1)
            {
                return 0;
            }

            return 2 * (n-1) + Function(n - 1);
        }
        
    }
}