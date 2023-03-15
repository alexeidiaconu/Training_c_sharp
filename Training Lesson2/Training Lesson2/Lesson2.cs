public class Lesson2
{
    private static void Main(string[] args)
    {
        readandwrite();




    }

    public static void readandwrite()
    {
        String BoxA;
        int output;
        //BoxA = 35;
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Input Something");
        BoxA = Console.ReadLine();
        if (int.TryParse(BoxA,out output) == true) {
            Console.WriteLine("Input was:" + BoxA);
            Console.WriteLine("Number was:" + BoxA);
        }
        else { 
            Console.WriteLine("Incorrect Input!" + BoxA + " Please enter a number!");
            readandwrite();
                }
        
      
    }

}