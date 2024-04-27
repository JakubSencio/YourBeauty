using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourBeauty.Models.Domains
{
    public class Pricing
    {
        public int Id { get; set; }
        public int Price { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
