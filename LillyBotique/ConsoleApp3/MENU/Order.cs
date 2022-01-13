using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp3.MENU
{
    // User Class to collect its Behavour and Properties
    public class Order
    {
        // User Fields
        string collection;
        string fabric;
        string color;
        string BranD;
        string size;



        // Zero Parameterised Con
        public Order()
        {
        }
        // Parameterised Contr



        public Order(string collection, string fabric, string color, string size, string brand)
        {



            Collection = collection;
            Fabric = fabric;
            Color = color;
            Size = size;
            Brand = brand;

        }



        public string Collection { get => collection; set => collection = value; }
        public string Fabric { get => fabric; set => fabric = value; }
        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }
        public string Brand { get => BranD; set => BranD = value; }



        public override string ToString()
        {
            return String.Format("collection---->{0} ,fabric---->{1} color---->{2} brand---->{3} size----->{4}", Collection, Fabric, Color, Size, Brand);
        }





    }
}