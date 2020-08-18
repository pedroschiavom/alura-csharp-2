using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoPedro = new ContaCorrente();

            contaDoPedro.titular = "Pedro";
            contaDoPedro.agencia = 851;
            contaDoPedro.numero = 86321;
            contaDoPedro.saldo = 2000;

            Console.WriteLine("O nome do titular é " + contaDoPedro.titular);
            Console.WriteLine("A agência da conta é " + contaDoPedro.agencia);
            Console.WriteLine("O número da conta é " + contaDoPedro.numero);
            Console.WriteLine("O saldo da conta é " + contaDoPedro.saldo);

            contaDoPedro.saldo += 2000;
            Console.WriteLine("O saldo da conta é " + contaDoPedro.saldo);

            Console.ReadLine();

            
        }
    }
}
