﻿using Lab_8;
using System;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Blue_1 blue1 = new Blue_1("Разбить исходный текст на строки длиной не более 50 символов." +
            //    " Перенос на новую строку осуществлять на месте пробела (слова не переносить)." +
            //    " Свойство-Output должно возвращать массив строк." +
            //    " Метод ToString() должен возвращать массив отформатированных строк построчно.");
            //blue1.Review();
            //Console.WriteLine(blue1.ToString());
            //Console.WriteLine();
            //Blue_1 blue_1 = new Blue_1(null);
            //blue_1.Review();
            //Console.WriteLine(blue_1.ToString());

            // 2
            //Blue_2 blue2 = new Blue_2("Дано текст. Необходимо удалить из текста все слова," +
            //    " которые содержат заданную последовательность букв (например, однокоренные слова)," +
            //    " а также убрать лишние пробелы, которые могут образоваться после удаления слов " +
            //    "(например, двойные пробелы или пробелы в начале и конце строки)." +
            //    " Последовательность букв передается второй строкой при создании экземпляра класса." +
            //    " Свойство Output должно возвращать итоговую строку после выполнения всех удалений," +
            //    " а метод ToString() должен возвращать сокращенный текст.", "а");
            //blue2.Review();
            //Console.WriteLine(blue2.ToString());
            //Console.WriteLine();
            //Blue_2 blue_2 = new Blue_2("ddfddf" , null);
            //blue_2.Review();
            //Console.WriteLine(blue_2.ToString());

            // 3
            //Blue_3 blue3 = new Blue_3("Определить долю (в процентах) слов, начинающихся на различные буквы." +
            //    " Выписать эти буквы и доли начинающихся на них слов." +
            //    " Свойство Output должно возвращать массив кортежей (символ в нижнем регистре, вещественное число)," +
            //    " отсортированный по убыванию доли слов. При равенстве долей сортировать по буквы по алфавиту." +
            //    " Метод ToString() должен возвращать построчно пары символа и вещественного числа, разделенных “-”.");
            //blue3.Review();
            //Console.WriteLine(blue3.ToString());
            //Blue_3 blue_3 = new Blue_3(null);
            //blue_3.Review();
            //Console.WriteLine(blue_3.ToString());

            // 4
            //Blue_4 blue4 = new Blue_4("Текст234 соде-23ржит45 слова45 и це765лые чи-09сла произвольного порядка." +
            //    " Найти сумму включенных в текст чисел.");
            //blue4.Review();
            //Console.WriteLine(blue4.ToString());
            Blue_4 blue_4 = new Blue_4("");
            blue_4.Review();
            Console.WriteLine(blue_4.ToString());

        }
    }
}
