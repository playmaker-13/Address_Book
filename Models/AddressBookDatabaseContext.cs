using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Address_Book.Models
{
    public class AddressBookDatabaseContext : DbContext
    {
        public AddressBookDatabaseContext()
            : base("Address_Book")
        {
        }

        public DbSet<Record> Records { get; set; }
    }
}
