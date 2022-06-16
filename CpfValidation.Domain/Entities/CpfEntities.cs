namespace CpfValidation.Domain.Entities
{
    public class CpfEntities
    {
        public string Cpf { get; private set; }
        public CpfEntities(string cpf)
        {
            Cpf = cpf;
        }
    }
}
