﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ERPWeb.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }    

    public class erpwebEntities : IdentityDbContext<ApplicationUser>
    {
        public erpwebEntities()
            : base("ErpWebData", throwIfV1Schema: false)
        {
        }

        public static erpwebEntities Create()
        {
            return new erpwebEntities();
        }

        public System.Data.Entity.DbSet<ERPWeb.Models.Administracao.Perfil> Perfis { get; set; }

        public System.Data.Entity.DbSet<ERPWeb.Models.Administracao.Usuario> Usuarios { get; set; }
    }
}