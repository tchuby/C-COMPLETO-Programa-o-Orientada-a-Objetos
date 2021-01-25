namespace ContaCorrente
{
    public class Conta
    {
        private const double _taxa = 5.00;
        private string _saldo;

        public int IdConta { get; protected set; }
        public string NomeTitular { get; protected set; }


    }
}
