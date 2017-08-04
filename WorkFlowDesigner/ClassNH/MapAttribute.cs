using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class MapAttribute:ClassMapping<Attribute>
    {
        public MapAttribute()
        {
            Table("Attribute");
            Id(x => x.Id_attribute, m => { m.Column("id_attribute"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });
            Property(x => x.Type, m => { m.Column("type"); });
            Property(x => x.Read_property, m => { m.Column("read_property"); });
            Property(x => x.Optional_change, m => { m.Column("optional_change"); });
            Property(x => x.Required_change, m => { m.Column("required_change"); });

            Bag(x => x.List, m =>
            {
                m.Inverse(true); m.Key(k => k.Column("id_attribute"));

            }, r => r.OneToMany(x => x.Class(typeof(ListElement))));

            ManyToOne(x => x.Id_workflow, m => {
                m.Column("id_workflow");
            });

        }
    }
}
