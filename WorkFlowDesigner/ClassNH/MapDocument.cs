using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace WorkFlowDesigner
{
    class MapDocument: ClassMapping<Document>
    {
        public MapDocument()
        {
            Table("Document");
            Id(x => x.Id_document, m => { m.Column("id_document"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });
            Property(x => x.Type, m => { m.Column("type"); });
            
        }
    }
}
