using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }

        public Coffee(int discount)
        {
            if (discount > 5)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(discount),
                    "Discount cannot be bigger than 5 kr."
                );
            }

            Discount = discount;
        }

        public virtual int Price()
        {
            return 20 - Discount;
        }

        public abstract string Strength();
    }
}
