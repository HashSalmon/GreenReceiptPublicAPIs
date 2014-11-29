using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocalAccountsApp.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            //using (Context context = new Context())
            //{
            //    try
            //    {
            //        List<Domain.Objects.User> users = context.Users.ToList<Domain.Objects.User>();
            //        var t = users;
            //    }
            //    catch(Exception ex)
            //    {
            //        int k = 10;
            //    }
                
            //}
            //return "";
            var userName = this.RequestContext.Principal.Identity.Name;
            return String.Format("Hello, {0}.", userName);
        }
    }
}
