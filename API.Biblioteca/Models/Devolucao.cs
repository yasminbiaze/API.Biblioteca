namespace API.Biblioteca.Models
{
    public class Devolucao
    {
        public Guid DevolucaoId { get; set; }
        public DateTime DataDevolucao { get; set; } = DateTime.Now;
        public Guid EmprestimoId { get; set; }
        public Emprestimo? Emprestimo { get; set; }
        public bool Atrasado { get; set; } = false;
    }
}
