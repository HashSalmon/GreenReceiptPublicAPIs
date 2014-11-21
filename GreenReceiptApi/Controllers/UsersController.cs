using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DA;
using Domain.Objects;

namespace GreenReceiptApi.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/users
        public IEnumerable<User> Get()
        {
            List<User> users;
            using (Context context = new Context())
            {
                users = context.Users.ToList();
            }
            return users;
        }

        // GET api/users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/users
        public void Post([FromBody]string value)
        {
        }

        // PUT api/users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        public void Delete(int id)
        {
        }
    }
}
