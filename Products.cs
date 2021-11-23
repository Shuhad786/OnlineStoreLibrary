using System;

namespace OnlineStoreLibrary
{
    public class Products
    {
        public int iProductAmount { get; set; }
        public decimal dProductPrice { get; set; }
        public string sProductName { get; set; }
        public string sDescription { get; set; }
  

        public Products()
        {
            iProductAmount = 0;
            dProductPrice = 0.00M;
            sProductName = "Nothing yet!";
            sDescription = "No description!";
            
        }

        public Products(int a, decimal b, string c, string d)
        {
            iProductAmount = a;
            dProductPrice = b;
            sProductName = c;
            sDescription = d;
            
        }

        public override string ToString()
        {
            return "Available: " + iProductAmount + "\nBrand: " + sProductName + "\nDescription: " + sDescription + "\nPrice: R" + dProductPrice;
        }

    }
}
