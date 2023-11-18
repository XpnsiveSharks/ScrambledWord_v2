using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambledWord_v2.Commons
{
    public class AttributesBase : IAttributes
    {
        public string WORD { get; set; }
        public string HINT { get; set; }
        public string DIFFICULTY { get; set; }
    }
}
