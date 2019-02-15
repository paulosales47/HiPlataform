namespace HiPlataform.Models
{
    public class Rua
    {
        public Rua(string cep, string nome)
        {
            Cep = cep;
            Nome = nome;
        }

        public string Cep { get; set; }
        public string Nome { get; set; }
    }
}
