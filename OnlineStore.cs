using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreLibrary
{
   public class OnlineStore
   {

        public List<Products> ProductsList { get; set; }
        public List<Products> OnlineStoreList { get; set; }
     
        public OnlineStore()
        {
            ProductsList = new List<Products>();
            OnlineStoreList = new List<Products>();
        }

        public int StockCount()
        {
            int RemainingStock = 0;

            foreach (var item in OnlineStoreList)
            {
                RemainingStock = RemainingStock - item.iProductAmount;
            }

            //OnlineStoreList.Clear();
            return RemainingStock;
        }

        public decimal CheckOut()
        {
            decimal TotalCost = 0;

            foreach (var item in OnlineStoreList)
            {
                TotalCost = TotalCost + item.dProductPrice;
            }

           
            return TotalCost;
        }

        

        public void PrintInventory(OnlineStore inventory)
        {
            for (int i = 0; i < inventory.ProductsList.Count; i++)
            {
                Console.WriteLine("This is the product: #" + i + "\n" + inventory.ProductsList[i].ToString());
            }
        }
        // This is a section thats copies entries from the user input stored in "ProductsList" to "OnlineStoreList"
        public void PrintCheckOut(OnlineStore checkout)
        {
            Console.WriteLine("You chose to purchase:\n");
            for (int i = 0; i < checkout.OnlineStoreList.Count; i++)
            {
                Console.WriteLine("This is the product: #" + i + " " + checkout.ProductsList[i].ToString() + "\n");
            }
           
        }

        // This is a menu for the console program
        public int OptionSelect()
        {
            Console.WriteLine("Choose 1 to add product\nChoose 2 to view product\nChoose 3 to check out\nChoose 4 to print receipt\nChoose 5 to exit");
            
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        // Creates a text file as a form of receipt for user
        public void PrintReceipt()
        {
            string FileName = @"C:\Users\Shuhad\Desktop\Receipt.txt"; // change file path to your respective location
            using (TextWriter tw = new StreamWriter(FileName))
            {
                foreach (var item in OnlineStoreList)
                {
                    tw.WriteLine(string.Format("Item: {0}\nCost: {1}\nDescription: {2}\nAmount: {3}", item.sProductName, item.dProductPrice, item.sDescription, item.iProductAmount.ToString()));
                    Console.WriteLine("Check destop for receipt text file");
                }
            }
            OnlineStoreList.Clear();
            
        }

       



   }
}
