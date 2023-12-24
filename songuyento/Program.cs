namespace songuyento;

 class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap 1 so di:");
        int a = int.Parse(Console.ReadLine());
        if(a<2)
        {
            Console.WriteLine("ko phai so nguyen to");
        }
        else
        {
            int b = 2;
            bool c = true;
            while (b<=Math.Sqrt(a))
            {
                if(a%b==0)
                {
                c=false;
                break;
                }
                b++;              
            }            
            
            if(c)            
                Console.WriteLine(a + "la so nguyen to");
            else
                Console.WriteLine(a + "ko phai so nguyen to");
        }
        }
        }
