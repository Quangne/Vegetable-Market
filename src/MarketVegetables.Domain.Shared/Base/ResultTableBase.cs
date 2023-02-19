using System;
using System.Collections.Generic;
using System.Text;

namespace MarketVegetables.Base
{
    public class ResultTableBase<T>
    {
        public T Items { get; set; }
        public int TotalCount { get; set; }
    }
}
