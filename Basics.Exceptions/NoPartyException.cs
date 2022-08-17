using System;

namespace Jarai.Basics.Exceptions
{
    internal class NoPartyException : Exception
    {
        public NoPartyException(string msg) : base(msg)
        {
        }
    }
}
