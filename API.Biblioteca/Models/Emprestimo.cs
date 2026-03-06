namespace API.Biblioteca.Models
{
    public class Emprestimo
    {
        public Guid EmprestimoId { get; set; }
        public DateTime? DataEmprestimo { get; set; } = DateTime.Now;
        public DateTime? DataDevolucao { get; set; } = DateTime.Now.AddDays(10);
        public bool Devolvido { get; set; } = false;


        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
