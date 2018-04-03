using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleManageLoanV01
{
    public partial class Receipt : Form
    {
        private readonly Personel _Personel;
        private readonly int _LastLoneId;
        public Receipt(Personel personel)
        {
            InitializeComponent();
            _Personel = personel;
            var msg = "";
            _LastLoneId = DAL.GetDAta.GetLastLoanId(_Personel.Id,ref msg);
            if (!string.IsNullOrEmpty(msg)) {
                MessageBox.Show("هیچ وام فعالی نداره که پرداخت کنی");
            }
        }


        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            SetString();
        }

        private void SetString()
        {
            var amount = (long)numAmount.Value;
            var txt=Num2Text.ToFarsi(amount);
            lblAmount.Text = txt;

        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var amount = numAmount.Value;
            var shenase = txtُShenase.Text;
            var receipt = txtReceipt.Text;
            var bank = comboBox1.Text;



            //string cmd = string.Format("INSERT INTO Receipt(Shenase,Amount,ReceiptDate)VALUES('{0}','{1}','{2}')", shenase, amount, receipt);
            string cmd = Helper.PardakhtCommand(_Personel.Id, shenase, amount.ToString(), bank, receipt, _LastLoneId);
            string result = InsertData.Payment(cmd);
            MessageBox.Show(result);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
