using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL

{
    public static class Helper
    {
        public static string GetConnectionString()
        {
            String line = "";
            var LocationPAth = AppDomain.CurrentDomain.BaseDirectory + "ManageLoanDB.txt";
            using (StreamReader sr = new StreamReader(LocationPAth))
            {
                // Read the stream to a string, and write the string to the console.
                 line = sr.ReadToEnd();
            }
            return string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}.accdb;Persist Security Info = False;", line);


        }

        //public static string GetConnectionString()
        //{
        //    return                 "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=e:\\db.accdb;Persist Security Info = False;";
        //}
        public static string PardakhtCommand(int PersonelId,String PaymentCode, string Amount, string BankName,string ReceiptDate,int LoanId)
        {
            var registerDate = "1396/01/03";

            return               
             string.Format("INSERT INTO Receipt(PaymentCode,PersonelId,Amount,ReceiptDate,BankName,LoanId,RegisterDate)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", PaymentCode, PersonelId.ToString(), Amount,ReceiptDate, BankName,LoanId.ToString(), registerDate);
            ;
        }

    }
}
