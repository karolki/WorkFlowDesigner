using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
namespace WorkFlowDesigner
{
    class MapStep : ClassMapping<Step>
    {
        public MapStep()
        {


            Table("Step");
            Id(x => x.Id_step, m => { m.Column("id_step"); m.Generator(Generators.Identity); });
            Property(x => x.Description, m => { m.Column("description"); });
            ManyToOne(x => x.Start_position_id, m =>
            {
                m.Column("start_position_id");
            });
            ManyToOne(x => x.End_position_id, m =>
            {
                m.Column("end_position_id");
            });
           



        }
    }
}