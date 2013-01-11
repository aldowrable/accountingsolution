using System;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Accounting_Solution_Software
{
    
    class DbObject
    {    
        private string data_source = "",db_name = "",tb_name = "", uid = "", pass = "";
        private SqlConnectionStringBuilder sql_connection_string;
        //private SqlConnection sql_connection;
        protected SqlConnection Connection;
        private string connectionString = null;

        /// <summary>
        /// A parameterized constructor, it allows us to take a connection
        /// string as a constructor argument, automatically instantiating
        /// a new connection.
        /// </summary>
        /// <param name="newConnectionString">Connection String to the associated database</param>

        public string[] getDatabaseInformationLogon()
        {
            string[] str = new string[] { this.data_source, this.db_name, this.uid, this.pass };
            return str;
        }

        public DbObject()
        {
            this.data_source = "192.168.1.2";
            //this.data_source = "127.0.0.1";
            //this.data_source = "ALDOWRABLE\\ALDOWRABLE";
            this.db_name = "dbvioletha";
            this.uid = "dtss";
            this.pass = "dtss!234";

            sql_connection_string = new SqlConnectionStringBuilder();
            try
            {
                this.sql_connection_string.DataSource = this.data_source;
                this.sql_connection_string.InitialCatalog = this.db_name;
                //this.sql_connection_string.NetworkLibrary = "DBMSSOCN";
                this.sql_connection_string.UserID = this.uid;
                this.sql_connection_string.Password = this.pass;
                //this.sql_connection_string.TrustServerCertificate = true;
                //this.sql_connection_string.PersistSecurityInfo = false;
                //this.sql_connection_string.IntegratedSecurity = true;
                this.Connection = new SqlConnection(sql_connection_string.ConnectionString);
                this.Connection.Open();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                //MessageBox.Show("Aplikasi tidak dapat terhubung dengan server.");
            }
        }

        public void close_connection()
        {
            try
            {
                this.Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Protected property that exposes the connection string
        /// to inheriting classes. Read-Only.
        /// </summary>
        protected string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        /// <summary>
        /// Private routine allowed only by this base class, it automates the task
        /// of building a SqlCommand object designed to obtain a return value from
        /// the stored procedure.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure in the DB, eg. sp_DoTask</param>
        /// <param name="parameters">Array of IDataParameter objects containing parameters to the stored proc</param>
        /// <returns>Newly instantiated SqlCommand instance</returns>
        private SqlCommand BuildIntCommand(string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(storedProcName, parameters);

            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int,
                4, /* Size */
                ParameterDirection.ReturnValue,
                false, /* is nullable */
                0, /* byte precision */
                0, /* byte scale */
                string.Empty,
                DataRowVersion.Default,
                null));

            return command;
        }


        /// <summary>
        /// Builds a SqlCommand designed to return a SqlDataReader, and not
        /// an actual integer value.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure</param>
        /// <param name="parameters">Array of IDataParameter objects</param>
        /// <returns></returns>
        private SqlCommand BuildQueryCommand(string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, Connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;

        }

        /// <summary>
        /// Runs a stored procedure, can only be called by those classes deriving
        /// from this base. It returns an integer indicating the return value of the
        /// stored procedure, and also returns the value of the RowsAffected aspect
        /// of the stored procedure that is returned by the ExecuteNonQuery method.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure</param>
        /// <param name="parameters">Array of IDataParameter objects</param>
        /// <param name="rowsAffected">Number of rows affected by the stored procedure.</param>
        /// <returns>An integer indicating return value of the stored procedure</returns>
        public int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            int result;
            if(Connection.State.ToString().ToLower().CompareTo("closed")==0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }

            SqlCommand command = BuildIntCommand(storedProcName, parameters);
            rowsAffected = command.ExecuteNonQuery();
            result = (int)command.Parameters["ReturnValue"].Value;
            Connection.Close();
            return result;
        }

        /// <summary>
        /// Will run a stored procedure, can only be called by those classes deriving
        /// from this base. It returns a SqlDataReader containing the result of the stored
        /// procedure.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure</param>
        /// <param name="parameters">Array of parameters to be passed to the procedure</param>
        /// <returns>A newly instantiated SqlDataReader object</returns>
        public SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            try
            {

            SqlDataReader returnReader;
            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            SqlCommand command = BuildQueryCommand(storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;

            returnReader = command.ExecuteReader();
            //Connection.Close();
            return returnReader;
            }
            catch (SqlException sq_e)
            {
                MessageBox.Show("Koneksi Database Error.");
                return null;
            }
        }

        /// <summary>
        /// Creates a DataSet by running the stored procedure and placing the results
        /// of the query/proc into the given tablename.
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="parameters"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            try{
            DataSet dataSet = new DataSet();
            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(storedProcName, parameters);
            sqlDA.Fill(dataSet, tableName);
            Connection.Close();

            return dataSet;
                            }
            catch(SqlException sq_e)
            {
                MessageBox.Show("Koneksi Database Error.");
                return null;
            }
        }

        /// <summary>
        /// Takes an -existing- dataset and fills the given table name with the results
        /// of the stored procedure.
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="parameters"></param>
        /// <param name="dataSet"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public void RunProcedure(string storedProcName, IDataParameter[] parameters, DataSet dataSet, string tableName)
        {
            try{
            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildIntCommand(storedProcName, parameters);
            sqlDA.Fill(dataSet, tableName);
            Connection.Close();
            }
            catch (SqlException sq_e)
            {
                MessageBox.Show("Koneksi Database Error.");
            }
        }

        /// <summary>
        /// Creates a DataSet by running the query and placing the results
        /// of the query/proc into the given tablename.
        /// </summary>
        /// <param name="Query"></param>        
        /// <param name="tableName"></param>
        /// <returns>DataSet</returns>
        public DataSet RunQuery(string Query, string tableName)
        {
            try{
            DataSet dataSet = new DataSet();
            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            SqlDataAdapter sqlDA = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.CommandType = CommandType.Text;
            sqlDA.SelectCommand = cmd;
            sqlDA.Fill(dataSet, tableName);
            Connection.Close();

        return dataSet;
            }
            catch (SqlException sq_e)
            {
                MessageBox.Show("Koneksi Database Error.");
                return null;
            }
        }

        public void run_query(string query)
        {

            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            try
            {
                
                MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query, this.Connection);
                SqlDataReader reader = cmd.ExecuteReader();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        public DataTable run_query_data_table(string query)
        {
            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            try
            {
                //MessageBox.Show(query);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, this.Connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                Connection.Close();

                return dataTable;
            }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.ToString());
                            return null;
                        }
        }

        public DataTable get_all(string[] field,string tbName,string where ,string sort,string orientation ,int limit ,int offset )
        {

            if (Connection.State.ToString().ToLower().CompareTo("closed") == 0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            string select_query_string ="", limit_str = "", field_str = "";
            try
            {
                if (field != null)
                {
                    field_str = string.Join(",", field);
                }
                else
                {
                    field_str = "*";
                }

                if (sort != "")
                {
                    sort = "order by " + sort;
                    if (orientation != "")
                    {
                        sort += " " + orientation;
                    }
                }

                if (limit != 0)
                {
                    limit_str = "limit " + limit;
                    if (offset != 0)
                    {
                        limit_str += " , " + offset;
                    }
                }

                if (where != "")
                {
                    where = " where " + where;
                }

                select_query_string = "select " + field_str + " from " + tbName + " " + where + " " + sort + " " + limit_str + ";";
                //MessageBox.Show(select_query_string);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select_query_string, this.Connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                Connection.Close();

                return dataTable;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());    
                return null;
            }
            
        }

        public SqlDataReader get_single_data(string[] field, string field_dest, string value,string tb_name)
        {
            if(Connection.State.ToString().ToLower().CompareTo("closed")==0)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close();
                Connection.Open();
            }
            string select_query_string = "", where = "", field_str = "";
            try
            {

                if (field != null)
                {
                    field_str = string.Join(",", field);
                }
                else
                {
                    field_str = "*";
                }

                if (field_dest != "")
                {
                    where = " where " + field_dest + " = '" + StripSlashes(value) +"'";
                }
                select_query_string = "select " + field_str + " from " + tb_name + " " + where + ";";
                //MessageBox.Show(select_query_string);
                SqlCommand cmd = new SqlCommand(select_query_string, this.Connection);
                SqlDataReader reader = cmd.ExecuteReader();


                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }
        }

        public DataTable search()
        {
            return null;
        }

        public string AddSlashes(string InputTxt)
        {
            // List of characters handled:
            // \000 null
            // \010 backspace
            // \011 horizontal tab
            // \012 new line
            // \015 carriage return
            // \032 substitute
            // \042 double quote
            // \047 single quote
            // \134 backslash
            // \140 grave accent

            string Result = InputTxt;

            try
            {
                Result = System.Text.RegularExpressions.Regex.Replace(InputTxt, @"[\000\010\011\012\015\032\042\047\134\140]", "\\$0");
            }
            catch (Exception Ex)
            {
                // handle any exception here
                Console.WriteLine(Ex.Message);
            }

            return Result;
        }

        /// <summary>
        /// Un-quotes a quoted string
        /// </summary>
        /// <param name="InputTxt">Text string need to be escape with slashes</param>
        public string StripSlashes(string InputTxt)
        {
            // List of characters handled:
            // \000 null
            // \010 backspace
            // \011 horizontal tab
            // \012 new line
            // \015 carriage return
            // \032 substitute
            // \042 double quote
            // \047 single quote
            // \134 backslash
            // \140 grave accent

            string Result = InputTxt;

            try
            {
                Result = System.Text.RegularExpressions.Regex.Replace(InputTxt, @"(\\)([\000\010\011\012\015\032\042\047\134\140])", "$2");
            }
            catch (Exception Ex)
            {
                // handle any exception here
                Console.WriteLine(Ex.Message);
            }

            return Result;
        }

       /* public string Tb_name{get; set;}
        public string Db_name{get; set;}
        public string Data_source { get; set; }*/

    }
}
