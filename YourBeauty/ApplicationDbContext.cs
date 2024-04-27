using System;
using System.Data.Entity;
using System.Linq;

namespace YourBeauty
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

    }
}