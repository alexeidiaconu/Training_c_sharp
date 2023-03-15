public class Lesson2
{
    private static void Main(string[] args)
    {
        //ReadAndWrite();

        Console.WriteLine("Let's Find the maximum between 2 numbers ");
        int[] input = inputTwoNumbers();
        Problem1(input[0], input[1]);

        Console.WriteLine("Let's input an Array: ");

        input = inputAnArray();

        Console.WriteLine("----------------Results------------------ ");

        EvenOddNumbers(input);
        SumOfArray(input);
        maxNumberOfArray(input);






    }

    public static int[] inputTwoNumbers()
    {
        String Num1;
        String Num2;
        int output;
        int[] result = new int[2];

        Console.WriteLine("Input First Number: ");
        Num1 = Console.ReadLine();

        while (int.TryParse(Num1, out output) == false)
        {
            Console.WriteLine("Incorrect Input!" + Num1 + " Please enter a number!");
            Num1 = Console.ReadLine();
        }

        Console.WriteLine("Input Second Number: ");
        Num2 = Console.ReadLine();

        while (int.TryParse(Num2, out output) == false)
        {
            Console.WriteLine("Incorrect Input!" + Num1 + " Please enter a number!");
            Num2 = Console.ReadLine();
        }

        result[0] = int.Parse(Num1);
        result[1] = int.Parse(Num2);

        return result;
        


    }

    // Find the maximum between 2 numbers
    public static void Problem1(int number1, int number2)
    {
        int result = ((number1 == number2) ? 0 : (number1 > number2) ? number1 : number2);

        Console.WriteLine("The Biggest number is: " + result);
      
    }

    public static void ReadAndWrite()
        {
            String BoxA;
            int output;

            Console.WriteLine("Input One Number: ");

            BoxA = Console.ReadLine();

            if (int.TryParse(BoxA, out output) == true)
            {

                Console.WriteLine("Input was:" + BoxA);
                
            }
            else
            {
                Console.WriteLine("Incorrect Input!" + BoxA + " Please enter a number!");
                ReadAndWrite();
            }


        }

    public static int InputOneNumber()
    {
        String Num1;
        int output;

        Console.WriteLine("Input One Number: ");
        Num1 = Console.ReadLine();

        while (int.TryParse(Num1, out output) == false)
        {
            Console.WriteLine("Incorrect Input!" + Num1 + " Please enter a number!");
            Num1 = Console.ReadLine();
        }

        int result = int.Parse(Num1);
        return result;
    }
    public static int[] inputAnArray()
    {
        
        int Alenght;
        int output;

        Console.WriteLine("Please Input the Array lenght:");
        //Alenght = Console.ReadLine();

        Alenght = InputOneNumber();

        int[] result = new int[Alenght];

        for (int i = 0; i < Alenght; i++) 
        {
            result[i] = InputOneNumber();
        }

        return result;

    }

    public static void maxNumberOfArray(int[] input)
    {
        int Max = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > Max)
            {
                Max = input[i];
            }
        }
        Console.WriteLine("The biggest number in Array is: " + Max);
    }

    public static void SumOfArray(int[] input) 
    {
        int Sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            Sum += input[i];
        }
        Console.WriteLine("The Sum of the Array elements is: " + Sum);
    }

    public static void EvenOddNumbers(int[] input)
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] % 2 == 0)
            {
                even.Add(input[i]);   
            }
            else
            {
                odd.Add(input[i]);
            }
        }

        String evenNum = " ";

        foreach (int i in even)
        {
            evenNum = evenNum + i.ToString()+ " ";
        }


        Console.WriteLine("Even numbers are: " + evenNum);

        String oddNum = " ";

        foreach (int i in odd)
        {
            oddNum = oddNum + i.ToString() + " ";
        }


        Console.WriteLine("Odd numbers are: " + oddNum );
  
    }
 
}