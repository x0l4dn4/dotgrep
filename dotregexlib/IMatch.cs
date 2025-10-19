using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotregexlib
{
    public interface IMatch
    {
        public bool Matched(Context context);
        public bool MatchedNext(Context context);
    }
}
