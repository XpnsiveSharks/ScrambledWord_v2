using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambledWord_v2.Commons
{
    public interface IAttributes
    {
        string WORD { get; set; }
        string HINT { get; set; }
        string DIFFICULTY { get; set; }
    }
}
