using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class ApplicationContext
    {
        public static List<Client> Clients = new List<Client>();
        public static List<Currency> Currencies = new List<Currency>()
        { 
            new Currency{CurrencyId = 1, CurrencyName = "Dollar", BuyRate = 2.45, SellRate = 2.38},
            new Currency{CurrencyId = 2, CurrencyName = "Euro", BuyRate = 2.78, SellRate = 2.67},
            new Currency{CurrencyId = 3, CurrencyName = "Rubls", BuyRate = 0.344, SellRate = 0.339}
        };
        public static DateTime dateTime = DateTime.Now;
        public static int Counter = 0;
    }
}
