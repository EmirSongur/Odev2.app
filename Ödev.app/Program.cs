namespace Ödev.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Başlangıç sayısını giriniz:");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş sayısı giriniz:");
            byte end = byte.Parse(Console.ReadLine());

            Console.WriteLine("Sayı adeti gir:");
            byte count = byte.Parse(Console.ReadLine());


            int[] numbers = new int[count];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(start, end);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == num)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}