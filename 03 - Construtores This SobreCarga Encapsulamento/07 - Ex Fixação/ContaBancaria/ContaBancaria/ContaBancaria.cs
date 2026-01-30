using System.Globalization;

namespace ContaBancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        override public string ToString()
        {
            return $"Conta" +
                   $"\nConta: {Numero}" +
                   $"\nTitular: {Titular}" +
                   $"\nSaldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
