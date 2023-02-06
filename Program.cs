//Чиннов 22-ИСП-2/1 Задание 81

namespace AbstractClassLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AndArray andArray = new(new double[] { 1, 2, 3, 4, 5 });
            OrArray orArray = new(new double[] { 1, 2, 3, 4, 5 });

            
            Console.WriteLine($"{String.Join(" " ,andArray.Arr)} ");
            Console.WriteLine($"{String.Join(" ", orArray.Arr)} ");
            Console.WriteLine();

            //сложение
            Console.WriteLine("Сложение AND с {4,5,6,7,8}");

            double[] sumAnd = andArray.Sum(new double[] { 4, 5, 6, 7, 8 });
            Console.WriteLine($"{String.Join(" ", sumAnd)} ");

            Console.WriteLine("Сложение OR {4,5,6,7,8}");

            double[] sumOr = orArray.Sum(new double[] { 4, 5, 6, 7, 8 });
            Console.WriteLine($"{String.Join(" ", sumOr)} ");

            //почленная обработка
            
            andArray.ElemByElem();
            orArray.ElemByElem();
            Console.WriteLine("Почленная обработка AND");
            for (int item_index = 0; item_index < andArray.Arr.Length; item_index++)
            {
                Console.Write($"{andArray.Arr[item_index]:F2} ");
            }
            Console.WriteLine();

            Console.WriteLine("Почленная обработка OR");
            for (int item_index = 0; item_index < orArray.Arr.Length; item_index++)
            {
                Console.Write($"{orArray.Arr[item_index]:F2} ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}