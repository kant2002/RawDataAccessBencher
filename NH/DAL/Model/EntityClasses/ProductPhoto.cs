﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductPhoto'</summary>
	public partial class ProductPhoto
	{
		#region Class Member Declarations
		private ISet<ProductProductPhoto> _productProductPhotos;
		private System.Byte[] _largePhoto;
		private System.String _largePhotoFileName;
		private System.DateTime _modifiedDate;
		private System.Int32 _productPhotoId;
		private System.Byte[] _thumbNailPhoto;
		private System.String _thumbnailPhotoFileName;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductPhoto"/> class.</summary>
		public ProductPhoto() : base()
		{
			_productProductPhotos = new HashSet<ProductProductPhoto>();
			_productPhotoId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ProductPhotoId.GetHashCode();
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
			ProductPhoto toCompareWith = obj as ProductPhoto;
			return toCompareWith == null ? false : ((this.ProductPhotoId == toCompareWith.ProductPhotoId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the LargePhoto field. </summary>	
		public virtual System.Byte[] LargePhoto
		{ 
			get { return _largePhoto; }
			set { _largePhoto = value; }
		}

		/// <summary>Gets or sets the LargePhotoFileName field. </summary>	
		public virtual System.String LargePhotoFileName
		{ 
			get { return _largePhotoFileName; }
			set { _largePhotoFileName = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets the ProductPhotoId field. </summary>	
		public virtual System.Int32 ProductPhotoId
		{ 
			get { return _productPhotoId; }
		}

		/// <summary>Gets or sets the ThumbNailPhoto field. </summary>	
		public virtual System.Byte[] ThumbNailPhoto
		{ 
			get { return _thumbNailPhoto; }
			set { _thumbNailPhoto = value; }
		}

		/// <summary>Gets or sets the ThumbnailPhotoFileName field. </summary>	
		public virtual System.String ThumbnailPhotoFileName
		{ 
			get { return _thumbnailPhotoFileName; }
			set { _thumbnailPhotoFileName = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ProductProductPhoto.ProductPhoto - ProductPhoto.ProductProductPhotos (m:1)'</summary>
		public virtual ISet<ProductProductPhoto> ProductProductPhotos
		{
			get { return _productProductPhotos; }
			set { _productProductPhotos = value; }
		}
		
		#endregion
	}
}
