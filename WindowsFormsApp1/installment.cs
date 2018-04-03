using PersianDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class installment : Form
    {
        public installment()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Enabled = false;
            //var text = textBox1.Text;

            //if (!string.IsNullOrEmpty(text))
            //{
            //    try
            //    {
            //        string dataBase = Helper.GetConnectionString();
            //        DataTable dataTable = new DataTable();
            //        using (OleDbConnection connection = new OleDbConnection(dataBase))
            //        {
            //            var command = string.Format("SELECT * FROM Personel where ID like '{0}'   ", text);
            //            OleDbCommand selectCommand = new OleDbCommand(command, connection);
            //            connection.Open();
            //            new OleDbDataAdapter(selectCommand).Fill(dataTable);

            //            if (dataTable.Rows.Count >= 1)
            //            {
            //                var first = (string)dataTable.Rows[0]["FirstName"];
            //                var last = (string)dataTable.Rows[0]["LastName"];
            //                txtName.Text = first;
            //                txtFamily.Text = last;
            //            }
            //            else
            //            {
            //                MessageBox.Show("not fonund pesronel");
            //            }
            //        }
            //        //loan finding
            //        using (OleDbConnection connection = new OleDbConnection(dataBase))
            //        {
            //            var command = string.Format("SELECT * FROM Loan where PersonelID like '{0}' and Expired <> 1   ", text);
            //            OleDbCommand selectCommand = new OleDbCommand(command, connection);
            //            connection.Open();
            //            new OleDbDataAdapter(selectCommand).Fill(dataTable);

            //            if (dataTable.Rows.Count >= 1)
            //            {
            //                var loanId = (int)dataTable.Rows[1]["Id"];
            //                var amount = (int)dataTable.Rows[1]["Amount"];
            //                var receiptDate = (string)dataTable.Rows[1]["ReceiptDate"];
            //                txtLoanAmount.Text = amount.ToString();
            //                txtLoanReceiptDate.Text = receiptDate;
            //                txtLoanId.Text = loanId.ToString();
            //            }
            //            else
            //            {
            //                MessageBox.Show("not fonund in loans");
            //            }
            //        }
            //        ActAghsat();



            //    }
            //    catch (Exception ex)
            //    {
            //        int num = (int)MessageBox.Show(ex.ToString());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("nothings to sseach");

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
        }

        private void numInstallmentcount_ValueChanged(object sender, EventArgs e)
        {
            ActAghsat();
        }
        protected void ActAghsat()
        {
            if (!string.IsNullOrEmpty(txtLoanAmount.Text))
            {
                var v = Int32.Parse(txtLoanAmount.Text) / (int)numInstallmentcount.Value;
                txtAmountPerInstallment.Text = v.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtAmountPerInstallment.Text))
            //{
            //    MessageBox.Show("ghesto moshkhsa kon");
            //}

            //else
            //{


            //    var personelId = textBox1.Text;
            //    var loanId = txtLoanId.Text;
            //    var loanAmount = txtAmountPerInstallment.Text;
            //    DateTime date = txtLoanReceiptDate.Text.ToEn();



            //    OleDbConnection connection = new OleDbConnection();
            //    connection.ConnectionString = Helper.GetConnectionString();
            //    try
            //    {
            //        connection.Open();


            //        for (int j = 1; j <= numInstallmentcount.Value; j++)
            //        {

            //            var tarikh = date.AddMonths(j).ToFa();
            //            tarikh = tarikh.Substring(0, tarikh.Length - 2) + "01";
            //            string cmd = string.Format("INSERT INTO Installment(PersonelId,LoanId,Amount,DueDate)VALUES('{0}','{1}','{2}','{3}')", personelId, loanId, loanAmount, tarikh);
            //            new OleDbCommand(cmd, connection).ExecuteNonQuery();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        int num = (int)MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //}



        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void numInstallmentcount_KeyDown(object sender, KeyEventArgs e)
        {
            ActAghsat();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtLoanId.Text))
            //{

            //}
            //else
            //{
            //    try
            //    {
            //        string dataBase = Helper.GetConnectionString();
            //        DataTable dataTable = new DataTable();
            //        using (OleDbConnection connection = new OleDbConnection(dataBase))
            //        {
            //            var command = string.Format("delete  * FROM Installment where LoanId like '{0}'   ", txtLoanId.Text);
            //            OleDbCommand selectCommand = new OleDbCommand(command, connection);
            //            connection.Open();
            //            new OleDbDataAdapter(selectCommand).Fill(dataTable);

            //            if (dataTable.Rows.Count >= 1)
            //            {
            //                var first = (string)dataTable.Rows[0]["FirstName"];
            //                var last = (string)dataTable.Rows[0]["LastName"];
            //                txtName.Text = first;
            //                txtFamily.Text = last;
            //            }
            //            else
            //            {
            //                MessageBox.Show("not fonund pesronel");
            //            }
            //        }
            //    }
            //    catch (Exception x)
            //    {
            //        MessageBox.Show(x.Message);
            //    }
            //}
        }
    }
}
