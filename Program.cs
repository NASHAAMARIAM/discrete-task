namespace Pro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            bool flag = true;
            Console.Write("Please,Enter Num1:");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Please,Enter Num2:");
            int Num2 = int.Parse(Console.ReadLine());

            for (int Num=Num1 ; Num <= Num2; Num++)
            { 
                for (int j=2 ;j <= Num2; j++)
                {
                    if (Num!=j && Num%j==0)
                    {
                        flag = false;
                        break;
                    }
                }
               if(flag)
                {
                    Console.Write("\t" + Num);
                }
                flag = true;
            }
            Console.ReadKey();
           



 






        }
    }
}
