using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleManageLoanV01
{
    public partial class SetDatabaseLocationcs : Form
    {
        public static string LocationPAth;
        public SetDatabaseLocationcs()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var pathfile = openFileDialog1.FileName;
            WriteDataBaseInfo(pathfile);
        }

        private void WriteDataBaseInfo(string pathfile)
        {
            if (!File.Exists(LocationPAth))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(LocationPAth))
                {
                    sw.WriteLine(pathfile);

                }
            }
            else
            {
                File.WriteAllText(LocationPAth, "");

                using (StreamWriter sw = File.CreateText(LocationPAth))
                {
                    sw.WriteLine(pathfile);
                }
            }
            ReadContent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
  

        }

        private void ReadContent()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(LocationPAth))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    lblResult.Text = line;
                }
            }
            catch (Exception e)
            {
                lblResult.Text="The file could not be read:";
                MessageBox.Show(e.Message);
            }
        }

        private void SetDatabaseLocationcs_Load(object sender, EventArgs e)
        {
            LocationPAth= AppDomain.CurrentDomain.BaseDirectory + "ManageLoanDB.txt";
            try
            {
                ReadContent();
            }
            catch (Exception x)
            {
                lblResult.Text = x.Message;
            }
        }
 

 
    }
}
