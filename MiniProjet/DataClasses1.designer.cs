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

namespace MiniProjet
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GestionEtudiants")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFiliere(Filiere instance);
    partial void UpdateFiliere(Filiere instance);
    partial void DeleteFiliere(Filiere instance);
    partial void Insertetudiant(etudiant instance);
    partial void Updateetudiant(etudiant instance);
    partial void Deleteetudiant(etudiant instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::MiniProjet.Properties.Settings.Default.GestionEtudiantsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Filiere> Filieres
		{
			get
			{
				return this.GetTable<Filiere>();
			}
		}
		
		public System.Data.Linq.Table<etudiant> etudiants
		{
			get
			{
				return this.GetTable<etudiant>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Filiere")]
	public partial class Filiere : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_Filiere;
		
		private string _nom_Filiere;
		
		private EntitySet<etudiant> _etudiants;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_FiliereChanging(int value);
    partial void Onid_FiliereChanged();
    partial void Onnom_FiliereChanging(string value);
    partial void Onnom_FiliereChanged();
    #endregion
		
		public Filiere()
		{
			this._etudiants = new EntitySet<etudiant>(new Action<etudiant>(this.attach_etudiants), new Action<etudiant>(this.detach_etudiants));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Filiere", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_Filiere
		{
			get
			{
				return this._id_Filiere;
			}
			set
			{
				if ((this._id_Filiere != value))
				{
					this.Onid_FiliereChanging(value);
					this.SendPropertyChanging();
					this._id_Filiere = value;
					this.SendPropertyChanged("id_Filiere");
					this.Onid_FiliereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom_Filiere", DbType="VarChar(20)")]
		public string nom_Filiere
		{
			get
			{
				return this._nom_Filiere;
			}
			set
			{
				if ((this._nom_Filiere != value))
				{
					this.Onnom_FiliereChanging(value);
					this.SendPropertyChanging();
					this._nom_Filiere = value;
					this.SendPropertyChanged("nom_Filiere");
					this.Onnom_FiliereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Filiere_etudiant", Storage="_etudiants", ThisKey="id_Filiere", OtherKey="id_fil")]
		public EntitySet<etudiant> etudiants
		{
			get
			{
				return this._etudiants;
			}
			set
			{
				this._etudiants.Assign(value);
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
		
		private void attach_etudiants(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.Filiere = this;
		}
		
		private void detach_etudiants(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.Filiere = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.etudiant")]
	public partial class etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cne;
		
		private string _nom;
		
		private string _prenom;
		
		private System.Nullable<char> _sexe;
		
		private string _date_naiss;
		
		private string _adresse;
		
		private string _telephone;
		
		private System.Nullable<int> _id_fil;
		
		private EntityRef<Filiere> _Filiere;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncneChanging(int value);
    partial void OncneChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OnsexeChanging(System.Nullable<char> value);
    partial void OnsexeChanged();
    partial void Ondate_naissChanging(string value);
    partial void Ondate_naissChanged();
    partial void OnadresseChanging(string value);
    partial void OnadresseChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void Onid_filChanging(System.Nullable<int> value);
    partial void Onid_filChanged();
    #endregion
		
		public etudiant()
		{
			this._Filiere = default(EntityRef<Filiere>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cne", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cne
		{
			get
			{
				return this._cne;
			}
			set
			{
				if ((this._cne != value))
				{
					this.OncneChanging(value);
					this.SendPropertyChanging();
					this._cne = value;
					this.SendPropertyChanged("cne");
					this.OncneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(100)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(100)")]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexe", DbType="Char(1)")]
		public System.Nullable<char> sexe
		{
			get
			{
				return this._sexe;
			}
			set
			{
				if ((this._sexe != value))
				{
					this.OnsexeChanging(value);
					this.SendPropertyChanging();
					this._sexe = value;
					this.SendPropertyChanged("sexe");
					this.OnsexeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_naiss", DbType="VarChar(10)")]
		public string date_naiss
		{
			get
			{
				return this._date_naiss;
			}
			set
			{
				if ((this._date_naiss != value))
				{
					this.Ondate_naissChanging(value);
					this.SendPropertyChanging();
					this._date_naiss = value;
					this.SendPropertyChanged("date_naiss");
					this.Ondate_naissChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse", DbType="VarChar(100)")]
		public string adresse
		{
			get
			{
				return this._adresse;
			}
			set
			{
				if ((this._adresse != value))
				{
					this.OnadresseChanging(value);
					this.SendPropertyChanging();
					this._adresse = value;
					this.SendPropertyChanged("adresse");
					this.OnadresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="VarChar(10)")]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_fil", DbType="Int")]
		public System.Nullable<int> id_fil
		{
			get
			{
				return this._id_fil;
			}
			set
			{
				if ((this._id_fil != value))
				{
					if (this._Filiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_filChanging(value);
					this.SendPropertyChanging();
					this._id_fil = value;
					this.SendPropertyChanged("id_fil");
					this.Onid_filChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Filiere_etudiant", Storage="_Filiere", ThisKey="id_fil", OtherKey="id_Filiere", IsForeignKey=true, DeleteRule="CASCADE")]
		public Filiere Filiere
		{
			get
			{
				return this._Filiere.Entity;
			}
			set
			{
				Filiere previousValue = this._Filiere.Entity;
				if (((previousValue != value) 
							|| (this._Filiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Filiere.Entity = null;
						previousValue.etudiants.Remove(this);
					}
					this._Filiere.Entity = value;
					if ((value != null))
					{
						value.etudiants.Add(this);
						this._id_fil = value.id_Filiere;
					}
					else
					{
						this._id_fil = default(Nullable<int>);
					}
					this.SendPropertyChanged("Filiere");
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