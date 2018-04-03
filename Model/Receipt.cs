using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receipt
    {
        [DisplayName("شناسه")]
        public int Id { get; set; }

        [DisplayName("شماره فیش")]
        public string PaymentCode { get; set; }

        [Browsable(false)]
        public int PersonelID { get; set; }

        [DisplayName("مبلغ پرداخت شده")]
        public Int32 Amount { get; set; }

        [DisplayName("تاریخ پرداخت")]
        public string ReceiptDate { get; set; }

        [DisplayName("تاریخ ثبت")]
        public string RegisterDate { get; set; }

        [DisplayName("بانک")]
        public string Bank { get; set; }

        [DisplayName("شناسه وام")]
        public int LoanId { get; set; }
    }
}
