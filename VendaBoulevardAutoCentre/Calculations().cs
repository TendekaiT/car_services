using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaBoulevardAutoCentre
{

    public class Calculations__
    {
        #region : Field definition
        public decimal carprice;
        public decimal tradeInAllowance;
        public decimal accessories;
        public decimal salestax;
        public static decimal due;
        public static decimal subtotal;
        public static decimal total;
        public decimal stereo;
        private const decimal leatherInterior = 29999m;
        private const decimal computerNav = 15900m;
        private const decimal pearlized = 9999m;
        public decimal standard;
        private const decimal custDetailing = 12999m;
        private const decimal taxRate = 0.15m;
        private const decimal SalesTaxRate = 0.08m;
        private const decimal min = 10000m;
        private const decimal max = 1000000m;
        #endregion

        //empty constructor
        #region : Constructors
        public Calculations__() { }

        public Calculations__(decimal subtotal, decimal total, decimal due)
        {
            //Constructor with 3 arguments.
            //It is executed when an object is instantiated. 
            this.Subtotal = subtotal;
            this.Total = total;
            this.Due = due;
        }
        #endregion

        #region:Property Definition 
        //Represents a data value that is associated with an object instance.
        //Get Accessor is executed when a request to retreive the property is made.
        //Set accessor is executed whne a request to set the property is made.
        public decimal Subtotal
        {
            get
            {
                return subtotal;
            }
            set
            {
                subtotal = value;
            }
        }
        public decimal Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public decimal Due
        {
            get
            {
                return due;
            }
            set
            {
                due = value;
            }
        }
        #endregion

        #region: Method
        //used to calculate and return the amount due from the customer. 
        public void Calculate()
        {
            decimal addon = 0m;
            if (stereo == addon)
            {
                addon += 5999;
            }
            if (leatherInterior == addon)
            {
                addon += 29999;
            }
            if (computerNav == addon)
            {
                addon += 15900;
            }

            if (standard == 0)
            {
                subtotal = standard + addon + carprice;
                salestax = subtotal * taxRate;
                total = salestax + subtotal;
                due = total - tradeInAllowance;
            }
            else if (pearlized > standard)
            {
                subtotal = pearlized + addon + carprice;
                salestax = subtotal * 0.15m;
                total = salestax + subtotal;
                due = total - tradeInAllowance;
            }
            else if (custDetailing > pearlized)
            {
                subtotal = custDetailing + addon + carprice;
                salestax = subtotal * 0.15m;
                total = salestax + subtotal;
                due = total - tradeInAllowance;
            }
        }
        #endregion
        
        public Calculations__ (decimal total, decimal due)
        {
            //Property values are assigned. 
            Total = total;
            Due = due;
            this.Calculate();
        }
    }





}
