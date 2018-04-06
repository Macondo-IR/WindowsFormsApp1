using DevComponents.DotNetBar;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
                // Using StyleManager change the style and color tinting
                if (StyleManager.IsMetro(style))
                {
                    //// More customization is needed for Metro
                    //// Capitalize App Button and tab
                    //buttonFile.Text = buttonFile.Text.ToUpper();
                    //foreach (BaseItem item in RibbonControl.Items)
                    //{
                    //    // Ribbon Control may contain items other than tabs so that needs to be taken in account
                    //    RibbonTabItem tab = item as RibbonTabItem;
                    //    if (tab != null)
                    //        tab.Text = tab.Text.ToUpper();
                    //}

                    //buttonFile.BackstageTabEnabled = true; // Use Backstage for Metro

                    ribbonControl1.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (style == eStyle.Metro)
                        StyleManager.MetroColorGeneratorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.DarkBlue;

                    // Adjust size of switch button to match Metro styling
                    switchButtonItem1.SwitchWidth = 16;
                    switchButtonItem1.ButtonWidth = 48;
                    switchButtonItem1.ButtonHeight = 19;

                    // Adjust tab strip style
                    //tabStrip1.Style = eTabStripStyle.Metro;

                    StyleManager.Style = style; // BOOM
                }
                else
                {
                    // If previous style was Metro we need to update other properties as well
                    //if (StyleManager.IsMetro(StyleManager.Style))
                    //{
                    //    ribbonControl1.RibbonStripFont = null;
                    //    // Fix capitalization App Button and tab
                    //    buttonFile.Text = ToTitleCase(buttonFile.Text);
                    //    foreach (BaseItem item in RibbonControl.Items)
                    //    {
                    //        // Ribbon Control may contain items other than tabs so that needs to be taken in account
                    //        RibbonTabItem tab = item as RibbonTabItem;
                    //        if (tab != null)
                    //            tab.Text = ToTitleCase(tab.Text);
                    //    }
                    //    // Adjust size of switch button to match Office styling
                    //    switchButtonItem1.SwitchWidth = 28;
                    //    switchButtonItem1.ButtonWidth = 62;
                    //    switchButtonItem1.ButtonHeight = 20;
                    //}
                    //// Adjust tab strip style
                    //tabStrip1.Style = eTabStripStyle.Office2007Document;
                    //StyleManager.ChangeStyle(style, Color.Empty);
                    //if (style == eStyle.Office2007Black || style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2007VistaGlass)
                    //    buttonFile.BackstageTabEnabled = false;
                    //else
                    //    buttonFile.BackstageTabEnabled = true;
                }
            }
            else if (source.CommandParameter is Color)
            {
                if (StyleManager.IsMetro(StyleManager.Style))
                    StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, (Color)source.CommandParameter);
                else
                    StyleManager.ColorTint = (Color)source.CommandParameter;
            }
        }

        private void RibbonStateCommand_Executed(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = RibbonStateCommand.Checked;
            RibbonStateCommand.Checked = !RibbonStateCommand.Checked;
        }

        private void bPersonelList_Click(object sender, EventArgs e)
        {

        }

        private void bAddPersonel_Click(object sender, EventArgs e)
        {

        }

        private void bFindPersonel_Click(object sender, EventArgs e)
        {

        }

  

        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            var form = new PersonelAdding();
            form.Show();

        }

        private void btnFindPersonel_Click(object sender, EventArgs e)
        {
            string error = "";
             var Personels = (IList<Personel>)DAL.GetDAta.GetPersonels(ref error);
            if (string.IsNullOrEmpty(error))
            {
                var form = new PersonelSearching(Personels);
                form.Show();
            }
            else
            {
                MessageBox.Show(error);

            }
        }





        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            try
            {
                var personelid = Int16.Parse(txtPersonel.Text);
                var error = "";
                var person = DAL.GetDAta.GetPersonel(personelid, ref error);
                if (person.Id == 0)
                {
                    MessageBox.Show("پرونده ای برای نمایش وجود ندارد.");
                }
                else
                {
                    var form = new PersonelForm(person);
                    form.Show();
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void txtPersonel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Find();
            }
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            //یک لیست از بدهکاران که وام دارند و مبلغ بدهی انها درست کن 
            //
            var cmd = @"SELECT Personel.LastName, Personel.FirstName, Loan.Amount, Loan.PersonelID, Loan.ReceiptDate, Loan.Expired
FROM Personel INNER JOIN Loan ON Personel.ID = Loan.PersonelID
where Loan.Expired<> TRUE";
        }
    }
}
