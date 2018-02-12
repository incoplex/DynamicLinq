﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PoweredSoft.DynamicLinq
{
    public enum ConditionOperators 
    {
        Equal,
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanOrEqual,
        Contains,
        StartsWith,
        EndsWith
    }

    internal static class Constants
    {
        internal static readonly MethodInfo ContainsMethod = typeof(string).GetMethod("Contains");
        internal static readonly MethodInfo StartsWithMethod = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
        internal static readonly MethodInfo EndsWithMethod = typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });
    }
}