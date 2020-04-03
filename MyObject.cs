using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPropertyGrid
{
    public class MyObject
    {
        public List<SubObj> Elements { get; set; }
    }

    public class SubObj
    {
        public int Value { get; set; }
        public MyObject Parent { get; set; }
    }
}
