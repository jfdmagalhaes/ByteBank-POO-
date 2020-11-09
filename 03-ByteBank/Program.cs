using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadaGabriela = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.numeroAgencia = 123;
            contadaGabriela.numero = 45678;


            ContaCorrente contadaGabrielaCosta = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.numeroAgencia = 123;
            contadaGabriela.numero = 45678;

            Console.WriteLine("Igualdade de tipo de referencia: " + (contadaGabriela == contadaGabrielaCosta));

            Console.ReadLine();
        }
    }
}
