using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Debugging_Profiling.Maps
{

    public class MapService
    {
        public List<Business> GetBusinesses()
        {
            return GenerateBusinesses();
        }

        private List<Business> GenerateBusinesses()
        {
            var businesses = new List<Business>();
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                var business = new Business()
                {
                    Name = GetBusinessName(i),
                    XPosition = GetRandomPosition(),
                    YPosition = GetRandomPosition(),
                    BusinessType = BusinessType.CoffeeShop,
                    Icon = GetIcon()
                };
                businesses.Add(business);
            }
            return businesses;
        }

        private string GetBusinessName(int i)
        {
            return $"Coffe Shop {i}";
        }

        private int GetRandomPosition()
        {
            Random random = new Random();
            Thread.Sleep(1);
            return random.Next(0, 1000);
        }

        private byte[] GetIcon()
        {
            return File.ReadAllBytes(@"Maps\coffee-cup.png");
        }
    }

}
