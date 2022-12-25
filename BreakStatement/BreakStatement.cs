class Program
{
    static void Main()
    {
        for(int i=0; i<10; i++)
        {
            
            if(i==6)
            {
                System.Console.WriteLine("Break Statement");
                break;
            }
            System.Console.WriteLine(i);
        }
    }
}