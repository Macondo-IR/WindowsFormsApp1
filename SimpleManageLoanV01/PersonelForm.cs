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
    public partial class PersonelForm : Form
    {
        public readonly Model.Personel _personel;

        public PersonelForm(Personel personel)
        {
                _personel = personel;
            InitializeComponent();
            this.Text = _personel.Name;
        }



        private void buttonX2_Click(object sender, EventArgs e)
        {
            string msg = "";
            //last loan id 
            //var loanIdCommand = string.Format("SELECT * FROM Loan where personelId ={0} and expired = false","9");
            var loanIdCommand = string.Format("SELECT * FROM Loan where personelId ={0}",_personel.Id);
            var table = GetDAta.GetLoans(loanIdCommand, ref msg);

            gv.DataSource = table;


        }

        private void FillGeneral(Personel personel)
        {
            string msg = "";
            var p = DAL.GetDAta.GetPersonelGeneralInfo(personel, ref msg);
            if (string.IsNullOrEmpty(p.LoanReceiptDate))
            {
                lblResult.Text = "تاکنون وام دریافت نکرده است";
            }
            else
            {
                txtLoanAmount.Text = NumberFormat.NumberDigitFormat(p.LoanAmount.ToString());
                txtLoanReceipt.Text = p.LoanReceiptDate;
                txtLastPayment.Text = p.LasPayment;
                txtDebt.Text = NumberFormat.NumberDigitFormat(p.LoanDebtAmount);

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            string msg = "";
            //last loan id 
            //var loanIdCommand = string.Format("SELECT * FROM Loan where personelId ={0} and expired = false","9");
            var receiptCommand = string.Format("SELECT * FROM Receipt where personelId ={0}", _personel.Id);
            var table = GetDAta.GetReceipts(receiptCommand, ref msg);

            gv2.DataSource = table;
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            var form = new Receipt(_personel);
            form.Show();
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            //اگه وام فعال نداشت ایجاد کن 
            var res=DAL.Check.CheckLoanPossiblity(_personel.Id);
            if (res)
            {
                var form = new LoanAdding(_personel);
                form.Show();
            }
            else
            {
                MessageBox.Show("امکان دریافت وام وجود ندارد");
            }
        }

        private bool CheckLoan(int personelId)
        {
            return true;
         }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            FillGeneral(_personel);

        }
    }
}
