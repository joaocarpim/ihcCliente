using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ihcCliente.Models
{
    public class ItemVenda
    {
        [Key]
        public int ItemVendaId { get; set; }  // Chave primária da tabela ItemVenda

        // Relacionamento com Produto
        [Required(ErrorMessage = "O produto é obrigatório.")]
        public int ProdutoId { get; set; }  // Chave estrangeira para Produto

        [ForeignKey("ProdutoId")]
        public Produto? Produto { get; set; }  // Navegação para a entidade Produto

        // Relacionamento com Venda
        [Required(ErrorMessage = "A venda é obrigatória.")]
        public int VendaId { get; set; }  // Chave estrangeira para Venda

        [ForeignKey("VendaId")]
        public virtual Venda? Venda { get; set; }  // Navegação para a entidade Venda

        // Quantidade do item na venda
        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser pelo menos 1.")]
        public int Quantidade { get; set; }

        // Preço unitário do item
        [Required(ErrorMessage = "O preço unitário é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço unitário deve ser maior que zero.")]
        public decimal PrecoUnitario { get; set; }

        // Propriedade calculada (não mapeada no banco) para o subtotal de cada item
        [NotMapped]
        public decimal Subtotal => Quantidade * PrecoUnitario;
    }
}
