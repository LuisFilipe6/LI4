using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feira_Facil.Models
{
    public class Produto
    {

        [Key]
        public int IdProduto { get; set; }
        public int idVendedor { get; set; }
        public int idStand { get; set; }
		public double preco { get; set; }
		public string imagens { get; set; }

        public string nome { get; set; }

	}
}
