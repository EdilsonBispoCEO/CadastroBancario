using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastrodeClientesDeumBanco;



internal class Contacorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo;
    public double valorTrans;
  

   // public void Depositar(double valor)

  //  {
   //     this.saldo += valor;


   // }
      public bool Saque(double valor)
     
      {
         
         if (this.saldo >= valor)
         {

            this.saldo -= valor;
            return true;
         }
         else
         {
            Console.WriteLine("saldo" + "insufisiente para realizar o saque");
            return false;
         }

            

      }
      public bool Transferencia(double valor, Contacorrente contaDestino)
      {
        if (this.saldo >= valor)
        {
            valorTrans= valor;
            this.saldo -= valor;
            contaDestino.saldo += valor;
            contaDestino.saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Não foi possível insufisiente para realizar o saque");
            return false;
        }
 
      }
}

