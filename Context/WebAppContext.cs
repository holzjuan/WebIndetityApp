using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebIdentityApp.Models;

namespace WebIdentityApp.Context
{
    public class WebAppContext : IdentityDbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options) { }

        public DbSet<Aluno> Alunos {  get; set; }
    }
}
