using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourBeauty.Models.Domains;

namespace YourBeauty.Models.Configurations
{
    public class PricingConfiguration : EntityTypeConfiguration<Pricing>
    {
        public PricingConfiguration()
        {
            ToTable("dbo.Pricings");

            HasKey(x => x.Id);
        }
    }
}
