using System;
using System.Collections.Generic;

namespace ConvertInt32ToIpV4AndBack
{
    static class ConverterClass
    {
      public static void ConverIntToIpV4(long number)
      {
            var str = Convert.ToString(number, 2);
            List<string> Blocks = new List<string>(str.Length / 8);

            for (int i = 0; i < str.Length; i += 8)
            {
                Blocks.Add(str.Substring(i, str.Length - i > 8 ? 8 : str.Length - i));
            }

            Console.WriteLine($"{number} To IpV4 = {Convert.ToInt32(Blocks[0], 2)}.{Convert.ToInt32(Blocks[1], 2)}.{Convert.ToInt32(Blocks[2], 2)}.{Convert.ToInt32(Blocks[3], 2)}");
      }

      public static void ConverIpV4ToInt(string str)
      {
            string concat = default;
            string[] split = str.Split('.');
            for(int i = 0; i < split.Length; i++)
            {
               var str1 = Convert.ToString(Convert.ToInt32(split[i]), 2);
                str1 = string.Concat(new string('0', 8 - str1.Length), str1);
                concat += str1;
            }
            Console.WriteLine(str + " To number = " + Convert.ToInt64(concat, 2));
        }
    }
}
