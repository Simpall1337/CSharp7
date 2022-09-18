using System;
namespace Lessons
{
    internal class Program
    {
        static void foo(ref int[] myArray)
        {
            Console.Write("Наш массив : ");
            for (int i = 0; i < myArray.Length; i++) // Вывод масива
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
            string Choose;
            Console.WriteLine("Какой елемент хотите изменить ? (Начальный,любой,конечный)");
            Choose = Console.ReadLine(); //Считывание нашего выбора
            switch (Choose) //Создание выбора изменения значение елемента масива
            {
                case "любой": //Первый выбор изменение любого елемента масива
                    Console.Write("Введите елемент который хотите изменить : ");
                    int ChangeNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число : ");
                    myArray[ChangeNum] = int.Parse(Console.ReadLine());
                    break;
                case "Начальный"://Второй выбор изменение начального числа в масиве
                    Console.Write("Введите число какое хотите изменить в начале массива : ");
                    int ChangeFirstNum = int.Parse(Console.ReadLine());
                    myArray[0] = ChangeFirstNum;
                    break;
                case "конечный"://Третий выбор изменение последнего числа в масиве
                    Console.Write("Введите число какое хотите изменить в конце массива : ");
                    int ChangeLastNum = int.Parse(Console.ReadLine());
                    myArray[^1] = ChangeLastNum;
                    break;
                default: // Возращение дефолтного текста если введены не корекные даные
                    Console.WriteLine("Введены не правильные данные!!!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[6]; // Создание массива
            for (int i = 0; i < myArray.Length; i++) // Заполнение масива
            {
                myArray[i] = random.Next(100);
            }
            foo(ref myArray); // вызов метода
            for (int i = 0; i < myArray.Length; i++) // вывод масива
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}

