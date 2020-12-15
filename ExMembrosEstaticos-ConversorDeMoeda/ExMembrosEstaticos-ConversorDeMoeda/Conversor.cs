namespace ExMembrosEstaticos_ConversorDeMoeda
{
    public class Conversor
    {
        public static double Iof = 1.06;

        public static double Converter(double cotacao, double qtd)
        {
            return cotacao * qtd * Iof;
        }
    }

}
