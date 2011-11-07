﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Collections;
using System.IO;
using Simpl.Serialization.Context;
using Simpl.Serialization.Deserializers;
using Simpl.Serialization.Serializers;
using ecologylab.serialization;

namespace Simpl.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    public class ElementState : ISimplSerializationPre, ISimplSerializationPost, ISimplDeserializationPre, ISimplDeserializationPost
    {
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<String, ElementState> _elementById;

        public ElementState Parent { get; set; }

        private ClassDescriptor classDescriptor;

        public ClassDescriptor ClassDescriptor
        {
            get
            {
                if (classDescriptor == null) classDescriptor = ClassDescriptor.GetClassDescriptor(this);
                return classDescriptor;
            }
            private set { classDescriptor = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, ElementState> ElementById
        {
            get { return _elementById; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="translationContext"></param>
        public void SerializationPreHook(TranslationContext translationContext)
        {
           //add functionality if necessary
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="translationContext"></param>
        public void SerializationPostHook(TranslationContext translationContext)
        {
            //add functionality if necessary
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="translationContext"></param>
        public void DeserializationPreHook(TranslationContext translationContext)
        {
            //add functionality if necessary
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="translationContext"></param>
        public void DeserializationPostHook(TranslationContext translationContext)
        {
            //add functionality if necessary
        }

        public void SetupInParent(ElementState newParent)
        {
            _elementById = newParent.ElementById;
        }
    }
}
