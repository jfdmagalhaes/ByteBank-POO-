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
            contadaGabriela.numero = 1111;
            contadaGabriela.numeroAgencia = 1212;
            contadaGabriela.saldo = 13;

            Console.WriteLine(contadaGabriela.titular);
            Console.WriteLine(contadaGabriela.numero);
            Console.WriteLine(contadaGabriela.numeroAgencia);
            Console.WriteLine(contadaGabriela.saldo);
            Console.ReadLine();

        }
    }
}
