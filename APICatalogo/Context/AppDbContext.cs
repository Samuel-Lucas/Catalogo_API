using Microsoft.EntityFrameworkCore;
using APICatalogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext   // Permite Coordenar as classes para o modelo de dados
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)   // Operações (crud)
            : base(options)
        {

        }

        // Mapeiam entidades
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
