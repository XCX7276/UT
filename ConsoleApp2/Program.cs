using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 4, 0, 3, 19, 492, -10, 1 }; 
            Console.WriteLine(MinSum(mass));
            Console.WriteLine();


            int[] nums = new int[4];
            Console.WriteLine("hash "+ nums.GetHashCode());
            foreach (var item in nums)
            { 
                Console.Write(item + " " + item.GetType() + " " + item.GetTypeCode() + " " +item.GetHashCode() +" "   );
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.ReadLine();
        } 
        static public int? MinSum(int[] array)
        {
            if (array.Length < 2) return null; 
            Array.Sort(array); 
            return array[0] + array[1];
        }
        static public double? MinSum(double[] array)
        {
            if (array.Length < 2) return null;
            Array.Sort(array);
            return array[0] + array[1];
        }
        static public int? MinSum(string[] array)
        { 
            return null;
        }
        static public int? MinSum(char[] array)
        {
            return null;
        }
    }
}
/*
 Напишите функцию, на вход которой приходит массив чисел. Функция возвращает сумму двух минимальных элементов массива.
Например, если дан массив [4, 0, 3, 19, 492, -10, 1], то результатом будет -10, потому что два минимальных числа -10 и 0, а их сумма -10.
Напишите минимум 3 модульных теста на эту функцию.
HINT: учти, что массив может быть пустым, или без цифр или состоять из 100 млн. элементов, поэтому надо учесть разные граничные условия.
Результат тестового выложи в виде ссылки на репозиторий с исходным кодом на github.com
 
 */