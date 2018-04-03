using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class InsertData
    {
        public static string Payment(string cmd)
        {
            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    new OleDbDataAdapter(selectCommand).Fill(dataTable);
                    connection.Close();
                }
    
                return  " فیش  در سیستم ثبت گردید. ";
            }
            catch (Exception ex)
            {
                return                  ex.ToString();

            }


        }


    }
}
