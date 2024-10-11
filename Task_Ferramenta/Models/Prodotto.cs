﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Ferramenta.Models
{
    [Table("Prodotto")]
    public class Prodotto
    {
        public int ProdottoID { get; set; }
        public string CodiceBarre { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string? Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string? Quantita { get; set; }
        public int RepartoRIF { get; set; }      

    }
}
