using Microsoft.EntityFrameworkCore;
using MyFirstProgram.Models;

namespace MyFirstProgram.Data

{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options){ }



        public DbSet<Student> Students{ get; set; }
        public DbSet<Teacher> teachers { get; set; }

    }
}
