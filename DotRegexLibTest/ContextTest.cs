using dotregexlib;

namespace DotRegexLibTest
{
    public class ContextTest
    {
        [Fact]
        public void ContextMatchsSingleChar()
        {
            var context = new Context("abdc");
            var inputChar = new MatchChar('a');

            var result = inputChar.Matched(context);

            Assert.True(result); // test if the current char is equal to input
            Assert.Equal(1, context.getOffset()); // test if when matched true offset has increased

        }
    }
}