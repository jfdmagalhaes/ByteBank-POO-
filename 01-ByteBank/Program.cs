using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadaGabriela = new ContaCorrente();

            contadaGabriela.titular = "Gabriela";

            Console.WriteLine(contadaGabriela.titular);

            Console.ReadLine();

        }
    }
}
