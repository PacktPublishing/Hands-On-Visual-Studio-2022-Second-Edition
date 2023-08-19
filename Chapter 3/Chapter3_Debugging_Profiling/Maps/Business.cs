using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Debugging_Profiling.Maps
{
    public class Business
    {
        public string Name { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public BusinessType BusinessType { get; set; }
        public byte[] Icon { get; set; }


        public void Draw()
        {
            Console.WriteLine($"{Name} at {XPosition}, {YPosition}");
        }
    }
}
