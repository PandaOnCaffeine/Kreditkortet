namespace Kreditkortet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Skriv et kredit nummer");
            string text = Console.ReadLine();
            int sequence = 0;

            //
            string[]numbersAsText = new string[text.Length];

            //
            foreach(char i in text)
            {
                numbersAsText[sequence] = i.ToString();
                sequence++;
            }

            //
            sequence = 0;
            int[] numbers = new int[numbersAsText.Length];
            foreach (string i in numbersAsText)
            {
                numbers[sequence] = int.Parse(numbersAsText[sequence]);
                sequence++;
            }

            //
            int check = numbers[numbers.Length - 1];
            numbers = numbers.SkipLast(1).ToArray();
            numbers = numbers.Reverse().ToArray();

            string str = "";

            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1)
                {
                    numbers[i] = numbers[i] * 2;
                    if (numbers[i] >= 10)
                    {
                        str = numbers[i].ToString();

                        num1 = int.Parse(str[0].ToString());
                        num2 = int.Parse(str[1].ToString());

                        numbers[i] = num1 + num2;
                    }
                }

            }

            string sumtxt = "";
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }

            sumtxt = sum.ToString();
            sumtxt.Split();
            
            int final = 10;

            final = final - sumtxt[1];



            if (final == check)
            {
                Console.WriteLine("Gyldigt");
            }
            else
            {
                Console.WriteLine("Ikke Gyldigt");
            }






            Console.WriteLine($"{numbers[0]}");
            Console.WriteLine($"{numbers[numbers.Length-1]}");




            /*
            //
            int[] numbers = Array.ConvertAll(text);
     
            int sequence = 0;

            foreach (char i in text)
            {
                int value = Convert.ToInt32(i);
                numbers[sequence] = value;
                sequence++;
            }
            Console.WriteLine($"{numbers[1]}");
            check = numbers[numbers.Length - 1];
            numbers.SkipLast(1).ToArray();

            Array.Reverse(numbers);





            //4916514021930560


            */








            Console.Read();
        }
    }
}