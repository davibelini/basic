using System;

namespace Token
{
    class Token
    {
        public Token(string type, string value="")
        {
            this.type = type
            this.value = value
        }
        public string Representation()
        {
            return this.type + ":" + this.value ? this.value != "" : this.type;
        }
    }
}