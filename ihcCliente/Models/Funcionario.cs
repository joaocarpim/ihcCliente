using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ihcCliente.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; } // Identificador único do funcionário

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome completo deve ter no máximo 100 caracteres.")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres.")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O RG é obrigatório.")]
        [StringLength(12, ErrorMessage = "O RG deve ter no máximo 12 caracteres.")]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O telefone deve ter no máximo 15 caracteres.")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [StringLength(100, ErrorMessage = "O e-mail deve ter no máximo 100 caracteres.")]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O cargo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O cargo deve ter no máximo 50 caracteres.")]
        public string Cargo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O departamento é obrigatório.")]
        [StringLength(50, ErrorMessage = "O departamento deve ter no máximo 50 caracteres.")]
        public string Departamento { get; set; } = string.Empty;

        [Required(ErrorMessage = "O salário é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser um valor positivo.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "A data de admissão é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataDemissao { get; set; }

        [Required(ErrorMessage = "O estado civil é obrigatório.")]
        [StringLength(20, ErrorMessage = "O estado civil deve ter no máximo 20 caracteres.")]
        public string EstadoCivil { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O nome do pai deve ter no máximo 100 caracteres.")]
        public string NomePai { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O nome da mãe deve ter no máximo 100 caracteres.")]
        public string NomeMae { get; set; } = string.Empty;

        [Required(ErrorMessage = "O status do funcionário é obrigatório.")]
        public bool Ativo { get; set; } = true;
    }
}