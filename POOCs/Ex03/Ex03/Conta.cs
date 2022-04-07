using System.Globalization;

namespace Ex03
{
    internal class ContaBancaria
    {

        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public double Deposito(double valorDeposito)
        {
            return Saldo += valorDeposito;
        }

        public double Saque(double valorSaque)
        {
            return Saldo -= valorSaque;
        }

        

    }
}
