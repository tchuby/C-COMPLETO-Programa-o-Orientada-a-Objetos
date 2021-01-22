namespace ExMembrosEstaticos_ConversorDeMoeda
{
    public static class Conversor
    {
        private static double Iof = 1.06; 

        public static double Converter(double cotacao, double qtd)
        {
            return cotacao * qtd * Iof;
        }
    }
}
