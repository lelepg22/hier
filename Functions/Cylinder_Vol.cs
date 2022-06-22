using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Cylinder_Vol : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)        {
            
            double Volume = Math.PI * (arguments[0].GetValue() * arguments[0].GetValue()) * arguments[1].GetValue();
            return (float)Volume;
        } 
    }
}
