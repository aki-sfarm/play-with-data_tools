using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockSalesDataGenerator
{
    public class Products
    {
        public string ProductName { get; set; }
        public int Price { get; set; }

        //仕入れ値
        public int PurchasePrice { get; set; }

        //人気順
        public int Popularity { get; set; }



        //購入確率下限
        public int PurchaseProbabilityLowerLimit { get; set; }
        //購入確率上限
        public int PurchaseProbabilityUpperLimit { get; set; }






        //public int Stock { get; set; }

        public Products(string productName, int price, int purchasePrice, int popularity, int purchaseProbabilityLowerLimit, int purchaseProbabilityUpperLimit)
        {
            ProductName = productName;
            Price = price;
            PurchasePrice = purchasePrice;
            Popularity = popularity;
            PurchaseProbabilityLowerLimit = purchaseProbabilityLowerLimit;
            PurchaseProbabilityUpperLimit = purchaseProbabilityUpperLimit;

        }
    }


}
