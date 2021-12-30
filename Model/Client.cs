using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CurrencyLimit { get; set; } = 1000;
        public Client(string name)
        {
            ++ApplicationContext.Counter;
            Name = name;
            Id = ApplicationContext.Counter;
        }

        public double ExchangeMoney(double sum, double rate, int id)
        {
            ApplicationContext.Clients.Where(x => x.Id == id).FirstOrDefault().CurrencyLimit -= sum;
            return sum * rate;
        }
    }
}
