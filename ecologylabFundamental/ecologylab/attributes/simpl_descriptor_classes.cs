﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecologylab.attributes
{
    /// <summary>
    ///     An array of classes used to bind the type of classes 
    ///     the annotated attribute can hold. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class simpl_descriptor_classes : Attribute
    {
        private Type[] classes;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="classes"></param>
        public simpl_descriptor_classes(Type[] classes)
        {
            this.classes = classes;
        }

        /// <summary>
        /// 
        /// </summary>
        public Type[] Classes
        {
            get
            {
                return classes;
            }
        }
    }
}