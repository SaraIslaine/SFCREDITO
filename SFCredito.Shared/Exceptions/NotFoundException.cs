namespace SFCredito.Shared.Exceptions
{
    public class NotFoundException : Exception
    {
        public string Nome { get; set; }
        public NotFoundException(string name, object key)
        : base($"Registro \"{name}\" ({key}) não encontrado.")
        {
        }

        public NotFoundException(string name)
        {
            this.Nome = name;

        }
    }
}
