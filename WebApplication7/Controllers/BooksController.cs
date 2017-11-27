using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [System.Web.Http.Authorize(Roles = "Admin")]
    public class BooksController : ApiController
    {
        [System.Web.Mvc.HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new BookContext())
            {
                return Ok(await context.Books.Include(x => x.Reviews).ToListAsync());
            }
        }
    }
}