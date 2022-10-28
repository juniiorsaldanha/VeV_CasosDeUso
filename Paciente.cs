namespace CasosDeUso
{
    public class Paciente
    {
        public string? Nome {get; set;}
        public string? Cpf {get; set; }
        public string? Telefone { get; set; }

        public Paciente(string nome, string cpf, string telefone)
        {
            Nome = nome; 
            Cpf = cpf; 
            Telefone = telefone; 
        }

        public override string ToString()
        {
            string retorno = ""; 
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "CPF: " + this.Cpf + Environment.NewLine;
            retorno += "Telefone: " + this.Telefone + Environment.NewLine;

            return retorno; 
        }
    }
}