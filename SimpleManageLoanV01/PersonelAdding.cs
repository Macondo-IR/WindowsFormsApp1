using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SimpleManageLoanV01
{
    public partial class PersonelAdding : Form
    {
        public PersonelAdding()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var res1=CheckNumbericalCode();
            var res2 = CheckExistanceNumbericalCode();
            if (res1 && res2)
            {
                GoAddPersonData();
            }
            this.Close();
}

        private void GoAddPersonData()
        {
                var personel = new Model.Personel()
                {
                    FirstName = textBox1.Text.TrimEnd(),
                    LastName = textBox2.Text.TrimEnd(),
                    NumericalNumber=txtNumerical.Text
                };
                string cmd=string.Format("INSERT INTO Personel(FirstName,LastName,NumericalNumber)VALUES('{0}','{1}','{2}')",personel.FirstName,personel.LastName,personel.NumericalNumber);
                string msg = DAL.InsertData.Payment(cmd);
                panelStatus.Visible = true;
        }
        private bool CheckExistanceNumbericalCode()
        {
            // نوشتن کد بعد از پر شدن و ضروری شدن کد ملی تمام کارمند ها 
            return true;
        }

        private bool CheckNumbericalCode()
        {
            var txtnum = txtNumerical.Text;
            var error = "";
            var result = NumbericCode.IsValidNationalCode(txtnum, ref error);
            if (result)
            {
                return true;
            }
            else
            {
                txtNumerical.Text = "";
                panelStatus.Visible = true;
                lblStatus.Text = error;
                return false;
            }
        }

        private void txtNumerical_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNumerical.TextLength > 1)
            {
                panelStatus.Visible = false;
                lblStatus.Text = "";
            }
        }
    }
}
