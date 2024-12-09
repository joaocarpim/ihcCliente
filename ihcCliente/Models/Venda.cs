using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ihcCliente.Models
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }  // Chave primária da tabela Venda

        // Data da venda
        [Required(ErrorMessage = "A data da venda é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataVenda { get; set; }

        // Total da venda
        [Required(ErrorMessage = "O total da venda é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O total da venda deve ser um valor positivo.")]
        public decimal TotalVenda { get; set; }

        // Chave estrangeira para Cliente
        [Required(ErrorMessage = "O cliente é obrigatório.")]
        public int ClienteId { get; set; }  // Chave estrangeira para a tabela Cliente

        // Relacionamento com a entidade Cliente
        [ForeignKey("ClienteId")]
        public virtual Cliente? Cliente { get; set; }  // Navegação para o cliente

        // Relacionamento com os itens de venda
        public virtual ICollection<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();  // Relacionamento com ItemVenda
    }
}
