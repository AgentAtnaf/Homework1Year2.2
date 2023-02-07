 class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
           float result =  question1(a);
            Console.WriteLine("{0:f3}",result);
        }
        static float question1(float x)
        {
            if(Math.Pow(x,2) <= 4)
            {
                return x = x+2;
            }
            else
            {
                return x = x+1+question1(x - (4*(Math.Abs(x)))/x);
            }
        }
    }