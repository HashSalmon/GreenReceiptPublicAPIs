using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Web.Http;
using DA;
using Domain.Objects;
using Newtonsoft.Json;

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
        public User Get(int id)
        {
            return DA.DA.LoadById<User>(id);
        }

        // POST api/users //Add a new user Database
        public void Post([FromBody]string value)
        {
            User user = new User
            {
                Email = "kz@hotmail.com",
                FirstName = "Kingsley",
                LastName = "Zheng",
                Password = "666555777",
                Username = "kingtown"
            };
            user.Save();
        }

        // PUT api/users/5 //Update a user in database
        public void Put(int id, [FromBody]string value)
        {
            
        }

        // DELETE api/users/5
        public void Delete(int id)
        {
        }
    }
}
