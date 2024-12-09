using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_6_1
{
    public class House
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public House(int houseNumebr, string address, string type)
        {
            HouseNumber = houseNumebr;
            Address = address;
            Type = type;
        }

        // Override ToString() method for easy display
        public override string ToString()
        {
            return $"House Number: {HouseNumber}, Address: {Address}, Type: {Type}";
        }
    }
    
}
