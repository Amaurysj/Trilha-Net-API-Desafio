using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Trilha_Net_API_Desafio.Models;

namespace Trilha_Net_API_Desafio.Context
{
  
     public class OrganizadorContext : DbContext
     {
         public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
         {

         }

         public DbSet<Tarefa> Tarefas { get; set; }
     }
    
}
