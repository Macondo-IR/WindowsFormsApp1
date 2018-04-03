using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LastLoanGeneralInfo
    {
        [DisplayName("شناسه وام")]
        public int LoanId { get; set; }

        [DisplayName("تاریخ آخرین پرداخت")]
        public string LastPayment { get; set; }

        [DisplayName("مبلغ وام")]
        public Int32 LoanAmount { get; set; }

        [DisplayName("مبلغ پرداختی")]
        public Int32 PaymentAmount { get; set; }

        [DisplayName("مبلغ بدهکاری")]
        public Int32 DebtAmount { get {                return LoanAmount - PaymentAmount;            } }

        //[DisplayName("وضعیت وام")]
        //public string NumericalNumber { get
        //    {
        //        if (this.Expired)
        //        {
        //            return "تسویه شده";
        //        }
        //        else
        //        {
        //            return "فعال";
        //        }
        //    }
        //}
        public LastLoanGeneralInfo(int Id,Int32 loanAmount)
        {
            LoanId = Id;
            LoanAmount = loanAmount;
        }

    }
}
