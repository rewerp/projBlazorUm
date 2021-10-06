using System;
using Microsoft.EntityFrameworkCore;

namespace projBlazorUm.Data
{
	public class AppDBContext: DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {
        }
		public DbSet<Autor>Autores { get; set; }
		public DbSet<Livro>Livros { get; set; }
	}
}
