using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class GetDAta
    {
        public static DataTable SimpleCommand(string cmd, ref string message)
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
                if (dataTable.Rows.Count == 0)
                {
                    message = "No Data To Return";
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }


        }

        public static LastLoanGeneralInfo  GetLoanDetails(LastLoanGeneralInfo loan)
        {
            var loanIdCommand = string.Format("SELECT  sUM(Receipt.Amount) AS SumAmount, MAX(Receipt.ReceiptDate) AS MaxReceipt FROM Receipt where LoanId = {0}", loan.LoanId);
            string dataBase = Helper.GetConnectionString();
            DataTable dataTable = new DataTable();
            try
            {
     using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(loanIdCommand, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                     loan.LastPayment =   Transform.ConvertFromDBVal<string>(reader["MaxReceipt"]);
                     loan.PaymentAmount= Convert.ToInt32( Transform.ConvertFromDBVal<double>(reader["SumAmount"]));
                         
                        }
                    }
                    connection.Close();
                }
                return loan;
            }
            catch (Exception x)
            {
                var s= x.Message;
                return null;
            }
           

            
       

        }

        public static PersonelGeneralInfo GetPersonelGeneralInfo(Personel personel, ref string message)
        {
            var personelGeneralInfo = new PersonelGeneralInfo(personel);
            var loanIdCommand = string.Format("SELECT  * FROM Loan where personelId ={0} and  expired<>true", personel.Id);
            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(loanIdCommand, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personelGeneralInfo.LoanId = (int)reader["Id"];
                            personelGeneralInfo.LoanReceiptDate = (string)reader["ReceiptDate"];
                            personelGeneralInfo.LoanAmount = (Int32)reader["Amount"];
                        }
                    }
                    connection.Close();
                }
                if (personelGeneralInfo.LoanId >= 0)
                {
                    //get sabeghe pardakht
                    var lastLoan = new LastLoanGeneralInfo(personelGeneralInfo.LoanId,personelGeneralInfo.LoanAmount);
                    
                    lastLoan = GetLoanDetails(lastLoan);
                    personelGeneralInfo.LoanDebtAmount = lastLoan.DebtAmount.ToString();
                    if (!string.IsNullOrEmpty(lastLoan.LastPayment))
                    {
                    personelGeneralInfo.LasPayment = lastLoan.LastPayment.ToString();

                    }


                }
       
                return personelGeneralInfo;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }




    
        }


        public static IEnumerable<Loan> GetLoans(string cmd, ref string message)
        {
            var list = new List<Loan>();

            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var loan = new Loan();
                            loan.Id = (int)reader["Id"];
                            loan.ReceiptDate = (string)reader["ReceiptDate"];
                            loan.Amount = (Int32)reader["Amount"];
                            loan.PersonelID = (int)reader["PersonelID"];
                            loan.Expired = (bool)reader["Expired"];

                            list.Add(loan);
                        }
                    }
                    connection.Close();
                }
                if (list.Count == 0)
                {
                    message = "No Data To Return";
                }
                return list;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }
        }

        public static int GetLastLoanId(int personelId,ref string message)
        {
            var cmd = string.Format("SELECT * FROM Loan where personelId ={0} and Expired <> true", personelId);


            try
            {
                var loan = new Loan();

                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loan.Id = (int)reader["Id"];
                            //loan.ReceiptDate = (string)reader["ReceiptDate"];
                            //loan.Amount = (Int32)reader["Amount"];
                            //loan.PersonelID = (int)reader["PersonelID"];
                            //loan.Expired = (bool)reader["Expired"];

                        }
                    }
                    connection.Close();
                }
                if (loan.Id ==0)
                {
                    message = "No Data To Return";
                }
                return loan.Id;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return -1;
            }





        }
        public static IEnumerable<Receipt> GetReceipts(string cmd, ref string message)
        {
            var list = new List<Model.Receipt>();

            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var receipt = new Receipt();
                            receipt.Id = (int)reader["Id"];
                            receipt.ReceiptDate = (string)reader["ReceiptDate"];
                            receipt.RegisterDate = (string)reader["RegisterDate"];
                            receipt.Amount = (Int32)reader["Amount"];
                            receipt.PersonelID = (int)reader["PersonelID"];
                            receipt.Bank = (string)reader["BankName"];
                            receipt.PaymentCode = (string)reader["PaymentCode"];
                            receipt.LoanId = (int)reader["LoanId"];
                            list.Add(receipt);
                        }
                    }
                    connection.Close();
                }
                if (list.Count == 0)
                {
                    message = "No Data To Return";
                }
                return list;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }
        }

        public static IEnumerable<string> FindPersonels(string cmd, ref string message)
        {
            var namesList = new List<string>();

            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            namesList.Add(((string)reader["FirstName"] + " " + (string)reader["LastName"]));
                        }
                    }
                    connection.Close();
                }
                if (namesList.Count == 0)
                {
                    message = "No Data To Return";
                }
                return namesList;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }

        }
        public static Personel GetPersonel(int personelId, ref string message)
        {
            //var cmd = string.Format("SELECT * FROM Personel where FirstName like '%{0}%' or  LastName like '%{0}%'  ", txtName.Text);
            var cmd = string.Format("SELECT * FROM Personel  where Id ={0}",personelId);
            var p = new Personel();


            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            p.FirstName = (string)reader["FirstName"];
                            p.LastName = (string)reader["LastName"];
                            p.Id = (int)reader["ID"];
                         }
                    }
                    connection.Close();
                }
      
                return p ;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }

        }
        public static IEnumerable<Personel> GetPersonels( ref string message)
        {
            //var cmd = string.Format("SELECT * FROM Personel where FirstName like '%{0}%' or  LastName like '%{0}%'  ", txtName.Text);
            var cmd ="SELECT * FROM Personel ";

            var list = new List<Personel>();

            try
            {
                string dataBase = Helper.GetConnectionString();
                DataTable dataTable = new DataTable();
                using (OleDbConnection connection = new OleDbConnection(dataBase))
                {
                    OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
                    connection.Open();
                    using (OleDbDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var p = new Personel();
                            p.FirstName = (string)reader["FirstName"];
                            p.LastName = (string)reader["LastName"];
                            p.Id = (int)reader["ID"];
                            list.Add(p);
                        }
                    }
                    connection.Close();
                }
                if (list.Count == 0)
                {
                    message = "No Data To Return";
                }
                return list ;

            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return null;
            }

        }
    }
}
