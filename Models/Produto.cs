using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMercadoIGL2.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int idProduto { get; set; }

        [Required(ErrorMessage = "Campo Fornecedor é OBRIGATORIO")]
        [Display(Name = "Fornecedor")]
        public int cnpjID { get; set; }
        [ForeignKey("cnpjFornecedor")]
        public Fornecedor fornecedor { get; set; }

        [Required(ErrorMessage = "Campo descricao é OBRIGATORIO")]
        [StringLength(50)]
        [Display(Name = "Descricao")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Valor Unitario é OBRIGATORIO")]
        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valorUnitario { get; set; }

        [Required(ErrorMessage = "Campo Estoque é OBRIGATORIO")]
        [Display(Name = "Estoque")]
        public int estoque { get; set; }
    }
}
