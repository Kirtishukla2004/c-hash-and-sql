namespace equalscheck
{
    class program
    {
      static public void equalmethods()
        {
            //using == method which compares according to behaviour of the operands 
            string a = "hello";
            string b = "hello";
            Console.WriteLine(a ==b);//true
            object obj1 = new object();
            object obj2 = new object();
            Console.WriteLine(obj1 == obj2);//false ,because memory storage will be diffrent 
            //.Equals methods
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(obj1.Equals(obj2));
            //refrenceequal 
            Console.WriteLine(ReferenceEquals(a, b));
            Console.WriteLine(ReferenceEquals(obj1, obj2));

        }
        static void Main(string[] args)
        {
            equalmethods();
        }
    }
}