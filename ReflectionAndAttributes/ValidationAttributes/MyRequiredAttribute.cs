using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj) => obj != null;
    }
}
