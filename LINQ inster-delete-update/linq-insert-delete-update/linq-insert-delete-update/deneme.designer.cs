﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace linq_insert_delete_update
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Deneme")]
	public partial class denemeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKisiler(Kisiler instance);
    partial void UpdateKisiler(Kisiler instance);
    partial void DeleteKisiler(Kisiler instance);
    partial void InsertIller(Iller instance);
    partial void UpdateIller(Iller instance);
    partial void DeleteIller(Iller instance);
    partial void InsertIlceler(Ilceler instance);
    partial void UpdateIlceler(Ilceler instance);
    partial void DeleteIlceler(Ilceler instance);
    #endregion
		
		public denemeDataContext() : 
				base(global::linq_insert_delete_update.Properties.Settings.Default.DenemeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public denemeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public denemeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public denemeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public denemeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Kisiler> Kisilers
		{
			get
			{
				return this.GetTable<Kisiler>();
			}
		}
		
		public System.Data.Linq.Table<Iller> Illers
		{
			get
			{
				return this.GetTable<Iller>();
			}
		}
		
		public System.Data.Linq.Table<Ilceler> Ilcelers
		{
			get
			{
				return this.GetTable<Ilceler>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kisiler")]
	public partial class Kisiler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _ad;
		
		private string _soyad;
		
		private System.DateTime _dogumTarihi;
		
		private string _il;
		
		private string _ilce;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnadChanging(string value);
    partial void OnadChanged();
    partial void OnsoyadChanging(string value);
    partial void OnsoyadChanged();
    partial void OndogumTarihiChanging(System.DateTime value);
    partial void OndogumTarihiChanged();
    partial void OnilChanging(string value);
    partial void OnilChanged();
    partial void OnilceChanging(string value);
    partial void OnilceChanged();
    #endregion
		
		public Kisiler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ad
		{
			get
			{
				return this._ad;
			}
			set
			{
				if ((this._ad != value))
				{
					this.OnadChanging(value);
					this.SendPropertyChanging();
					this._ad = value;
					this.SendPropertyChanged("ad");
					this.OnadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soyad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string soyad
		{
			get
			{
				return this._soyad;
			}
			set
			{
				if ((this._soyad != value))
				{
					this.OnsoyadChanging(value);
					this.SendPropertyChanging();
					this._soyad = value;
					this.SendPropertyChanged("soyad");
					this.OnsoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dogumTarihi", DbType="DateTime NOT NULL")]
		public System.DateTime dogumTarihi
		{
			get
			{
				return this._dogumTarihi;
			}
			set
			{
				if ((this._dogumTarihi != value))
				{
					this.OndogumTarihiChanging(value);
					this.SendPropertyChanging();
					this._dogumTarihi = value;
					this.SendPropertyChanged("dogumTarihi");
					this.OndogumTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_il", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string il
		{
			get
			{
				return this._il;
			}
			set
			{
				if ((this._il != value))
				{
					this.OnilChanging(value);
					this.SendPropertyChanging();
					this._il = value;
					this.SendPropertyChanged("il");
					this.OnilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilce", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ilce
		{
			get
			{
				return this._ilce;
			}
			set
			{
				if ((this._ilce != value))
				{
					this.OnilceChanging(value);
					this.SendPropertyChanging();
					this._ilce = value;
					this.SendPropertyChanged("ilce");
					this.OnilceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iller")]
	public partial class Iller : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ilid;
		
		private string _iller1;
		
		private EntitySet<Ilceler> _Ilcelers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnilidChanging(int value);
    partial void OnilidChanged();
    partial void Oniller1Changing(string value);
    partial void Oniller1Changed();
    #endregion
		
		public Iller()
		{
			this._Ilcelers = new EntitySet<Ilceler>(new Action<Ilceler>(this.attach_Ilcelers), new Action<Ilceler>(this.detach_Ilcelers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ilid
		{
			get
			{
				return this._ilid;
			}
			set
			{
				if ((this._ilid != value))
				{
					this.OnilidChanging(value);
					this.SendPropertyChanging();
					this._ilid = value;
					this.SendPropertyChanged("ilid");
					this.OnilidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="iller", Storage="_iller1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string iller1
		{
			get
			{
				return this._iller1;
			}
			set
			{
				if ((this._iller1 != value))
				{
					this.Oniller1Changing(value);
					this.SendPropertyChanging();
					this._iller1 = value;
					this.SendPropertyChanged("iller1");
					this.Oniller1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Iller_Ilceler", Storage="_Ilcelers", ThisKey="ilid", OtherKey="ilid")]
		public EntitySet<Ilceler> Ilcelers
		{
			get
			{
				return this._Ilcelers;
			}
			set
			{
				this._Ilcelers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Ilcelers(Ilceler entity)
		{
			this.SendPropertyChanging();
			entity.Iller = this;
		}
		
		private void detach_Ilcelers(Ilceler entity)
		{
			this.SendPropertyChanging();
			entity.Iller = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ilceler")]
	public partial class Ilceler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ilceid;
		
		private string _ilce;
		
		private int _ilid;
		
		private EntityRef<Iller> _Iller;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnilceidChanging(int value);
    partial void OnilceidChanged();
    partial void OnilceChanging(string value);
    partial void OnilceChanged();
    partial void OnilidChanging(int value);
    partial void OnilidChanged();
    #endregion
		
		public Ilceler()
		{
			this._Iller = default(EntityRef<Iller>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilceid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ilceid
		{
			get
			{
				return this._ilceid;
			}
			set
			{
				if ((this._ilceid != value))
				{
					this.OnilceidChanging(value);
					this.SendPropertyChanging();
					this._ilceid = value;
					this.SendPropertyChanged("ilceid");
					this.OnilceidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilce", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ilce
		{
			get
			{
				return this._ilce;
			}
			set
			{
				if ((this._ilce != value))
				{
					this.OnilceChanging(value);
					this.SendPropertyChanging();
					this._ilce = value;
					this.SendPropertyChanged("ilce");
					this.OnilceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilid", DbType="Int NOT NULL")]
		public int ilid
		{
			get
			{
				return this._ilid;
			}
			set
			{
				if ((this._ilid != value))
				{
					if (this._Iller.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnilidChanging(value);
					this.SendPropertyChanging();
					this._ilid = value;
					this.SendPropertyChanged("ilid");
					this.OnilidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Iller_Ilceler", Storage="_Iller", ThisKey="ilid", OtherKey="ilid", IsForeignKey=true)]
		public Iller Iller
		{
			get
			{
				return this._Iller.Entity;
			}
			set
			{
				Iller previousValue = this._Iller.Entity;
				if (((previousValue != value) 
							|| (this._Iller.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Iller.Entity = null;
						previousValue.Ilcelers.Remove(this);
					}
					this._Iller.Entity = value;
					if ((value != null))
					{
						value.Ilcelers.Add(this);
						this._ilid = value.ilid;
					}
					else
					{
						this._ilid = default(int);
					}
					this.SendPropertyChanged("Iller");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591