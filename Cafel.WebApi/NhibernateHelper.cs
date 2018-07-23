using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Cafel.WebApi
{
    public class NhibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString("Data Source=.;Initial Catalog=CafelDB;Integrated Security=SSPI;")
                    .ShowSql())

                .Mappings(m => m.FluentMappings
                        
                    .AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(true, false))
         
                .BuildSessionFactory();
        }
        
    }
}