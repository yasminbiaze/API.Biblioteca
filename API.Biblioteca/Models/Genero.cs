using System.ComponentModel.DataAnnotations;

namespace API.Biblioteca.Models
{
    public class Genero
    {
        public Guid GeneroId { get; set; }
        [Required]
        public string? Nome { get; set; }

        // Propriedade de navegação para a relação muitos-para-muitos com Livro
        public ICollection<Livro>? Livros { get; set; }
    }


}
