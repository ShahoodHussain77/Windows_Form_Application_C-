using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace SCHOOL.Sql_Classes
{
    public class connectionClass
    {
        string connectionString ="Dsn=SCHOOL;uid=sa;pwd=123456";
        OdbcConnection connection;
        OdbcCommand sqlCommand;


        public OdbcDataAdapter ExecQueryAdapter(string qry)
        {
            OdbcConnection con = CheckSqlCon();
            OdbcDataAdapter adapter = new OdbcDataAdapter(qry, con);
            return adapter;
        }

        public OdbcDataReader ExecQueryReader(string query)
        {
            OdbcConnection con = CheckSqlCon();
            sqlCommand = new OdbcCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            OdbcDataReader dr = sqlCommand.ExecuteReader();
            return dr;
        }

        public bool User_Login(string query)
        {
            OdbcConnection con = CheckSqlCon();
            sqlCommand = new OdbcCommand();            
            sqlCommand.Connection = con;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            OdbcDataReader dr = sqlCommand.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public OdbcConnection CheckSqlCon()
        {
            connection = new OdbcConnection();
            connection.ConnectionString = connectionString;
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
