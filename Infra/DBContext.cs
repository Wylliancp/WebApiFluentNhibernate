using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApiFluentNhibernate.Infra
{
    public class DBContext : IDisposable
    {
        public ISession session;
        public ITransaction transaction;
        public static ISessionFactory sessionFactory;

        public DBContext()
        {
            sessionFactory = CreateSessionFactory();
            session = sessionFactory.OpenSession();
            transaction = session.BeginTransaction();

        }

        private static ISessionFactory CreateSessionFactory()
        {
            var pathScriptBanco = ConfigurationManager.ConnectionStrings["desafio"];

            var retorno = sessionFactory ?? (sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey("desafio")).ShowSql())
                                                                      .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                                                                      .ExposeConfiguration(cfg => new SchemaExport(cfg).SetOutputFile(pathScriptBanco.Name).Create(false,false))
                                                                      .BuildSessionFactory());
            return retorno;
        }
        public void Dispose()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Dispose();
            }
        }
    }
}