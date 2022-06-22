using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Sphere_Vol : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float volume = 0.0F;

            volume = (float)(4.0 / 3 * Math.PI * arguments[0].GetValue() * arguments[0].GetValue() * arguments[0].GetValue());

            return volume;
           
        }
    }
}
