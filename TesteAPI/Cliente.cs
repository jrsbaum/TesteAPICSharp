using System.ComponentModel.DataAnnotations;

namespace TesteAPI
{
    public class Cliente
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Nome { get; set; } = string.Empty;
        [StringLength(20)]
        public string Email { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
        public int Telefone { get; set; }
        public int Registro { get; set; }
    }
}
