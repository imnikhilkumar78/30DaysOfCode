using ArrayQuestions;

internal class Program
{
    private static void Main(string[] args)
    {
        Program prg = new Program();
        prg.printMenu();

        Console.ReadKey();

        
    }

    public void printMenu()
    {
        Program prg = new Program();
        Console.WriteLine("Enter Number of Operation You want to perform");
        Console.WriteLine("1. Rotate Array by D");
        try
        {
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Rotation Of Array");
                    ArrayRotation arrayRotation = new ArrayRotation();
                    arrayRotation.RotateArray();
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Enter only Integer from Menu : "+e.Message);
            prg.printMenu();
        }
    }
}