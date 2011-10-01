//
//  InitConnectionResponse.cs
//  s.im.pl serialization
//
//  Generated by DotNetTranslator on 04/09/11.
//  Copyright 2011 Interface Ecology Lab. 
//

using System;
using Simpl.Serialization.Attributes;

namespace Simpl.OODSS.Messages 
{
	/// <summary>
	/// missing java doc comments or could not find the source file.
	/// </summary>
	[SimplInherit]
	public class InitConnectionResponse : ResponseMessage<ServiceMessage<object>>
	{
		/// <summary>
		/// missing java doc comments or could not find the source file.
		/// </summary>
		[SimplScalar]
		private String sessionId;

		public InitConnectionResponse()
		{ }

		public String SessionId
		{
			get{return sessionId;}
			set{sessionId = value;}
		}
	}
}
