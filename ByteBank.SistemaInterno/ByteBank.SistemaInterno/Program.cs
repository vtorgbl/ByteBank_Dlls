using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(458, 455789);
            Console.WriteLine(conta1.Saldo);



            conta1.Sacar(-10);
            string nome = "Guilherme";

            Console.ReadLine();
        }
    }
}
