using LibreriaPrioridades.Models;
using Microsoft.EntityFrameworkCore;

namespace PrioridadesProject.API.DAL
{
	public class Contexto:DbContext
	{
		public Contexto(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Prioridades> Prioridades { get; set; }
		public DbSet<Clientes> Clientes { get; set; }

		public DbSet<Tickets> Tickets { get; set; }
		public DbSet<Sistemas> Sistemas { get; set; }
	}
}
