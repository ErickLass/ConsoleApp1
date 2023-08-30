using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //identaçao: organizar o codigo (ctrl + k + d)
            
            Console.WriteLine("--ERICK COMPRAS ONLINE--");
            Console.WriteLine("Antes de comprar seu lindo celular de R$ 400, você precisa se cadastrar!");
            Console.WriteLine("Para se cadastrar na loja você deve nos informar:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome:");
            string sobrenome = Console.ReadLine();

            string nomecompleto = nome + " " + sobrenome;

            Console.WriteLine("Olá " + nomecompleto + "!");

            Console.Write("Numero do cartâo: ");
            int numerodocartao = int.Parse(Console.ReadLine());
            Console.Write("Seu saldo: ");
            int saldo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int saldofinal = saldo - 400;

            Console.WriteLine("Estas são suas informações, deseja finalizar a compra?");
            Console.WriteLine("Nome: " + nomecompleto);
            Console.WriteLine("Numero do cartâo: " + numerodocartao);
            Console.WriteLine("Saldo final: " + saldofinal);
            Console.WriteLine("Produto: Celular");

            bool sim = Console.ReadLine() == "sim";
            bool compraRealizada = saldofinal >= 0 && sim == true;

            if (sim)
            {
                Console.WriteLine("carregando...");

            }
            else
            {
                Console.WriteLine("OK!");
            }
            
            if (compraRealizada)
            {
                Console.WriteLine("Compra finalizada, seu celular chegará na segunda-feira, saldo restante: " + saldofinal);
            }
            else
            { 
                Console.WriteLine("Saldo indisponivel para a compra ou não foi possível realizar sua compra, tente novamente.");
            }


            Console.ReadLine();
        }
    }
}
