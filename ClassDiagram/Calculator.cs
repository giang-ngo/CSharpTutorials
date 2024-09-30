using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Calculator : ICalculator
    {
        

        double ICalculator.Add()
        {
            throw new NotImplementedException();
        }

        double ICalculator.Sub()
        {
            throw new NotImplementedException();
        }

        double ICalculator.Mul()
        {
            throw new NotImplementedException();
        }
    }
}