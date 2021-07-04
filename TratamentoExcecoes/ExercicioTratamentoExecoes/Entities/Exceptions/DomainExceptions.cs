using System;

namespace ExercicioTratamentoExecoes.Entities.Exceptions
{
    public class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }
    }
}
