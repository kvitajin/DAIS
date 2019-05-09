using System;
using Oracle.ManagedDataAccess.Client;

namespace WebApplication1.App_Data.db_shets {
    public class Database {
       private OracleConnection Connection { get; set; }

       public Database() {
           Connection = new OracleConnection();
       }
       public  bool Connect(string conString)
       {
           if (Connection.State != System.Data.ConnectionState.Open)
           {
               Connection.ConnectionString = conString;
               Connection.Open();
           }
           return true;
       }
       public  bool Connect()
       {
           Connection = new OracleConnection(
               "User Id=kvi0029;Password=n2HO69fi3w;Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = dbsys.cs.vsb.cz)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = oracle.dbsys.cs.vsb.cz)));");
           Connection.Open();
           return true;
       }
       public  void Close()
       {
           Connection.Close();
       }
       public int ExecuteNonQuery(OracleCommand command)
       {
           int rowNumber = 0;
           try
           {
               rowNumber = command.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               throw e;
           }
           finally
           {
               Close();
           }
           return rowNumber;
       }
       public OracleCommand CreateCommand(string strCommand)
       {
           OracleCommand command = new OracleCommand(strCommand, Connection);

       
           return command;
       }
       /// <summary>
       /// Select encapulated in the command.
       /// </summary>
       public OracleDataReader Select(OracleCommand command)
       {
           //command.Prepare();
           OracleDataReader sqlReader = command.ExecuteReader();
           return sqlReader;
       }
    }
}