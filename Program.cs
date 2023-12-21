
class Program
{
    private static void Main(string[] args)
    {
        int a = 12;
        while (a!=0)
        {
            Console.WriteLine("Meunu");
            Console.WriteLine("1.Hinh vuong");
            Console.WriteLine("2.Hinh chu nhat");
            Console.WriteLine("3.Hinh tam giac");
            Console.WriteLine("Chon di:");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                break;
                case 2:
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                break;
                case 3:
                Console.WriteLine("****");
                Console.WriteLine("***");
                Console.WriteLine("**");
                Console.WriteLine("*");
                break;
                default:
                Console.WriteLine("Co nhin ben tren yeu cau gi ko?");
                break;
            }

        }
        }
}
