using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Initializer : MigrateDatabaseToLatestVersion<BookContext,Configuration>
    {
    }
}