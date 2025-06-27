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
            Console.Write("Por favor, escolha uma senha de 4 dígitos para acessar sua conta: ");
            string senha = Console.ReadLine();

            while (senha.Length != 4 || !senha.All(char.IsDigit))
            {
                Console.Write("Senha inválida! Por favor, digite uma senha com 4 dígitos númericos: ");
                senha = Console.ReadLine();
            }
            Console.Clear();
            Deposito dep;

            dep = new Deposito(nome, numeroConta, senha);
            
            AcessarConta(dep);

            Console.Write("\nDeseja fazer um depósito inicial? Lembrando que o depósito inicial é opcional! Digite 1 para SIM ou 2 para NÃO: ");

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
                dep = new Deposito(nome, numeroConta, valor, senha);

                Console.WriteLine(dep);
                Thread.Sleep(5000);

                Console.Clear();

                InteragirUsuario(dep);

            }
            else
            {

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
            Console.WriteLine("\n--- Menu de Opções ---");
            Console.WriteLine("1 - Depositar dinheiro");
            Console.WriteLine("2 - Não depositar");
            String entrada = Console.ReadLine();
            int escolha;
            while ((!int.TryParse(entrada, out escolha)) || escolha != 1 && escolha != 2)
            {
                Console.Write("Entrada inválida! Digite novamente: 1 para SIM ou 2 para NÃO: ");
                Console.WriteLine("\n--- Menu de Opções ---");
                Console.WriteLine("1 - Depositar dinheiro");
                Console.WriteLine("2 - Não depositar");
                entrada = Console.ReadLine();

            }
            if (escolha == 1)
            {
                RealizarDeposito(conta);
                Thread.Sleep(5000);
                Console.Clear();
            }

            Console.Write($"Deseja sacar dinheiro? Digite 1 para SIM ou 2 para NÃO: ");
            Console.WriteLine("\n--- Menu de Opções ---");
            Console.WriteLine("1 - Sacar dinheiro");
            Console.WriteLine("2 - Não sacar");
            entrada = Console.ReadLine();
            while ((!int.TryParse(entrada, out escolha)) || escolha != 1 && escolha != 2)
            {
                Console.Write("Entrada inválida! Digite novamente: 1 para SIM ou 2 para NÃO: ");
                Console.WriteLine("\n--- Menu de Opções ---");
                Console.WriteLine("1 - Sacar dinheiro");
                Console.WriteLine("2 - Não sacar");
                entrada = Console.ReadLine();
            }

            if (escolha == 1)
            {
                SacarDinheiro(conta);
            }
            else
            {
                Console.WriteLine(conta);
            }

        }
        static void AcessarConta(Deposito conta)
        {
            Console.WriteLine("Seja bem-vindo à tela de iniciar, digite suas credenciais para acessar o aplicativo de banco Unisul!");
            Console.Write("Número da conta: ");
            string entrada = (Console.ReadLine());
            int numero;
            while (!(int.TryParse(entrada, out numero)) || numero != conta.Numero)
            {
                Console.Write("Número da conta incorreto! Digite novamente: ");
                entrada = (Console.ReadLine());
            }

            int tentativas = 4;
            while (tentativas > 0)
            {
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();
                if (senha == conta.Senha)
                {
                    Console.WriteLine($"Dados corretos! Seja bem-vindo {conta.Nome}.\n");
                    return;
                }
                tentativas--;
                if (tentativas > 0)
                {
                    Console.Write($"Senha incorreta! Você tem mais {tentativas} tentativas antes do bloqueio temporário de sua conta. Escreva com atenção.\n");

                }
                else
                {
                    Console.WriteLine("Número de tentativas excedido! Sua conta está bloqueada temporariamente.\n Por favor, entre em contato conosco para desbloqueá-la.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
    
