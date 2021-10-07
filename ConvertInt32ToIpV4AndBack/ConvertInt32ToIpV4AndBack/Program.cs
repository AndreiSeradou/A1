using System;
using System.Collections.Generic;


namespace ConvertInt32ToIpV4AndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterClass.ConverIntToIpV4(2149583360);
            ConverterClass.ConverIpV4ToInt("128.32.10.0");
        }

    }
}
