using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAgenda.Models;

namespace WebAppAgenda.Data
{
    public class WebAppAgendaContext : DbContext
    {
        public WebAppAgendaContext (DbContextOptions<WebAppAgendaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAgenda.Models.Person> Person { get; set; }
    }
}
