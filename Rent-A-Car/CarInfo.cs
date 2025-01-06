using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    public class CarInfo
    {
        public int id;
        public string brand;
        public string model;
        public string year;
        public string type;
        public int pricePerDay;
        public int branchId;
        public string numberPlate;

        public CarInfo(int id, string brand, string model, string year, string type, int pricePerDay, int branchId)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.type = type;
            this.pricePerDay = pricePerDay;
            this.branchId = branchId;
        }

        public CarInfo(string brand, string model, string year, string type)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.type = type;
        }

        public CarInfo(string brand, string model, string year, string type, int pricePerDay, string numberPlate)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.type = type;
            this.pricePerDay = pricePerDay;
            this.numberPlate = numberPlate;
        }
    }
}
