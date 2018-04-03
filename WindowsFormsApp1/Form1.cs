using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error="";
            try
            {
              var datatable= DAL.GetDAta.SimpleCommand("SELECT * FROM Personel",ref error);
            }
            catch 
            {
                MessageBox.Show(error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var text = textBox1.Text;

            //if (!string.IsNullOrEmpty(text))
            //{
            //    try
            //    {
            //        string dataBase = Helper.GetConnectionString();
            //        DataTable dataTable = new DataTable();
            //        using (OleDbConnection connection = new OleDbConnection(dataBase))
            //        {
            //            var command = string.Format("SELECT * FROM Personel where FirstName like '%{0}%' or  LastName like '%{0}%'  ", text);
            //            OleDbCommand selectCommand = new OleDbCommand(command, connection);
            //            connection.Open();
            //            new OleDbDataAdapter(selectCommand).Fill(dataTable);
            //        }
            //        this.dataGridView1.DataSource = (object)dataTable;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //OleDbConnection connection = new OleDbConnection();
            //connection.ConnectionString = Helper.GetConnectionString();
            //try
            //{
            //    connection.Open();
            //    new OleDbCommand("INSERT INTO Personel(Field1)VALUES('" + "test" + "')", connection).ExecuteNonQuery();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var form=new Personel();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
       //     var list =new List<string>();
       //     try
       //     {
       //         string dataBase = Helper.GetConnectionString();
       //         DataTable dataTable = new DataTable();
       //using (OleDbConnection connection = new OleDbConnection(dataBase))
       //         {
       //             OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM Personel", connection);
       

       //             connection.Open();
       //             using (OleDbDataReader reader = selectCommand.ExecuteReader())
       //             {
       //                 while (reader.Read())
       //                 {
       //                     list.Add(((string)reader["FirstName"] + " " + (string)reader["LastName"]));
       //                 }
       //             }
       //             connection.Close();


       //         }
       //         listBox1.DataSource = list;
       //     }
       //     catch (Exception ex)
       //     {
       //         int num = (int)MessageBox.Show(ex.ToString());
       //     }
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form =new FindPersonel();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new Pardakht();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new installment();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var form = new Personels();
            form.Show();
        }
    }
}
