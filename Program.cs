using System;


class MyException : Exception
{
    public override string Message
    { 
        get 
        {

            return "Don't Do This Again!!!!!";
}
        }
    }
class Program
{
    static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("First Number Must Be Grater Than Second Number");
            Console.WriteLine("Enter Two Number");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                throw new MyException();
            }
            Console.WriteLine("Division is :{0}", n1 / n2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);


        }
        Console.ReadKey();
    }
}