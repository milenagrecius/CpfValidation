namespace CpfValidation.Domain.Entities
{
    public class CpfEntities
    {
        public string Cpf { get; set; }
        public CpfEntities(string cpf)
        {
            Cpf = cpf;
        }
    }
}
