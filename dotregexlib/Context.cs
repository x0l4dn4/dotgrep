using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotregexlib
{
    public class Context
    {
        private readonly string input;
        private int offset = 0;
        public Context(string input) => this.input = input;

        public int getInputLen() => input.Length;

        public void next() => offset++;
        public void prev() => offset--;

        public int getOffset() => offset;

        // TODO: Add some validation
        public char getCurrentChar() => input[offset];

        private string concatOffset(int offset)
        {
            string concat = "";
            for (int i = 0; i < offset; i++)
            {
                concat += "-";
            }
            return concat;
        }

        public override string ToString() => input + "\n" + concatOffset(getOffset()) + "^";


    }
}
