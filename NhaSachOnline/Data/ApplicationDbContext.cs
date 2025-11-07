using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NhaSachOnline.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
        internal object Books;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
  }
}