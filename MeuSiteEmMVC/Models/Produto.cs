using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuSiteEmMVC.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
    }
}
