class Program
{
    static void Main(string[] args)
    {
        double a = float.Parse(Console.ReadLine());
        double result =  question1(a);
        Console.WriteLine("{0:f3}",result);
    }
    static double question1(double x)
    {
        if(x >= -1 && x <= 1)
        {
            return Math.Sqrt(1 - Math.Pow(x,2));
        }
        else if(x < -1)
        {
            return question1(x + 2);
        }
        else
        {
            return question1(x - 2);
        }
    }
}


