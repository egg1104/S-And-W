using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_W_HealthStore.Models
{
    public class Product
    {
        //int variable named Id 
        public int Id { get; set; }
        //string variable named Name
        public string Name{ get; set; }
        //int variable named Quantity
        public int Quantity { get; set; }
        //creating variable named Price
        private decimal Price;
        public decimal price
        {
            //Returns the value of Price
            get { return Price; }
            //Sets the value of Price
            set
            {
                //Checks to see if value meets condition below
                if (value >= 0)
                {
                    //Sets Price equal to value
                    Price = value;
                }
                else
                {
                    //throws exception if condition is not met above
                    throw new ArgumentOutOfRangeException("Price Cannot Be a Negative");
                }
            }
        }
    }
}
