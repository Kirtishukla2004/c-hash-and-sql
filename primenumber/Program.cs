namespace prime
{
    class program
    {
        static void Main(string[] args)
        {
            int startnum, endnum;
            while (true)
            {
                Console.WriteLine(" input two positive non-equal integers (between 2 and 1000)");
                Console.WriteLine("enter the smaller number ");
                startnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the larger number ");
                endnum = Convert.ToInt32(Console.ReadLine());
                if(startnum >= 2 && endnum <= 1000 && startnum < endnum)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("enter a vaild input the entred input is invaild ");
                }
            }
            for(int num = startnum; num < endnum; num++)
            {
                if (isprime(num))
                {
                    Console.WriteLine(num);
                }
            }
           
            
            static bool isprime(int number)
            {
                if (number <= 1)
                    return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }

        }
    }
}