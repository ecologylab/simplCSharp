﻿using System;
using Simpl.Serialization.Context;

namespace Simpl.Serialization.Types.Scalar
{
    /// <summary>
    ///     Class abstracting C# Float type
    /// </summary>
    class StringType : ScalarType
    {
        /// <summary>
        ///      Calls the parent constructor for String type
        /// </summary>
        public StringType()
            : base(typeof(String))
        { }

        /// <summary>
        ///     Creates and returns an instance of int type for the given
        ///     input value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="formatStrings"></param>
        /// <returns></returns>
        public override Object GetInstance(String value, String[] formatStrings, IScalarUnmarshallingContext scalarUnmarshallingContext)
        {
            return value; 
        }
    }
}