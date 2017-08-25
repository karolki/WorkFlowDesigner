using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WorkFlowDesigner.ClassDatabase;
using System.Data.SqlClient;

namespace WorkFlowDesigner.Forms
{
    public partial class SetDatasource : DevExpress.XtraEditors.XtraForm
    {
        public Source source = new Source();
        DatabaseConnection databaseConnection;
        NHibernateOperation operation = new NHibernateOperation();
        public SetDatasource()
        {
            InitializeComponent();
            
            IList<DatabaseConnection> connections = operation.GetList<DatabaseConnection>();
            foreach (var connection in connections)
            {
                cbConnection.Items.Add(connection.Name);
            }
        }

        private void cbConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTable.Items.Clear();
            cbTable.Visible = true;
            databaseConnection = operation.GetConnectionByName(cbConnection.SelectedItem.ToString());
            List<string> tables = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {
                Connector connectro = new Connector();
                conn.ConnectionString = connectro.GetConnectionString(databaseConnection);
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT name FROM Sys.Tables", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Add(reader[0].ToString());
                    }
                }
            }
            foreach(var table in tables)
            {
                cbTable.Items.Add(table);
            }

        }
       

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            cbColumn.Items.Clear();
            cbColumn.Visible = true;
            databaseConnection = operation.GetConnectionByName(cbConnection.SelectedItem.ToString());
            List<string> columns = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = connector.GetConnectionString(databaseConnection);
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT COLUMN_NAME FROM "+databaseConnection.Database+".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'"+cbTable.SelectedItem.ToString()+"'", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader[0].ToString());
                    }
                }
            }
            foreach (var table in columns)
            {
                cbColumn.Items.Add(table);
            }
        }

        private void cbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            source.Id_database = databaseConnection;
            source.TableName = cbTable.SelectedItem.ToString();
            source.ColumnName = cbColumn.SelectedItem.ToString();
        }
    }
}