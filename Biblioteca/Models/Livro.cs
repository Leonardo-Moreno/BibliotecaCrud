using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    [Table("Livro")]
    public class Livro
    {
        [Display(Name = "Id")]
        [Column("Id")]

        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Nome { get; set; }

        [Display(Name = "Autor")]
        [Column("Autor")]

        public string Autor { get; set; }
        
        [Display(Name = "Preco")]
        [Column("Preco")]
        public decimal Preco { get; set; }

        [Display(Name = "Lancamento")]
        [Column("Lancamento")]
        public DateTime Lancamento { get; set; } = DateTime.UtcNow;
    }
}
