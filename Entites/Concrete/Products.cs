using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    [Table("Products")]
    public class Products : IEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("quantity")]
        public int quantity { get; set; }
        [Column("price")]
        public decimal price { get; set; }

       
    }
}
