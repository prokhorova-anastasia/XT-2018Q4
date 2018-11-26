using System;

namespace Epam.Task1.FontAdjustment
{
    class Program
    {
        [Flags]
        public enum ParametrsOfText : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }

        static void Main(string[] args)
        {
            int parametr = int.Parse(Console.ReadLine());
            try
            {
                while (parametr < 1 || parametr > 3)
                {
                    Console.WriteLine("Введите число от 1 до 3: ");
                    parametr = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Enter parametr between 1 and 3: ");
                parametr = int.Parse(Console.ReadLine());
            }

            ParametrsOfText p = 0;

            while(true)
            {
                Console.WriteLine("Параметры надписи: {0}", p);
                Console.WriteLine("Введите: ");
                Console.WriteLine("\t1: bold \n\t2: italic \n\t3: underline");

                switch(parametr)
                {
                    case 1: 
                        p = ParametrsOfText.Bold; 
                        break;
                    case 2: 
                        p = ParametrsOfText.Italic; 
                        break;
                    case 3: 
                        p = ParametrsOfText.Underline; 
                        break;

                }
            }
        }
    }
}
