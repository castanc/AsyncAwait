using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var oElement in GetNumeros())
            {
                Console.WriteLine($"Se solicita archivo grande: {oElement} ");
            }
            Console.ReadLine();
        }

        static IEnumerable<int> GetNumeros()
        {
            List<int> list = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Leo un archivo grande de 1GB: {i}");
                //yield return i;
                list.Add(i);
            }
            return list;
        }
    }
}
