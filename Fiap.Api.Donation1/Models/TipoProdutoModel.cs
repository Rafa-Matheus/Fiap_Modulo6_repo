using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Api.Donation1.Models
{
    [Table("TipoProduto")]
    public class TipoProdutoModel
    {
        [Key] // Notação para indicar chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Notação para gerar Id automático e incremental
        public int TipoProdutoId { get; set; }

        // [Column("NomeTipoProduto")] // Associa a propriedade à coluna do banco
        [Required(ErrorMessage = "O nome para o tipo do produto é obrigatório.")] // Não aceita nulo
        [StringLength(55)] // Tamanho da string
        [MinLength(3)] // Tamanho mínimo para o campo
        //[Display(Name = "Nome do tipo de produto: ")]
        public string Nome { get; set; }

        [Required]
        [StringLength(256)]
        public string? Descricao { get; set; }

        [NotMapped] // Anotação para propriedade que NÃO É uma entidade do banco
        public string? Token { get; set; }


        public TipoProdutoModel() { }

        public TipoProdutoModel(int id, string nome, string descricao)
        {
            TipoProdutoId = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
