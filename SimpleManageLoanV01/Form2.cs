using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace SimpleManageLoanV01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                label1.Text = NumberFormat.NumberDigitFormat(textBox1.Text);
              
            }
            catch (Exception x)
            {

                label1.Text =x.Message;
            }


        }
    }
}
