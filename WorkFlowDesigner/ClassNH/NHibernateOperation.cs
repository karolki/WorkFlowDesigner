
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using WorkFlowDesigner.ClassDatabase;

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
        public DatabaseConnection GetConnectionByName(string name)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    IList<DatabaseConnection> pos = session.QueryOver<DatabaseConnection>().Where(type => type.Name == name).List();
                    transaction.Commit();

                    return pos.First();
                }
            }
        }
        public Document GetDocByName(string name)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                   
                    IList<Document> pos = session.QueryOver<Document>().Where(type => type.Name==name).List();
                    transaction.Commit();
                        
                    return pos.First();
                }
            }
        }

        public IList<Access> GetAccesByAtrID(Attributes flow)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    
                        IList<Access> access = session.QueryOver<Access>().Where(f => f.Id_attribute.Id_attribute==flow.Id_attribute).List();
                        
                    
                    transaction.Commit();
                    return access;
                }
            }
        }
        public void GetStepByPosID(Position flow)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    IList<Step> access = session.QueryOver<Step>().Where(f => f.Start_position_id.Id_position==flow.Id_position).List();
                    IList<Step> access2 = session.QueryOver<Step>().Where(f => f.End_position_id.Id_position == flow.Id_position).List();
                    
                    transaction.Commit();
                    flow.StartStepList = access;
                    flow.EndStepList = access2;
                }
            }
        }
        public IList<Step> GetStepByFlowID(FlowDefinition flow)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IList<Step> step = new List<Step>();
                    foreach (var pos in flow.PositionList)
                    {
                        IList<Step> a = session.QueryOver<Step>().Where(f => f.Start_position_id.Id_position==pos.Id_position).List();
                        step.Union(a);
                    }
                    transaction.Commit();
                   
                    return step;
                }
            }
        }
        public IList<Flow> GetFlowByFlowID(FlowDefinition flow)
        {
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                   
                        IList<Flow> a = session.QueryOver<Flow>().Where(f => f.id_flowdefinition.id_flowDefinition == flow.id_flowDefinition).List();
                    
                    transaction.Commit();

                    return a;
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
        public IList<Position> GetPositionByID(int id) 
        {
            IList<Position> listposition = new List<Position>();
            using (ISession session = InitNH.OppenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())

                {
                    listposition = session.QueryOver<Position>().Where(f => f.Id_flowDefinition.id_flowDefinition == id).List();
                }

            }
            return listposition;
        }
        public IList<Attributes> GetAttributeByID(int id)
        {
            IList<Attributes> listattributes = new List<Attributes>();
            using (ISession session = InitNH.OppenSession())

            {
                using (ITransaction transaction = session.BeginTransaction())

                {

                    listattributes = session.QueryOver<Attributes>().Where(f => f.Id_workflow.id_flowDefinition == id).List();
                    foreach(var a in listattributes)
                    {
                        a.List = session.QueryOver<ListElement>().Where(f => f.Id_attribute.Id_attribute == a.Id_attribute).List();
                    }

                }

            }
            return listattributes;
        }



    }
}