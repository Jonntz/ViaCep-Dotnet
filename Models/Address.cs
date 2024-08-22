namespace CorreiosApp.Models
{
    public class Address
    {
        public string Logradouro { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string Localidade { get; set; } = string.Empty;
    }
}