using System.Globalization;

namespace ContaCorrente
{
    public class Conta
    {
        private const double _taxa = -5.00;
        private double _saldo;

        public int IdConta { get; set; }
        public string NomeTitular { get; set; }

        public Conta(int idConta, string nomeTitular) 
        {
            IdConta = idConta;
            NomeTitular = nomeTitular;
        }

        public void Depositar(double deposito)
        {
            _saldo += deposito;
        }

        public void Sacar(double saque)
        {
            _saldo = _saldo - saque + _taxa;
        }

        public string GetSaldo()
        {
            return _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
