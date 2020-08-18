using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente pedro = new Cliente();

            //pedro.nome = "Pedro";
            //pedro.profissao = "Desenvolvedor C#";
            //pedro.cpf = "454.484.547-87";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = pedro;
           // conta.titular = new Cliente();
            conta.titular.nome = "Pedro Schiavom";
            conta.titular.cpf = "454.484.547-87";
            conta.titular.profissao = "Desenvolvedora C#";


            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 56154615;

            

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);


            Console.ReadLine();
        }
    }
}
