using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Common.Models
{
    public enum OrderStatus
    {
        Open = 1,
        InProcess = 2,
        PendingInvoice = 3,
        Paid = 4
    }
}
