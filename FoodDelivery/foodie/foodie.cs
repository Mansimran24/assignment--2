using System;
using System.ComponentModel.DataAnnotations;
namespace FoodDelivery.foodie
{
    public class foodie
    {
        public int ID { get; set; }
        public string item{ get; set; }

        [DataType(DataType.Date)]
        public DateTime orderDate { get; set; }
        public DateTime deliveryDate { get; set; }
        public decimal price{ get; set; }
    }
}
