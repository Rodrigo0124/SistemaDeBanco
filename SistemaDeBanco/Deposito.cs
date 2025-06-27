using System.Globalization;

namespace SistemaDeBanco
{
    public class Deposito
    {
        public string Nome
        {
            get;
            set;
        }
        public int Numero
        {
            get;
            private set;
        }
        public double Saldo
        {
            get;
            private set;
        }
        public string Senha
        {
            get;
            private set;
        }
        public Deposito(string nome, int numero, string senha)
        {
            Numero = numero;
            Senha = senha;
            Nome = nome;
        }

        public Deposito(string nome, int numero, double saldo, string senha) : this(nome, numero, senha)
        {
            Depositar(saldo);
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido!");
                return;
            }
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            const double taxa = 5.0;
            Saldo -= valor + taxa;
        }

        public override string ToString()
        {
            return $@"
            ===== Dados da Conta =====
            Nome: {Nome}
            Número da conta: {Numero}
            Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}
            ===========================
                                        ";
        }
    }
}