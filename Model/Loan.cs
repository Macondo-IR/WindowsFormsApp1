using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Loan
    {
        [DisplayName("شناسه وام")]
        public int Id { get; set; }
        [DisplayName("تاریخ دریافت")]
        public string ReceiptDate { get; set; }
        [Browsable(false)]
        public bool  Expired { get; set; }
        [Browsable(false)]
        public int  PersonelID { get; set; }

        [DisplayName("مبلغ وام")]
        public Int32 Amount { get; set; }
        [DisplayName("وضعیت وام")]
        public string NumericalNumber { get
            {
                if (this.Expired)
                {
                    return "تسویه شده";
                }
                else
                {
                    return "فعال";
                }
            }
        }


    }
}
