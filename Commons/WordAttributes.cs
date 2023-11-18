using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambledWord_v2.Commons
{
    public class WordAttributes : AttributesBase
    {
        public static WordAttributes[] GetArrayOfWords()
        {
            WordAttributes[] WordsInfo = new WordAttributes[]
            {
                new WordAttributes{WORD = "Apple", HINT = "A round, pomaceous fruit of the rose family, typically having a bright red or yellow skin and a crisp flesh.", DIFFICULTY = "easy"},
                new WordAttributes{WORD = "Bird", HINT = "A warm-blooded vertebrate animal distinguished by feathers, toothless beaked jaws, the laying of hard-shelled eggs, a high metabolic rate, a four-chambered heart, and a well-developed forebrain.", DIFFICULTY = "easy"},
            };
            return WordsInfo;
        }
        public override string ToString()
        {
            return $"{WORD}\n{HINT}\n{DIFFICULTY}";
        }
    }
}
