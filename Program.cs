namespace Class_0609_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1;
            IName p1;

            string str = Console.ReadLine();

            if (str == "1")
            {
                p1 = new Student();
            }
            else
            {
                p1 = new Teacher();
            }

            Console.WriteLine(p1.GetName());
        }
    }
}