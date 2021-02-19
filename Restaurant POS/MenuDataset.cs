
using System.Collections.Generic;

namespace Restaurant_POS
{
    public static class MenuDataset
    {
        public const string Barley_Tea = "Barley Tea";

        public static Dictionary<string, double> ItemCost = new Dictionary<string, double> {
            { Barley_Tea, 1}
        };
    }
}
