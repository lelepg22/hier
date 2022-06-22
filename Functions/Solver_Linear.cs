using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Solver_Linear : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float x = ((arguments[2].GetValue() - arguments[1].GetValue()) / arguments[0].GetValue());
            return x;
        }

    }
}
