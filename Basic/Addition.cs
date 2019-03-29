using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class Addition : IAddition
    {
        public double Add(double first, double second)
        {
            return first + second;
        }
    }
}
