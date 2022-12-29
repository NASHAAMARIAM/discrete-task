namespace Pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            
            Console.Write("Please,Enter Num1:");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Please,Enter Num2:");
            int Num2 = int.Parse(Console.ReadLine());
            
            for(int num = Num1 ; num <= Num2 ; num ++)
            {
                int sum = 0;
                for (int j = 1; j < num; j++)
                {

                    if (num % j == 0)
                    {
                        sum = sum + j;
                    }

                }    
                    
                    if (sum == num)
                    {
                        Console.WriteLine("\t"+num);
                        

                    }
                
                

            }

            Console.ReadKey();


        }
    }
}