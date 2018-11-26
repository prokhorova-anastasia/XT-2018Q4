using System;

namespace Epam.Tas1.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,,] Array = new int[10, 10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Array[i, j, k] = r.Next(-100, 100);
                    }
                }
            }


            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        if (Array[i, j, k] > 0)
                        {
                            Array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
