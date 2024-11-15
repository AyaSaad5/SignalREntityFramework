using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SignalR_.Models
{
    public partial class ChatContext : DbContext
    {
        public ChatContext()
            : base("name=ChatContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
