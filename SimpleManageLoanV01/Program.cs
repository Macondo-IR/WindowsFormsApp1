using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleManageLoanV01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
         //   Application.Run(new Main());
            //    //Application.Run(new Receipt());
            //    //Application.Run(new PersonelAdding());
             Application.Run(new SetDatabaseLocationcs());
         //IEnumerable<Personel> _personels;
         //   string error = "";
         //   _personels = (IList<Personel>)DAL.GetDAta.GetPersonels(ref error);
         //   var person = _personels.Where(p => p.Id == 9).FirstOrDefault();
         //   Application.Run(new PersonelForm(person));
        }
    }
}
