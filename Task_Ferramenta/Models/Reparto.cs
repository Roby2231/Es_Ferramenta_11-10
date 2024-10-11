using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Ferramenta.Models
{
    [Table("Reparto")]
    public class Reparto
    {
        public int RepartoId { get; set; }
        public string RepartoCOD { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string? Fila { get; set; }
    }
}
