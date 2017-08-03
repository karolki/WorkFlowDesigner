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
        public  void Add(User NewUser)
        {
            using (ISession session = InitNH.OppenSession())

            {
                using (ITransaction transaction = session.BeginTransaction())

                {
                    session.Save(NewUser);
                    transaction.Commit();
                }
            }
        }
        
    }
}
