﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public double BuyRate { get; set; }
        public double SellRate { get; set; }
    }
}
