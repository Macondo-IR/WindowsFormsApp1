using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonelGeneralInfo:Personel
    {
        [DisplayName("تاریخ دریافت وام")]

        public string LoanReceiptDate { get; set; }
        [DisplayName("شناسه وام")]
        public int LoanId { get; set; }
        [DisplayName("مبلغ وام")]
        public Int32 LoanAmount { get; set; }
        [DisplayName("آخرین پرداخت ")]
        public string LasPayment { get; set; }
        public string LoanDebtAmount { get; set; }

        public PersonelGeneralInfo(Personel personel)
        {
            this.Id = personel.Id;
            this.FirstName = personel.FirstName;
            this.LastName = personel.LastName;
            this.NumericalNumber=personel.NumericalNumber;
        }
        public PersonelGeneralInfo()
        {
        }
    }

}
