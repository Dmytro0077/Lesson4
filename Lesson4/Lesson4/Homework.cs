namespace Lesson3
{
    class Homework
    {
        static void Main()
        {
            Console.WriteLine("Введіть a:");
            string? a1 = Console.ReadLine();
            Console.WriteLine("Введіть b:");
            string? b1 = Console.ReadLine();
            Console.WriteLine("Введіть c:");
            string? c1 = Console.ReadLine();
            Console.WriteLine("Введіть f:");
            string? f1 = Console.ReadLine();

            Console.WriteLine($"Введений текст, який ви хочете повторити:");
            string? text1 = Console.ReadLine();
            Console.WriteLine($"Введений число повторень тексту:");
            string? count1 = Console.ReadLine();

            bool resulta = int.TryParse(a1, out int a);
            bool resultb = int.TryParse(b1, out int b);
            bool resultc = int.TryParse(c1, out int c);
            bool resultf = int.TryParse(f1, out int f);
            bool resultcount = int.TryParse(count1, out int count);

            if (resulta && resultb && resultc && resultf && resultcount) 
            {
                MaxNumber(a, b, c, f);
                MinNumber(a, b, c, f);
                TrySumIfOdd(a, b, out int h);
                RepeatWriteText(text1,count);
            }
            
            else
            {
                Console.WriteLine("Введено некоректні дані. Будь ласка, введіть коректні дані!");
            }
        }


        static void MaxNumber(int number1, int number2, int number3, int number4)
        {
            int[] arrayNumbers =new int[4] { number1, number2, number3, number4 };

            int Maxnumber = number1;
            
            for (int i=1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] > Maxnumber)
                {
                    Maxnumber = arrayNumbers[i];
                }
            }
            Console.WriteLine($"Максимальне значення = {Maxnumber}");
        }


        static void MinNumber(int number1, int number2, int number3, int number4)
        {
            int[] arrayNumbers = new int[4] { number1, number2, number3, number4 };

            int Minnumber = number1;

            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < Minnumber)
                {
                    Minnumber = arrayNumbers[i];
                }
            }
            Console.WriteLine($"Мінімальне значення = {Minnumber}");
        }

        static bool TrySumIfOdd(int number1, int number2, out int sum)
        {
            sum = number1 + number2;

            Console.WriteLine(sum);

            return sum % 2 == 0;           
        }

        static void RepeatWriteText(string textrepeat, int countrepeat)
        {
            IEnumerable<string> strings = Enumerable.Repeat(textrepeat, countrepeat);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
//checked
