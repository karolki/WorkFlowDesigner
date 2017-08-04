using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class MapListElement : ClassMapping<ListElement>
    {
        public MapListElement()
        {
            Table("ListElement");
            Id(x => x.Id_list_element, m => { m.Column("id_list_element"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });

            ManyToOne(x => x.Id_attribute, m => {
                m.Column("id_atribute");
            });
        }
    }
}
