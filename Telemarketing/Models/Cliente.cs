using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telemarketing.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public long id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        //[Column("Email")]
        //[Display(Name = "Email")]
        //public string email { get; set; }

        //[Column("Numero")]
        //[Display(Name = "Numero")]
        //public int numero { get; set; }
    }
}
