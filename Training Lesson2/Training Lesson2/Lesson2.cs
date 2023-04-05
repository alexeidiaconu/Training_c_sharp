using System.Security.Cryptography;

public class Lesson2
{
    private static void Main(string[] args)
    {
        
        /*ReadAndWrite();

         Console.WriteLine("Let's Find the maximum between 2 numbers ");
          int[] input = inputTwoNumbers();
          Problem1(input[0], input[1]); 

          Console.WriteLine("Let's input an Array: ");

          input = inputAnArray();

          Console.WriteLine("----------------Results------------------4 ");

          EvenOddNumbers(input);
          SumOfArray(input);
          maxNumberOfArray(input);

          Console.WriteLine("----------------Homework------------------ ");
          Console.WriteLine("Let's Find Out if the given number is divisible by 7 AND 11! ");

          DivBy7and11(InputOneNumber());

          Console.WriteLine("Let's Find Out if the given number is divisible by any two given numbers! ");

          IsDivByTwoNumbers(InputOneNumber());

          Console.WriteLine("Let's Find Out if the given Year is Leap or Not! ");

          leapYear(InputOneNumber());

          Console.WriteLine("Let's see the list of N Prime numbers! Please enter the size of the list: ");

          TheNthPrimeNumber(InputOneNumber());

          Console.WriteLine("Let's see the lists of Prime and Even terms < 1000 in Fibonaci sequence! ");

          SumOfPrimeFibonaciTerms();
          SumOfEvenFibonaciTerms();
        Console.WriteLine("Let's calculate the sum of the digits for a given number: ");

        SumOfNumberDigits(InputOneNumber());*/


    }

    public static int[] inputTwoNumbers() // Reads 2 numbers from the keyboard
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

        Console.WriteLine(" ");

        return result;



    }


    public static void Problem1(int number1, int number2) // Finds the maximum between 2 numbers
    {
        int result = ((number1 == number2) ? 0 : (number1 > number2) ? number1 : number2);

        Console.WriteLine("The Biggest number is: " + result);
        Console.WriteLine(" ");

    }

    public static void ReadAndWrite() //Reads one number from the keyboard, validaes it and writes it to the screen: Recursive - Experimet
    {
        String BoxA;
        int output;

        Console.WriteLine("Input One Number: ");

        BoxA = Console.ReadLine();

        if (int.TryParse(BoxA, out output) == true)
        {

            Console.WriteLine("Input was:" + BoxA);
            Console.WriteLine(" ");

        }
        else
        {
            Console.WriteLine("Incorrect Input!" + BoxA + " Please enter a number!");
            ReadAndWrite();
        }


    }

    public static int InputOneNumber() //Reads one number from the keyboard, validaes it and returns it
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
        Console.WriteLine(" ");
        return result;
    }

    public static int[] inputAnArray() //Reads the length and the elemments of an int Array from the kyboard and returns it.
    {

        int Alenght;

        Console.WriteLine("Please Input the Array lenght:");

        Alenght = InputOneNumber();

        int[] result = new int[Alenght];

        Console.WriteLine("Please Input the Array Elements:");

        for (int i = 0; i < Alenght; i++)
        {
            Console.WriteLine("Element " + ++i + ":");
            i--;
            result[i] = InputOneNumber();
        }
        Console.WriteLine(" ");
        return result;

    }

    public static void maxNumberOfArray(int[] input) //Calculates the biggest number in a given int Array
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
        Console.WriteLine("      ");
    }

    public static void SumOfArray(int[] input) //Calculates the sum of the elements in a given int Array
    {
        int Sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            Sum += input[i];
        }
        Console.WriteLine("The Sum of the Array elements is: " + Sum);
        Console.WriteLine("      ");
    }

    public static Boolean IsEven(int input) //Determines if a given number is Even or not
    {
        if (input % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }    
    public static void EvenOddNumbers(int[] input) // Determines the Odd and Even numbers in a given Array
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
            evenNum = evenNum + i.ToString() + " ";
        }


        Console.WriteLine("Even numbers are: " + evenNum);

        String oddNum = " ";

        foreach (int i in odd)
        {
            oddNum = oddNum + i.ToString() + " ";
        }


        Console.WriteLine("Odd numbers are: " + oddNum);
        Console.WriteLine("      ");

    }

    public static void DivBy7and11(int input) //Determines if a given numver is divisible by 7 and 11
    {
        if (input % 77 == 0)
        {
            Console.WriteLine("The number " + input + " is DIVISIBLE by 11 and 7");
        }
        else 
        {
            Console.WriteLine("The number " + input + " is NOT divisible by 11 and 7");
        }
        Console.WriteLine("      ");
    }


    public static void IsDivByTwoNumbers(int input) //Determines if a given numver is divisible by any 2 given dividers
    {

        Console.WriteLine("Please Input the two dividers: ");
        int[] Dividers = inputTwoNumbers();


        if ((input % Dividers[0] == 0) && (input % Dividers[1] == 0))
        {
            Console.WriteLine("The number " + input + " is DIVIDED by " + Dividers[0]+ " and " + Dividers[1]);
        }
        else
        {
            Console.WriteLine("The number " + input + " is NOT divided by " + Dividers[0] + " and " + Dividers[1]);
        }
        Console.WriteLine("      ");
    }

    public static void leapYear(int input) //Determines if a given year is leap or not
    {
        if (input % 4 == 0 && (input % 100 != 0 || input % 400 == 0))
        {
            Console.WriteLine("The year " + input + " is LEAP");
        }
        else 
        {
            Console.WriteLine("The year " + input + " is NOT LEAP");
        }
        Console.WriteLine("      ");

    }

    public static Boolean IsPrime(int input) //Determines if a given number is prime or not
    {
        Boolean IsPrime = true;
        
        for (int i = 2; i * 2 <= input; i++)
        {
            if (input % i == 0 && input / i > 1)
            {
                IsPrime = false;
                break;
            }
        }
        return IsPrime;
    }

    public static void TheNthPrimeNumber(int input) //Determines the given number of Prime Terms (starting with first)
    {
        int currentNumber = 2;
        List<int> PrimeNumbers = new List<int>();

        //PrimeNumbers.Add(2);

        while (PrimeNumbers.Count < input)
        {
            //Double Mid = currentNumber / 2;
            //Boolean IsPrime = true;
            //Math.Floor(Mid)

            if (IsPrime(currentNumber))
            {
                PrimeNumbers.Add(currentNumber);
            }
            currentNumber++;
        }

        String PrimeList = " ";

        foreach (int i in PrimeNumbers)
        {
            PrimeList =  PrimeList + i.ToString() + " ";
        }

        Console.WriteLine("The list of first " + input + " Prime numbers is:");
        Console.WriteLine(PrimeList);
        Console.WriteLine("      ");
    }

    public static int Fibonaci(int input) // Determines the given number of Fibonaci sequence Terms
    {
        if (input < 2)
        {
            return 1;
        }
        else
        {
            return Fibonaci(input - 2) + Fibonaci(input - 1);
        }
    }

    public static void SumOfPrimeFibonaciTerms() //Determines the sum of Prime Fibonnaci sequence terms < 1000
    { 
       String PrimeFibo = " ";
        int i = 2;
        int FiboTerm = 0;
        int sum = 0;

        while(FiboTerm < 1000)
        {
            FiboTerm = Fibonaci(i);
            if (IsPrime(FiboTerm) && FiboTerm < 1000)
            {
                sum += FiboTerm;
                PrimeFibo = PrimeFibo + FiboTerm.ToString() + " ";
            }
            i++;
        }

        Console.WriteLine("The list of Prime terms in Fibonacci sequence is:");
        Console.WriteLine(PrimeFibo);
        Console.WriteLine("      ");
        Console.WriteLine("The Sum of Prime terms in Fibonacci sequence is:" + sum);
        Console.WriteLine("      ");
    }

    public static void SumOfEvenFibonaciTerms() //Determines the sum of Even Fibonnaci sequence terms < 1000
    {
        String PrimeFibo = " ";
        int i = 2;
        int FiboTerm = 0;
        int sum = 0;

        while (FiboTerm < 1000)
        {
            FiboTerm = Fibonaci(i);
            if (IsEven(FiboTerm) && FiboTerm < 1000)
            {
                sum += FiboTerm;
                PrimeFibo = PrimeFibo + FiboTerm.ToString() + " ";
            }
            i++;
        }

        Console.WriteLine("The list of Even terms in Fibonacci sequence is:");
        Console.WriteLine(PrimeFibo);
        Console.WriteLine("The Sum of Even terms in Fibonacci sequence is:" + sum);
        Console.WriteLine("      ");
        
    }

    public static void SumOfNumberDigits(int input) // Determines the sum of the difits for a given number
    {
        String DigitList = input.ToString();
        int sum = 0;

        for (int i = 0; i < DigitList.Length; i++)
        {
            sum += DigitList[i] - '0';
        }
        Console.WriteLine("The Sum of Digits of the number: " + input + " is:" + sum);
    }
}