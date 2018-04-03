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
using DAL;

namespace WindowsFormsApp1
{
    public partial class Pardakht : Form
    {
        public Pardakht()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var amount = numAmount.Value;
            var shenase = txtُShenase.Text;
            var receipt = txtReceipt.Text;
            var bank = comboBox1.Text;


       
                //string cmd = string.Format("INSERT INTO Receipt(Shenase,Amount,ReceiptDate)VALUES('{0}','{1}','{2}')", shenase, amount, receipt);
                string cmd = Helper.PardakhtCommand(1, shenase, amount.ToString(),bank,receipt);
            string result = InsertData.Payment(cmd);
            MessageBox.Show(result);
     
        }
    }
}
