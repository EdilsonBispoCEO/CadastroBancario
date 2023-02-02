using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientesDeumBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
                   // Aula 01/02/23
                Contacorrente conta1 = new Contacorrente();
                conta1.agencia = 59;
                conta1.conta = ("3214-x");
                conta1.nome = "Natalia";
                conta1.saldo = 300;
                



        // Console.WriteLine("Natalia sua conta é "+conta1.agencia+" "+ conta1.conta+ ". Seu saldo atual é "+ conta1.saldo);
        // conta1.saldo = 550;
        // Console.WriteLine("O saldo anterior " + conta1.saldo );
        // conta1.Depositar(150);
        // Console.WriteLine("O saldo atual é " + conta1.saldo);



        //  Projeto 1
             Contacorrente conta2 = new Contacorrente();
              conta2.agencia = 59;
              conta2.conta = "3214-x";
              conta2.nome = "Natalia";

              conta2.saldo = 550;

            Console.WriteLine("   Natalia sua conta é  " +"  \n   " +   conta1.agencia + " " + "\n   "
                + conta1.conta +  "\n" 
              +  " Seu saldo atual é " + conta1.saldo);
            // Console.WriteLine(" o saldo da sua conta é: " + conta2.saldo);

            // if (conta2.Saque(150)) 
            //  Console.WriteLine(" Saldo atual após saque: " + conta2.saldo);


            Console.WriteLine(" Saldo atual da conta de transferencia: " + conta1.saldo);
            Console.WriteLine(" Saldo atual da conta que ira receber: " + conta2.saldo);
            if (conta1.Transferencia(10, conta2))
                Console.WriteLine("");
            Console.WriteLine(" Saldo atual após a transferencia: " + conta1.saldo);
            Console.WriteLine(" Valor de transferencia: " + conta1.valorTrans);
            Console.WriteLine(" Saldo atual após saque: " + conta2.saldo);


        }
    }
}
