using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Pedro";

            Console.WriteLine(conta.saldo);

            bool resultado = conta.Sacar(500);

            Console.WriteLine(conta.saldo);
            Console.WriteLine(resultado);

            Console.WriteLine(conta.saldo);
            conta.Depositar(500);

            Console.WriteLine(conta.saldo);

            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = "Peixe";

            Console.WriteLine("Saldo do Pedro " + conta.saldo);
            Console.WriteLine("Saldo do Peixe " + conta1.saldo);

            bool resultado1 = conta.Transferir(200, conta1);

            Console.WriteLine("Saldo do Pedro " + conta.saldo);
            Console.WriteLine("Saldo do Peixe " + conta1.saldo);

            Console.WriteLine("Resultado " + resultado1);

            conta1.Transferir(100, conta);

            Console.WriteLine("Saldo do Pedro " + conta.saldo);
            Console.WriteLine("Saldo do Peixe " + conta1.saldo);

            Console.ReadLine();

        }
    }
}
