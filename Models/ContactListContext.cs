using Microsoft.EntityFrameworkCore;

namespace ContactList.Models {
  public class ContactListContext : DbContext {

    public ContactListContext(DbContextOptions<ContactListContext> options) : base (options) { }

    public DbSet<User> Users { get; set; }

  }
}
