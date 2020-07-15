using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SqlMultiScript.Class
{
    class SqlOperations : ExceptionOperations
    {
        public string Servername { get; set; }
        public string DbName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string authenticationmode { get; set; }


        public SqlOperations(params string[] args)
        {
            Servername = args[0];
            DbName = args[1];
            Password = args[2];
            Username = args[3];
            authenticationmode = args[4];
        }


        public static void ConnectTest(string servername, string username, string password)
        {
            SqlConnection con = new SqlConnection("Server = " + servername + "; Database=master;User Id = " + username + "; Password = " + password + ";");

            try
            {
                con.Open();
                if (con.State != ConnectionState.Open)
                {
                    throw new ExceptionOperations("Connection failed");
                }

                MessageBox.Show("Connection successful");

            }
            catch (ExceptionOperations ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException sp)
            {
                MessageBox.Show(sp.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public static List<string> GetDbName(string servername, string username, string password)
        {
            List<string> list = new List<string>();
            SqlConnection con = new SqlConnection("Server = " + servername + "; Database=master;        User Id = " + username + "; Password = " + password + ";");

            try
            {
                con.Open();

                if (con.State != ConnectionState.Open)
                {
                    throw new ExceptionOperations("Connection failed");
                }

                string query = "SELECT (@@servername+'.dbo.'+name)name  FROM sys.sysdatabases ";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }

                con.Close();
            }
            catch (ExceptionOperations ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (SqlException sp)
            {
                MessageBox.Show(sp.Message);
            }
            finally
            {
                con.Close();
            }


            return list;
        }


        public List<string> UpdateDataBase(string script)
        {
            List<string> errors = new List<string>();

            string sqlConnectionString = "Server=" + Servername + ";Database=" + DbName + ";User ID=" + Username + ";Password=" + Password + ";";

            SqlConnection connection = new SqlConnection(sqlConnectionString);
            try
            {
                
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        // new SqlCommand(commandString, conn).ExecuteNonQuery();
                        connection.Open();
                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;
                        transaction = connection.BeginTransaction("Transaction");
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            command.CommandText = commandString;
                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch (SqlException sqlmessage)
                        {
                            transaction.Rollback();
                            connection.Close();
                            errors.Add(sqlmessage.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                //errors.Add("Database updated successfully.");
            }
            catch (SqlException er)
            {
                connection.Close();
                errors.Add(er.Message);
            }
            finally
            {
                connection.Close();
            }

            return errors;
        }

    }
}
