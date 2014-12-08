using System;
using System.Security.Claims;
using System.Threading.Tasks;
using GreenReceiptRest.MySql;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GreenReceiptRest.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //If your database doesn't have this column. Run this alter script
        //alter table aspnetusers add column FirstName varchar(128) not null default ''
        public string FirstName { get; set; }
        //If your database doesn't have this column. Run this alter script
        //alter table aspnetusers add column LastName varchar(128) not null default ''
        public string LastName { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        static ApplicationDbContext()
        {
            System.Data.Entity.Database.SetInitializer(new MySqlInitializer());
        }
#if ALEX
        
            public ApplicationDbContext()
            : base("AlexConnection", throwIfV1Schema: false)
        {
            
        }
#elif DEBUG
            public ApplicationDbContext()
            : base("KingsleyConnection", throwIfV1Schema: false)
        {
            
        }
#else 
        public ApplicationDbContext()
            : base("ReleaseConnection", throwIfV1Schema: false)
        {
            
        }
#endif


            public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}