using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.AtividadeMVC.Models.Entities
{
    [Table("filmes")]
    public class Filme
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("nota")]
        [Display(Name = "Nota")]
        public int Nota { get; set; }

        [Column("CategoriaId")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
