﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Address'</summary>
	public partial class Address
	{
		#region Class Member Declarations
		private Iesi.Collections.Generic.ISet<BusinessEntityAddress> _businessEntityAddresses;
		private Iesi.Collections.Generic.ISet<SalesOrderHeader> _salesOrderHeaders;
		private Iesi.Collections.Generic.ISet<SalesOrderHeader> _salesOrderHeaders1;
		private StateProvince _stateProvince;
		private System.Int32 _addressId;
		private System.String _addressLine1;
		private System.String _addressLine2;
		private System.String _city;
		private System.DateTime _modifiedDate;
		private System.String _postalCode;
		private System.Guid _rowguid;
		private Microsoft.SqlServer.Types.SqlGeography _spatialLocation;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Address"/> class.</summary>
		public Address() : base()
		{
			_businessEntityAddresses = new Iesi.Collections.Generic.HashedSet<BusinessEntityAddress>();
			_salesOrderHeaders = new Iesi.Collections.Generic.HashedSet<SalesOrderHeader>();
			_salesOrderHeaders1 = new Iesi.Collections.Generic.HashedSet<SalesOrderHeader>();
			_addressId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.AddressId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			if(obj == null) 
			{
				return false;
			}
			Address toCompareWith = obj as Address;
			return toCompareWith == null ? false : ((this.AddressId == toCompareWith.AddressId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the AddressId field. </summary>	
		public virtual System.Int32 AddressId
		{ 
			get { return _addressId; }
		}

		/// <summary>Gets or sets the AddressLine1 field. </summary>	
		public virtual System.String AddressLine1
		{ 
			get { return _addressLine1; }
			set { _addressLine1 = value; }
		}

		/// <summary>Gets or sets the AddressLine2 field. </summary>	
		public virtual System.String AddressLine2
		{ 
			get { return _addressLine2; }
			set { _addressLine2 = value; }
		}

		/// <summary>Gets or sets the City field. </summary>	
		public virtual System.String City
		{ 
			get { return _city; }
			set { _city = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the PostalCode field. </summary>	
		public virtual System.String PostalCode
		{ 
			get { return _postalCode; }
			set { _postalCode = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the SpatialLocation field. </summary>	
		public virtual Microsoft.SqlServer.Types.SqlGeography SpatialLocation
		{ 
			get { return _spatialLocation; }
			set { _spatialLocation = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.Address - Address.BusinessEntityAddresses (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<BusinessEntityAddress> BusinessEntityAddresses
		{
			get { return _businessEntityAddresses; }
			set { _businessEntityAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Address - Address.SalesOrderHeaders (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Address1 - Address.SalesOrderHeaders1 (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<SalesOrderHeader> SalesOrderHeaders1
		{
			get { return _salesOrderHeaders1; }
			set { _salesOrderHeaders1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Address.StateProvince - StateProvince.Addresses (m:1)'</summary>
		public virtual StateProvince StateProvince
		{
			get { return _stateProvince; }
			set { _stateProvince = value; }
		}
		
		#endregion
	}
}
