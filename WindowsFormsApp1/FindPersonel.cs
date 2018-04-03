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
using PersianDate;

namespace WindowsFormsApp1
{
    public partial class FindPersonel : Form
    {
        public FindPersonel()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
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
            //                var first =(string) dataTable.Rows[0]["FirstName"];
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

        private void button2_Click(object sender, EventArgs e)
        {
            ////personel 
            ////mablagh
            ////tarikh
            //var personel = textBox1.Text;
            //var amount = (int) numericUpDown1.Value;
            //var tarikh =   txtDate.Text;
         


            //OleDbConnection connection = new OleDbConnection();
            //connection.ConnectionString = Helper.GetConnectionString();
            //try
            //{
            //    connection.Open();
            //    string cmd = string.Format("INSERT INTO Loan(PersonelID,Amount,ReceiptDate)VALUES('{0}','{1}','{2}')",personel,amount, tarikh);
            //    new OleDbCommand(cmd, connection).ExecuteNonQuery();
            //    this.label1.Text = "Data saved successfuly...!";
            //}
            //catch (Exception ex)
            //{
            //    int num = (int)MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        private void FindPersonel_Load(object sender, EventArgs e)
        {

            var date =  DateTime.Now;
           var  date2 = (string)date.ToFa();
            txtDate.Text = date2.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
