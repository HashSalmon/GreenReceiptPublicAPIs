using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DA;

namespace GreenReceiptRest.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            //try
            //{
            //    using (Context context = new Context())
            //    {

            //        List<Domain.Objects.User> users = context.Users.ToList<Domain.Objects.User>();
            //        var t = users;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    int k = 10;
            //    var t = k;
            //}
            //return "";
            var userName = this.RequestContext.Principal.Identity.Name;
            return String.Format("Hello, {0}.", userName);
        }
    }
}
