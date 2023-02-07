class Program
{
    static void Main(string[] args)
    {
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());
        double Px = double.Parse(Console.ReadLine());
        double Py = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double r = findRadius(Cx, Cy, Px, Py);
        double a = Math.PI / 4;

        for (int i = 1; i <= n; i++)
        {
            a += Math.PI / 2;
            Px = findPointX(r, a, i, Cx);
            Py = findPointY(r, a, i, Cy);
            Cx = findCircleX(r, a, i, Cx);
            Cy = findCircleY(r, a, i, Cy);
        }
        Console.WriteLine("Ans:");
        Console.WriteLine("{0:f2}\n{1:f2}\n{2:f2}\n{3:f2}",Cx,Cy,Px,Py);
    }

    static double findRadius(double Cx, double Cy, double Px, double Py)
    {
        return Math.Sqrt(Math.Pow(Px - Cx, 2) + Math.Pow(Py - Cy, 2));
    }

    static double findPointX(double r, double a, int i, double Cx)
    {
        return r * Math.Cos(a) / Math.Pow(2, i - 1) + Cx;
    }

    static double findPointY(double r, double a, int i, double Cy)
    {
        return r * Math.Sin(a) / Math.Pow(2, i - 1) + Cy;
    }

    static double findCircleX(double r, double a, int i, double Cx)
    {
        return r * Math.Cos(a) / Math.Pow(2, i) + Cx;
    }

    static double findCircleY(double r, double a, int i, double Cy)
    {
        return r * Math.Sin(a) / Math.Pow(2, i) + Cy;
    }
}
