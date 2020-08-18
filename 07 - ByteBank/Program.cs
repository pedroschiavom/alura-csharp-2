using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(786, 86715451);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDoPedro = new ContaCorrente(867, 8674520);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();


        }
    }
}
