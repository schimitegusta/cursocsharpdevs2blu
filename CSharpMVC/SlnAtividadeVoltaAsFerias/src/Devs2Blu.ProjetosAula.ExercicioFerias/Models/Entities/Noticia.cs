using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Devs2Blu.ProjetosAula.ExercicioFerias.Models.Entities
{
    [Table("noticias")]
    public class Noticia
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("categoriaId")]
        [Display(Name = "CategoriaId")]
        public int CategoriaId { get; set; }

        [Column("titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Column("descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
