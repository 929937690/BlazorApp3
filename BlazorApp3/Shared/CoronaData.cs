using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp3.Shared
{
    public class CoronaData
    {
        public string ProvinceState { get; set; }

        public string CountryRegion { get; set; }

        public int Confirmed { get; set; }

        public int Death { get; set; }

        public double Latitude { get; set; }
        
        public double Longtitude { get; set; }

        public string Summary { get; set; }
    }
}
