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
	/// <summary>Class which represents the entity 'Customer', mapped on table 'AdventureWorks.Sales.Customer'.</summary>
	[Table(Name="[Sales].[Customer]")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_accountNumber;
		private System.Int32	_customerId;
		private System.DateTime	_modifiedDate;
		private Nullable<System.Int32>	_personId;
		private System.Guid	_rowguid;
		private Nullable<System.Int32>	_storeId;
		private Nullable<System.Int32>	_territoryId;
		private EntityRef <Person> _person;
		private EntitySet <SalesOrderHeader> _salesOrderHeaders;
		private EntityRef <SalesTerritory> _salesTerritory;
		private EntityRef <Store> _store;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnAccountNumberChanging(System.String value);
		partial void OnAccountNumberChanged();
		partial void OnCustomerIdChanging(System.Int32 value);
		partial void OnCustomerIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnPersonIdChanging(Nullable<System.Int32> value);
		partial void OnPersonIdChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnStoreIdChanging(Nullable<System.Int32> value);
		partial void OnStoreIdChanged();
		partial void OnTerritoryIdChanging(Nullable<System.Int32> value);
		partial void OnTerritoryIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Customer"/> class.</summary>
		public Customer()
		{
			_person = default(EntityRef<Person>);
			_salesOrderHeaders = new EntitySet<SalesOrderHeader>(new Action<SalesOrderHeader>(this.Attach_SalesOrderHeaders), new Action<SalesOrderHeader>(this.Detach_SalesOrderHeaders) );
			_salesTerritory = default(EntityRef<SalesTerritory>);
			_store = default(EntityRef<Store>);
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
		private void Attach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.Customer = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.Customer = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field. Mapped on target field 'AccountNumber'. </summary>
		[Column(Name="AccountNumber", Storage="_accountNumber", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="varchar(10) NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.String AccountNumber
		{
			get	{ return _accountNumber; }
		}

		/// <summary>Gets or sets the CustomerId field. Mapped on target field 'CustomerID'. </summary>
		[Column(Name="CustomerID", Storage="_customerId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 CustomerId
		{
			get	{ return _customerId; }
			set
			{
				if((_customerId != value))
				{
					OnCustomerIdChanging(value);
					SendPropertyChanging("CustomerId");
					_customerId = value;
					SendPropertyChanged("CustomerId");
					OnCustomerIdChanged();
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

		/// <summary>Gets or sets the PersonId field. Mapped on target field 'PersonID'. </summary>
		[Column(Name="PersonID", Storage="_personId", DbType="int NULL")]
		public Nullable<System.Int32> PersonId
		{
			get	{ return _personId; }
			set
			{
				if((_personId != value))
				{
					if(_person.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnPersonIdChanging(value);
					SendPropertyChanging("PersonId");
					_personId = value;
					SendPropertyChanged("PersonId");
					OnPersonIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		[Column(Name="rowguid", Storage="_rowguid", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="uniqueidentifier NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the StoreId field. Mapped on target field 'StoreID'. </summary>
		[Column(Name="StoreID", Storage="_storeId", DbType="int NULL")]
		public Nullable<System.Int32> StoreId
		{
			get	{ return _storeId; }
			set
			{
				if((_storeId != value))
				{
					if(_store.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnStoreIdChanging(value);
					SendPropertyChanging("StoreId");
					_storeId = value;
					SendPropertyChanged("StoreId");
					OnStoreIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the TerritoryId field. Mapped on target field 'TerritoryID'. </summary>
		[Column(Name="TerritoryID", Storage="_territoryId", DbType="int NULL")]
		public Nullable<System.Int32> TerritoryId
		{
			get	{ return _territoryId; }
			set
			{
				if((_territoryId != value))
				{
					if(_salesTerritory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnTerritoryIdChanging(value);
					SendPropertyChanging("TerritoryId");
					_territoryId = value;
					SendPropertyChanged("TerritoryId");
					OnTerritoryIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Person - Person.Customers (m:1)'</summary>
		[Association(Name="Customer_Persona7aebeb94d794c53ae3e1cf1edcd48a3", Storage="_person", ThisKey="PersonId", IsForeignKey=true)] 
		public Person Person
		{
			get { return _person.Entity; }
			set
			{
				Person previousValue = _person.Entity;
				if((previousValue != value) || (_person.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Person");
					if(previousValue != null)
					{
						_person.Entity = null;
						previousValue.Customers.Remove(this);
					}
					_person.Entity = value;
					if(value == null)
					{
						_personId = default(Nullable<System.Int32>);
					}
					else
					{
						value.Customers.Add(this);
						_personId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("Person");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Customer - Customer.SalesOrderHeaders (m:1)'</summary>
		[Association(Name="SalesOrderHeader_Customer67981023e90d4f4d9b32f4c63f7fceb4", Storage="_salesOrderHeaders", OtherKey="CustomerId")]
		public EntitySet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return this._salesOrderHeaders; }
			set { this._salesOrderHeaders.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.SalesTerritory - SalesTerritory.Customers (m:1)'</summary>
		[Association(Name="Customer_SalesTerritory7ad6c6c625e543cfb6084e52c1b35dad", Storage="_salesTerritory", ThisKey="TerritoryId", IsForeignKey=true)] 
		public SalesTerritory SalesTerritory
		{
			get { return _salesTerritory.Entity; }
			set
			{
				SalesTerritory previousValue = _salesTerritory.Entity;
				if((previousValue != value) || (_salesTerritory.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("SalesTerritory");
					if(previousValue != null)
					{
						_salesTerritory.Entity = null;
						previousValue.Customers.Remove(this);
					}
					_salesTerritory.Entity = value;
					if(value == null)
					{
						_territoryId = default(Nullable<System.Int32>);
					}
					else
					{
						value.Customers.Add(this);
						_territoryId = value.TerritoryId;
					}
					this.SendPropertyChanged("SalesTerritory");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Store - Store.Customers (m:1)'</summary>
		[Association(Name="Customer_Storef77ea94a5bfa4ec49b0aeee356700508", Storage="_store", ThisKey="StoreId", IsForeignKey=true)] 
		public Store Store
		{
			get { return _store.Entity; }
			set
			{
				Store previousValue = _store.Entity;
				if((previousValue != value) || (_store.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Store");
					if(previousValue != null)
					{
						_store.Entity = null;
						previousValue.Customers.Remove(this);
					}
					_store.Entity = value;
					if(value == null)
					{
						_storeId = default(Nullable<System.Int32>);
					}
					else
					{
						value.Customers.Add(this);
						_storeId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("Store");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649