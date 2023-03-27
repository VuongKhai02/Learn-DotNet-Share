using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_5_bai4._1_TinhDaHinh
{

    internal class SavingAccount: Account
    {
        private double _rate;
        public SavingAccount(decimal initialize, double rate)
            :base (initialize)
        {
            _rate = rate;
        }

        public decimal GetInterest()
        {
            return balance * (decimal)_rate;    
        }


    }
}
