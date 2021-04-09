using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class ExchangeModel : DbContext
    {
        
        public ExchangeModel()
            : base("name=Model1")
        {
        }

       

        public virtual DbSet<Exchange> Exchanges { get; set; }
    }

    public class Exchange
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public decimal Rate { get; set; }
    }
}