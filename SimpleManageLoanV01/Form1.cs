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
    public partial class Form1 : Form
    {
        public static IEnumerable<Personel> Personels;
        public Form1()
        {
            InitializeComponent();
            Personels = new List<Personel>();
        }

 

        private void showPersonelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                var datatable = DAL.GetDAta.SimpleCommand("SELECT * FROM Personel", ref error);
                gv.DataSource = datatable;
            }
            catch
            {
                MessageBox.Show(error);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string error = "";
            //Personels =(IList<Personel>) DAL.GetDAta.GetPersonels( ref error);
            //if (string.IsNullOrEmpty(error))
            //{
            //    var form = new Form2(Personels);
            //    form.Show();
            //}
            //else
            //{
            //    MessageBox.Show(error);

            //}
        }

      
    }
}
