using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
namespace WorkFlowDesigner
{
    class MapStepCondition:ClassMapping<StepCondition>
    {
        public MapStepCondition()
        {
                Table("StepCondition");
                Id(x => x.Id_stepcondition, m => { m.Column("id_stepcondition"); m.Generator(Generators.Identity); });
                Property(x =>x.Condition, m => { m.Column("condition"); });
            ManyToOne(x => x.Id_step, m =>
            {
                m.Column("id_step");
            });
        }
    }
}
