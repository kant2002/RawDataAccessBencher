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
	/// <summary>Class which represents the entity 'SalesOrderHeader'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class SalesOrderHeader : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="SalesOrderHeader"/> class.</summary>
		public SalesOrderHeader() : base()
		{
			this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
			this.SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field. </summary>
		[DataMember]
		public System.String AccountNumber { get; set;}
		/// <summary>Gets or sets the Comment field. </summary>
		[DataMember]
		public System.String Comment { get; set;}
		/// <summary>Gets or sets the CreditCardApprovalCode field. </summary>
		[DataMember]
		public System.String CreditCardApprovalCode { get; set;}
		/// <summary>Gets or sets the DueDate field. </summary>
		[DataMember]
		public System.DateTime DueDate { get; set;}
		/// <summary>Gets or sets the Freight field. </summary>
		[DataMember]
		public System.Decimal Freight { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the OnlineOrderFlag field. </summary>
		[DataMember]
		public System.Boolean OnlineOrderFlag { get; set;}
		/// <summary>Gets or sets the OrderDate field. </summary>
		[DataMember]
		public System.DateTime OrderDate { get; set;}
		/// <summary>Gets or sets the PurchaseOrderNumber field. </summary>
		[DataMember]
		public System.String PurchaseOrderNumber { get; set;}
		/// <summary>Gets or sets the RevisionNumber field. </summary>
		[DataMember]
		public System.Byte RevisionNumber { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SalesOrderId field. </summary>
		[DataMember]
		public System.Int32 SalesOrderId { get; set;}
		/// <summary>Gets or sets the SalesOrderNumber field. </summary>
		[DataMember]
		public System.String SalesOrderNumber { get; set;}
		/// <summary>Gets or sets the ShipDate field. </summary>
		[DataMember]
		public Nullable<System.DateTime> ShipDate { get; set;}
		/// <summary>Gets or sets the Status field. </summary>
		[DataMember]
		public System.Byte Status { get; set;}
		/// <summary>Gets or sets the SubTotal field. </summary>
		[DataMember]
		public System.Decimal SubTotal { get; set;}
		/// <summary>Gets or sets the TaxAmt field. </summary>
		[DataMember]
		public System.Decimal TaxAmt { get; set;}
		/// <summary>Gets or sets the TotalDue field. </summary>
		[DataMember]
		public System.Decimal TotalDue { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Address - Address.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual Address Address { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Address_ - Address.SalesOrderHeaders_ (m:1)'</summary>
		[DataMember]
		public virtual Address Address_ { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.CreditCard - CreditCard.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual CreditCard CreditCard { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.CurrencyRate - CurrencyRate.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual CurrencyRate CurrencyRate { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Customer - Customer.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual Customer Customer { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderDetail.SalesOrderHeader - SalesOrderHeader.SalesOrderDetails (m:1)'</summary>
		[DataMember]
		public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeaderSalesReason.SalesOrderHeader - SalesOrderHeader.SalesOrderHeaderSalesReasons (m:1)'</summary>
		[DataMember]
		public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.SalesPerson - SalesPerson.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual SalesPerson SalesPerson { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.SalesTerritory - SalesTerritory.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual SalesTerritory SalesTerritory { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.ShipMethod - ShipMethod.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual ShipMethod ShipMethod { get; set;}
		#endregion
	}
}
