using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slovarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> fir = new Dictionary<int, string>();

            fir.Add(1, "Долина");
            fir.Add(2, "Карина");
            fir.Add(3, "Прострация");
            fir.Add(4, "Карбон");
            fir.Add(5, "Керамика");
            fir.Add(6, "Пóтен");
            fir.Add(7, "Бутон");
            fir.Add(8, "Хороший Вопрос");
            fir.Add(9, "Сильно");
            fir.Add(10, "Контекст");

            Console.Write("Введите номер заказа: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (fir.ContainsKey(num))
            {
                Console.WriteLine($"Заказ под номером {num} - {fir[num]}");
                Console.ReadLine();

                Console.WriteLine($"Заказ под номером {num} удален");
                fir.Remove(num);
                Console.ReadLine();

                Console.WriteLine("Оставшиеся элементы словаря:");
                foreach (KeyValuePair<int, string> i in fir)
                {
                    Console.WriteLine($"{i.Key}: {i.Value}");
                }
                Console.ReadLine();

                Console.WriteLine("Удалены все элементы");
                fir.Clear();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"В словаре нет информации о данном заказе {num}");
                Console.ReadLine();
            }
        }

    }
}
