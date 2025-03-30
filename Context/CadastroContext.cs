using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;
using System;
using System.Collections.Generic;

namespace ProjetoMVC.Context
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}