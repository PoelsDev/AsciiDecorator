using System;
using Xunit;
using AsciiDecorators;

namespace AsciiDecoratorTests
{
    public class AsciiDecoratorTest
    {
        [Fact]
        public void UnderlineShouldUnderlineWithOneExtraCharacter()
        {
            AsciiDecorator ad = new AsciiDecorator('-');

            string[] lines = ad.Underline("Hello!");

            Assert.Equal("Hello!", lines[0]);
            Assert.Equal("-------", lines[1]);
        }

        [Fact]
        public void AsciiDecoratorShouldUseAsteriskAsDefaultChar()
        {
            AsciiDecorator ad = new AsciiDecorator();

            string[] lines = ad.Underline("Hello!");

            Assert.Equal("Hello!", lines[0]);
            Assert.Equal("*******", lines[1]);
        }

        [Fact]
        public void BoxShouldBoxWithOneSpaceOnEachSide()
        {
            AsciiDecorator ad = new AsciiDecorator('+');

            string[] lines = ad.Box("Hello!");

            Assert.Equal("++++++++++", lines[0]);
            Assert.Equal("+ Hello! +", lines[1]);
            Assert.Equal("++++++++++", lines[2]);
        }
    }
}
