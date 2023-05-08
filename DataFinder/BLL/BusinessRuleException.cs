using System;

namespace DataFinder.BLL
{
    internal class BusinessRuleException : Exception
    {
        public BusinessRuleException(string massege) : base(massege) { }
    }
}
