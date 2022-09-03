using System;

namespace Jarai.CSharp.Basics.Exceptions
{
    internal class NoPartyException : Exception
    {
        public NoPartyException(string msg) : base(msg)
        {
        }
    }
}
