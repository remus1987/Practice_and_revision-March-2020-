using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_March2020
{
    class TheoryExamples_Basics
    {
        #region Type_Casting
        // Implicit type conversion is done automatically from smaller
        // to larger types or from derived to base classes
        public void ExplicitConversion ()
        {
            double d = 23.3565;
            int i;
            // cast double to int 
            i = (int)d;
            Console.WriteLine(i);
            // C# provide built-in type conversions: ToBoolean; ToChar; ToINt32; ToString
            Console.WriteLine(i.ToString());
        }
        #endregion
    }
}
