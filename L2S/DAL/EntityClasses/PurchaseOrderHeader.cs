﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'PurchaseOrderHeader', mapped on table 'AdventureWorks.Purchasing.PurchaseOrderHeader'.</summary>
	[Table(Name="[Purchasing].[PurchaseOrderHeader]")]
	public partial class PurchaseOrderHeader : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_employeeId;
		private System.Decimal	_freight;
		private System.DateTime	_modifiedDate;
		private System.DateTime	_orderDate;
		private System.Int32	_purchaseOrderId;
		private System.Byte	_revisionNumber;
		private Nullable<System.DateTime>	_shipDate;
		private System.Int32	_shipMethodId;
		private System.Byte	_status;
		private System.Decimal	_subTotal;
		private System.Decimal	_taxAmt;
		private System.Decimal	_totalDue;
		private System.Int32	_vendorId;
		private EntityRef <Employee> _employee;
		private EntitySet <PurchaseOrderDetail> _purchaseOrderDetails;
		private EntityRef <ShipMethod> _shipMethod;
		private EntityRef <Vendor> _vendor;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnEmployeeIdChanging(System.Int32 value);
		partial void OnEmployeeIdChanged();
		partial void OnFreightChanging(System.Decimal value);
		partial void OnFreightChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnOrderDateChanging(System.DateTime value);
		partial void OnOrderDateChanged();
		partial void OnPurchaseOrderIdChanging(System.Int32 value);
		partial void OnPurchaseOrderIdChanged();
		partial void OnRevisionNumberChanging(System.Byte value);
		partial void OnRevisionNumberChanged();
		partial void OnShipDateChanging(Nullable<System.DateTime> value);
		partial void OnShipDateChanged();
		partial void OnShipMethodIdChanging(System.Int32 value);
		partial void OnShipMethodIdChanged();
		partial void OnStatusChanging(System.Byte value);
		partial void OnStatusChanged();
		partial void OnSubTotalChanging(System.Decimal value);
		partial void OnSubTotalChanged();
		partial void OnTaxAmtChanging(System.Decimal value);
		partial void OnTaxAmtChanged();
		partial void OnTotalDueChanging(System.Decimal value);
		partial void OnTotalDueChanged();
		partial void OnVendorIdChanging(System.Int32 value);
		partial void OnVendorIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.</summary>
		public PurchaseOrderHeader()
		{
			_employee = default(EntityRef<Employee>);
			_purchaseOrderDetails = new EntitySet<PurchaseOrderDetail>(new Action<PurchaseOrderDetail>(this.Attach_PurchaseOrderDetails), new Action<PurchaseOrderDetail>(this.Detach_PurchaseOrderDetails) );
			_shipMethod = default(EntityRef<ShipMethod>);
			_vendor = default(EntityRef<Vendor>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_PurchaseOrderDetails(PurchaseOrderDetail entity)
		{
			this.SendPropertyChanging("PurchaseOrderDetails");
			entity.PurchaseOrderHeader = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_PurchaseOrderDetails(PurchaseOrderDetail entity)
		{
			this.SendPropertyChanging("PurchaseOrderDetails");
			entity.PurchaseOrderHeader = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the EmployeeId field. Mapped on target field 'EmployeeID'. </summary>
		[Column(Name="EmployeeID", Storage="_employeeId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 EmployeeId
		{
			get	{ return _employeeId; }
			set
			{
				if((_employeeId != value))
				{
					if(_employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnEmployeeIdChanging(value);
					SendPropertyChanging("EmployeeId");
					_employeeId = value;
					SendPropertyChanged("EmployeeId");
					OnEmployeeIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Freight field. Mapped on target field 'Freight'. </summary>
		[Column(Name="Freight", Storage="_freight", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal Freight
		{
			get	{ return _freight; }
			set
			{
				if((_freight != value))
				{
					OnFreightChanging(value);
					SendPropertyChanging("Freight");
					_freight = value;
					SendPropertyChanged("Freight");
					OnFreightChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the OrderDate field. Mapped on target field 'OrderDate'. </summary>
		[Column(Name="OrderDate", Storage="_orderDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime OrderDate
		{
			get	{ return _orderDate; }
			set
			{
				if((_orderDate != value))
				{
					OnOrderDateChanging(value);
					SendPropertyChanging("OrderDate");
					_orderDate = value;
					SendPropertyChanged("OrderDate");
					OnOrderDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the PurchaseOrderId field. Mapped on target field 'PurchaseOrderID'. </summary>
		[Column(Name="PurchaseOrderID", Storage="_purchaseOrderId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 PurchaseOrderId
		{
			get	{ return _purchaseOrderId; }
			set
			{
				if((_purchaseOrderId != value))
				{
					OnPurchaseOrderIdChanging(value);
					SendPropertyChanging("PurchaseOrderId");
					_purchaseOrderId = value;
					SendPropertyChanged("PurchaseOrderId");
					OnPurchaseOrderIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the RevisionNumber field. Mapped on target field 'RevisionNumber'. </summary>
		[Column(Name="RevisionNumber", Storage="_revisionNumber", CanBeNull=false, DbType="tinyint NOT NULL")]
		public System.Byte RevisionNumber
		{
			get	{ return _revisionNumber; }
			set
			{
				if((_revisionNumber != value))
				{
					OnRevisionNumberChanging(value);
					SendPropertyChanging("RevisionNumber");
					_revisionNumber = value;
					SendPropertyChanged("RevisionNumber");
					OnRevisionNumberChanged();
				}
			}
		}

		/// <summary>Gets or sets the ShipDate field. Mapped on target field 'ShipDate'. </summary>
		[Column(Name="ShipDate", Storage="_shipDate", DbType="datetime NULL")]
		public Nullable<System.DateTime> ShipDate
		{
			get	{ return _shipDate; }
			set
			{
				if((_shipDate != value))
				{
					OnShipDateChanging(value);
					SendPropertyChanging("ShipDate");
					_shipDate = value;
					SendPropertyChanged("ShipDate");
					OnShipDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the ShipMethodId field. Mapped on target field 'ShipMethodID'. </summary>
		[Column(Name="ShipMethodID", Storage="_shipMethodId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 ShipMethodId
		{
			get	{ return _shipMethodId; }
			set
			{
				if((_shipMethodId != value))
				{
					if(_shipMethod.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnShipMethodIdChanging(value);
					SendPropertyChanging("ShipMethodId");
					_shipMethodId = value;
					SendPropertyChanged("ShipMethodId");
					OnShipMethodIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Status field. Mapped on target field 'Status'. </summary>
		[Column(Name="Status", Storage="_status", CanBeNull=false, DbType="tinyint NOT NULL")]
		public System.Byte Status
		{
			get	{ return _status; }
			set
			{
				if((_status != value))
				{
					OnStatusChanging(value);
					SendPropertyChanging("Status");
					_status = value;
					SendPropertyChanged("Status");
					OnStatusChanged();
				}
			}
		}

		/// <summary>Gets or sets the SubTotal field. Mapped on target field 'SubTotal'. </summary>
		[Column(Name="SubTotal", Storage="_subTotal", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal SubTotal
		{
			get	{ return _subTotal; }
			set
			{
				if((_subTotal != value))
				{
					OnSubTotalChanging(value);
					SendPropertyChanging("SubTotal");
					_subTotal = value;
					SendPropertyChanged("SubTotal");
					OnSubTotalChanged();
				}
			}
		}

		/// <summary>Gets or sets the TaxAmt field. Mapped on target field 'TaxAmt'. </summary>
		[Column(Name="TaxAmt", Storage="_taxAmt", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal TaxAmt
		{
			get	{ return _taxAmt; }
			set
			{
				if((_taxAmt != value))
				{
					OnTaxAmtChanging(value);
					SendPropertyChanging("TaxAmt");
					_taxAmt = value;
					SendPropertyChanged("TaxAmt");
					OnTaxAmtChanged();
				}
			}
		}

		/// <summary>Gets or sets the TotalDue field. Mapped on target field 'TotalDue'. </summary>
		[Column(Name="TotalDue", Storage="_totalDue", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="money NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Decimal TotalDue
		{
			get	{ return _totalDue; }
		}

		/// <summary>Gets or sets the VendorId field. Mapped on target field 'VendorID'. </summary>
		[Column(Name="VendorID", Storage="_vendorId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 VendorId
		{
			get	{ return _vendorId; }
			set
			{
				if((_vendorId != value))
				{
					if(_vendor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnVendorIdChanging(value);
					SendPropertyChanging("VendorId");
					_vendorId = value;
					SendPropertyChanged("VendorId");
					OnVendorIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Employee - Employee.PurchaseOrderHeaders (m:1)'</summary>
		[Association(Name="PurchaseOrderHeader_Employeec4979523b2b34bb4a3c1e0c347d9b665", Storage="_employee", ThisKey="EmployeeId", IsForeignKey=true)] 
		public Employee Employee
		{
			get { return _employee.Entity; }
			set
			{
				Employee previousValue = _employee.Entity;
				if((previousValue != value) || (_employee.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Employee");
					if(previousValue != null)
					{
						_employee.Entity = null;
						previousValue.PurchaseOrderHeaders.Remove(this);
					}
					_employee.Entity = value;
					if(value == null)
					{
						_employeeId = default(System.Int32);
					}
					else
					{
						value.PurchaseOrderHeaders.Add(this);
						_employeeId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderDetail.PurchaseOrderHeader - PurchaseOrderHeader.PurchaseOrderDetails (m:1)'</summary>
		[Association(Name="PurchaseOrderDetail_PurchaseOrderHeader16afa68c7f36487c81bf5a4e7de500df", Storage="_purchaseOrderDetails", OtherKey="PurchaseOrderId")]
		public EntitySet<PurchaseOrderDetail> PurchaseOrderDetails
		{
			get { return this._purchaseOrderDetails; }
			set { this._purchaseOrderDetails.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.ShipMethod - ShipMethod.PurchaseOrderHeaders (m:1)'</summary>
		[Association(Name="PurchaseOrderHeader_ShipMethodb9e0447b9efd4e07b6e8902dabe7ca65", Storage="_shipMethod", ThisKey="ShipMethodId", IsForeignKey=true)] 
		public ShipMethod ShipMethod
		{
			get { return _shipMethod.Entity; }
			set
			{
				ShipMethod previousValue = _shipMethod.Entity;
				if((previousValue != value) || (_shipMethod.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("ShipMethod");
					if(previousValue != null)
					{
						_shipMethod.Entity = null;
						previousValue.PurchaseOrderHeaders.Remove(this);
					}
					_shipMethod.Entity = value;
					if(value == null)
					{
						_shipMethodId = default(System.Int32);
					}
					else
					{
						value.PurchaseOrderHeaders.Add(this);
						_shipMethodId = value.ShipMethodId;
					}
					this.SendPropertyChanged("ShipMethod");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Vendor - Vendor.PurchaseOrderHeaders (m:1)'</summary>
		[Association(Name="PurchaseOrderHeader_Vendor0c14df47893649fa9f436089a770b879", Storage="_vendor", ThisKey="VendorId", IsForeignKey=true)] 
		public Vendor Vendor
		{
			get { return _vendor.Entity; }
			set
			{
				Vendor previousValue = _vendor.Entity;
				if((previousValue != value) || (_vendor.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Vendor");
					if(previousValue != null)
					{
						_vendor.Entity = null;
						previousValue.PurchaseOrderHeaders.Remove(this);
					}
					_vendor.Entity = value;
					if(value == null)
					{
						_vendorId = default(System.Int32);
					}
					else
					{
						value.PurchaseOrderHeaders.Add(this);
						_vendorId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("Vendor");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649