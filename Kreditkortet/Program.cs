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