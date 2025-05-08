using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOpenData
{
    public class Fields
    {
        public string adres { get; set; }
        public int? aantal_toiletten { get; set; }
        public int? aantal_urinoirs { get; set; }
    }

    public class Record
    {
        public Fields fields { get; set; }
    }
    public class RootObject
    {
        public List<Record> records { get; set; }
    }
}
