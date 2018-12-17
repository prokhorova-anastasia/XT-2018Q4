using System;

namespace Epam.Task4.NumberArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 5;
            Random random = new Random();
            Console.WriteLine($"Sum for array of numbers");

            Console.WriteLine("Integer array: ");
            int[] intmas = new int[count];
            for (int i = 0; i < intmas.Length; i++)
            {
                intmas[i] = random.Next(10);
                Console.Write("{0} ", intmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Integer array sum = {0}", intmas.Sum());

            Console.WriteLine("Double array: ");
            double[] doublemas = new double[count];
            for (int i = 0; i < doublemas.Length; i++)
            {
                doublemas[i] = (double)random.Next(10);
                Console.Write("{0} ", doublemas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Double array sum = {0}", doublemas.Sum());

            Console.WriteLine("Float array: ");
            float[] floatmas = new float[count];
            for (int i = 0; i < floatmas.Length; i++)
            {
                floatmas[i] = (float)random.Next(10);
                Console.Write("{0} ", floatmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Float array sum = {0}", floatmas.Sum());

            Console.WriteLine("Byte array: ");
            byte[] bytemas = new byte[count];
            for (int i = 0; i < bytemas.Length; i++)
            {
                bytemas[i] = (byte)random.Next(10);
                Console.Write("{0} ", bytemas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Byte array sum = {0}", bytemas.Sum());

            Console.WriteLine("Sbyte array: ");
            sbyte[] sbytemas = new sbyte[count];
            for (int i = 0; i < sbytemas.Length; i++)
            {
                sbytemas[i] = (sbyte)random.Next(10);
                Console.Write("{0} ", sbytemas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Sbyte array sum = {0}", sbytemas.Sum());

            Console.WriteLine("Short array: ");
            short[] shortmas = new short[count];
            for (int i = 0; i < shortmas.Length; i++)
            {
                shortmas[i] = (short)random.Next(10);
                Console.Write("{0} ", shortmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Short array sum = {0}", shortmas.Sum());

            Console.WriteLine("Ushort array: ");
            ushort[] ushortmas = new ushort[count];
            for (int i = 0; i < ushortmas.Length; i++)
            {
                ushortmas[i] = (ushort)random.Next(10);
                Console.Write("{0} ", ushortmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Ushort array sum = {0}", ushortmas.Sum());

            Console.WriteLine("uint array: ");
            uint[] uintmas = new uint[count];
            for (int i = 0; i < uintmas.Length; i++)
            {
                uintmas[i] = (uint)random.Next(10);
                Console.Write("{0} ", uintmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("uint array sum = {0}", uintmas.Sum());

            Console.WriteLine("long array: ");
            long[] longmas = new long[count];
            for (int i = 0; i < longmas.Length; i++)
            {
                longmas[i] = (long)random.Next(10);
                Console.Write("{0} ", longmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("long array sum = {0}", longmas.Sum());

            Console.WriteLine("ulong array: ");
            ulong[] ulongmas = new ulong[count];
            for (int i = 0; i < ulongmas.Length; i++)
            {
                ulongmas[i] = (ulong)random.Next(10);
                Console.Write("{0} ", ulongmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("ulong array: sum = {0}", ulongmas.Sum());

            Console.WriteLine("decimal array: ");
            decimal[] decimalmas = new decimal[count];
            for (int i = 0; i < decimalmas.Length; i++)
            {
                decimalmas[i] = (decimal)random.Next(10);
                Console.Write("{0} ", decimalmas[i]);
            }

            Console.WriteLine();

            Console.WriteLine("decimal array sum = {0}", decimalmas.Sum());
        }

    }
}
