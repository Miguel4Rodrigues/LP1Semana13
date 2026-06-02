using System;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SuperList lista = new SuperList{5.5, 10.2, 1.8, 25.4, 12.0};

            Console.WriteLine("Testing MinMax methods:");
            
            // MinMax1
            lista.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"MinMax1 - Min: {min1}, Max: {max1}");
            // MinMax2
            SuperList.MinMaxResult minMax2 = lista.GetMinMax2();
            Console.WriteLine($"MinMax2 - Min: {minMax2.Min}, Max: {minMax2.Max}");
            // MinMax3
            Tuple<double, double> minMax3 = lista.GetMinMax3();
            Console.WriteLine($"MinMax3 - Min: {minMax3.Item1}, Max: {minMax3.Item2}");
            // MinMax4
            (double min4, double max4) = lista.GetMinMax4();
            Console.WriteLine($"MinMax4 - Min: {min4}, Max: {max4}");
        }
    }
}
