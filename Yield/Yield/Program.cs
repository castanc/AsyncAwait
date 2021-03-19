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
                Console.WriteLine("Se solicita archivo grande");
            }
        }

        static IEnumerable<int> GetNumeros()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Leo un archivo grande de 1GB");
                yield return i;
                Console.WriteLine("Liberamos memoria");
            }
        }
    }
}
