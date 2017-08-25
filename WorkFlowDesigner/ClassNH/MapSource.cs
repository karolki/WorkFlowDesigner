using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowDesigner.ClassDatabase;

namespace WorkFlowDesigner.ClassNH
{
    public class MapSource : ClassMapping<Source>
    {
        public MapSource()
        {

            Table("Source");
            Id(x => x.Id_source, m => { m.Column("id_source"); m.Generator(Generators.Identity); });
            Property(x => x.TableName, m => { m.Column("table_name"); });
            Property(x => x.ColumnName, m => { m.Column("column_name"); });

            ManyToOne(x => x.Id_database, m =>
            {
                m.Column("id_connection");
            });
            /*OneToOne(x => x.Id_database, m =>
            {
                m.PropertyReference(typeof(DatabaseConnection).GetProperty(nameof(DatabaseConnection.Id_connection)));
            });*/


        }
    }
}
