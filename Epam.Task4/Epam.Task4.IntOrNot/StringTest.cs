using System;

namespace Epam.Task4.IntOrNot
{
    public static class StringTest
    {
        public static bool IsInteger(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
