using System;
using System.Globalization;

namespace SistemaDeBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bem-vindo ao banco Unisul! Vamos começar pelo processo de cadastro.\nDigite o seu nome: ");
            string nome = Console.ReadLine();
            int numeroConta = new Random().Next(1000, 9999);
            Console.WriteLine("\nOlá Sr(a) " + nome + " é um prazer tê-lo conosco! O número da sua conta é: " + numeroConta +
              ", por favor, não esqueça!\n");
            Console.Write("Deseja fazer um depósito inicial? Lembrando que o depósito inicial é opcional! Digite 1 para SIM ou 2 para NÃO: ");
            Deposito dep;
            string entrada = Console.ReadLine();
            int escolha;
            while (!(int.TryParse(entrada, out escolha)) || escolha != 1 && escolha != 2)
            {
                Console.Write("Comando inválido! Digite novamente: 1 para SIM ou 2 para NÃO: ");
                entrada = Console.ReadLine();
            }
            if (escolha == 1)
            {

                Console.Write("\nQuanto deseja depositar em sua conta? Digite: R$ ");
                entrada = Console.ReadLine();
                double valor;
                while (!(double.TryParse(entrada, out valor)) || valor <= 0)
                {

                    Console.Write("Valor de depósito inválido! Digite novamente: R$ ");
                    entrada = Console.ReadLine();
                }
                dep = new Deposito(nome, numeroConta, valor);
                Console.WriteLine();
                Console.WriteLine(dep);

                InteragirUsuario(dep);
            }
            else
            {

                dep = new Deposito(nome, numeroConta);
                Console.WriteLine(dep);

                InteragirUsuario(dep);
            }


        }
        static void RealizarDeposito(Deposito conta)
        {
            Console.Write("Quantos Reais deseja depositar em sua conta? Digite o valor: R$ ");
            string entrada = Console.ReadLine();
            double valor;
            while (!(double.TryParse(entrada, out valor)) || valor <= 0)
            {

                Console.Write("Valor de depósito inválido! Digite novamente: R$ ");
                entrada = Console.ReadLine();
            }
            conta.Depositar(valor);
            Console.WriteLine(conta);

        }

        static void SacarDinheiro(Deposito conta)
        {
            Console.Write("Quantos Reais deseja sacar? Digite o valor: R$ ");
            string entrada = Console.ReadLine();
            double valor;
            while (!(double.TryParse(entrada, out valor)) || valor <= 0)
            {

                Console.Write("Valor de saque inválido! Digite novamente: R$ ");
                entrada = Console.ReadLine();
            }
            conta.Sacar(valor);
            Console.WriteLine(conta);
        }

        static void InteragirUsuario(Deposito conta)
        {
            Console.Write("Deseja depositar dinheiro? Digite 1 para SIM ou 2 para NÃO: ");
            String entrada = Console.ReadLine();
            int escolha;
            while ((!int.TryParse(entrada, out escolha)) || escolha != 1 && escolha != 2)
            {
                Console.Write("Entrada inválida! Digite novamente: 1 para SIM ou 2 para NÃO: ");
                entrada = Console.ReadLine();
            }
            if (escolha == 1)
            {
                RealizarDeposito(conta);
            }

            Console.Write($"\nDeseja sacar dinheiro? Digite 1 para SIM ou 2 para NÃO: ");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                SacarDinheiro(conta);
            }
            else
            {
                Console.WriteLine(conta);
            }

        }
    }
}