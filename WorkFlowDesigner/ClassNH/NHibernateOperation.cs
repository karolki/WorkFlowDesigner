
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;


namespace WorkFlowDesigner
{
    public class NHibernateOperation
    {



        public void AddElement<T>(T element)
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

        public IList<Position> GetUserPosition(User user)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IList<Position> pos = session.QueryOver<Position>().Where(type => type.Id_position == user.Id_position.Id_position).List();
                    transaction.Commit();
                    return pos;
                }
            }
        }

        public FlowDefinition GetUserFlow ( Position position)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    FlowDefinition flow = session.QueryOver<FlowDefinition>().Where(p => p.id_flowDefinition == position.Id_flowDefinition.id_flowDefinition).List().First();
                    transaction.Commit();
                    return flow;
                }
            }
        }

        

        public IList<Step> GetUserTasks (Position pos) 
        {
            
            using (ISession session = InitNH.OppenSession())
            {
                IList<StepConditions> list = new List<StepConditions>();
                using (ITransaction transaction = session.BeginTransaction())
                {        
                                        
                    IList<Step> steplist = session.QueryOver<Step>().Where(type => type.Start_position_id.Id_position == pos.Id_position).List();
                    transaction.Commit();
                    return steplist;                   
                    
                }
            }
            
        }

        public void Delete<T>(T element)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(element);
                    transaction.Commit();
                }
            }
        }

        public void Update<T>(T element)
        {
            using (ISession session = InitNH.OppenSession())

            {
                using (ITransaction transaction = session.BeginTransaction())

                {
                    session.Update(element);
                    transaction.Commit();
                }
            }
        }

        public IList<T> GetList<T>() where T : class
        {
            IList<T> listposition = new List<T>();
            using (ISession session = InitNH.OppenSession())

            {
                using (ITransaction transaction = session.BeginTransaction())

                {

                    listposition = session.QueryOver<T>().List();

                }

            }
            return listposition;
        }



    }
}