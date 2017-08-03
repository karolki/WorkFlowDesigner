using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;

namespace WorkFlowDesigner
{
    class InitNH
    {
        public static ISessionFactory SessionFactory;
        public static void InitNHibernate()
        {
           

            if (SessionFactory != null)
                return;

            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ToString();

            string databaseName = ConfigurationManager.AppSettings["DatabaseName"];

            NHibernate.Cfg.Configuration config = new NHibernate.Cfg.Configuration().DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2008Dialect>();
                db.Driver<SqlClientDriver>();
                db.ConnectionString = connectionString;
            });
            ModelMapper mapper = new ModelMapper();
            mapper.AddMappings(new List<Type>()
            {
              typeof(MapUser)
            });

            config.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), "EWA");

            NHibernate.Tool.hbm2ddl.SchemaMetadataUpdater.QuoteTableAndColumns(config);

            SessionFactory = config.BuildSessionFactory(); 
        }

    }
}
