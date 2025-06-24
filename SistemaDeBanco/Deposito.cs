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

        public Deposito(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
            Saldo = 0.0;

        }
        public Deposito(string nome, int numero, double saldo) : this(nome, numero)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
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
            return "\nOs dados da sua conta são:\nNome: " + Nome + "\n" + "Número da conta: " + Numero + "\n" + "Valor em conta = R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}