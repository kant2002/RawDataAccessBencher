﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Person.EmailAddress'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class EmailAddress : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="EmailAddress"/> class.</summary>
		public EmailAddress() : base()
		{
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the BusinessEntityId field. </summary>
		[DataMember]
		public System.Int32 BusinessEntityId { get; set;}
		/// <summary>Gets or sets the EmailAddressId field. </summary>
		[DataMember]
		public System.Int32 EmailAddressId { get; set;}
		/// <summary>Gets or sets the EmailAddressValue field. </summary>
		[DataMember]
		public System.String EmailAddressValue { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Person.EmailAddress.Person - Person.Person.EmailAddresses (m:1)'</summary>
		[DataMember]
		public virtual Person Person { get; set;}
		#endregion
	}
}
