using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
	public class EmployeeManagerContext : DbContext
	{
		public DbSet<Role> Roles { get; set; }
		public DbSet<Position> Positions { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.UseSqlServer(@"");
		}
	}
}
