using Chapter3_Debugging_Profiling.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Debugging_Profiling
{
    public class PerformanceDemo
    {
        public void Run()
        {
            MapService mapsService = new MapService();
            var businesses = mapsService.GetBusinesses();
            DrawBusiness(businesses);
        }

        private void DrawBusiness(List<Business> businesses)
        {
            foreach (var business in businesses)
            {
                business.Draw();
            }
        }
    }
}
