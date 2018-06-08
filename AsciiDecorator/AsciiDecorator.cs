using System;

namespace AsciiDecorators
{
    public class AsciiDecorator
    {
        private char decoratorChar;

        public AsciiDecorator(char decorator = '*')
        {
            decoratorChar = decorator;
        }

        public string[] Underline(string text)
        {
            string[] result = new string[2];
            result[0] = text;
            result[1] = new string(decoratorChar, text.Length + 1);

            return result;
        }

        public string[] Box(string text)
        {
            string[] result = new string[3];
            result[0] = new string(decoratorChar, text.Length + 4);
            result[1] = $"{decoratorChar} {text} {decoratorChar}";
            result[2] = new string(decoratorChar, text.Length + 4);
            return result;
        }
    }
}
