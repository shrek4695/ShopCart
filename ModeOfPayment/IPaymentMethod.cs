﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeOfPayment
{
   public interface IPaymentMethod
    {
        void SavePaymentDetails(int Amount);
    }
}
