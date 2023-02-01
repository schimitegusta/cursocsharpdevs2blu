using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.ExercicioFerias.Models.Entities
{
    [Table("categorias")]
    public class Categoria
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Noticia>? Noticias { get; set; }
    }
}
