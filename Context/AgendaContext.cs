using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiComEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiComEntityFramework.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)  
        {
            
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}