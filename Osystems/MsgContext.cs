using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.Owin;

namespace Osystems
{
    public class MsgContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}