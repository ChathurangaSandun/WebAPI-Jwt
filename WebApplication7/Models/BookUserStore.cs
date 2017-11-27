using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication7.Models
{
    public class BookUserStore : UserStore<IdentityUser>
    {
        public BookUserStore() : base(new BookContext())
        {
        }
    }
}