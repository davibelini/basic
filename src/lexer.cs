using System;
using Token;

namespace Lexer
{
    class Lexer
    {
        Token.Token[] GetTokens(string source)
        {
            return [new Token.Token("INT", "0")];
        }
    }
}