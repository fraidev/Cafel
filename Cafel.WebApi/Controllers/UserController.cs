using System.Collections.Generic;
using System.Linq;
using Cafel.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace Cafel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            
            List<User> users;

            var sessionFactory =  NhibernateHelper.CreateSessionFactory();
            using (ISession session = sessionFactory.OpenSession())  // Open a session to conect to the database
            {
                users = session.Query<User>().ToList(); //  Querying to get all the books
            }

            return users;

        }
    }
}