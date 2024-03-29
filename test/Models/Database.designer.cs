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

namespace test.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RaiseFund_Full")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertDonation(Donation instance);
    partial void UpdateDonation(Donation instance);
    partial void DeleteDonation(Donation instance);
    partial void InsertCampaign(Campaign instance);
    partial void UpdateCampaign(Campaign instance);
    partial void DeleteCampaign(Campaign instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    #endregion
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        public DatabaseDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RaiseFund_FullConnectionString5"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Donation> Donations
		{
			get
			{
				return this.GetTable<Donation>();
			}
		}
		
		public System.Data.Linq.Table<Campaign> Campaigns
		{
			get
			{
				return this.GetTable<Campaign>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Comment> Comments
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Account_ID;
		
		private string _Username;
		
		private string _Password;
		
		private string _Full_Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccount_IDChanging(int value);
    partial void OnAccount_IDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFull_NameChanging(string value);
    partial void OnFull_NameChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Account_ID
		{
			get
			{
				return this._Account_ID;
			}
			set
			{
				if ((this._Account_ID != value))
				{
					this.OnAccount_IDChanging(value);
					this.SendPropertyChanging();
					this._Account_ID = value;
					this.SendPropertyChanged("Account_ID");
					this.OnAccount_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Full_Name
		{
			get
			{
				return this._Full_Name;
			}
			set
			{
				if ((this._Full_Name != value))
				{
					this.OnFull_NameChanging(value);
					this.SendPropertyChanging();
					this._Full_Name = value;
					this.SendPropertyChanged("Full_Name");
					this.OnFull_NameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Donation")]
	public partial class Donation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Account_ID;
		
		private int _Campaign_ID;
		
		private int _Donation_ID;
		
		private decimal _Donation_Amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccount_IDChanging(int value);
    partial void OnAccount_IDChanged();
    partial void OnCampaign_IDChanging(int value);
    partial void OnCampaign_IDChanged();
    partial void OnDonation_IDChanging(int value);
    partial void OnDonation_IDChanged();
    partial void OnDonation_AmountChanging(decimal value);
    partial void OnDonation_AmountChanged();
    #endregion
		
		public Donation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Account_ID
		{
			get
			{
				return this._Account_ID;
			}
			set
			{
				if ((this._Account_ID != value))
				{
					this.OnAccount_IDChanging(value);
					this.SendPropertyChanging();
					this._Account_ID = value;
					this.SendPropertyChanged("Account_ID");
					this.OnAccount_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Campaign_ID
		{
			get
			{
				return this._Campaign_ID;
			}
			set
			{
				if ((this._Campaign_ID != value))
				{
					this.OnCampaign_IDChanging(value);
					this.SendPropertyChanging();
					this._Campaign_ID = value;
					this.SendPropertyChanged("Campaign_ID");
					this.OnCampaign_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Donation_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Donation_ID
		{
			get
			{
				return this._Donation_ID;
			}
			set
			{
				if ((this._Donation_ID != value))
				{
					this.OnDonation_IDChanging(value);
					this.SendPropertyChanging();
					this._Donation_ID = value;
					this.SendPropertyChanged("Donation_ID");
					this.OnDonation_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Donation_Amount", DbType="Money NOT NULL")]
		public decimal Donation_Amount
		{
			get
			{
				return this._Donation_Amount;
			}
			set
			{
				if ((this._Donation_Amount != value))
				{
					this.OnDonation_AmountChanging(value);
					this.SendPropertyChanging();
					this._Donation_Amount = value;
					this.SendPropertyChanged("Donation_Amount");
					this.OnDonation_AmountChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Campaign")]
	public partial class Campaign : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Campaign_ID;
		
		private string _Campaign_Owner;
		
		private string _Bank_Name;
		
		private string _Campaign_Cate;
		
		private decimal _Campaign_Goal;
		
		private string _Campaign_Img;
		
		private string _Campaign_Title;
		
		private string _Campaign_Story;
		
		private string _Campaign_FullName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCampaign_IDChanging(int value);
    partial void OnCampaign_IDChanged();
    partial void OnCampaign_OwnerChanging(string value);
    partial void OnCampaign_OwnerChanged();
    partial void OnBank_NameChanging(string value);
    partial void OnBank_NameChanged();
    partial void OnCampaign_CateChanging(string value);
    partial void OnCampaign_CateChanged();
    partial void OnCampaign_GoalChanging(decimal value);
    partial void OnCampaign_GoalChanged();
    partial void OnCampaign_ImgChanging(string value);
    partial void OnCampaign_ImgChanged();
    partial void OnCampaign_TitleChanging(string value);
    partial void OnCampaign_TitleChanged();
    partial void OnCampaign_StoryChanging(string value);
    partial void OnCampaign_StoryChanged();
    partial void OnCampaign_FullNameChanging(string value);
    partial void OnCampaign_FullNameChanged();
    #endregion
		
		public Campaign()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Campaign_ID
		{
			get
			{
				return this._Campaign_ID;
			}
			set
			{
				if ((this._Campaign_ID != value))
				{
					this.OnCampaign_IDChanging(value);
					this.SendPropertyChanging();
					this._Campaign_ID = value;
					this.SendPropertyChanged("Campaign_ID");
					this.OnCampaign_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_Owner", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Campaign_Owner
		{
			get
			{
				return this._Campaign_Owner;
			}
			set
			{
				if ((this._Campaign_Owner != value))
				{
					this.OnCampaign_OwnerChanging(value);
					this.SendPropertyChanging();
					this._Campaign_Owner = value;
					this.SendPropertyChanged("Campaign_Owner");
					this.OnCampaign_OwnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bank_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Bank_Name
		{
			get
			{
				return this._Bank_Name;
			}
			set
			{
				if ((this._Bank_Name != value))
				{
					this.OnBank_NameChanging(value);
					this.SendPropertyChanging();
					this._Bank_Name = value;
					this.SendPropertyChanged("Bank_Name");
					this.OnBank_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_Cate", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Campaign_Cate
		{
			get
			{
				return this._Campaign_Cate;
			}
			set
			{
				if ((this._Campaign_Cate != value))
				{
					this.OnCampaign_CateChanging(value);
					this.SendPropertyChanging();
					this._Campaign_Cate = value;
					this.SendPropertyChanged("Campaign_Cate");
					this.OnCampaign_CateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_Goal", DbType="Money NOT NULL")]
		public decimal Campaign_Goal
		{
			get
			{
				return this._Campaign_Goal;
			}
			set
			{
				if ((this._Campaign_Goal != value))
				{
					this.OnCampaign_GoalChanging(value);
					this.SendPropertyChanging();
					this._Campaign_Goal = value;
					this.SendPropertyChanged("Campaign_Goal");
					this.OnCampaign_GoalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_Img", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Campaign_Img
		{
			get
			{
				return this._Campaign_Img;
			}
			set
			{
				if ((this._Campaign_Img != value))
				{
					this.OnCampaign_ImgChanging(value);
					this.SendPropertyChanging();
					this._Campaign_Img = value;
					this.SendPropertyChanged("Campaign_Img");
					this.OnCampaign_ImgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Campaign_Title
		{
			get
			{
				return this._Campaign_Title;
			}
			set
			{
				if ((this._Campaign_Title != value))
				{
					this.OnCampaign_TitleChanging(value);
					this.SendPropertyChanging();
					this._Campaign_Title = value;
					this.SendPropertyChanged("Campaign_Title");
					this.OnCampaign_TitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_Story", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Campaign_Story
		{
			get
			{
				return this._Campaign_Story;
			}
			set
			{
				if ((this._Campaign_Story != value))
				{
					this.OnCampaign_StoryChanging(value);
					this.SendPropertyChanging();
					this._Campaign_Story = value;
					this.SendPropertyChanged("Campaign_Story");
					this.OnCampaign_StoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_FullName", DbType="NVarChar(50)")]
		public string Campaign_FullName
		{
			get
			{
				return this._Campaign_FullName;
			}
			set
			{
				if ((this._Campaign_FullName != value))
				{
					this.OnCampaign_FullNameChanging(value);
					this.SendPropertyChanging();
					this._Campaign_FullName = value;
					this.SendPropertyChanged("Campaign_FullName");
					this.OnCampaign_FullNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Category_ID;
		
		private string _CategoryName;
		
		private string _ShowOnHomePage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategory_IDChanging(int value);
    partial void OnCategory_IDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnShowOnHomePageChanging(string value);
    partial void OnShowOnHomePageChanged();
    #endregion
		
		public Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Category_ID
		{
			get
			{
				return this._Category_ID;
			}
			set
			{
				if ((this._Category_ID != value))
				{
					this.OnCategory_IDChanging(value);
					this.SendPropertyChanging();
					this._Category_ID = value;
					this.SendPropertyChanged("Category_ID");
					this.OnCategory_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShowOnHomePage", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ShowOnHomePage
		{
			get
			{
				return this._ShowOnHomePage;
			}
			set
			{
				if ((this._ShowOnHomePage != value))
				{
					this.OnShowOnHomePageChanging(value);
					this.SendPropertyChanging();
					this._ShowOnHomePage = value;
					this.SendPropertyChanged("ShowOnHomePage");
					this.OnShowOnHomePageChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comment")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Account_ID;
		
		private int _Comment_ID;
		
		private int _Campaign_ID;
		
		private string _Comment_Content;
		
		private string _Campaign_FullName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccount_IDChanging(int value);
    partial void OnAccount_IDChanged();
    partial void OnComment_IDChanging(int value);
    partial void OnComment_IDChanged();
    partial void OnCampaign_IDChanging(int value);
    partial void OnCampaign_IDChanged();
    partial void OnComment_ContentChanging(string value);
    partial void OnComment_ContentChanged();
    partial void OnCampaign_FullNameChanging(string value);
    partial void OnCampaign_FullNameChanged();
    #endregion
		
		public Comment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Account_ID
		{
			get
			{
				return this._Account_ID;
			}
			set
			{
				if ((this._Account_ID != value))
				{
					this.OnAccount_IDChanging(value);
					this.SendPropertyChanging();
					this._Account_ID = value;
					this.SendPropertyChanged("Account_ID");
					this.OnAccount_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Comment_ID
		{
			get
			{
				return this._Comment_ID;
			}
			set
			{
				if ((this._Comment_ID != value))
				{
					this.OnComment_IDChanging(value);
					this.SendPropertyChanging();
					this._Comment_ID = value;
					this.SendPropertyChanged("Comment_ID");
					this.OnComment_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Campaign_ID
		{
			get
			{
				return this._Campaign_ID;
			}
			set
			{
				if ((this._Campaign_ID != value))
				{
					this.OnCampaign_IDChanging(value);
					this.SendPropertyChanging();
					this._Campaign_ID = value;
					this.SendPropertyChanged("Campaign_ID");
					this.OnCampaign_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment_Content", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Comment_Content
		{
			get
			{
				return this._Comment_Content;
			}
			set
			{
				if ((this._Comment_Content != value))
				{
					this.OnComment_ContentChanging(value);
					this.SendPropertyChanging();
					this._Comment_Content = value;
					this.SendPropertyChanged("Comment_Content");
					this.OnComment_ContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Campaign_FullName", DbType="NVarChar(50)")]
		public string Campaign_FullName
		{
			get
			{
				return this._Campaign_FullName;
			}
			set
			{
				if ((this._Campaign_FullName != value))
				{
					this.OnCampaign_FullNameChanging(value);
					this.SendPropertyChanging();
					this._Campaign_FullName = value;
					this.SendPropertyChanged("Campaign_FullName");
					this.OnCampaign_FullNameChanged();
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
