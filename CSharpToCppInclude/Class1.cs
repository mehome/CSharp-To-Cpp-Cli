﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpToCpp
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class ExposeToCppAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.All)]
    public class SkipCppAttribute : Attribute
    {
    }
}
