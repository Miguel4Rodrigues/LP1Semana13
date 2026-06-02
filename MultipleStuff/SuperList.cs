using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            min = this.Min();
            max = this.Max();
        }
        public struct MinMaxResult
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }
        public MinMaxResult GetMinMax2()
        {
            return new MinMaxResult { Min = this.Min(), Max = this.Max()};
        }
        public Tuple<double, double> GetMinMax3()
        {
            return new Tuple<double, double>(this.Min(), this.Max());
        }
        public (double min, double max) GetMinMax4()
        {
            return (this.Min(), this.Max());
        }
    }
}