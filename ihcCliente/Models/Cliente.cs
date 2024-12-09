using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ihcCliente.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome completo deve ter no máximo 100 caracteres.")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório.")]
        [StringLength(12, ErrorMessage = "O RG deve ter no máximo 12 caracteres.")]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres.")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O estado civil é obrigatório.")]
        [StringLength(20, ErrorMessage = "O estado civil deve ter no máximo 20 caracteres.")]
        public string EstadoCivil { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O nome do pai deve ter no máximo 100 caracteres.")]
        public string NomePai { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O nome da mãe deve ter no máximo 100 caracteres.")]
        public string NomeMae { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        [StringLength(150, ErrorMessage = "O Logradouro não pode exceder 150 caracteres.")]
        public string Logradouro { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "O Bairro não pode exceder 50 caracteres.")]
        public string Bairro { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "A Localidade não pode exceder 50 caracteres.")]
        public string Localidade { get; set; } = string.Empty;

        [StringLength(10, ErrorMessage = "O Complemento não pode exceder 10 caracteres.")]
        public string Complemento { get; set; } = string.Empty;

        [StringLength(2, ErrorMessage = "O UF deve ter 2 caracteres.")]
        public string UF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O CEP deve ter exatamente 9 caracteres.")]
        public string CEP { get; set; } = string.Empty;
    }
}
