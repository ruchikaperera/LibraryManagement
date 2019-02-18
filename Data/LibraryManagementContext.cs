using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Models
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext (DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagement.Models.Book> Book { get; set; }
    }
}
