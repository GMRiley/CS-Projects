using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibV2;

namespace CustomerLib
{
    class Customer : PersonV2
    {
        private DateTime customerSince;
        private Double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;
        public DateTime CustomerSince
        {
            get { return customerSince; }
            set
            {
                bool result = isPastDate(value);
                if (result == true)
                    customerSince = value;
            }

        }
        public Double TotalPurchases
        {
            get { return totalPurchases; }
            set { totalPurchases = value; }
        }
        public bool DiscountMember
        {
            get { return discountMember; }
            set { discountMember = value; }
        }
        public int RewardsEarned
        {
            get { return rewardsEarned; }
            set { rewardsEarned = value; }
        }
    }
}
