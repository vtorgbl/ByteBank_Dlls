using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimDePagamento = new DateTime(2021, 12, 10);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan vencimento = dataFimDePagamento - dataCorrente;
            TimeSpan minutosHoras = TimeSpan.FromMinutes(60);

            Console.WriteLine("A data e hora atuais são: " + dataCorrente);
            Console.WriteLine("A data do fim do pagamento é: " + dataFimDePagamento);

            string mensagem = "Vencimento em: " + Humanizer.TimeSpanHumanizeExtensions.Humanize(vencimento);
            string horas = "Horas: " + Humanizer.TimeSpanHumanizeExtensions.Humanize(minutosHoras);

            Console.WriteLine(mensagem);
            Console.WriteLine(horas);

            Console.ReadLine();
        }

        
    }
}
