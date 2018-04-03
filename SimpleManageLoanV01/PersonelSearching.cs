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
    public partial class PersonelSearching : Form
    {
        public IEnumerable<Personel> _personels;

        public PersonelSearching(IEnumerable<Personel> personels)
        {
            InitializeComponent();
            _personels = personels;
        }

        private List<Personel> Search()
        {
            lblResult.Text = "";

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                var txt = txtName.Text;
                lblResult.Text = "";

                string error = "";
                try
                {
                    return _personels.Where(p => p.Name.Contains(txt)).ToList();
                }
                catch
                {
                    MessageBox.Show(error);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private void FillList(List<Personel> list)
        {
            if (list == null || list.Count == 0)
            {
                //nothing to bind
                personelList.DataSource = null;
                lblResult.Text = "پرسنلی یافت نشد";

            }
            else
            {
                personelList.DataSource = list.Select(p => p.Name).ToList();
            }

        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }


        private void personelList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string text = personelList.GetItemText(personelList.SelectedItem);
            if (!string.IsNullOrEmpty(text)) {

            var person = _personels.Where(p => p.Name == text).FirstOrDefault<Personel>();
            //MessageBox.Show(person.Name);



           var form =new  PersonelForm(person);
                form.Show();
                this.Close();
                //int index = this.personelList.IndexFromPoint(e.Location);
                //if (index != System.Windows.Forms.ListBox.NoMatches)
                //{

                //    //MessageBox.Show(index.ToString());

                //    //do your stuff here

                //}
                //var form = new RibbonForm1();
                //form.Show();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var list = Search();
            FillList(list);
        }
    }
}

