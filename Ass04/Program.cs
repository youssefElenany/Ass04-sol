namespace Ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2
            //Console.Write("Enter a number: ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine( 5* i );
            //}

            #endregion

            #region Q3
            // Console.Write("Enter a number: ");
            //for (int i = 2; i <= 15; i += 2)
            // {
            //     Console.WriteLine(i);
            // }

            #endregion

            #region Q4
            //Console.Write("Enter num01: ");
            //int Num01 = int.Parse(Console.ReadLine());
            //Console.Write("Enter num02: ");
            //int Num02 = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(Num01, Num02));

            #endregion

            #region Q5
            //int[] marks = new int[5] { 95, 76, 58, 90, 89 };
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //  total += marks[i];
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");

            #endregion

            #region Q6
            //string name;
            //name = new string("REVERSE");
            //Console.WriteLine(name);    
            #endregion

            #region Q7
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (num > 0)
            //{
            //    reversed = reversed * 10 + num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine("Reversed integer: " + reversed);

            #endregion

            #region Q8


            //Console.WriteLine("Prime numbers:");
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.WriteLine (i);
            //    }


            #endregion

            #region Q9
            //    Console.Write("Enter a decimal number: ");
            //    int num = int.Parse(Console.ReadLine());
            //    string binary = "";
            //    while (num > 0)
            //    {
            //        binary = (num % 2) + binary;
            //        num /= 2;
            //    }
            //    Console.WriteLine("Binary: " + binary);
            //}

            #endregion

            #region Q10

            #endregion

            #region Q11


            #endregion

            #region Q12

            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");


            #endregion

            #region Q13


#endregion

