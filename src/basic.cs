using System;
using System.Diagnostics;
using Lexer;
using Token;

namespace Basic
{
    class Basic {
        static void Main(string[] args)
        {
            while(true) {
                Console.Clear();
                Console.WriteLine("The Basic Programming Language (2021)");
                string source = Console.ReadLine("basic > ");

                Lexer.Lexer lexer = new Lexer.Lexer();
                Token.Token[] tokens = lexer.GetTokens(source);
                for (rawToken in tokens)
                {
                    rawToken = rawToken.Representation();
                }

                Console.WriteLine(tokens)
            }
        }
     }
}