using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Maper
{

    /*
     * IEntityTypeConfiguration consente di eseguire il factoring della configurazione di un tipo di entità in una classe separata, 
     * anziché in linea in OnModelCreating(ModelBuilder)
     */

    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
