﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecologylab.serialization.types.scalar
{
    /// <summary>
    /// 
    /// </summary>
    class UriType : ReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        public UriType()
            : base(typeof(Uri))
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="formatStrings"></param>
        /// <returns></returns>
        public override Object GetInstance(String value, String[] formatStrings)
        {
            Object result = null;
            try
            {
                result = new Uri(value);
            }
            catch (UriFormatException e)
            {
                Console.WriteLine("UriFormat Exception: " + value);
            }
            return result;
        } 
    }
}
