using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ApplikationGrupp2.Models;

namespace ApplikationGrupp2.DAL
{
    public class UserInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User {UserID = 1, FirstName = "Anton", LastName = "Andersson", Email = "Anton.Andersson@Kaffe.com", UserName = "ANTAND",
                          Password = "Anton12345" },
                new User {UserID = 1, FirstName = "Erik", LastName = "Svensson", Email = "Erik.Svensson@hotmail.com", UserName = "ERISVE",
                          Password = "Erik12345" },
                new User {UserID = 1, FirstName = "Mikael", LastName = "Bergman", Email = "Mikael.Bergman@Yahoo.se", UserName = "MIKBER",
                          Password = "Mikael12345" },
                new User {UserID = 1, FirstName = "Svante", LastName = "Grabblund", Email = "Svante.Grabblund@Afrika.org", UserName = "SVAGRA",
                          Password = "Svante12345" },
                new User {UserID = 1, FirstName = "Johan", LastName = "Theodor", Email = "Johan.Theodor@pitberg.se", UserName = "JOHTHE",
                          Password = "Johan12345" },
                new User {UserID = 1, FirstName = "Erik", LastName = "Thor", Email = "Erik.Thor@Arlanda.nu", UserName = "ERITHO",
                          Password = "Erik12345" }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}