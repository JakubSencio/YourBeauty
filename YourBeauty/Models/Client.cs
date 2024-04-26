using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourBeauty.Models
{
    public class Client // Id FirstName LastName Data Zabieg Price Time
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Data {  get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Time {  get; set; }
        public Group Group { get; set; }
    }
}
