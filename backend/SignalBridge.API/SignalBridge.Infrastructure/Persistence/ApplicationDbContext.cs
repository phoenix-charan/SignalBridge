using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalBridge.Infrastructure.Identity;

namespace SignalBridge.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}