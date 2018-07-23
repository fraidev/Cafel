using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cafel.WebApi.Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Cafel.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var felipe = new User("Felipe", "felipe", "felipe", new DateTime(1997,3, 07) );
                    
                    session.SaveOrUpdate(felipe);

                    transaction.Commit();
                    
                    Console.WriteLine("User Created: " + felipe.Name + "\t");
                }
            }
            
            
            CreateWebHostBuilder(args).Build().Run();
        }
        
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString("Data Source=.;Initial Catalog=CafelDB;Integrated Security=SSPI;")
                    .ShowSql())

                .Mappings(m => m.FluentMappings
                        
                .AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(true, true))
         
                .BuildSessionFactory();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
