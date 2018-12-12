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

namespace Zad4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AJPO")]
	public partial class Linq2SqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertczytelnicy(czytelnicy instance);
    partial void Updateczytelnicy(czytelnicy instance);
    partial void Deleteczytelnicy(czytelnicy instance);
    partial void InsertKsiazki(Ksiazki instance);
    partial void UpdateKsiazki(Ksiazki instance);
    partial void DeleteKsiazki(Ksiazki instance);
    partial void Insertwypozyczenia(wypozyczenia instance);
    partial void Updatewypozyczenia(wypozyczenia instance);
    partial void Deletewypozyczenia(wypozyczenia instance);
    #endregion
		
		public Linq2SqlDataContext() : 
				base(global::Zad4.Properties.Settings.Default.AJPOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Linq2SqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Linq2SqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Linq2SqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Linq2SqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<czytelnicy> czytelnicy
		{
			get
			{
				return this.GetTable<czytelnicy>();
			}
		}
		
		public System.Data.Linq.Table<Ksiazki> Ksiazki
		{
			get
			{
				return this.GetTable<Ksiazki>();
			}
		}
		
		public System.Data.Linq.Table<wypozyczenia> wypozyczenia
		{
			get
			{
				return this.GetTable<wypozyczenia>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.czytelnicy")]
	public partial class czytelnicy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_czytelnika;
		
		private string _nazwisko;
		
		private string _imie;
		
		private string _pesel;
		
		private System.Nullable<char> _plec;
		
		private string _telefon;
		
		private EntitySet<wypozyczenia> _wypozyczenia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_czytelnikaChanging(int value);
    partial void Onid_czytelnikaChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnpeselChanging(string value);
    partial void OnpeselChanged();
    partial void OnplecChanging(System.Nullable<char> value);
    partial void OnplecChanged();
    partial void OntelefonChanging(string value);
    partial void OntelefonChanged();
    #endregion
		
		public czytelnicy()
		{
			this._wypozyczenia = new EntitySet<wypozyczenia>(new Action<wypozyczenia>(this.attach_wypozyczenia), new Action<wypozyczenia>(this.detach_wypozyczenia));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_czytelnika", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_czytelnika
		{
			get
			{
				return this._id_czytelnika;
			}
			set
			{
				if ((this._id_czytelnika != value))
				{
					this.Onid_czytelnikaChanging(value);
					this.SendPropertyChanging();
					this._id_czytelnika = value;
					this.SendPropertyChanged("id_czytelnika");
					this.Onid_czytelnikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="NChar(10)")]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="NChar(10)")]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pesel", DbType="NChar(11)")]
		public string pesel
		{
			get
			{
				return this._pesel;
			}
			set
			{
				if ((this._pesel != value))
				{
					this.OnpeselChanging(value);
					this.SendPropertyChanging();
					this._pesel = value;
					this.SendPropertyChanged("pesel");
					this.OnpeselChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_plec", DbType="NChar(1)")]
		public System.Nullable<char> plec
		{
			get
			{
				return this._plec;
			}
			set
			{
				if ((this._plec != value))
				{
					this.OnplecChanging(value);
					this.SendPropertyChanging();
					this._plec = value;
					this.SendPropertyChanged("plec");
					this.OnplecChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="NChar(10)")]
		public string telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="czytelnicy_wypozyczenia", Storage="_wypozyczenia", ThisKey="id_czytelnika", OtherKey="id_czytelnika")]
		public EntitySet<wypozyczenia> wypozyczenia
		{
			get
			{
				return this._wypozyczenia;
			}
			set
			{
				this._wypozyczenia.Assign(value);
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
		
		private void attach_wypozyczenia(wypozyczenia entity)
		{
			this.SendPropertyChanging();
			entity.czytelnicy = this;
		}
		
		private void detach_wypozyczenia(wypozyczenia entity)
		{
			this.SendPropertyChanging();
			entity.czytelnicy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ksiazki")]
	public partial class Ksiazki : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _sygnatura;
		
		private string _tytul;
		
		private string _autor;
		
		private string _cena;
		
		private string _gatunek;
		
		private EntitySet<wypozyczenia> _wypozyczenia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsygnaturaChanging(int value);
    partial void OnsygnaturaChanged();
    partial void OntytulChanging(string value);
    partial void OntytulChanged();
    partial void OnautorChanging(string value);
    partial void OnautorChanged();
    partial void OncenaChanging(string value);
    partial void OncenaChanged();
    partial void OngatunekChanging(string value);
    partial void OngatunekChanged();
    #endregion
		
		public Ksiazki()
		{
			this._wypozyczenia = new EntitySet<wypozyczenia>(new Action<wypozyczenia>(this.attach_wypozyczenia), new Action<wypozyczenia>(this.detach_wypozyczenia));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sygnatura", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int sygnatura
		{
			get
			{
				return this._sygnatura;
			}
			set
			{
				if ((this._sygnatura != value))
				{
					this.OnsygnaturaChanging(value);
					this.SendPropertyChanging();
					this._sygnatura = value;
					this.SendPropertyChanged("sygnatura");
					this.OnsygnaturaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tytul", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string tytul
		{
			get
			{
				return this._tytul;
			}
			set
			{
				if ((this._tytul != value))
				{
					this.OntytulChanging(value);
					this.SendPropertyChanging();
					this._tytul = value;
					this.SendPropertyChanged("tytul");
					this.OntytulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autor", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string autor
		{
			get
			{
				return this._autor;
			}
			set
			{
				if ((this._autor != value))
				{
					this.OnautorChanging(value);
					this.SendPropertyChanging();
					this._autor = value;
					this.SendPropertyChanged("autor");
					this.OnautorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cena", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string cena
		{
			get
			{
				return this._cena;
			}
			set
			{
				if ((this._cena != value))
				{
					this.OncenaChanging(value);
					this.SendPropertyChanging();
					this._cena = value;
					this.SendPropertyChanged("cena");
					this.OncenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gatunek", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string gatunek
		{
			get
			{
				return this._gatunek;
			}
			set
			{
				if ((this._gatunek != value))
				{
					this.OngatunekChanging(value);
					this.SendPropertyChanging();
					this._gatunek = value;
					this.SendPropertyChanged("gatunek");
					this.OngatunekChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ksiazki_wypozyczenia", Storage="_wypozyczenia", ThisKey="sygnatura", OtherKey="sygnatura")]
		public EntitySet<wypozyczenia> wypozyczenia
		{
			get
			{
				return this._wypozyczenia;
			}
			set
			{
				this._wypozyczenia.Assign(value);
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
		
		private void attach_wypozyczenia(wypozyczenia entity)
		{
			this.SendPropertyChanging();
			entity.Ksiazki = this;
		}
		
		private void detach_wypozyczenia(wypozyczenia entity)
		{
			this.SendPropertyChanging();
			entity.Ksiazki = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.wypozyczenia")]
	public partial class wypozyczenia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_w;
		
		private int _sygnatura;
		
		private int _id_czytelnika;
		
		private System.Nullable<double> _kara;
		
		private EntityRef<czytelnicy> _czytelnicy;
		
		private EntityRef<Ksiazki> _Ksiazki;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_wChanging(int value);
    partial void Onid_wChanged();
    partial void OnsygnaturaChanging(int value);
    partial void OnsygnaturaChanged();
    partial void Onid_czytelnikaChanging(int value);
    partial void Onid_czytelnikaChanged();
    partial void OnkaraChanging(System.Nullable<double> value);
    partial void OnkaraChanged();
    #endregion
		
		public wypozyczenia()
		{
			this._czytelnicy = default(EntityRef<czytelnicy>);
			this._Ksiazki = default(EntityRef<Ksiazki>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_w", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_w
		{
			get
			{
				return this._id_w;
			}
			set
			{
				if ((this._id_w != value))
				{
					this.Onid_wChanging(value);
					this.SendPropertyChanging();
					this._id_w = value;
					this.SendPropertyChanged("id_w");
					this.Onid_wChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sygnatura", DbType="Int NOT NULL")]
		public int sygnatura
		{
			get
			{
				return this._sygnatura;
			}
			set
			{
				if ((this._sygnatura != value))
				{
					if (this._Ksiazki.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsygnaturaChanging(value);
					this.SendPropertyChanging();
					this._sygnatura = value;
					this.SendPropertyChanged("sygnatura");
					this.OnsygnaturaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_czytelnika", DbType="Int NOT NULL")]
		public int id_czytelnika
		{
			get
			{
				return this._id_czytelnika;
			}
			set
			{
				if ((this._id_czytelnika != value))
				{
					if (this._czytelnicy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_czytelnikaChanging(value);
					this.SendPropertyChanging();
					this._id_czytelnika = value;
					this.SendPropertyChanged("id_czytelnika");
					this.Onid_czytelnikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kara", DbType="Float")]
		public System.Nullable<double> kara
		{
			get
			{
				return this._kara;
			}
			set
			{
				if ((this._kara != value))
				{
					this.OnkaraChanging(value);
					this.SendPropertyChanging();
					this._kara = value;
					this.SendPropertyChanged("kara");
					this.OnkaraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="czytelnicy_wypozyczenia", Storage="_czytelnicy", ThisKey="id_czytelnika", OtherKey="id_czytelnika", IsForeignKey=true)]
		public czytelnicy czytelnicy
		{
			get
			{
				return this._czytelnicy.Entity;
			}
			set
			{
				czytelnicy previousValue = this._czytelnicy.Entity;
				if (((previousValue != value) 
							|| (this._czytelnicy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._czytelnicy.Entity = null;
						previousValue.wypozyczenia.Remove(this);
					}
					this._czytelnicy.Entity = value;
					if ((value != null))
					{
						value.wypozyczenia.Add(this);
						this._id_czytelnika = value.id_czytelnika;
					}
					else
					{
						this._id_czytelnika = default(int);
					}
					this.SendPropertyChanged("czytelnicy");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ksiazki_wypozyczenia", Storage="_Ksiazki", ThisKey="sygnatura", OtherKey="sygnatura", IsForeignKey=true)]
		public Ksiazki Ksiazki
		{
			get
			{
				return this._Ksiazki.Entity;
			}
			set
			{
				Ksiazki previousValue = this._Ksiazki.Entity;
				if (((previousValue != value) 
							|| (this._Ksiazki.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ksiazki.Entity = null;
						previousValue.wypozyczenia.Remove(this);
					}
					this._Ksiazki.Entity = value;
					if ((value != null))
					{
						value.wypozyczenia.Add(this);
						this._sygnatura = value.sygnatura;
					}
					else
					{
						this._sygnatura = default(int);
					}
					this.SendPropertyChanged("Ksiazki");
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
