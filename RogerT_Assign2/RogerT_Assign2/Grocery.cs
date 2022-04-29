using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogerT_Assign2
{
    //Defining a Grocery class
    class Grocery
    {

        //1.  Define properties
        // auto properties
        public string ItemCode
        {
            get;set;
        }

        public string ItemName
        {
            get;set;
        }

        public double UnitPrice
        {
            get;set;
        }

        public int QtyMinForRestock
        {
            get;set;
        }

        public int InitialQty
        {
            get;set;
        }

        public int QtySold
        {
            get;set;
        }

        public int QtyRestocked
        {
            get;set;
        }

        // computer read-only properties
        public int AvailableQty
        {
            get
            {
                return InitialQty - QtySold + QtyRestocked;
            }
        }


        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;
            }
        }

        //2. Define constructors
        // default constructor
        public Grocery()
        {

        }

        // constructor with 7 parameters
        public Grocery(string itemCode, string itemName, double unitPrice, int qtyMinForRestock,
            int initialQty, int qtySold, int qtyRestocked)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
            QtyMinForRestock = qtyMinForRestock;
            InitialQty = initialQty;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
        }

        //3. ToString ovverride method
        public override string ToString()
        {
            //Using formatted string in string.format() to format each grocery item information
            string objectStr1 = String.Format(
                "{0, -15} {1, -20} {2, -15} {3, -18} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15}", 
                ItemCode, ItemName, UnitPrice.ToString("C2"), QtyMinForRestock.ToString("F0"), InitialQty.ToString("F0"),
                QtySold.ToString("F0"), QtyRestocked.ToString("F0"), AvailableQty.ToString("F0"), TotalSales.ToString("C2"));

            return objectStr1;

        }


    }
}
