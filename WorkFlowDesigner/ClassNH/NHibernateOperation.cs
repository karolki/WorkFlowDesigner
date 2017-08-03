using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
namespace WorkFlowDesigner
{
    class NHibernateOperation
    {

        public void AddFlow (Flow flow)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(flow);
                    transaction.Commit();
                }
            }
        }
        public void AddPosition(Position element)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(element);
                    transaction.Commit();
                }
            }
        }

        public void Delete(Flow DeleteFlow)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(DeleteFlow);
                        transaction.Commit();
                }
            }
        }
       
        public void UpdateUser(User UpdateUser)
        {
            using (ISession session = InitNH.OppenSession())

            {
                using (ITransaction transaction = session.BeginTransaction())

                {
                    session.Update(UpdateUser);
                    transaction.Commit();
                }
            }
        }

    }
}
