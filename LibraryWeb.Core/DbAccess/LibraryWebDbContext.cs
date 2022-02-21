using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryWeb.Core.DbAccess
{
    public class LibraryWebDbContext : DbContext
    {
        public LibraryWebDbContext(DbContextOptions options) : base(options) 
        { }
    }
}
