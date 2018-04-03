using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersianDate;

using System.Windows.Forms;

namespace SimpleManageLoanV01
{
    public partial class LoanAdding : Form
    {
        private readonly Personel _Personel;

        public LoanAdding(Personel personel)
        {
            InitializeComponent();
            _Personel = personel;
            txtReceipt.Text = (DateTime.Now).ToFa();
            
        }

        private void LoanAdding_Load(object sender, EventArgs e)
        {
            SetString();

        }
        private void SetString()
        {
            var amount = (long)numAmount.Value;
            var txt = Num2Text.ToFarsi(amount);
            lblAmount.Text = txt;

        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            SetString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //check if have not acivet loan 
            if (CheckActiveLoan(_Personel))
            {
            GoAddLoanData();
            }
        }
        private bool CheckActiveLoan(Personel personel)
        {
            return true;
        }
        private void GoAddLoanData()
        {
            var personelId = _Personel.Id;
            var amount = numAmount.Value;
            var receiptDate = txtReceipt.Text;

            string cmd = string.Format("INSERT INTO Loan (PersonelID,ReceiptDate,Amount)VALUES('{0}','{1}','{2}')",personelId,receiptDate,amount);
            string error = "";
            DAL.GetDAta.SimpleCommand(cmd,ref error);
            MessageBox.Show(error);
            this.Close();
        }
    }
}
