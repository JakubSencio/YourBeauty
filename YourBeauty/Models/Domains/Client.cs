using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourBeauty.Models.Domains
{
    public class Client
    {
        public Client() 
        {
            Pricings = new Collection<Pricing>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public ICollection<Pricing> Pricings { get; set;}
    }
}
