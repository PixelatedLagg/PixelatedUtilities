using System.Data;
using System.Data.SqlClient;

namespace PUtils.Sql
{
    public static class SqlCommands
    {
        public static SqlCommand CreateCommand(this string str, SqlConnection conn, int timeOut = 60)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = timeOut;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            return cmd;
        }
        public static void CreateAndExecuteCommand(this string str, SqlConnection conn, int timeOut = 60)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = timeOut;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            cmd.ExecuteScalar();
        }
        public static void CreateAndCloseReadCommand(this string str, SqlConnection conn, int timeOut = 60)
        {
            str.CreateAndReadCommand(conn, timeOut);
        }
        public static SqlDataReader CreateAndReadCommand(this string str, SqlConnection conn, int timeOut = 60)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 60;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            
            cmd.ExecuteScalar();
            return cmd.ExecuteReader();
        }
    }
}
