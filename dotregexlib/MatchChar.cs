using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotregexlib
{
    public class MatchChar : IMatch
    {
        private readonly char current_char;

        public MatchChar(char c)
        {
            current_char = c;
        }
        public bool Matched(Context context)
        {
           if (context.getOffset() > context.getInputLen()) return false;

           if (context.getCurrentChar() == current_char)
           {
               context.next();
               return true;
           }
           return false;
        }

        public bool MatchedNext(Context context)
        {
            context.prev();
            return false;
        }
    }
}
