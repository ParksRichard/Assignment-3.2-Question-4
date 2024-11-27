namespace Assignment_3._2_Question_4
{
    //Write a function that takes 4 numbers as input to calculate
    //teh total and average. 

    //should be simple

    internal class Program
    {
        static void calculate(int num1, int num2, int num3, int num4)
        {
  
            //calculate
            int total = num1 + num2 + num3 + num4;

            //could make in put with number of inputs for totalling average
            double average = total / 4;

            //print
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
        }

        //input
        //loop for unknown entries
        static void Main()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            //calc
            calculate(num1, num2, num3, num4);  
        }
    }
}

