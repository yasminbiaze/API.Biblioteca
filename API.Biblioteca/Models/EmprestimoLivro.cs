namespace API.Biblioteca.Models
{
    public class EmprestimoLivro
    {
        public Guid EmprestimoLivroId { get; set; }
        public Guid EmprestimoId { get; set; }
        public Emprestimo? Emprestimo { get; set; }
        public Guid LivroId { get; set; }
        public Livro? Livro { get; set; }
    }
}
