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

            ContaCorrente contaDoPedro = new ContaCorrente();
            contaDoPedro.titular = "Pedro";
            contaDoPedro.agencia = 863;
            contaDoPedro.numero = 865231;

            ContaCorrente contaDoPedroS = new ContaCorrente();
            contaDoPedro.titular = "Pedro";
            contaDoPedro.agencia = 863;
            contaDoPedro.numero = 865231;

            Console.WriteLine(contaDoPedro == contaDoPedroS);



            Console.ReadLine();
        }
    }
}
