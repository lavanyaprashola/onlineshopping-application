using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class Admin
    {
        string COLLECTIONS;
        string FABRIC;
        string COLOR;
        string SIZE;
        string BRAND;

        // Zero Parameterised Con
        public Admin()
        {
        }
        // Parameterised Contr

        public Admin(string collections, string fabric, string Color, string size, string brand)
        {

            Collections = collections;
            Fabric = fabric;
            Color = Color;
            Size = size;
            Brand = brand;
        }

        public string Collections { get => COLLECTIONS; set => COLLECTIONS = value; }
        public string Fabric { get => FABRIC; set => FABRIC = value; }
        public string Color { get => COLOR; set => COLOR = value; }
        public string Size { get => SIZE; set => SIZE = value; }
        public string Brand { get => BRAND; set => BRAND = value; }



        
        public override string ToString()
        {
            return String.Format("Collection--->{0} Fabric---->{1} Color------->{2} size----->{3} brand---->{4}", Collections, Fabric, Color, Size, Brand);
        }
    }
}
